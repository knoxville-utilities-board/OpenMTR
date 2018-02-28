using System.IO;
using System;
using System.Text.RegularExpressions;
using OpenCvSharp;
using System.Collections.Generic;
using Newtonsoft.Json;

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
            string filename = Path.GetFileNameWithoutExtension(imagePath);
            return new Meter(filename, new Mat(imagePath), new Mat(imagePath), ReadMetaData(imagePath));
        }

        // Get a metadata file path with the same name as the provided file
        private static MeterMetaData ReadMetaData(string imagePath)
        {
            string metaPath = Regex.Replace(Path.GetFullPath(imagePath), @"\.(jpe?g|png)$", ".json", RegexOptions.IgnoreCase);
            return JsonConvert.DeserializeObject<MeterMetaData>(File.ReadAllText(metaPath));
        }
    }
}
