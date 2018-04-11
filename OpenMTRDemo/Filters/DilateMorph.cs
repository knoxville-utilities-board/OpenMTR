using System;
using OpenMTRDemo.Forms;
using OpenMTRDemo.Models;
using OpenCvSharp;

namespace OpenMTRDemo.Filters
{
    public partial class DilateMorph : BaseFilter
    {
        public DilateMorph(ExpandedImageForm Editor = null, MeterImage Meter = null, int horizontal = 1, int vertical = 1)
        {
            InitializeComponent();
            this.Editor = Editor;
            this.Meter = Meter;
            FilterName = "Dilate";
            horizontalTrackBar.Value = horizontal;
            verticalTrackBar.Value = vertical;
        }

        public override void ApplyFilter(Mat image)
        {
            Cv2.Dilate(image, image, Cv2.GetStructuringElement(MorphShapes.Rect, new Size(horizontalTrackBar.Value * 2 + 1, verticalTrackBar.Value * 2 + 1)));
        }

        public override BaseFilter Clone()
        {
            return new DilateMorph(Editor, Meter, horizontalTrackBar.Value, verticalTrackBar.Value);
        }

        private void valueChanged(object sender, EventArgs e)
        {
            Render();
        }
    }
}
