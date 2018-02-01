using OpenCvSharp;

namespace OpenMTR
{
    public class DataObject
    {
        public string FileName { get; set; }
        public Mat Image { get; set; }
        public int MeterRead { get; set; }

        public DataObject() { }
        public DataObject(string fileName, Mat image, int meterRead)
        {
            this.FileName = fileName;
            this.Image = image;
            this.MeterRead = meterRead;
        }
    }
}
