using System.Linq;
using System.IO;
using System.Drawing;
using System.Text.RegularExpressions;


namespace OpenMTR
{
    //Iterates through images in directory
    class Iterator
    {
        public struct Files
        {
            public Bitmap bitmap;
            public int metaData;
        }


        private string imagePath, metadataPath;
        private int pos;
        private string[] filenames;
        private Files currentData;
        private string extensions;


        public Iterator (string path, string extensions = "(jpe?g|png)$")
        {   // the default regex value above matches jpg, jpeg, and png
            Dir = path;
            filenames = getFilenames(path);
            pos = -1; //pos is used to determine which files in the directory are to be processed

            this.extensions = extensions;
        }



        //================================ PROPERTIES ===========================================



        /// <summary>
        /// GET|SET the current working directory of the iterator, setting this will also set the metadata directory
        /// </summary>
        public string Dir
        {
            get
            {
                return imagePath;
            }
            set
            {
                if (!Directory.Exists(value)) throw new DirectoryNotFoundException("That directory does not exist, ensure it typed correctly and includeds the volume");
                imagePath = standardizePath(value);
                metadataPath = imagePath;
                pos = 0;
            }
        }



        /// <summary>
        /// Change the directory to search for metadata files, if this is different from the image file directory, this will have to explicitly set
        /// </summary>
        public string MetadataDir
        {
            get
            {
                return metadataPath;
            }
            set
            {
                if (!Directory.Exists(value)) throw new DirectoryNotFoundException("That directory does not exist, ensure it typed correctly and includeds the volume");
                metadataPath = standardizePath(value);
            }
        }



        /// <summary>
        /// Return the current data struct, read only
        /// </summary>
        public Files Data
        {
            get
            {
                return currentData;
            }
        }



        /// <summary>
        /// Return the full path of the current image
        /// </summary>
        public string ImageFile
        {
            get
            {
                return Dir + filenames[pos];
            }
        }



        /// <summary>
        /// Return the full path of the current metadata file
        /// </summary>
        public string MetadataFile
        {
            get
            { // technically one line, broken out for readability
                return
                    MetadataDir +
                    Regex.Replace(
                        filenames[pos], extensions, "txt"
                        );
            }
        }



        //================================ STATIC METHODS ===========================================



        /// <summary>
        /// Converts a file to a bitmap, direct copy of Matt's method in the canny filter program
        /// </summary>
        /// <param name="fileName">The filename</param>
        /// <returns>A bitmap</returns>
        public static Bitmap ConvertToBitmap(string fileName)
        {
            Bitmap bitmap;
            using (Stream bmpStream = File.Open(fileName, FileMode.Open))
            {
                Image image = Image.FromStream(bmpStream);

                bitmap = new Bitmap(image);

            }
            return bitmap;
        }



        /// <summary>
        /// Replace forward slashes with backslashes and add a trailing backslash if not present
        /// </summary>
        /// <param name="input"></param>
        /// <returns>A standardized path</returns>
        public static string standardizePath(string input)
        {
            string output = input.Replace('/','\\').Trim();

            if (output[output.Length - 1] == '\\') return output;
            return output + "\\";
        }



        /// <summary>
        /// Returns the integer contained in a plain text file
        /// </summary>
        /// <param name="fileName">The name of file with complete path</param>
        /// <returns>Whatever integer was found in the file</returns>
        public static int ConvertToInt(string fileName, bool noFail)
        {
            string number = File.ReadAllText(fileName);

            number = number.Replace("[\n\r]", "").Trim(); // I was going to trim anyway, so I might as well get rid of new lines while I'm at it

            if (noFail) // If the file contains some kind of comment or other silliness this can be used to purge every non-numeric character
            {
                number = "0" + number.Replace("[^0-9]","");
            }

            return int.Parse(number);
        }
        public static int ConvertToInt(string fileName)
        {
            return ConvertToInt(fileName, false);
        }



        //=================================== PUBLIC METHODS ==============================================

        
        
        /// <summary>
        /// Check if there is a next file to move on to
        /// </summary>
        /// <returns></returns>
        public bool HasNext()
        {
            return pos < filenames.Length;
        }


        /// <summary>
        /// Moves to the next file and returns it and its associated metadata in a struct
        /// </summary>
        /// <returns>struct containing a bitmap and an integer</returns>
        public Files Next()
        {
            pos++;
            while (!Regex.IsMatch(ImageFile, extensions) && HasNext()) pos++;
            return processFiles();
        }



        //=================================== STATIC METHODS WITH PRIVATE USES =============================



        /// <summary>
        /// Process two files and return a bitmap and an integer contained in a struct
        /// </summary>
        /// <param name="imageFile">The file to be converted to a bitmap</param>
        /// <param name="metadataFile">The file to be converted to an integer</param>
        /// <param name="ignoreFNF">If there's no metadata file enter -1 instead of throwing a FileNotFoundException</param>
        /// <returns>A struct containing the bitmap and integer</returns>
        public static Files processFiles(string imageFile, string metadataFile, bool ignoreFNF = false)
        {
            Files data = new Files();

            data.bitmap = ConvertToBitmap(imageFile);

            try
            {
                data.metaData = ConvertToInt(metadataFile);
            }
            catch (FileNotFoundException fnf)
            {
                if (!ignoreFNF) throw fnf;
                else data.metaData = -1;
            }

            return data;
        }
        private Files processFiles()
        {
            currentData = processFiles(ImageFile, MetadataFile);
            return currentData;
        }



        //====================================  PRIVATE METHODS  =================================================


        /// <summary>
        /// Generate a list of filenames without the full path to save memory.
        /// This may have to be replaced later with some other method due to the memory usage of half a million+ strings
        /// </summary>
        /// <param name="path">Path to files</param>
        /// <returns>The files in the path</returns>
        private string[] getFilenames(string path)
        {
            return (string[])Directory.GetFiles(path).Select(f => Path.GetFileName(f));
        }
        


    }
}
