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
            RotateImage(meter.SourceImage, meter.ModifiedImage, GetAngle(meter));
        }

        public static void RotateImage(Mat sourceImage, Mat destinationImage, double degrees)
        {
            Mat rotationMatrix = Cv2.GetRotationMatrix2D(new Point2f(sourceImage.Cols / 2, sourceImage.Rows / 2), degrees, 1);
            Cv2.WarpAffine(sourceImage, destinationImage, rotationMatrix, sourceImage.Size());
        }

        private static double GetAngle(Meter meter)
        {
            Mat handler = meter.SourceImage.Clone();
            ColorToGray(handler, handler);
            Cv2.Canny(handler, handler, 100, 100, 3);
            LineSegmentPoint[] lineSegmentPoints = Cv2.HoughLinesP(handler, 1, Cv2.PI / 180.0, 100, minLineLength: 100, maxLineGap: 5);

            if (lineSegmentPoints.Count() == 0)
            {
                return 0;
            }

            Point point1 = lineSegmentPoints[0].P1;
            Point point2 = lineSegmentPoints[0].P2;

            return Math.Atan2(point2.Y - point1.Y, point2.X - point1.X) * (180 / Math.PI);
        }
    }
}
