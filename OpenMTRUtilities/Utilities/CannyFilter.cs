using OpenCvSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenMTRUtilities
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

        public static void ApplyCannyFilter(List<DataObject> dataObjectList)
        {
            foreach (DataObject dataObject in dataObjectList)
            {
                Cv2.Canny(dataObject.ModifiedImage, dataObject.ModifiedImage, 100, 150);
            }
        }
    }
}
