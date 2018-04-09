using OpenCvSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenMTR
{
    public static class Sprague
    {
        public static void ReadMeter(Meter meter)
        {
            try
            {
                if (ExtractionFirstPass(meter))
                {
                    throw new SuccessfulReadException();
                }

                throw new FailReadException();
            }
            catch (SuccessfulReadException)
            {
                Report.AddSuccessfulRead(meter);
            }
            catch (FailReadException)
            {
                Report.AddFailedRead(meter);
            }
        }

        private static bool ExtractionFirstPass(Meter meter)
        {
            List<CircleSegment> filteredCircles = new List<CircleSegment>();
            ImageUtils.AdjustImageSkew(meter);
            ImageUtils.ColorToGray(meter.SourceImage, meter.ModifiedImage);
            CircleSegment[] circles = Cv2.HoughCircles(meter.ModifiedImage, HoughMethods.Gradient, 1, meter.ModifiedImage.Rows / 20, 250);
            for (int i = 0; i < circles.Length; i++)
            {
                CircleSegment circle = circles[i];
                Point center = circle.Center;
                int count = 0;
                foreach (CircleSegment otherCircle in circles)
                {
                    if (!circle.Equals(otherCircle))
                    {
                        if (Math.Abs(center.Y - otherCircle.Center.Y) < 10)
                        {
                            count++;
                        }
                    }
                }
                if (count == 3)
                {
                    filteredCircles.Add(circle);
                }
            }

            if (filteredCircles.Count != 4)
            {
                return false;
            }
            string ret = Dial.Read(meter, filteredCircles);
            DebugUtils.Log($"{meter.FileName} | {ret} | {meter.MetaData.MeterRead}");
            return ret == meter.MetaData.MeterRead;
        }
    }
}
