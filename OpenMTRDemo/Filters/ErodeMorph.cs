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
    public partial class ErodeMorph : BaseFilter
    {
        public ErodeMorph(ExpandedImageForm Editor = null, MeterImage Meter = null)
        {
            InitializeComponent();
            this.Editor = Editor;
            this.Meter = Meter;
            FilterName = "Erode";
        }
        public override void ApplyFilter(Mat image)
        {
            Cv2.Erode(image, image, new Mat());
        }

        public override BaseFilter Clone()
        {
            return new ErodeMorph(Editor, Meter);
        }
    }
}
