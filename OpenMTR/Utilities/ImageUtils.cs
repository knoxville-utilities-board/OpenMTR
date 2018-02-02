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
        public static void ColorToGray(DataObject dataObject)
        {
            Cv2.CvtColor(dataObject.SourceImage, dataObject.ModifiedImage, ColorConversionCodes.BGR2GRAY);
        }

        public static void ColorToGray(List<DataObject> dataObjectList)
        {
            foreach (DataObject dataObject in dataObjectList)
            {
                Cv2.CvtColor(dataObject.SourceImage, dataObject.ModifiedImage, ColorConversionCodes.BGR2GRAY);
            }
        }

        public static void ApplyGaussianBlur(DataObject dataObject)
        {
            Cv2.GaussianBlur(dataObject.SourceImage, dataObject.ModifiedImage, new Size(3, 3), 0, 0, BorderTypes.Default);
        }

        public static void ApplyGaussianBlur(List<DataObject> dataObjectList)
        {
            foreach(DataObject dataObject in dataObjectList)
            {
                Cv2.GaussianBlur(dataObject.SourceImage, dataObject.ModifiedImage, new Size(3, 3), 0, 0, BorderTypes.Default);
            }
        }
    }
}
