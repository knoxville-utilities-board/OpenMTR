using OpenCvSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenMTRDemo.Forms
{
    public partial class ExpandedImageForm : Form
    {
        public ExpandedImageForm(Mat mat)
        {
            InitializeComponent();
            pictureBoxExpanded.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxExpanded.Image = DemoUtilities.MatToBitmap(mat);   
        }
    }
}
