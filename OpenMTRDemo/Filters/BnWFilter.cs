using System.Windows.Forms;
using OpenCvSharp;
using OpenMTRDemo.Forms;
using OpenMTRDemo.Models;

namespace OpenMTRDemo.Filters
{
    public partial class GrayFilter : BaseFilter
    {
        public GrayFilter(ExpandedImageForm Editor = null, MeterImage Meter = null)
        {
            InitializeComponent();
            this.Editor = Editor;
            this.Meter = Meter;
            FilterName = "Black and White";
        }

        public override void ApplyFilter(Mat image)
        {
            if (image.Channels() > 2)
            {
                Cv2.CvtColor(image, image, ColorConversionCodes.BGR2GRAY);
            }
        }

        public override BaseFilter Clone()
        {
            return new GrayFilter(Editor, Meter);
        }
    }
}
