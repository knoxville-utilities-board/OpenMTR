using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenMTR;
using OpenCvSharp;

namespace OpenMTR
{
    public static class OMTR
    {
        public static void GetCannyFilter(Mat inputImage, Mat outputImage, double threshold1, double threshold2)
        {
            CannyFilter.ApplyCannyFilter(inputImage, outputImage, threshold1, threshold2);
        }

        public static void GetBlackAndWhite(Mat inputImage, Mat outputImage)
        {
            ImageUtils.ColorToGray(inputImage, outputImage);
        }

        public static void GetGaussianBlur(Mat inputImage, Mat outputImage)
        {
            ImageUtils.ApplyGaussianBlur(inputImage, outputImage);
        }

        public static void GetSobelFilter(Mat inputImage, Mat outputImage)
        {
            SobelFilter.ApplySobelFilter(inputImage, outputImage);
        }

        public static Meter GetMeter(string filePath)
        {
            return ReadData.GetMeter(filePath);
        }
    }
}
