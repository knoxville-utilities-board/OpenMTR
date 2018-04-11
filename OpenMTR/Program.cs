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
            while (true)
            {
                Welcome.WelcomeUser();
                Report.StartTimer();
                List<Meter> meters = ReadData.GetMeterList(DirectoryPath);
                ProgressBar progressBar = new ProgressBar("Reading photos...");
                double meterCount = meters.Count, progress = 1;
                foreach (Meter meter in meters)
                {
                    Report.AddMeter(meter);
                    Detect.DetectType(meter);
                    progressBar.Report(progress / meterCount);
                    progress++;
                }
                progressBar.Dispose();
                Report.EndTimer();
                Report.Export(meterCount);
                Console.Clear();
            }
        }
    }
}
