using System.Windows.Forms;
using OpenCvSharp;
using OpenMTRDemo.Forms;
using OpenMTRDemo.Models;

namespace OpenMTRDemo.Filters
{
    public partial class GaussianFilter : BaseFilter
    {
        public GaussianFilter(ExpandedImageForm Editor = null, MeterImage Meter = null, int hRadius = 1, int vRadius = 1)
        {
            InitializeComponent();
            this.Editor = Editor;
            this.Meter = Meter;
            FilterName = "Gaussian Blur";
            horizontalTrackBar.Value = hRadius;
            verticalTrackBar.Value = vRadius;
        }

        public override void ApplyFilter(Mat image)
        {
            Cv2.GaussianBlur(image, image, new OpenCvSharp.Size(horizontalTrackBar.Value * 2 + 1, verticalTrackBar.Value * 2 + 3), 0);
        }

        private void kernelChanged(object sender, System.EventArgs e)
        {
            Render();
        }

        public override BaseFilter Clone()
        {
            return new GaussianFilter(Editor, Meter, horizontalTrackBar.Value, verticalTrackBar.Value);
        }
    }
}
