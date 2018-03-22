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
    public partial class AffineFilter : BaseFilter
    {
        public AffineFilter(ExpandedImageForm Editor = null, MeterImage meter = null, int horizontal = 0, int vertical = 0, int angle = 0)
        {
            InitializeComponent();
            this.Editor = Editor;
            Meter = meter;
            FilterName = "Affine";
            horizontalNumeric.Value = horizontal;
            horizontalTrackBar.Value = horizontal;
            verticalNumeric.Value = vertical;
            verticalTrackBar.Value = vertical;
            angleNumeric.Value = angle;
            angleTrackBar.Value = angle;
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
            Cv2.WarpAffine(image, image, Cv2.GetRotationMatrix2D(new Point2f(image.Width / 2, image.Height / 2), -angleTrackBar.Value, 1), new OpenCvSharp.Size(image.Width, image.Height));
        }

        private void transform_ValueChanged(object sender, EventArgs e)
        {
            int value = (sender == horizontalNumeric || sender == verticalNumeric || sender == angleNumeric) ? (int)((NumericUpDown)sender).Value : ((TrackBar)sender).Value;
            if (sender == horizontalTrackBar || sender == horizontalNumeric)
            {
                horizontalTrackBar.Value = value;
                horizontalNumeric.Value = value;
            }
            else if (sender == verticalTrackBar || sender == verticalNumeric)
            {
                verticalTrackBar.Value = value;
                verticalNumeric.Value = value;
            }
            else
            {
                angleTrackBar.Value = value;
                angleNumeric.Value = value;
            }
            Render();
        }

        public override BaseFilter Clone()
        {
            return new AffineFilter(Editor, Meter, horizontalTrackBar.Value, verticalTrackBar.Value, angleTrackBar.Value);
        }
    }
}
