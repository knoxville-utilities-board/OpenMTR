using OpenCvSharp;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace OpenMTR
{
    public static class DebugUtils
    {
        public static void Log(string message, bool newLine = true)
        {
            if (Program.DEBUG)
            {
                if (newLine)
                {
                    message += Environment.NewLine;
                }

                Console.Write(message);
            }
        }

        public static void ExportMatToFile(Mat image, string fileName)
        {
            ConvertMatToBitmap(image).Save(fileName);
        }

        public static Bitmap ConvertMatToBitmap(Mat image)
        {
            return OpenCvSharp.Extensions.BitmapConverter.ToBitmap(image);
        }
    }
}
