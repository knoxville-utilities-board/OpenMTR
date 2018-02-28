using OpenCvSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenMTRDemo.Models
{
    public class MeterImage
    {
        public string FileName { get; set; }
        public Mat SourceImage { get; set; }
        public Mat ModifiedImage { get; set; }


        public MeterImage() { }
        public MeterImage(string fileName, Mat sourceImage, Mat modifiedImage)
        {
            this.FileName = fileName;
            this.SourceImage = sourceImage;
            this.ModifiedImage = modifiedImage;
        }
    }
}
