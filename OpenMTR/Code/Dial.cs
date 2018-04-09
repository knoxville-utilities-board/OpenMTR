using OpenCvSharp;
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
            return ExtractDialDigits(meter, SortDials(dials));
        }

        private static string ExtractDialDigits(Meter meter, List<CircleSegment> circles)
        {
            StringBuilder readValue = new StringBuilder("????");
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
                meter.ModifiedImage = new Mat(meter.SourceImage.Clone(), new Rect(rectX, rectY, rectW, rectH));
                Mat test = meter.ModifiedImage.Clone();
                Point center = new Point(meter.ModifiedImage.Width / 2, meter.ModifiedImage.Height / 2);
                Point needleTip = DetectNeedleTip(meter, center);
                Cv2.Circle(test, center, 1, new Scalar(255, 0, 0), 2);
                Cv2.Circle(test, needleTip, 1, new Scalar(0, 255, 0), 2);
                DebugUtils.Log($"Processing for {meter.FileName}_{i}");
                foreach (KeyValuePair<char, List<Point>> numberPosition in (MathUtils.IsEven(i)) ? CreateCounterClockwiseSegments(meter.ModifiedImage, center) : CreateClockwiseSegments(meter.ModifiedImage, center))
                {
                    Cv2.Line(test, center, numberPosition.Value[1], new Scalar(0, 0, 255));
                    //Point centerTri = new Point((center.X + numberPosition.Value[0].X + numberPosition.Value[1].X) / 3, (center.Y + numberPosition.Value[0].Y + numberPosition.Value[1].Y) / 3);
                    //Cv2.PutText(test, $"{numberPosition.Key}", centerTri, HersheyFonts.HersheyComplex, 0.5, new Scalar(255, 0, 0));

                    if (MathUtils.IsPointInTriangle(needleTip, center, numberPosition.Value[0], numberPosition.Value[1]))
                    {
                        readValue[i] = numberPosition.Key;
                        break;
                    }

                    if (MathUtils.IsPointNearLine(needleTip, center, numberPosition.Value[0]))
                    {
                        readValue[i] = numberPosition.Key;
                        break;
                    }
                }
                //DebugUtils.ExportMatToFile(meter.ModifiedImage, $"{meter.FileName}_{i}");
            }
            return readValue.ToString();
        }

        private static Point DetectNeedleTip(Meter meter, Point centerOfNeedle)
        {
            double distance = 0f;
            Point needlePoint = new Point();
            ImageUtils.ColorToGray(meter.ModifiedImage, meter.ModifiedImage);
            Cv2.Dilate(meter.ModifiedImage, meter.ModifiedImage, ImageUtils.GetKernel(new Size(3, 3)));
            Cv2.Dilate(meter.ModifiedImage, meter.ModifiedImage, ImageUtils.GetKernel(new Size(3, 3)));
            Cv2.Dilate(meter.ModifiedImage, meter.ModifiedImage, ImageUtils.GetKernel(new Size(3, 3)));
            Cv2.Canny(meter.ModifiedImage, meter.ModifiedImage, 100, 200);
            Cv2.FindContours(meter.ModifiedImage, out Point[][] contours, out HierarchyIndex[] hierarchy, RetrievalModes.External, ContourApproximationModes.ApproxNone);
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
                { '0', new List<Point>() { new Point(center.X * 0.30, 0), new Point(center.X + (center.X * 0.70), 0) } },
                { '1', new List<Point>() { new Point(center.X + (center.X * 0.70), 0), new Point(dial.Width, center.Y * 0.65) } },
                { '2', new List<Point>() { new Point(dial.Width, center.Y * 0.65), new Point(dial.Width, center.Y + (center.Y * 0.30)) } },
                { '3', new List<Point>() { new Point(dial.Width, center.Y + (center.Y * 0.30)), new Point(center.X + (center.X * 0.65), dial.Height) } },
                { '4', new List<Point>() { new Point(center.X + (center.X * 0.65), dial.Height), new Point(center.X, dial.Width) } },
                { '5', new List<Point>() { new Point(center.X, dial.Width), new Point(center.X * 0.20, dial.Height) } },
                { '6', new List<Point>() { new Point(center.X * 0.20, dial.Height), new Point(0, center.Y + (center.Y * 0.30)) } },
                { '7', new List<Point>() { new Point(0, center.Y + (center.Y * 0.30)), new Point(0, center.Y * 0.65) } },
                { '8', new List<Point>() { new Point(0, center.Y * 0.65), new Point(center.X * 0.30, 0) } },
                { '9', new List<Point>() { new Point(center.X * 0.30, 0), new Point(center.X, 0) } },
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
