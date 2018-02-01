using OpenCvSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenMTR.code
{
    public static class ImageUtils
    {
        public static void ColorToGray(DataObject dataObject)
        {
            Mat tempImage = new Mat();
            Cv2.CvtColor(dataObject.Image, tempImage, ColorConversionCodes.BGR2GRAY);
            dataObject.Image = tempImage;
        }
    }
}
