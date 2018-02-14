using System.IO;
using System;
using System.Text.RegularExpressions;
using OpenCvSharp;
using System.Collections.Generic;

namespace OpenMTR
{
    public static class ReadData
    {
        // Get a list of data objects built from all the images found in a directory
        public static List<Meter> GetMeterList(string directoryPath)
        {
            List<Meter> data = new List<Meter>();
            foreach (string filePath in Directory.GetFiles(directoryPath))
            {
                if (Regex.IsMatch(filePath, @"\.(jpe?g|png)$", RegexOptions.IgnoreCase))
                {
                    data.Add(GetMeter(filePath));
                }
            }
            return data;
        }
        public static void GetMeterList(string directoryPath, List<Meter> data)
        {
            data = GetMeterList(directoryPath);
        }

        // Get a single data object from a path to the image file
        public static Meter GetMeter(string imagePath)
        {
            Meter meter = new Meter();
            GetMeter(meter, imagePath);
            return meter;
        }
        public static void GetMeter(Meter meter, string imagePath)
        {
            meter.FileName = Path.GetFileNameWithoutExtension(imagePath);
            meter.SourceImage = new Mat(imagePath);
            meter.ModifiedImage = new Mat(imagePath);
            meter.MeterRead = ReadMetaData(imagePath);
        }

        // Get a metadata file path with the same name as the provided file
        private static int ReadMetaData(string imagePath)
        {
            string metaPath = Regex.Replace(Path.GetFullPath(imagePath), @"\.(jpe?g|png)$", ".txt", RegexOptions.IgnoreCase);
            try
            {
                return int.Parse(File.ReadAllText(metaPath));
            }
            catch (Exception)
            {
                return -1;
            }
        }
    }
}
