using System.Windows.Forms;
using OpenCvSharp;
using OpenMTRDemo.Forms;

namespace OpenMTRDemo.Filters
{
    public partial class ScharrFilter : BaseFilter
    {
        public ScharrFilter(ExpandedImageForm Editor = null, FlowLayoutPanel FiltersPanel = null)
        {
            InitializeComponent();
            this.Editor = Editor;
            this.FiltersPanel = FiltersPanel;
            FilterName = "Scharr Filter";
        }

        public override void ApplyFilter(Mat image)
        {
            Cv2.Scharr(image, image, MatType.CV_8U, xorder: 0, yorder: 1);
        }

        public override BaseFilter Clone()
        {
            return new ScharrFilter(Editor, FiltersPanel);
        }
    }
}
