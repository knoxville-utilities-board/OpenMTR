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

                int x1 = (int)(x0 + 1000 * (-b)),
                    y1 = (int)(y0 + 1000 * a),
                    x2 = (int)(x0 - 1000 * (-b)),
                    y2 = (int)(y0 - 1000 * (a));

                Cv2.Line(sourceImage, new OpenCvSharp.Point(x1, y1), new OpenCvSharp.Point(x2, y2), new Scalar(255, 0, 0));
            }

            ExportMatToFile(sourceImage, "image_with_lines.jpg");
        }
    }
}
