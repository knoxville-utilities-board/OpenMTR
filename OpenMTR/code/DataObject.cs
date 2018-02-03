using OpenCvSharp;

namespace OpenMTR
{
    public class DataObject
    {
        public string FileName { get; set; }
        public Mat SourceImage { get; set; }
        public Mat ModifiedImage { get; set; }
        public int MeterRead { get; set; }

        public DataObject() { }
        public DataObject(string fileName, Mat sourceImage, Mat modifiedImage, int meterRead)
        {
            this.FileName = fileName;
            this.SourceImage = sourceImage;
            this.ModifiedImage = modifiedImage;
            this.MeterRead = meterRead;
        }
    }
}
