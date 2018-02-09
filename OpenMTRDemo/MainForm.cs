using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenCvSharp;
using OpenMTR;

namespace OpenMTRDemo
{
    public partial class MainForm : Form
    {
        OpenFileDialog OpenBrowser;
        SaveFileDialog SaveBrowser;
        OpenMTR.Meter meter;

        public MainForm()
        {
            OpenBrowser = new OpenFileDialog();
            SaveBrowser = new SaveFileDialog();
            OpenBrowser.Filter = "Image Files|*.bmp;*.gif;*.jpg;*.jpeg;*.png";
            SaveBrowser.Filter = "JPG|*.jpg";
            InitializeComponent();
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (OpenBrowser.ShowDialog() == DialogResult.OK)
            {
                meter = OMTR.GetMeter(OpenBrowser.FileName);
                Render();
            }
            MetaDataTextBox.Text = meter.MeterRead + "";
            SetDisableableControls(true);
            WidthTextBox.Text = meter.SourceImage.Width + " px";
            HeightTextBox.Text = meter.SourceImage.Height + " px";
        }

        private void Render()
        {
            InputImageBox.Image = DemoUtilities.MatToBitmap(meter.SourceImage);
            RenderOutput();
        }
        private void RenderOutput()
        {
            meter.ModifiedImage = meter.SourceImage.Clone();
            ApplyFilters(meter.ModifiedImage);
            OutputImageBox.Image = DemoUtilities.MatToBitmap(meter.ModifiedImage);
        }

        private void ApplyFilters(Mat imageToFilter)
        {
            foreach (string filter in FilterListBox.SelectedItems)
            {
                switch (filter)
                {
                    case "Black and White":
                        OMTR.GetBlackAndWhite(imageToFilter, imageToFilter);
                        break;
                    case "Canny":
                        OMTR.GetCannyFilter(imageToFilter.Clone(), imageToFilter, (double)CannyThreshold1Number.Value, (double)CannyThreshold2Number.Value);
                        break;
                    case "Gaussian Blur":
                        OMTR.GetGaussianBlur(imageToFilter, imageToFilter);
                        break;
                    case "Sobel":
                        OMTR.GetSobelFilter(imageToFilter, imageToFilter);
                        break;
                }
            }
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (SaveBrowser.ShowDialog() == DialogResult.OK)
            {
                meter.ModifiedImage.SaveImage(SaveBrowser.FileName);
            }
        }

        private void FilterListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            CannyThresholdBox.Enabled = FilterListBox.SelectedItems.Contains("Canny");
            RenderOutput();
        }

        private void CloseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetDisableableControls(false);
            WidthTextBox.Text = "";
            HeightTextBox.Text = "";
            MetaDataTextBox.Text = "";
            InputImageBox.Image = null;
            OutputImageBox.Image = null;
        }

        private void SetDisableableControls(bool state)
        {
            SaveToolStripMenuItem.Enabled = state;
            CloseToolStripMenuItem.Enabled = state;
            FilterListBox.Enabled = state;
            CannyThresholdBox.Enabled = state && FilterListBox.SelectedItems.Contains("Canny");
        }

        private void CannyThreshold1Number_ValueChanged(object sender, EventArgs e)
        {
            CannyThreshold1Slider.Value = (int)CannyThreshold1Number.Value;
            RenderOutput();
        }

        private void CannyThreshold2Number_ValueChanged(object sender, EventArgs e)
        {
            CannyThreshold2Slider.Value = (int)CannyThreshold2Number.Value;
            RenderOutput();
        }

        private void CannyThreshold1Slider_Scroll(object sender, EventArgs e)
        {
            CannyThreshold1Number.Value = CannyThreshold1Slider.Value;
            RenderOutput();
        }

        private void CannyThreshold2Slider_Scroll(object sender, EventArgs e)
        {
            CannyThreshold2Number.Value = CannyThreshold2Slider.Value;
            RenderOutput();
        }
    }
}
