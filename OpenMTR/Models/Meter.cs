using OpenCvSharp;

namespace OpenMTR
{
    public class Meter
    {
        public string FileName { get; set; }
        public Mat SourceImage { get; set; }
        public Mat ModifiedImage { get; set; }
        public string MeterRead { get; set; }
        public string ReadType { get; set; }
        public string MeterType { get; set; }
        public string Manufacturer { get; set; }

        public Meter() { }
        public Meter(string fileName, Mat sourceImage, Mat modifiedImage, string meterRead, string readType, string meterType, string manufacturer)
        {
            this.FileName = fileName;
            this.SourceImage = sourceImage;
            this.ModifiedImage = modifiedImage;
            this.MeterRead = meterRead;
            this.ReadType = readType;
            this.MeterType = meterType;
            this.Manufacturer = manufacturer;
        }
    }
}
