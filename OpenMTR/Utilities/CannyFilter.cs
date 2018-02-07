using OpenCvSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenMTR
{
    public static class CannyFilter
    {
        public static void ApplyCannyFilter(Mat sourceImage, Mat destinationImage)
        {
            Cv2.Canny(sourceImage, destinationImage, 100, 150);
        }

        public static void ApplyCannyFilter(Mat sourceImage, Mat destinationImage, double minThreshold, double maxThreshold)
        {
            Cv2.Canny(sourceImage, destinationImage, minThreshold, maxThreshold);
        }

        public static void ApplyCannyFilter(List<Meter> meterList)
        {
            foreach (Meter meter in meterList)
            {
                Cv2.Canny(meter.ModifiedImage, meter.ModifiedImage, 100, 150);
            }
        }
    }
}
