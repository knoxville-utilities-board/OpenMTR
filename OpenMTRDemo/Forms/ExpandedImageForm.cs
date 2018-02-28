using System;
using System.Windows.Forms;
using OpenCvSharp;

namespace OpenMTRDemo.Forms
{
    public partial class ExpandedImageForm : BaseForm
    {
        public Mat Source, Image;
        private Models.LoadSaveDialog _loadSaveDialog;

        public ExpandedImageForm(Mat image)
        {
            this.Source = image.Clone();
            this.Image = image;
            InitializeComponent();
            this.DialogResult = DialogResult.Cancel;
            OutputImageBox.Image = DemoUtilities.MatToBitmap(Image);
            _loadSaveDialog = new Models.LoadSaveDialog();
            this.CloseToolStripMenuItem.Enabled = true;
            this.SaveToolStripMenuItem.Enabled = true;
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

        private void cannyThreshold_ValueChanged(object sender, EventArgs e)
        {
            int value;
            try
            {
                value = (int)((NumericUpDown)sender).Value;
                TrackBar receiver = (sender == CannyThreshold1Number) ? CannyThreshold1Slider : CannyThreshold2Slider;
                receiver.Value = value;
            }
            catch (InvalidCastException)
            {
                value = ((TrackBar)sender).Value;
                NumericUpDown receiver = (sender == CannyThreshold1Slider) ? CannyThreshold1Number : CannyThreshold2Number;
                receiver.Value = value;
            }
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
