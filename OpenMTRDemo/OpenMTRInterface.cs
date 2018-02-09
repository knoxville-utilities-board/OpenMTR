using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenMTR;
using OpenCvSharp;

namespace OpenMTRDemo
{
    public static class OpenMTRInterface
    {
        public static void CannyFilter(Mat inputImage, Mat outputImage, double threshold1, double threshold2)
        {
            OpenMTR.CannyFilter.ApplyCannyFilter(inputImage, outputImage, threshold1, threshold2);
        }

        public static void BlackAndWhite(Mat inputImage, Mat outputImage)
        {
            ImageUtils.ColorToGray(inputImage, outputImage);
        }

        public static void GaussianBlur(Mat inputImage, Mat outputImage)
        {
            ImageUtils.ApplyGaussianBlur(inputImage, outputImage);
        }

        public static void SobelFilter(Mat inputImage, Mat outputImage)
        {
            OpenMTR.SobelFilter.ApplySobelFilter(inputImage, outputImage);
        }

        public static Meter GetMeter(string filePath)
        {
            return ReadData.GetMeter(filePath);
        }
    }
}
