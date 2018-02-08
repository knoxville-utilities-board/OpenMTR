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
        OpenFileDialog OpenBrowser;
        SaveFileDialog SaveBrowser;
        Meter meter;

        public MainForm()
        {
            OpenBrowser = new OpenFileDialog();
            SaveBrowser = new SaveFileDialog();
            OpenBrowser.Filter = "Image Files|*.bmp;*.gif;*.jpg;*.jpeg;*.png";
            SaveBrowser.Filter = "JPG|*.jpg";
            InitializeComponent();
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (OpenBrowser.ShowDialog() == DialogResult.OK)
            {
                meter = ReadData.GetMeter(OpenBrowser.FileName);
                Render();
            }
            metaDataTextBox.Text = meter.MeterRead + "";
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

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (SaveBrowser.ShowDialog() == DialogResult.OK)
            {
                meter.ModifiedImage.SaveImage(SaveBrowser.FileName);
            }
        }
    }
}
