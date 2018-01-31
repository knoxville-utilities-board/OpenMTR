using OpenCvSharp;

namespace OpenMTR
{
    public class DataObject
    {
        public string FileName { get; private set; }
        public Mat Image { get; private set; }
        public int MeterRead { get; private set; }

        public DataObject() { }
        public DataObject(string fileName, Mat image, int meterRead)
        {
            this.FileName = fileName;
            this.Image = image;
            this.MeterRead = meterRead;
        }
    }
}
