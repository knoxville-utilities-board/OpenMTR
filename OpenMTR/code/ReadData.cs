using System.IO;
using System.Text.RegularExpressions;
using OpenCvSharp;
using System.Collections.Generic;


namespace OpenMTR
{
    static class ReadData
    {
        // Get a list of data objects built from all the images found in a directory
        public static List<DataObject> GetDataObjectList(string DirectoryPath)
        {
            List<DataObject> Data = new List<DataObject>();
            foreach (string FilePath in Directory.GetFiles(DirectoryPath))
            {
                if (Regex.IsMatch(FilePath, ".(jpe?g|png)$"))
                {
                    Data.Add(GetDataObject(FilePath));
                }
            }
            return Data;
        }
        public static void GetDataObjectList(string DirectoryPath, List<DataObject> Data)
        {
            Data = GetDataObjectList(DirectoryPath);
        }

        // Get a single data object from a path to the image file
        public static DataObject GetDataObject(string ImagePath)
        {
            string Filename = Path.GetFileNameWithoutExtension(ImagePath);
            int MetaReading = int.Parse(File.ReadAllLines(GetMetaPath(ImagePath))[0]);
            return new DataObject(Filename, new Mat(ImagePath), MetaReading);
        }
        public static void GetDataObject(string ImagePath, DataObject Data)
        {
            Data = GetDataObject(ImagePath);
        }

        // Get a metadata file path with the same name as the provided file
        private static string GetMetaPath(string ImagePath)
        {
            string MetaPath = Path.GetFullPath(ImagePath);
            if (Path.HasExtension(MetaPath))
            {
                return MetaPath + ".txt";
            }
            return Regex.Replace(MetaPath, ".(jpe?g|png)$", ".txt", RegexOptions.IgnoreCase);
        }
    }
}
