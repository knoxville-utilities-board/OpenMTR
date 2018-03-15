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

        private static List<CircleSegment> SortDials(List<CircleSegment> dials)
        {
            int n = dials.Count();
            for (int i = 0; i < n - 1; i++)
            {
                int index = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (dials[index].Center.X > dials[j].Center.X)
                    {
                        CircleSegment temp = dials[index];
                        CircleSegment temp1 = dials[j];
                        dials[index] = temp1;
                        dials[j] = temp;
                    }
                }
            }
            return dials;
        }

        private static Point DetectNeedleTip(Mat dial, Point centerOfNeedle)
        {
            double distance = 0f;
            Point needlePoint = new Point();
            ImageUtils.ColorToGray(dial, dial);
            ImageUtils.RotateImage(dial, dial, ImageUtils.DetectImageSkew(dial));
            Cv2.Dilate(dial, dial, ImageUtils.GetKernel(new Size(5, 5)));
            Cv2.MorphologyEx(dial, dial, MorphTypes.Open, ImageUtils.GetKernel(new Size(3, 3)));
            Cv2.MorphologyEx(dial, dial, MorphTypes.Close, ImageUtils.GetKernel(new Size(3, 3)));
            Cv2.Canny(dial, dial, 100, 200);
            Cv2.FindContours(dial, out Point[][] contours, out HierarchyIndex[] hierarchy, RetrievalModes.External, ContourApproximationModes.ApproxNone);
            foreach (Point[] points in contours)
            {
                foreach (Point point in points)
                {
                    if (centerOfNeedle.DistanceTo(point) > distance)
                    {
                        needlePoint = point;
                        distance = centerOfNeedle.DistanceTo(point);
                    }
                }
            }
            return needlePoint;
        }

        private static string ExtractDialDigits(Meter meter, List<CircleSegment> circles)
        {
            StringBuilder readValue = new StringBuilder("????");
            for (int i = 0; i < circles.Count; i++)
            {
                CircleSegment circle = circles[i];
                Mat dial = new Mat(meter.SourceImage, new Rect((int)(circle.Center.X - circle.Radius), (int)(circle.Center.Y - circle.Radius), (int)(circle.Radius * 2 + 1), (int)(circle.Radius * 2 + 1)));
                Point center = new Point(dial.Width / 2, dial.Height / 2);
                Point needleTip = DetectNeedleTip(dial, center);

                Dictionary<char, List<Point>> clockwise = new Dictionary<char, List<Point>>()
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

                Dictionary<char, List<Point>> counterClockwise = new Dictionary<char, List<Point>>()
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
                    { '9', new List<Point>() { new Point(center.X + (center.X * 0.70), 0), new Point(center.X * 0.30, 0) } }
                };

                foreach (KeyValuePair<char, List<Point>> numberPosition in (MathUtils.IsEven(i)) ? counterClockwise : clockwise)
                {
                    if (MathUtils.IsPointInTriangle(needleTip, center, numberPosition.Value[0], numberPosition.Value[1]))
                    {
                        readValue[i] = numberPosition.Key;
                    }
                }
            }
            return readValue.ToString();
        }
    }
}
