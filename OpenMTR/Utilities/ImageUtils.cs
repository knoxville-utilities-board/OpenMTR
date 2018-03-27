using OpenCvSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenMTR
{
    public static class ImageUtils
    {
        public static void ColorToGray(Mat sourceImage, Mat destinationImage)
        {
            Cv2.CvtColor(sourceImage, destinationImage, ColorConversionCodes.BGR2GRAY);
        }

        public static void ColorToGray(List<Meter> meterList)
        {
            foreach (Meter meter in meterList)
            {
                Cv2.CvtColor(meter.SourceImage, meter.ModifiedImage, ColorConversionCodes.BGR2GRAY);
            }
        }

        public static Mat GetKernel(Size size)
        {
            return Cv2.GetStructuringElement(MorphShapes.Rect, size);
        }

        public static void AdjustImageSkew(Meter meter)
        {
            RotateImage(meter.SourceImage, meter.ModifiedImage, GetAngle(meter.SourceImage));
        }

        public static void RotateImage(Mat sourceImage, Mat destinationImage, double degrees)
        {
            Mat rotationMatrix = Cv2.GetRotationMatrix2D(new Point2f(sourceImage.Cols / 2, sourceImage.Rows / 2), degrees, 1);
            Cv2.WarpAffine(sourceImage, destinationImage, rotationMatrix, sourceImage.Size());
        }

        private static double GetAngle(Mat image)
        {
            Mat handler = image.Clone();
            List<double> angles = new List<double>();
            double sumOfAngles = 0;
            ColorToGray(handler, handler);
            Cv2.Canny(handler, handler, 100, 100, 3);
            LineSegmentPoint[] lineSegmentPoints = Cv2.HoughLinesP(handler, 1, Cv2.PI / 180.0, 100, minLineLength: 100, maxLineGap: 5);

            foreach (LineSegmentPoint lsp in lineSegmentPoints)
            {
                Point point1 = lsp.P1;
                Point point2 = lsp.P2;
                Cv2.Line(handler, point1.X, point1.Y, point2.X, point2.Y, new Scalar(0, 255, 0), (int)LineTypes.Link8, 0);
                angles.Add(Math.Atan2(point2.Y - point1.Y, point2.X - point1.X) * (180 / Math.PI));
            }
            foreach (Double dbl in angles)
            {
                sumOfAngles += dbl;
            }
            return sumOfAngles / angles.Count;
        }
    }
}
