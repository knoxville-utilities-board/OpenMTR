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
        public MorphExOpening(ExpandedImageForm Editor = null, MeterImage Meter = null)
        {
            InitializeComponent();
            this.Editor = Editor;
            this.Meter = Meter;
            FilterName = "Morph Open";
        }

        public override void ApplyFilter(Mat image)
        {
            Cv2.MorphologyEx(image, image, MorphTypes.Open, ImageUtils.GetKernel(new OpenCvSharp.Size(3, 3)));
        }

        public override BaseFilter Clone()
        {
            return new MorphExClosing(Editor, Meter);
        }
    }
}
