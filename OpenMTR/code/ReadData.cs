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
        public static List<DataObject> GetDataObjectList(string directoryPath)
        {
            List<DataObject> data = new List<DataObject>();
            foreach (string filePath in Directory.GetFiles(directoryPath))
            {
                if (Regex.IsMatch(filePath, ".(jpe?g|png)$"))
                {
                    data.Add(GetDataObject(filePath));
                }
            }
            return data;
        }
        public static void GetDataObjectList(string directoryPath, List<DataObject> data)
        {
            data = GetDataObjectList(directoryPath);
        }

        // Get a single data object from a path to the image file
        private static DataObject GetDataObject(string imagePath)
        {
            string Filename = Path.GetFileNameWithoutExtension(imagePath);
            return new DataObject(Filename, new Mat(imagePath), ReadMetaData(imagePath));
        }

        // Get a metadata file path with the same name as the provided file
        private static int ReadMetaData(string imagePath)
        {
            string metaPath = Path.GetFullPath(imagePath);
            metaPath = (Path.HasExtension(metaPath)) ? Regex.Replace(metaPath, ".(jpe?g|png)$", ".txt", RegexOptions.IgnoreCase) : metaPath + ".txt";

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
