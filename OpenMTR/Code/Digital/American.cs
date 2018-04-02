using OpenCvSharp;
using System;
using System.Collections.Generic;
using System.Linq;

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
                    throw new PassFailException(string.Format("{0}: Successful Read", meter.FileName));
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
            meter.ModifiedImage = new Mat(meter.ModifiedImage.Clone(), new Rect(0, 0, meter.ModifiedImage.Width, meter.ModifiedImage.Height / 2));
            ImageUtils.ColorToGray(meter.ModifiedImage, meter.ModifiedImage);
            Cv2.GaussianBlur(meter.ModifiedImage, meter.ModifiedImage, new Size(3, 3), 0);
            Cv2.MorphologyEx(meter.ModifiedImage, meter.ModifiedImage, MorphTypes.Close, ImageUtils.GetKernel(new Size(3, 3)));
            Cv2.Canny(meter.ModifiedImage, meter.ModifiedImage, 100, 200);
            List<Rect> readouts = ExtractReadouts(meter);
            if (readouts.Count == 0)
            {
                return false;
            }
            List<Rect> extractedDigits = ExtractDigits(meter, readouts);
            if (extractedDigits.Count != 4)
            {
                return false;
            }
            //string odometerValue = Odometer.Read(meter, extractedDigits);
            //DebugUtils.Log($"{meter.FileName}: Read {odometerValue}");
            //return (odometerValue.Equals(meter.MetaData.MeterRead));
            return true;
        }

        private static List<Rect> ExtractReadouts(Meter meter)
        {
            Cv2.FindContours(meter.ModifiedImage, out Point[][] contours, out HierarchyIndex[] hierarchy, RetrievalModes.External, ContourApproximationModes.ApproxSimple);
            List<Rect> readouts = new List<Rect>();
            foreach (Point[] point in contours)
            {
                Rect rect = Cv2.BoundingRect(point);
                double area = rect.Height * rect.Width; 
                if (area > 4000 && area < 10000)
                {
                    if (rect.Width > (rect.Height * 2) && rect.Width < (rect.Height * 3))
                    {
                        readouts.Add(rect);
                    }
                }
            }
            return readouts;
        }

        private static List<Rect> ExtractDigits(Meter meter, List<Rect> readouts)
        {
            List<Rect> rectangles = new List<Rect>(); 
            foreach (Rect readout in readouts)
            {
                List<Rect> filteredRect = new List<Rect>();
                Mat roi = new Mat(meter.SourceImage.Clone(), readout);
                ImageUtils.AdjustImageSkew(roi);
                ImageUtils.ColorToGray(roi, roi);
                Cv2.GaussianBlur(roi, roi, new Size(3, 3), 0);
                Cv2.MorphologyEx(roi, roi, MorphTypes.Close, ImageUtils.GetKernel(new Size(3, 3)));
                Cv2.Canny(roi, roi, 50, 150);
                Cv2.FindContours(roi, out Point[][] contours, out HierarchyIndex[] hierarchy, RetrievalModes.Tree, ContourApproximationModes.ApproxSimple);
                foreach (Point[] point in contours)
                {
                    Rect rect = Cv2.BoundingRect(point);
                    double area = rect.Height * rect.Width;
                    if ((area > 175 && area < 500) && (rect.Height > rect.Width))
                    {
                        if (rectangles.Where(r => (r.X == rect.X && r.Y == rect.Y)).Count() == 0)
                        {
                            rectangles.Add(rect);
                        }
                    }
                }
                Odometer.SortDigits(rectangles);
                filteredRect = rectangles.Where(rect => rectangles.Where(otherRect => (!rect.Equals(otherRect) && (Math.Abs(rect.TopLeft.Y - otherRect.TopLeft.Y) < 5))).Count() == 3).ToList();
                if (filteredRect.Count == 4)
                {                 
                    meter.ModifiedImage = new Mat(meter.SourceImage.Clone(), readout);
                    ImageUtils.AdjustImageSkew(meter.ModifiedImage);
                    return filteredRect;
                }
            }

            return new List<Rect>();
        }
    }
}
