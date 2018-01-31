using OpenCvSharp;

namespace OpenMTR.code
{
    public class DataObject
    {
        public string FileName { get; set; }
        public Mat Image { get; set; }
        public int MeterRead { get; set; }
    }
}
