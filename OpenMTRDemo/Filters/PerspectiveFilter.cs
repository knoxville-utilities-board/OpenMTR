using System;
using System.Windows.Forms;
using OpenMTRDemo.Forms;
using OpenMTRDemo.Models;
using OpenCvSharp;

namespace OpenMTRDemo.Filters
{
    public partial class PerspectiveFilter : BaseFilter
    {
        public PerspectiveFilter(ExpandedImageForm Editor = null, MeterImage Meter = null, int horizontal = 0, int vertical = 0)
        {
            InitializeComponent();
            this.Editor = Editor;
            this.Meter = Meter;
            FilterName = "Perspective Filter";
            horizontalNumeric.Value = horizontal;
            horizontalTrackBar.Value = horizontal;
            verticalNumeric.Value = vertical;
            verticalTrackBar.Value = vertical;
        }

        public override void ApplyFilter(Mat image)
        {
            Point2f topLeft, topRight, bottomLeft, bottomRight, mTopLeft, mTopRight, mBottomLeft, mBottomRight;

            float width = image.Width;
            float height = image.Height;

            float widthChange = width / 800 * verticalTrackBar.Value;
            float heightChange = height / 800 * horizontalTrackBar.Value;

            topLeft = new Point2f(0, 0);
            topRight = new Point2f(width, 0);
            bottomLeft = new Point2f(0, height);
            bottomRight = new Point2f(width, height);

            mTopLeft = new Point2f(0 - widthChange, 0 - heightChange);
            mTopRight = new Point2f(width + widthChange, heightChange);
            mBottomLeft = new Point2f(widthChange, height + heightChange);
            mBottomRight = new Point2f(width - widthChange, height - heightChange);

            Point2f[] src = { topLeft, topRight, bottomLeft, bottomRight };
            Point2f[] dst = { mTopLeft, mTopRight, mBottomLeft, mBottomRight };

            Mat transform = Cv2.GetPerspectiveTransform(src, dst);

            Cv2.WarpPerspective(image, image, transform, new OpenCvSharp.Size(image.Width, image.Height));
        }

        private void transform_ValueChanged(object sender, EventArgs e)
        {
            int value;
            if (sender == horizontalNumeric || sender == verticalNumeric)
            {
                value = (int)((NumericUpDown)sender).Value;
            }
            else
            {
                value = ((TrackBar)sender).Value;
            }
            if (sender == horizontalTrackBar || sender == horizontalNumeric)
            {
                horizontalTrackBar.Value = value;
                horizontalNumeric.Value = value;
            }
            else
            {
                verticalTrackBar.Value = value;
                verticalNumeric.Value = value;
            }
            Render();
        }

        public override BaseFilter Clone()
        {
            return new PerspectiveFilter(Editor, Meter, horizontalTrackBar.Value, verticalTrackBar.Value);
        }
    }
}
