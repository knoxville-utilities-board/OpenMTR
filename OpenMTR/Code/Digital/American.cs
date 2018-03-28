using OpenCvSharp;
using System;
using System.Collections.Generic;

namespace OpenMTR
{
    public static class American
    {
        public static void ProcessDigitalMeter(Meter meter)
        {
            try
            {
                if (ExtractionFirstPass(meter))
                {
                    throw new PassFailException(string.Format("{0}: Succesful Read", meter.FileName));
                }

                throw new PassFailException(string.Format("{0}: Failed Read", meter.FileName));
            }
            catch (PassFailException ex)
            {
                DebugUtils.Log(ex.Message);
            }
        }

        private static bool ExtractionFirstPass(Meter meter)
        {
            ImageUtils.AdjustImageSkew(meter);
            Mat test = meter.ModifiedImage.Clone();
            ImageUtils.ColorToGray(meter.ModifiedImage, meter.ModifiedImage);
            Cv2.MorphologyEx(meter.ModifiedImage, meter.ModifiedImage, MorphTypes.Close, ImageUtils.GetKernel(new Size(3, 3)));
            Cv2.Dilate(meter.ModifiedImage, meter.ModifiedImage, ImageUtils.GetKernel(new Size(5, 5)));
            Cv2.Dilate(meter.ModifiedImage, meter.ModifiedImage, ImageUtils.GetKernel(new Size(5, 5)));
            Cv2.Canny(meter.ModifiedImage, meter.ModifiedImage, 100, 300);
            Cv2.FindContours(meter.ModifiedImage, out Point[][] contours, out HierarchyIndex[] hierarchy, RetrievalModes.External, ContourApproximationModes.ApproxSimple);
            List<Rect> rectangles = new List<Rect>();
            
            foreach (Point[] point in contours)
            {
                Rect rect = Cv2.BoundingRect(point);
                double area = rect.Width * rect.Height;
                if (area >= 400 && area <= 1000)
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
