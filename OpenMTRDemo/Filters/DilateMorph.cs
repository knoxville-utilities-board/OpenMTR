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
    public partial class DilateMorph : BaseFilter
    {
        public DilateMorph(ExpandedImageForm Editor = null, MeterImage Meter = null)
        {
            InitializeComponent();
            this.Editor = Editor;
            this.Meter = Meter;
            FilterName = "Dilate";
        }

        public override void ApplyFilter(Mat image)
        {
            Cv2.Dilate(image, image, new Mat());
        }

        public override BaseFilter Clone()
        {
            return new DilateMorph(Editor, Meter);
        }
    }
}
