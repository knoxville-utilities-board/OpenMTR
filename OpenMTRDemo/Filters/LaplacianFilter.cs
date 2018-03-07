using System.Windows.Forms;
using OpenCvSharp;
using OpenMTRDemo.Forms;

namespace OpenMTRDemo.Filters
{
    public partial class LaplacianFilter : BaseFilter
    {
        public LaplacianFilter(ExpandedImageForm Editor = null, FlowLayoutPanel FiltersPanel = null)
        {
            InitializeComponent();
            this.Editor = Editor;
            this.FiltersPanel = FiltersPanel;
            FilterName = "Laplacian Filter";
        }

        public override void ApplyFilter(Mat image)
        {
            Cv2.Laplacian(image, image, MatType.CV_8U, kSizeTrackBar.Value * 2 + 1, deltaTrackBar.Value);
        }

        public override BaseFilter Clone()
        {
            return new LaplacianFilter(Editor, FiltersPanel);
        }

        private void parametersChanged(object sender, System.EventArgs e)
        {
            Render();
        }
    }
}
