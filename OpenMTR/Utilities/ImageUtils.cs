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

        public static void ColorToGray(List<Meter> dataObjectList)
        {
            foreach (Meter dataObject in dataObjectList)
            {
                Cv2.CvtColor(dataObject.SourceImage, dataObject.ModifiedImage, ColorConversionCodes.BGR2GRAY);
            }
        }

        public static void ApplyGaussianBlur(Mat sourceImage, Mat destinationImage)
        {
            Cv2.GaussianBlur(sourceImage, destinationImage, new Size(3, 3), 0, 0, BorderTypes.Default);
        }

        public static void ApplyGaussianBlur(List<Meter> dataObjectList)
        {
            foreach(Meter dataObject in dataObjectList)
            {
                Cv2.GaussianBlur(dataObject.SourceImage, dataObject.ModifiedImage, new Size(3, 3), 0, 0, BorderTypes.Default);
            }
        }

        public static Mat GetKernel(Size size)
        {
            return Cv2.GetStructuringElement(MorphShapes.Rect, size);
        }
    }
}
