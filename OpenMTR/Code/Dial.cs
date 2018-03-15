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

        private static string ExtractDialDigits(Meter meter, List<CircleSegment> circles)
        {
            StringBuilder readValue = new StringBuilder("????");
            int interation = 0;
            foreach (CircleSegment circle in circles)
            {
                Mat dial = new Mat(meter.SourceImage, new Rect((int)(circle.Center.X - circle.Radius), (int)(circle.Center.Y - circle.Radius), (int)(circle.Radius * 2 + 1), (int)(circle.Radius * 2 + 1)));
                Mat test = dial.Clone();  // DEBUG REMOVE
                Point center = new Point(dial.Width / 2, dial.Height / 2);
                ImageUtils.ColorToGray(dial, dial);
                ImageUtils.RotateImage(dial, dial, ImageUtils.DetectImageSkew(dial));
                //Cv2.GaussianBlur(dial, dial, new Size(3, 3), 0);
                Cv2.Dilate(dial, dial, ImageUtils.GetKernel(new Size(5, 5)));
                //Cv2.Dilate(dial, dial, ImageUtils.GetKernel(new Size(5, 5)));
                Cv2.MorphologyEx(dial, dial, MorphTypes.Open, ImageUtils.GetKernel(new Size(3, 3)));
                //Cv2.GaussianBlur(dial, dial, new Size(5, 5), 0);
                //Cv2.AdaptiveThreshold(dial, dial, 255, AdaptiveThresholdTypes.MeanC, ThresholdTypes.BinaryInv, 3, 3);
                Cv2.MorphologyEx(dial, dial, MorphTypes.Close, ImageUtils.GetKernel(new Size(3, 3)));
                //DebugUtils.ExportMatToFile(dial, "dtest" + interation);
                Cv2.Canny(dial, dial, 100, 200);
                
                

                Cv2.FindContours(dial, out Point[][] contours, out HierarchyIndex[] hierarchy, RetrievalModes.External, ContourApproximationModes.ApproxNone);

                Point farthestPoint = new Point();
                double distance = 0f;
                foreach (Point[] points in contours)
                {
                    foreach (Point point in points)
                    {
                        if (center.DistanceTo(point) > distance)
                        {
                            farthestPoint = point;
                            distance = center.DistanceTo(point);
                        }
                    }
                }

                // DEBUG START
                Cv2.Circle(test, farthestPoint, 2, new Scalar(0, 255, 0), 2); // Point
                Cv2.DrawContours(test, contours, 0, new Scalar(0, 0, 255));
                Cv2.Line(test, new Point(center.X, 0), new Point(center.X, dial.Width), new Scalar(255, 0, 0));  // Y axis
                // Counter clockwise
                Cv2.Line(test, center, new Point(center.X * 0.30, 0), new Scalar(255, 0, 0)); // 1|9
                Cv2.Line(test, center, new Point(0, center.Y * 0.65), new Scalar(255, 0, 0)); // 2|8
                Cv2.Line(test, center, new Point(0, center.Y + (center.Y * 0.30)), new Scalar(255, 0, 0)); // 3|7
                Cv2.Line(test, center, new Point(center.X * 0.20, dial.Height), new Scalar(255, 0, 0)); // 4|6
                Cv2.Line(test, center, new Point(center.X + (center.X * 0.65), dial.Height), new Scalar(255, 0, 0)); // 6|4
                Cv2.Line(test, center, new Point(dial.Width, center.Y + (center.Y * 0.30)), new Scalar(255, 0, 0)); // 7|3
                Cv2.Line(test, center, new Point(dial.Width, center.Y * 0.65), new Scalar(255, 0, 0)); // 8|2
                Cv2.Line(test, center, new Point(center.X + (center.X * 0.70), 0), new Scalar(255, 0, 0)); // 9|1

                DebugUtils.ExportMatToFile(test, "test" + interation);
                // DEBUG END

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

                foreach (KeyValuePair<char, List<Point>> numberPosition in (MathUtils.IsEven(interation)) ? counterClockwise : clockwise)
                {
                    if (MathUtils.IsPointInTriangle(farthestPoint, center, numberPosition.Value[0], numberPosition.Value[1]))
                    {
                        readValue[interation] = numberPosition.Key;
                    }
                }

                interation++;
            }
            return readValue.ToString();
        }
    }
}
