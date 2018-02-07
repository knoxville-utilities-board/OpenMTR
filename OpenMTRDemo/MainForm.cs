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
        OpenFileDialog fileBrowser;
        Meter meter;
        public MainForm()
        {
            fileBrowser = new OpenFileDialog();
            fileBrowser.Filter = "Image Files|*.bmp;*.jpeg;*.jpg;*.gif";
            InitializeComponent();
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fileBrowser.ShowDialog() == DialogResult.OK)
            {
                meter = ReadData.GetMeter(fileBrowser.FileName);
                render();
            }
        }

        private void render()
        {
            inputImageBox.Image = DemoUtilities.MatToBitmap(meter.SourceImage);
            renderOutput();
        }
        private void renderOutput()
        {
            outputImageBox.Image = DemoUtilities.MatToBitmap(meter.ModifiedImage);
        }
    }
}
