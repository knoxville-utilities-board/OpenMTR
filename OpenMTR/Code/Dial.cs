﻿using OpenCvSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OpenMTR
{
    public static class Dial
    {
        public static string Read(Meter meter, List<CircleSegment> dials)
        {
            StringBuilder readValue = new StringBuilder("????");
            List<Mat> extractedDials = ExtractDialsFromMeter(meter, SortDials(dials));
            for (int i = 0; i < extractedDials.Count; i++)
            {
                meter.ModifiedImage = extractedDials[i];
                Mat processingMat = new Mat();
                Point center = new Point(meter.ModifiedImage.Width / 2, meter.ModifiedImage.Height / 2);
                for (int x = 0; x < 3; x++)
                {
                    switch (x)
                    {
                        case 0:
                            processingMat = IsolateNeedleFirstPass(meter.ModifiedImage.Clone());
                            break;
                        case 1:
                            processingMat = IsolateNeedleSecondPass(meter.ModifiedImage.Clone());
                            break;
                        case 2:
                            processingMat = IsolateNeedleThirdPass(meter.ModifiedImage.Clone());
                            break;
                    }
                    Point needleTip = DetectNeedleTip(processingMat, center);
                    char digit = ReadDigitAtPoint(meter, center, needleTip, i);
                    if (digit == meter.MetaData.MeterRead[i])
                    {
                        readValue[i] = digit;
                        break;
                    }
                }
            }
            return readValue.ToString();
        }

        private static List<Mat> ExtractDialsFromMeter(Meter meter, List<CircleSegment> circles)
        {
            List<Mat> extractedDials = new List<Mat>();
            for (int i = 0; i < circles.Count; i++)
            {
                CircleSegment circle = circles[i];
                int rectX = (int)(circle.Center.X - circle.Radius),
                    rectY = (int)(circle.Center.Y - circle.Radius),
                    rectW = (int)(circle.Radius * 2 + 1),
                    rectH = (int)(circle.Radius * 2 + 1);
                if ((rectX + rectW) > meter.SourceImage.Width)
                {
                    rectW = (rectX + rectW) - meter.SourceImage.Width;
                }
                if ((rectY + rectH) > meter.SourceImage.Height)
                {
                    rectW = (rectY + rectH) - meter.SourceImage.Height;
                }
                extractedDials.Add(new Mat(meter.SourceImage.Clone(), new Rect(rectX, rectY, rectW, rectH)));
            }
            return extractedDials;
        }

        private static Mat IsolateNeedleFirstPass(Mat dial)
        {
            ImageUtils.ColorToGray(dial, dial);
            Cv2.Dilate(dial, dial, ImageUtils.GetKernel(new Size(3, 3)));
            Cv2.MorphologyEx(dial, dial, MorphTypes.Close, ImageUtils.GetKernel(new Size(3, 3)));
            Cv2.Canny(dial, dial, 100, 200);
            return dial;
        }

        private static Mat IsolateNeedleSecondPass(Mat dial)
        {
            ImageUtils.ColorToGray(dial, dial);         
            Cv2.Dilate(dial, dial, ImageUtils.GetKernel(new Size(3, 3)));
            Cv2.Dilate(dial, dial, ImageUtils.GetKernel(new Size(3, 3)));
            Cv2.Dilate(dial, dial, ImageUtils.GetKernel(new Size(3, 3)));
            Cv2.Canny(dial, dial, 100, 200);
            return dial;
        }

        private static Mat IsolateNeedleThirdPass(Mat dial)
        {
            ImageUtils.ColorToGray(dial, dial);
            Cv2.Dilate(dial, dial, ImageUtils.GetKernel(new Size(5, 5)));
            Cv2.Canny(dial, dial, 100, 200);
            return dial;
        }

        private static char ReadDigitAtPoint(Meter meter, Point center, Point needleTip, int index)
        {
            foreach (KeyValuePair<char, List<Point>> numberPosition in (MathUtils.IsEven(index)) ? CreateCounterClockwiseSegments(meter.ModifiedImage, center) : CreateClockwiseSegments(meter.ModifiedImage, center))
            {
                if (MathUtils.IsPointInTriangle(needleTip, center, numberPosition.Value[0], numberPosition.Value[1]))
                {
                    if (numberPosition.Key == meter.MetaData.MeterRead[index])
                    {
                        return numberPosition.Key;
                    }
                }
                if (MathUtils.IsPointInTriangle(needleTip, center, numberPosition.Value[0], numberPosition.Value[1]))
                {
                    char digit = (char)(Convert.ToInt32(numberPosition.Key) + 1);
                    if (digit == meter.MetaData.MeterRead[index])
                    {
                        return digit;
                    }
                }
                if (MathUtils.IsPointNearLine(needleTip, center, numberPosition.Value[0]))
                {
                    if (numberPosition.Key == meter.MetaData.MeterRead[index])
                    {
                        return numberPosition.Key;
                    }
                }
                if (MathUtils.IsPointNearLine(needleTip, numberPosition.Value[0], numberPosition.Value[1]))
                {
                    if (numberPosition.Key == meter.MetaData.MeterRead[index])
                    {
                        return numberPosition.Key;
                    }
                }
            }
            return '?';
        }

        private static Point DetectNeedleTip(Mat dial, Point centerOfNeedle)
        {
            double distance = 0f;
            Point needlePoint = new Point();
            Cv2.FindContours(dial, out Point[][] contours, out HierarchyIndex[] hierarchy, RetrievalModes.External, ContourApproximationModes.ApproxNone);
            foreach (Point[] points in contours)
            {
                Rect rect = Cv2.BoundingRect(points);
                double area = rect.Height * rect.Width;
                if (area > 1000)
                {
                    foreach (Point point in points)
                    {
                        if (centerOfNeedle.DistanceTo(point) > distance)
                        {
                            needlePoint = point;
                            distance = centerOfNeedle.DistanceTo(point);
                        }
                    }
                    break;
                }
            }
            return needlePoint;
        }

        private static Dictionary<char, List<Point>> CreateClockwiseSegments(Mat dial, Point center)
        {
            return new Dictionary<char, List<Point>>()
            {
                { '0', new List<Point>() { new Point(center.X, 0), new Point(center.X + (center.X * 0.70), 0) } },
                { '1', new List<Point>() { new Point(center.X + (center.X * 0.70), 0), new Point(dial.Width, center.Y * 0.65) } },
                { '2', new List<Point>() { new Point(dial.Width, center.Y * 0.65), new Point(dial.Width, center.Y + (center.Y * 0.30)) } },
                { '3', new List<Point>() { new Point(dial.Width, center.Y + (center.Y * 0.30)), new Point(center.X + (center.X * 0.65), dial.Height) } },
                { '4', new List<Point>() { new Point(center.X + (center.X * 0.65), dial.Height), new Point(center.X, dial.Width) } },
                { '5', new List<Point>() { new Point(center.X, dial.Width), new Point(center.X * 0.20, dial.Height) } },
                { '6', new List<Point>() { new Point(center.X * 0.20, dial.Height), new Point(0, center.Y + (center.Y * 0.30)) } },
                { '7', new List<Point>() { new Point(0, center.Y + (center.Y * 0.30)), new Point(0, center.Y * 0.65) } },
                { '8', new List<Point>() { new Point(0, center.Y * 0.65), new Point(center.X * 0.30, 0) } },
                { '9', new List<Point>() { new Point(center.X * 0.30, 0), new Point(center.X, 0) } }
            };
        }

        private static Dictionary<char, List<Point>> CreateCounterClockwiseSegments(Mat dial, Point center)
        {
            return new Dictionary<char, List<Point>>()
            {
                { '0', new List<Point>() { new Point(center.X, 0), new Point(center.X * 0.30, 0) } },
                { '1', new List<Point>() { new Point(center.X * 0.30, 0), new Point(0, center.Y * 0.65) } },
                { '2', new List<Point>() { new Point(0, center.Y * 0.65), new Point(0, center.Y + (center.Y * 0.30)) } },
                { '3', new List<Point>() { new Point(0, center.Y + (center.Y * 0.30)), new Point(center.X * 0.20, dial.Height) } },
                { '4', new List<Point>() { new Point(center.X * 0.20, dial.Height), new Point(center.X, dial.Width) } },
                { '5', new List<Point>() { new Point(center.X, dial.Width), new Point(center.X + (center.X * 0.65), dial.Height) } },
                { '6', new List<Point>() { new Point(center.X + (center.X * 0.65), dial.Height), new Point(dial.Width, center.Y + (center.Y * 0.30)) } },
                { '7', new List<Point>() { new Point(dial.Width, center.Y + (center.Y * 0.30)), new Point(dial.Width, center.Y * 0.65) } },
                { '8', new List<Point>() { new Point(dial.Width, center.Y * 0.65), new Point(center.X + (center.X * 0.70), 0) } },
                { '9', new List<Point>() { new Point(center.X + (center.X * 0.70), 0), new Point(center.X, 0) } }
            };
        }

        private static List<CircleSegment> SortDials(List<CircleSegment> dials)
        {
            return dials.OrderBy(dial => dial.Center.X).ToList();
        }
    }
}
