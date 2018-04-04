using System.Windows.Forms;
using OpenCvSharp;
using OpenMTRDemo.Forms;
using OpenMTRDemo.Models;

namespace OpenMTRDemo.Filters
{
    public partial class SobelFilter : BaseFilter
    {
        public SobelFilter(ExpandedImageForm Editor = null, MeterImage Meter = null)
        {
            InitializeComponent();
            this.Editor = Editor;
            this.Meter = Meter;
            FilterName = "Sobel Filter";
            Type = 1;
        }

        public override void ApplyFilter(Mat image)
        {
            Cv2.Sobel(image, image, MatType.CV_8U, xorder: 1, yorder: 0, ksize: -1);
        }

        public override BaseFilter Clone()
        {
            return new SobelFilter(Editor, Meter);
        }
    }
}
