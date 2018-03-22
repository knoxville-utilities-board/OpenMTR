using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenMTRDemo.Forms;
using OpenMTRDemo.Models;
using OpenCvSharp;

namespace OpenMTRDemo.Filters
{
    public partial class ShearFilter : BaseFilter
    {
        public ShearFilter(ExpandedImageForm Editor = null, MeterImage meter = null, int horizontal = 0, int vertical = 0)
        {
            InitializeComponent();
            this.Editor = Editor;
            Meter = meter;
            FilterName = "Shear";
            horizontalNumeric.Value = horizontal;
            horizontalTrackBar.Value = horizontal;
            verticalNumeric.Value = vertical;
            verticalTrackBar.Value = vertical;
        }

        public override void ApplyFilter(Mat image)
        {
            Point2f center, right, down, mRight, mDown;
            center = new Point2f(image.Width/2, image.Width/2);
            
            right = new Point2f(center.X + 100, center.Y);
            down = new Point2f(center.X, center.Y + 100);
            
            mRight = new Point2f(right.X, right.Y + verticalTrackBar.Value);
            mDown = new Point2f(down.X + horizontalTrackBar.Value, down.Y);

            Point2f[] src = { center, right, down };
            Point2f[] dst = { center, mRight, mDown };

            Mat transform = Cv2.GetAffineTransform(src, dst);

            Cv2.WarpAffine(image, image, transform, new OpenCvSharp.Size(image.Width, image.Height));
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
            return new ShearFilter(Editor, Meter, horizontalTrackBar.Value, verticalTrackBar.Value);
        }
    }
}
