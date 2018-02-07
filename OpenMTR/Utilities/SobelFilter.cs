using OpenCvSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenMTR
{
    public static class SobelFilter
    {
        public static void ApplySobelFilter(Mat source, Mat destination)
        {
            Cv2.Sobel(source, destination, MatType.CV_32F, xorder: 1, yorder: 0, ksize: -1);
        }

        public static void ApplySobelFilter(List<Meter> meterList)
        {
            foreach(Meter meter in meterList)
            {
                Cv2.Sobel(meter.ModifiedImage, meter.ModifiedImage, MatType.CV_32F, xorder: 1, yorder: 0, ksize: -1);
            }
        }
    }
}
