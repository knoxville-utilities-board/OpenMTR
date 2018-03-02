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

        public class Listable : BaseFilterListable
        {
            public Listable(ExpandedImageForm form, FlowLayoutPanel panel)
            {
                Form = form;
                Panel = panel;
                Name = "Black and White";
            }

            public override BaseFilter Instance()
            {
                return new BnWFilter(Form, Panel);
            }
        }
    }
}
