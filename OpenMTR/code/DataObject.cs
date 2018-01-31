using OpenCvSharp;

namespace OpenMTR
{
    public class DataObject
    {
        public string FileName { get; set; }
        public Mat Image { get; set; }
        public int MeterRead { get; set; }

        public DataObject() { }
        public DataObject(string name, Mat imageMat, int parsedMeterMetaData)
        {
            this.FileName = name;
            this.Image = imageMat;
            this.MeterRead = parsedMeterMetaData;
        }
    }
}
