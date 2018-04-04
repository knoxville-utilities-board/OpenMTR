using System.Windows.Forms;
using OpenCvSharp;
using OpenMTRDemo.Forms;
using OpenMTRDemo.Models;

namespace OpenMTRDemo.Filters
{
    public partial class LaplacianFilter : BaseFilter
    {
        public LaplacianFilter(ExpandedImageForm Editor = null, MeterImage Meter = null, int kernelSize = 0, int delta = 1)
        {
            InitializeComponent();
            this.Editor = Editor;
            this.Meter = Meter;
            FilterName = "Laplacian Filter";
            Type = 1;
            kSizeTrackBar.Value = kernelSize;
            deltaTrackBar.Value = delta;
        }

        public override void ApplyFilter(Mat image)
        {
            Cv2.Laplacian(image, image, MatType.CV_8U, kSizeTrackBar.Value * 2 + 1, deltaTrackBar.Value);
        }

        public override BaseFilter Clone()
        {
            return new LaplacianFilter(Editor, Meter, kSizeTrackBar.Value, deltaTrackBar.Value);
        }

        private void parametersChanged(object sender, System.EventArgs e)
        {
            Render();
        }
    }
}
