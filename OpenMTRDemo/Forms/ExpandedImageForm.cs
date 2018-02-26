using System;
using System.Windows.Forms;
using OpenCvSharp;
using OpenMTRDemo.Forms;

namespace OpenMTRDemo.Forms
{
    public partial class ExpandedImageForm : BaseForm
    {
        public Mat Source, Image;
        private Models.LoadSaveDialog _loadSaveDialog;

        public ExpandedImageForm(Mat source, Mat image)
        {
            this.Source = source;
            this.Image = image;
            InitializeComponent();
            this.DialogResult = DialogResult.Cancel;
            InputImageBox.Image = DemoUtilities.MatToBitmap(Source);
            OutputImageBox.Image = DemoUtilities.MatToBitmap(Image);
            _loadSaveDialog = new Models.LoadSaveDialog();
        }

        public ExpandedImageForm(Mat source, Mat image, string[] filterList)
        {
            this.Source = source;
            this.Image = image;
            InitializeComponent();
            this.DialogResult = DialogResult.Cancel;
            foreach (string filter in filterList)
            {
                if (FilterListBox.Items.Contains(filter))
                {
                    FilterListBox.SelectedItems.Add(filter);
                }
            }
            InputImageBox.Image = DemoUtilities.MatToBitmap(Source);
            Render();
        }

        public override void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_loadSaveDialog.saveBrowser.ShowDialog() == DialogResult.OK)
            {
                OutputImageBox.Image.Save(_loadSaveDialog.saveBrowser.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
            }
        }

        public override void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_loadSaveDialog.openBrowser.ShowDialog() == DialogResult.OK)
            {
                Source = new Mat(_loadSaveDialog.openBrowser.FileName);
                InputImageBox.Image = DemoUtilities.MatToBitmap(Source);
                Render();
                SetDisableableControls(true);
            }
        }

        private void Render()
        {
            Image = Source.Clone();
            ApplyFilters(Image);
            OutputImageBox.Image = DemoUtilities.MatToBitmap(Image);
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
                        Cv2.GaussianBlur(imageToFilter, imageToFilter, new Size(3, 3), 0, 0, BorderTypes.Default);
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

        private void filterListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            edgeFindingBox.Enabled = FilterListBox.SelectedItems.Contains("Edge Finding");
            Render();
        }

        public override void CloseToolStripMenuItem_Click(object sender, EventArgs e)
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
            Render();
        }

        private void cannyThreshold2Number_ValueChanged(object sender, EventArgs e)
        {
            CannyThreshold2Slider.Value = (int)CannyThreshold2Number.Value;
            Render();
        }

        private void cannyThreshold1Slider_Scroll(object sender, EventArgs e)
        {
            CannyThreshold1Number.Value = CannyThreshold1Slider.Value;
            Render();
        }

        private void cannyThreshold2Slider_Scroll(object sender, EventArgs e)
        {
            CannyThreshold2Number.Value = CannyThreshold2Slider.Value;
            Render();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void cannyRadio_CheckedChanged(object sender, EventArgs e)
        {
            SetDisableableControls(true);
            Render();
        }
    }
}
