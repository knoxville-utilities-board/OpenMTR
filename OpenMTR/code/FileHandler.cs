using System.Linq;
using System.IO;
using System.Text.RegularExpressions;


namespace OpenMTR
{
    class FileHandler
    {
        const string DefaultRegexExtensions = ".(jpe?g|png)$";
        public string ImageDirectory, MetaDirectory, InstanceRegexExtensions;
        public string[] ImageNames, MissingMetaData;

        public FileHandler(string WorkingDirectory, string InstanceExtensions = DefaultRegexExtensions)
        {
            this.InstanceRegexExtensions = InstanceExtensions;
            SetWorkingDirectory(StandardizeDirectory(WorkingDirectory));
        }


        // Set the directory to look for files in, returns false if it can't find the directory
        public bool SetWorkingDirectory(string NewDirectory)
        {
            if (!Directory.Exists(NewDirectory)) return false;
            ImageDirectory = NewDirectory;
            MetaDirectory = NewDirectory;
            SetFileNames();
            return true;
        }

        // Create an array containing filenames and another with filenames for images with no associated metadata
        private void SetFileNames()
        {
            string[] AllFiles = Directory.GetFiles(ImageDirectory).Select(file => Path.GetFileName(file)).ToArray();
            ImageNames = FilterForImageFiles(AllFiles, InstanceRegexExtensions);
            MissingMetaData = ImageNames.Where(file => !AllFiles.Contains(GetMetaFile(file))).ToArray();
        }

        // Select for image files from an array of filenames
        public static string[] FilterForImageFiles(string[] UnfilteredFiles, string Extensions = DefaultRegexExtensions)
        {
            return UnfilteredFiles.Where(file => Regex.IsMatch(file, Extensions, RegexOptions.IgnoreCase)).ToArray();
        }

        // Removes the image extension and replaces it with the filename for the metadata file associated with it
        public static string GetMetaFile(string ImageFile, string Extensions = DefaultRegexExtensions)
        {
            return Regex.Replace(ImageFile, Extensions, ".txt", RegexOptions.IgnoreCase);
        }
        public string GetMetaFile(string ImageFile)
        {
            return GetMetaFile(ImageFile, InstanceRegexExtensions);
        }

        // This at least is necessary, the directory string needs the trailing backslash, I'd still rather convert forward slashes to backslashes
        private static string StandardizeDirectory(string InputString)
        {
            if (InputString[InputString.Length - 1] == '\\') return InputString;
            return InputString + "\\";
        }
    }
}
