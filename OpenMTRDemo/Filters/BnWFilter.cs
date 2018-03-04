using OpenCvSharp;
using OpenMTRDemo.Forms;
using System.Windows.Forms;

namespace OpenMTRDemo.Filters
{
    public partial class BnWFilter : BaseFilter
    {
        public BnWFilter(ExpandedImageForm Editor = null, FlowLayoutPanel filtersPanel = null)
        {
            InitializeComponent();
            this.Editor = Editor;
            FiltersPanel = filtersPanel;
            FilterName = "Black and White";
            SetLabel();
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
            return new BnWFilter(Editor, FiltersPanel);
        }
    }
}
