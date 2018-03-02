using OpenCvSharp;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;

namespace OpenMTR
{
    public static class DebugUtils
    {
        public static void Log(object message, bool newLine = true)
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
            ConvertMatToBitmap(image).Save(fileName + ".jpg");
            Process.Start(fileName + ".jpg");
        }

        public static Bitmap ConvertMatToBitmap(Mat image)
        {
            return OpenCvSharp.Extensions.BitmapConverter.ToBitmap(image);
        }

        public static void DrawLines(Mat sourceImage, List<LineSegmentPolar> lines)
        {
            foreach (LineSegmentPolar line in lines)
            {
                float rho = line.Rho;
                float theta = line.Theta;

                double a = Math.Cos(theta),
                       b = Math.Sin(theta),
                       x0 = a * rho,
                       y0 = b * rho;

                Cv2.Line(sourceImage, new OpenCvSharp.Point((int)(x0 + 1000 * (-b)), (int)(y0 + 1000 * a)), new OpenCvSharp.Point((int)(x0 - 1000 * (-b)), (int)(y0 - 1000 * (a))), new Scalar(255, 0, 0));
            }

            ExportMatToFile(sourceImage, "image_with_lines.jpg");
        }
    }
}
