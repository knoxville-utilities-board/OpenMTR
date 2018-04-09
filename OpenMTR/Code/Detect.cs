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
                case "TRIDENT":
                case "NEPTUNE":
                    break;
                case "SENSUS":
                    break;
                case "ROOTS":
                    break;
                case "EMCO":
                    break;
                case "BADGER":
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
                case "SPRAGUE":
                    Sprague.ReadMeter(meter);
                    break;
                case "EMCO":
                case "BADGER":
                case "TRIDENT":
                case "NEPTUNE":
                case "AMERICAN":
                    ProcessDigitalManufacturer(meter);
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
                case "NEPTUNE":
                case "TRIDENT":
                    ProcessDigitalManufacturer(meter);
                    break;
                case "AMERICAN":
                    // A dial meter?
                    break;
                default:
                    Console.WriteLine(string.Format("Unexpected meter manufacturer of '{0}'. Please check the metadata json file for '{1}' and ensure this is correct", meter.MetaData.Manufacturer, meter.FileName));
                    break;
            }
        }
    }
}
