using OpenCvSharp;
using OpenMTRDemo.Forms;
using System.Windows.Forms;

namespace OpenMTRDemo.Filters
{
    public partial class SobelFilter : BaseFilter
    {
        public SobelFilter(ExpandedImageForm Editor = null, FlowLayoutPanel filtersPanel = null)
        {
            InitializeComponent();
            this.Editor = Editor;
            FiltersPanel = filtersPanel;
            FilterName = "Sobel Filter";
            SetLabel();
        }

        public override void ApplyFilter(Mat image)
        {
            Cv2.Sobel(image, image, MatType.CV_8U, xorder: 1, yorder: 0, ksize: -1);
        }

        public class Listable : BaseFilterListable
        {
            public Listable(ExpandedImageForm form, FlowLayoutPanel panel)
            {
                Form = form;
                Panel = panel;
                Name = "Sobel Filter";
            }

            public override BaseFilter Instance()
            {
                return new SobelFilter(Form, Panel);
            }
        }
    }
}
