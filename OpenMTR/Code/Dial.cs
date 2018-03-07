using OpenCvSharp;
using System;
using System.Collections.Generic;
using System.Linq;

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
            int count = 0;
            foreach (CircleSegment circle in circles)
            {
                Mat dial = new Mat(meter.SourceImage, new Rect((int)(circle.Center.X - circle.Radius), (int)(circle.Center.Y - circle.Radius), (int)(circle.Radius * 2 + 1), (int)(circle.Radius * 2 + 1)));
                Mat test = dial.Clone();  // DEBUG REMOVE
                Point center = new Point(dial.Width / 2, dial.Height / 2);
                ImageUtils.ColorToGray(dial, dial);
                Cv2.GaussianBlur(dial, dial, new Size(5, 5), 0);
                Cv2.Dilate(dial, dial, ImageUtils.GetKernel(new Size(5, 5)));
                Cv2.Dilate(dial, dial, ImageUtils.GetKernel(new Size(5, 5)));
                Cv2.MorphologyEx(dial, dial, MorphTypes.Open, ImageUtils.GetKernel(new Size(3, 3)));
                Cv2.GaussianBlur(dial, dial, new Size(5, 5), 0);
                //Cv2.AdaptiveThreshold(dial, dial, 255, AdaptiveThresholdTypes.MeanC, ThresholdTypes.BinaryInv, 3, 3);
                Cv2.Canny(dial, dial, 50, 200);
                Cv2.MorphologyEx(dial, dial, MorphTypes.Close, ImageUtils.GetKernel(new Size(3, 3)));

                Cv2.FindContours(dial, out Point[][] contours, out HierarchyIndex[] hierarchy, RetrievalModes.List, ContourApproximationModes.ApproxSimple);

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

                Cv2.DrawContours(test, contours, 0, new Scalar(0, 0, 255));
                Cv2.Circle(test, farthestPoint, 2, new Scalar(0, 255, 0), 2);

                DebugUtils.ExportMatToFile(test, "test" + count); // DEBUG REMOVE
                count++; // DEBUG REMOVE

            }
            return meter.MetaData.MeterRead;
        }
    }
}
