using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenMTR;

namespace OpenMTRDemo
{
    public partial class MainForm : Form
    {
        OpenFileDialog FileBrowser;
        Meter meter;
        public MainForm()
        {
            FileBrowser = new OpenFileDialog();
            FileBrowser.Filter = "Image Files|*.bmp;*.jpeg;*.jpg;*.gif";
            InitializeComponent();
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FileBrowser.ShowDialog() == DialogResult.OK)
            {
                meter = ReadData.GetMeter(FileBrowser.FileName);
                Render();
            }
        }

        private void Render()
        {
            inputImageBox.Image = DemoUtilities.MatToBitmap(meter.SourceImage);
            RenderOutput();
        }
        private void RenderOutput()
        {
            outputImageBox.Image = DemoUtilities.MatToBitmap(meter.ModifiedImage);
        }
    }
}
