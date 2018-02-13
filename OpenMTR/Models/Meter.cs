using OpenCvSharp;

namespace OpenMTR
{
    public class Meter
    {
        public string FileName { get; set; }
        public Mat SourceImage { get; set; }
        public Mat ModifiedImage { get; set; }
        public int MeterRead { get; set; }

        public Meter() { }
        public Meter(string fileName, Mat sourceImage, Mat modifiedImage, int meterRead)
        {
            this.FileName = fileName;
            this.SourceImage = sourceImage;
            this.ModifiedImage = modifiedImage;
            this.MeterRead = meterRead;
        }

        public Meter(string fileName)
        {
            Meter meter = ReadData.GetMeter(fileName);
            FileName = meter.FileName;
            SourceImage = meter.SourceImage;
            ModifiedImage = meter.ModifiedImage;
            MeterRead = meter.MeterRead;
        }
    }
}
