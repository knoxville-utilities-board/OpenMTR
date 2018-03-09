using System.Windows.Forms;
using OpenCvSharp;
using OpenMTRDemo.Forms;
using OpenMTRDemo.Models;

namespace OpenMTRDemo.Filters
{
    public partial class ScharrFilter : BaseFilter
    {
        public ScharrFilter(ExpandedImageForm Editor = null, MeterImage meter = null)
        {
            InitializeComponent();
            this.Editor = Editor;
            this.Meter = meter;
            FilterName = "Scharr Filter";
        }

        public override void ApplyFilter(Mat image)
        {
            Cv2.Scharr(image, image, MatType.CV_8U, xorder: 0, yorder: 1);
        }

        public override BaseFilter Clone()
        {
            return new ScharrFilter(Editor, Meter);
        }
    }
}
