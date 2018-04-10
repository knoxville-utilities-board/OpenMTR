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
using OpenMTR;

namespace OpenMTRDemo.Filters
{
    public partial class MorphExOpening : BaseFilter
    {
        public MorphExOpening(ExpandedImageForm Editor = null, MeterImage Meter = null, int hSize = 1, int vSize = 1)
        {
            InitializeComponent();
            this.Editor = Editor;
            this.Meter = Meter;
            FilterName = "Morph Open";
            horizontalTrackBar.Value = hSize;
            verticalTrackBar.Value = vSize;
        }

        public override void ApplyFilter(Mat image)
        {
            Cv2.MorphologyEx(image, image, MorphTypes.Open, ImageUtils.GetKernel(new OpenCvSharp.Size(1 + 2 * horizontalTrackBar.Value, 1 + 2 * verticalTrackBar.Value)));
        }

        public override BaseFilter Clone()
        {
            return new MorphExOpening(Editor, Meter, horizontalTrackBar.Value, verticalTrackBar.Value);
        }

        private void Render(object sender, EventArgs e)
        {
            Render();
        }
    }
}
