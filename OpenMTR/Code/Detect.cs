using OpenCvSharp;
using System;
using System.Collections.Generic;

namespace OpenMTR
{
    public static class Detect
    {
        public static void DetectType(Meter meter)
        {
            switch (meter.MetaData.ReadType)
            {
                case "DIGITAL":
                    ProcessDigitalManufacturer(meter);
                    break;
                case "DIALS":
                    ProcessDialManufacturer(meter);
                    break;
                case "AMI":
                    ProcessAMIManufacturer(meter);
                    break;
                default:
                    Console.WriteLine(string.Format("Unexpected read type of '{0}'. Please check the metadata json file for '{1}' and ensure this is correct", meter.MetaData.ReadType, meter.FileName));
                    return;
            }
        }

        private static void ProcessDigitalManufacturer(Meter meter)
        {
            switch (meter.MetaData.Manufacturer)
            {
                case "AMERICAN":
                    American.ProcessDigitalMeter(meter);
                    break;
                case "NEPTUNE":
                    break;
                case "SENSUS":
                    break;
                case "ROOTS":
                    break;
                default:
                    Console.WriteLine(string.Format("Unexpected meter manufacturer of '{0}'. Please check the metadata json file for '{1}' and ensure this is correct", meter.MetaData.Manufacturer, meter.FileName));
                    break;
            }
        }

        private static void ProcessDialManufacturer(Meter meter)
        { 
            switch (meter.MetaData.Manufacturer)
            {
                case "NEPTUNE":
                    break;
                case "TRIDENT":
                    break;
                case "SPRAGUE":
                    break;
                case "AMERICAN":
                    break;
                case "BADGER":
                    break;
                case "EMCO":
                    break;
                default:
                    Console.WriteLine(string.Format("Unexpected meter manufacturer of '{0}'. Please check the metadata json file for '{1}' and ensure this is correct", meter.MetaData.Manufacturer, meter.FileName));
                    break;
            }
        }

        private static void ProcessAMIManufacturer(Meter meter)
        {
            switch (meter.MetaData.Manufacturer)
            {
                case "SENSUS":
                    break;
                case "NEPTUNE":
                    break;
                case "TRIDENT":
                    break;
                case "AMERICAN":
                    break;
                default:
                    Console.WriteLine(string.Format("Unexpected meter manufacturer of '{0}'. Please check the metadata json file for '{1}' and ensure this is correct", meter.MetaData.Manufacturer, meter.FileName));
                    break;
            }
        }

        private static void ExtractDials(Meter meter)
        {
            List<CircleSegment> filteredCircles = new List<CircleSegment>();
            ImageUtils.ColorToGray(meter.SourceImage, meter.ModifiedImage);
            Cv2.MorphologyEx(meter.ModifiedImage, meter.ModifiedImage, MorphTypes.Open, ImageUtils.GetKernel(new Size(3, 3)));
            Cv2.GaussianBlur(meter.ModifiedImage, meter.ModifiedImage, new Size(3, 3), 1);
            CircleSegment[] circles = Cv2.HoughCircles(meter.ModifiedImage, HoughMethods.Gradient, 1, meter.ModifiedImage.Rows / 20, 250, 100, 0, 0);
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
            string dialValue = Dial.Read(meter, filteredCircles);
            DebugUtils.Log(string.Format("Read value: {0} | Metadata Value: {1}", dialValue, meter.MetaData.MeterRead));
        }
    }
}
