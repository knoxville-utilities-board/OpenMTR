using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenCvSharp;

namespace OpenMTR
{
    partial class Program
    {
        public static string DirectoryPath { get; set; }
        public const bool DEBUG = true;

        static void Main(string[] args)
        {
            if (DEBUG)
            {
                DirectoryPath = @"C:\Users\Bryan\Desktop\OpenMTR\OdometerTest";
            }
            else
            {
                Welcome.WelcomeUser();
            }
            
            List<Meter> meters = ReadData.GetMeterList(DirectoryPath);
            Meter firstMeter = meters[0];
            ImageUtils.ColorToGray(firstMeter.SourceImage, firstMeter.ModifiedImage);
            CannyFilter.ApplyCannyFilter(firstMeter.ModifiedImage, firstMeter.ModifiedImage);
            ImageUtils.DetectOdometer(firstMeter);
            Odometer.Read(firstMeter.ModifiedImage);

            //DebugUtils.Log(string.Format("Read value: {0} | Metadata Value: {1}", odometerValue, firstMeter.MeterRead));
            DebugUtils.Log("Finished");
            Console.Read();
        }
    }
}
