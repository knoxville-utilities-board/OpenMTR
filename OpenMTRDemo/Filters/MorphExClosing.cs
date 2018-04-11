using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenMTRDemo.Models;
using OpenMTRDemo.Forms;
using OpenCvSharp;
using OpenMTR;

namespace OpenMTRDemo.Filters
{
    public partial class MorphExClosing : BaseFilter
    {
        public MorphExClosing(ExpandedImageForm Editor = null, MeterImage Meter = null, int hSize = 1, int vSize = 1)
        {
            InitializeComponent();
            this.Editor = Editor;
            this.Meter = Meter;
            FilterName = "Morph Close";
            horizontalTrackBar.Value = hSize;
            verticalTrackBar.Value = vSize;
        }

        public override void ApplyFilter(Mat image)
        {
            Cv2.MorphologyEx(image, image, MorphTypes.Close, ImageUtils.GetKernel(new OpenCvSharp.Size(1 + 2 * horizontalTrackBar.Value, 1 + 2 * verticalTrackBar.Value)));
        }

        public override BaseFilter Clone()
        {
            return new MorphExClosing(Editor, Meter, horizontalTrackBar.Value, verticalTrackBar.Value);
        }

        private void Render(object sender, EventArgs e)
        {
            Render();
        }
    }
}
