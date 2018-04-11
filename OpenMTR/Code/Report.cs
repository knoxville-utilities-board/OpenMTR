using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenMTR
{
    public static class Report
    {
        private static DateTime StartTime = new DateTime();
        private static DateTime EndTime = new DateTime();
        private static Dictionary<string, int> MeterTypes = new Dictionary<string, int>();
        private static Dictionary<string, int> MeterManufacturers = new Dictionary<string, int>();
        private static List<string> SuccessfulReads = new List<string>();
        private static List<string> FailedReads = new List<string>();
        
        public static void StartTimer()
        {
            StartTime = DateTime.Now;
        }

        public static void EndTimer()
        {
            EndTime = DateTime.Now;
        }

        public static void AddMeter(Meter meter)
        {
            AddType(meter.MetaData.ReadType);
            AddManufacturer(meter.MetaData.Manufacturer);
        }

        public static void AddSuccessfulRead(Meter meter)
        {
            SuccessfulReads.Add(meter.FileName);
        }

        public static void AddFailedRead(Meter meter)
        {
            FailedReads.Add(meter.FileName);
        }

        public static void Export(double numberOfMetersProcessed)
        {
            string output = File.ReadAllText(string.Format("{0}\\template.html", Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location)));
            string filename = string.Format("{0}\\OpenMTR_Report_{1}.html", Environment.CurrentDirectory, DateTime.Now.ToString("MM-dd-yyyy-HH-mm-ss"));
            output = output.Replace("{{OCR_START_TIME}}", StartTime.ToString("MM/dd/yyyy h:mm:ss tt"));
            output = output.Replace("{{OCR_END_TIME}}", EndTime.ToString("MM/dd/yyyy h:mm:ss tt"));
            output = output.Replace("{{METER_COUNT}}", string.Format("{0}", numberOfMetersProcessed));
            output = output.Replace("{{METER_TYPES_PROCESSED}}", DisplayTypes());
            output = output.Replace("{{METER_MANUFACTURERS_PROCESSED}}", DisplayManufacturers());
            output = output.Replace("{{SUCCESSFUL_READS}}", string.Format("{0}", SuccessfulReads.Count));
            output = output.Replace("{{FAILED_READS}}", string.Format("{0}", FailedReads.Count));
            output = output.Replace("{{FAILED_READS_LIST}}", DisplayFailedReads());
            File.WriteAllText(filename, output);
            Process.Start(filename);
            Reset();
        }

        private static void Reset()
        {
            MeterTypes = new Dictionary<string, int>();
            MeterManufacturers = new Dictionary<string, int>();
            SuccessfulReads = new List<string>();
            FailedReads = new List<string>();
        }

        private static string DisplayFailedReads()
        {
            StringBuilder output = new StringBuilder();
            foreach (string filename in FailedReads)
            {
                output.Append(string.Format("<li>{0}</li>", filename));
            }
            return output.ToString();
        }

        private static string DisplayTypes()
        {
            StringBuilder output = new StringBuilder();
            foreach (KeyValuePair<string, int> type in MeterTypes)
            {
                output.Append(string.Format("<li>{0}: {1}</li>", type.Key, type.Value));
            }
            return output.ToString();
        }

        private static string DisplayManufacturers()
        {
            StringBuilder output = new StringBuilder();
            foreach (KeyValuePair<string, int> type in MeterManufacturers)
            {
                output.Append(string.Format("<li>{0}: {1}</li>", type.Key, type.Value));
            }
            return output.ToString();
        }

        private static void AddType(string type)
        {
            if (!MeterTypes.ContainsKey(type))
            {
                MeterTypes.Add(type, 1);
            }
            else
            {
                MeterTypes[type]++;
            }
        }

        private static void AddManufacturer(string name)
        {
            if (!MeterManufacturers.ContainsKey(name))
            {
                MeterManufacturers.Add(name, 1);
            }
            else
            {
                MeterManufacturers[name]++;
            }
        }
    }
}
