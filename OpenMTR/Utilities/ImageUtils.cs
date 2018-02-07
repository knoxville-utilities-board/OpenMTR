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

        public static void ApplyGaussianBlur(Mat sourceImage, Mat destinationImage)
        {
            Cv2.GaussianBlur(sourceImage, destinationImage, new Size(3, 3), 0, 0, BorderTypes.Default);
        }

        public static void ApplyGaussianBlur(List<Meter> meterList)
        {
            foreach(Meter meter in meterList)
            {
                Cv2.GaussianBlur(meter.SourceImage, meter.ModifiedImage, new Size(3, 3), 0, 0, BorderTypes.Default);
            }
        }

        public static Mat GetKernel(Size size)
        {
            return Cv2.GetStructuringElement(MorphShapes.Rect, size);
        }
    }
}
