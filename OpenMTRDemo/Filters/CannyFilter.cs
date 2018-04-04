using System.Windows.Forms;
using OpenCvSharp;
using OpenMTRDemo.Forms;
using OpenMTRDemo.Models;

namespace OpenMTRDemo.Filters
{
    public partial class CannyFilter : BaseFilter
    {
        public CannyFilter(ExpandedImageForm Editor = null, MeterImage Meter = null, int threshold1 = 85, int threshold2 = 170)
        {
            InitializeComponent();
            this.Editor = Editor;
            this.Meter = Meter;
            FilterName = "Canny Filter";
            Type = 1;
            thresholdTrackBar1.Value = threshold1;
            thresholdTrackBar2.Value = threshold2;
        }

        public override void ApplyFilter(Mat image)
        {
            Cv2.Canny(image.Clone(), image, thresholdTrackBar1.Value, thresholdTrackBar2.Value);
        }

        private void threshold_ValueChanged(object sender, System.EventArgs e)
        {
            int value;
            if (sender == thresholdNumber1 || sender == thresholdNumber2)
            {
                value = (int)((NumericUpDown)sender).Value;
            }
            else
            {
                value = ((TrackBar)sender).Value;
            }
            if (sender == thresholdNumber1 || sender == thresholdTrackBar1)
            {
                thresholdNumber1.Value = value;
                thresholdTrackBar1.Value = value;
            }
            else
            {
                thresholdNumber2.Value = value;
                thresholdTrackBar2.Value = value;
            }
            Render();
        }

        public override BaseFilter Clone()
        {
            return new CannyFilter(Editor, Meter, thresholdTrackBar1.Value, thresholdTrackBar2.Value);
        }
    }
}
