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
            ImageUtils.AdjustImageSkew(meter);
            ImageUtils.ColorToGray(meter.ModifiedImage, meter.ModifiedImage);
            Cv2.Canny(meter.ModifiedImage, meter.ModifiedImage, 100, 200);
            //Cv2.Dilate(meter.ModifiedImage, meter.ModifiedImage, ImageUtils.GetKernel(new Size(1, 1)));
            Cv2.MorphologyEx(meter.ModifiedImage, meter.ModifiedImage, MorphTypes.Open, ImageUtils.GetKernel(new Size(1, 1)));
            Cv2.FindContours(meter.ModifiedImage, out Point[][] contours, out HierarchyIndex[] hierarchy, RetrievalModes.External, ContourApproximationModes.ApproxSimple);
            List<Rect> rectangles = new List<Rect>();
            Mat test = meter.ModifiedImage.Clone();
            foreach (Point[] point in contours)
            {
                Rect rect = Cv2.BoundingRect(point);
                double area = rect.Width * rect.Height;
                if (area >= 300 && area <= 1000)
                {
                    Cv2.Rectangle(test, rect, new Scalar(255, 0, 0), 2);
                    rectangles.Add(rect);
                }
            }

            DebugUtils.ExportMatToFile(test, meter.FileName);

            List<Rect> filteredRect = new List<Rect>();
            for (int i = 0; i < rectangles.Count; i++)
            {
                Rect rect = rectangles[i];
                int count = 0;
                foreach (Rect otherRect in rectangles)
                {
                    if (!rect.Equals(otherRect))
                    {
                        if (Math.Abs(rect.TopLeft.Y - otherRect.TopLeft.Y) < 10)
                        {
                            count++;
                        }
                    }
                }
                if (count == 3)
                {
                    filteredRect.Add(rect);
                }
            }

            if (filteredRect.Count != 4)
            {
                return false;
            }

            string odometerValue = Odometer.Read(meter, filteredRect);
            DebugUtils.Log($"{meter.FileName}: Read {odometerValue}");
            return (odometerValue.Equals(meter.MetaData.MeterRead));
        }
    }
}
