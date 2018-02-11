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

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (OpenBrowser.ShowDialog() == DialogResult.OK)
            {
                meter = ReadData.GetMeter(OpenBrowser.FileName);
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
                        Cv2.CvtColor(imageToFilter, imageToFilter, ColorConversionCodes.BGR2GRAY);
                        break;
                    case "Gaussian Blur":
                        Cv2.GaussianBlur(imageToFilter, imageToFilter, new OpenCvSharp.Size(3, 3), 0, 0, BorderTypes.Default);
                        break;
                    case "Edge Finding":
                        if (cannyRadio.Checked)
                        {
                            Cv2.Canny(imageToFilter.Clone(), imageToFilter, CannyThreshold1Slider.Value, CannyThreshold2Slider.Value);
                        }
                        else
                        {
                            
                            Cv2.Sobel(imageToFilter, imageToFilter, MatType.CV_8U, xorder: 1, yorder: 0, ksize: -1);
                        }
                        break;
                }
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (SaveBrowser.ShowDialog() == DialogResult.OK)
            {
                meter.ModifiedImage.SaveImage(SaveBrowser.FileName);
            }
        }

        private void filterListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            edgeFindingBox.Enabled = FilterListBox.SelectedItems.Contains("Edge Finding");
            RenderOutput();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
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
            edgeFindingBox.Enabled = state && FilterListBox.SelectedItems.Contains("Edge Finding");
            cannySettingsPanel.Enabled = cannyRadio.Checked;
        }

        private void cannyThreshold1Number_ValueChanged(object sender, EventArgs e)
        {
            CannyThreshold1Slider.Value = (int)CannyThreshold1Number.Value;
            RenderOutput();
        }

        private void cannyThreshold2Number_ValueChanged(object sender, EventArgs e)
        {
            CannyThreshold2Slider.Value = (int)CannyThreshold2Number.Value;
            RenderOutput();
        }

        private void cannyThreshold1Slider_Scroll(object sender, EventArgs e)
        {
            CannyThreshold1Number.Value = CannyThreshold1Slider.Value;
            RenderOutput();
        }

        private void cannyThreshold2Slider_Scroll(object sender, EventArgs e)
        {
            CannyThreshold2Number.Value = CannyThreshold2Slider.Value;
            RenderOutput();
        }

        private void cannyRadio_CheckedChanged(object sender, EventArgs e)
        {
            SetDisableableControls(true);
            RenderOutput();
        }
    }
}
