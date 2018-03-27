using OpenCvSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenMTR
{
    public static class American
    {
        public static bool FirstPass(Meter meter)
        {
            bool success = false;
            ImageUtils.AdjustImageSkew(meter);
            ImageUtils.ColorToGray(meter.ModifiedImage, meter.ModifiedImage);
            Cv2.Canny(meter.ModifiedImage, meter.ModifiedImage, 100, 200);
            Cv2.Dilate(meter.ModifiedImage, meter.ModifiedImage, ImageUtils.GetKernel(new Size(3, 3)));
            Cv2.FindContours(meter.ModifiedImage, out Point[][] contours, out HierarchyIndex[] hierarchy, RetrievalModes.External, ContourApproximationModes.ApproxSimple);
            List<Rect> rectangles = new List<Rect>();
            Mat test = meter.ModifiedImage.Clone();
            foreach (Point[] point in contours)
            {
                Point[] approx = Cv2.ApproxPolyDP(point, 0.04 * Cv2.ArcLength(point, true), true);

                if (approx.Length > 3)
                {
                    Rect rect = Cv2.BoundingRect(point);
                    Cv2.Rectangle(test, rect, new Scalar(255, 0, 0), 2);
                    double area = rect.Width * rect.Height;

                    if (area > 1000 && area < 12000)
                    {
                        rectangles.Add(rect);
                    }
                }
            }

            //DebugUtils.ExportMatToFile(test, meter.FileName);

            foreach (Rect rect in rectangles)
            {
                meter.ModifiedImage = new Mat(meter.SourceImage.Clone(), rect);
                string odometerValue = Odometer.Read(meter);
                if (odometerValue.Equals(meter.MetaData.MeterRead))
                {
                    success = true;
                    break;
                }
            }

            return success;
        }
    }
}
