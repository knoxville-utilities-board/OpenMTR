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
using OpenCvSharp;

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
            meter.ModifiedImage = meter.SourceImage.Clone();
            foreach (string filter in FilterListBox.SelectedItems)
            {
                switch (filter)
                {
                    case "Black and White":
                        ImageUtils.ColorToGray(meter.ModifiedImage, meter.ModifiedImage);
                        break;
                    case "Canny":
                        CannyFilter.ApplyCannyFilter(meter.ModifiedImage.Clone(), meter.ModifiedImage);
                        break;
                    case "Gaussian Blur":
                        ImageUtils.ApplyGaussianBlur(meter.ModifiedImage, meter.ModifiedImage);
                        break;
                    case "Sobel":
                        SobelFilter.ApplySobelFilter(meter.ModifiedImage, meter.ModifiedImage);
                        break;
                }
            }
            outputImageBox.Image = DemoUtilities.MatToBitmap(meter.ModifiedImage);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (SaveBrowser.ShowDialog() == DialogResult.OK)
            {
                meter.ModifiedImage.SaveImage(SaveBrowser.FileName);
            }
        }

        private void FilterListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            RenderOutput();
        }
    }
}
