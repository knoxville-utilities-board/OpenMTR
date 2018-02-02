using OpenCvSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenMTR.code
{
    public static class SobelFilter
    {
        public static void ApplySobelFilter(DataObject dataObject)
        {
            Mat tempImage = new Mat();
            Cv2.Sobel(tempImage, dataObject.Image, MatType.CV_32F, xorder: 1, yorder: 0, ksize: -1);
        }
    }
}
