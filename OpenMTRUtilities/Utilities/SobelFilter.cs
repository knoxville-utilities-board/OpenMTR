using OpenCvSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenMTRUtilities
{
    public static class SobelFilter
    {
        public static void ApplySobelFilter(Mat source, Mat destination)
        {
            Cv2.Sobel(source, destination, MatType.CV_32F, xorder: 1, yorder: 0, ksize: -1);
        }

        public static void ApplySobelFilter(List<DataObject> dataObjectList)
        {
            foreach(DataObject dataObject in dataObjectList)
            {
                Cv2.Sobel(dataObject.ModifiedImage, dataObject.ModifiedImage, MatType.CV_32F, xorder: 1, yorder: 0, ksize: -1);
            }
        }
    }
}
