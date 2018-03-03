using System;
using System.Windows.Forms;
using OpenCvSharp;
using OpenMTRDemo.Filters;
using System.Collections.Generic;

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
            this.DialogResult = DialogResult.Cancel;
            InitializeComponent();
        }

        private void ExpandedImageForm_Load(object sender, EventArgs e)
        {
            OutputImageBox.Image = DemoUtilities.MatToBitmap(Image);
            _loadSaveDialog = new Models.LoadSaveDialog();
            SetDisableableControls(true);
            LoadFilters();
        }

        private void LoadFilters()
        {
            BaseFilter.BaseFilterListable[] filters = {
                new BnWFilter.Listable(this, filtersFlowPanel),
                new GaussianFilter.Listable(this, filtersFlowPanel),
                new CannyFilter.Listable(this, filtersFlowPanel),
                new SobelFilter.Listable(this, filtersFlowPanel)
            };
            filtersComboBox.Items.AddRange(filters);
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

        public void Render(object sender = null, EventArgs e = null)
        {
            Image = Source.Clone();
            ApplyFilters(Image);
            OutputImageBox.Image = DemoUtilities.MatToBitmap(Image);
        }

        private void ApplyFilters(Mat image)
        {
            foreach (BaseFilter filter in filtersFlowPanel.Controls)
            {
                filter.ApplyFilter(image);
            }
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
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Image = Source;
            Close();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void addFilterButton_Click(object sender, EventArgs e)
        {
            filtersFlowPanel.Controls.Add(((BaseFilter.BaseFilterListable)filtersComboBox.SelectedItem).Instance());
        }

        public Mat returnImage()
        {
            return Image;
        }
    }
}
