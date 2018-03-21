using System;
using System.Windows.Forms;
using OpenCvSharp;
using OpenMTRDemo.Filters;
using OpenMTRDemo.Models;
using System.Collections.Generic;

namespace OpenMTRDemo.Forms
{
    public partial class ExpandedImageForm : BaseForm
    {
        public MeterImage Meter;
        private Models.LoadSaveDialog _loadSaveDialog;

        public ExpandedImageForm(MeterImage meter)
        {
            this.Meter = meter;
            this.DialogResult = DialogResult.Cancel;
            InitializeComponent();
        }

        private void ExpandedImageForm_Load(object sender, EventArgs e)
        {
            _loadSaveDialog = new Models.LoadSaveDialog();
            SetDisableableControls(true);
            LoadFilters();
            Render();
        }

        private void LoadFilters()
        {
            BaseFilter[] filters = {
                new GrayFilter(this, Meter),
                new GaussianFilter(this, Meter),
                new CannyFilter(this, Meter),
                new SobelFilter(this, Meter),
                new ScharrFilter(this, Meter),
                new LaplacianFilter(this, Meter),
                new PerspectiveFilter(this, Meter)
            };
            filtersComboBox.Items.AddRange(filters);
            for (int i = 0; i < Meter.FilterList.Count; i++)
            {
                Meter.FilterList[i].Editor = this;
                Meter.FilterList[i].Meter = Meter;
                Meter.FilterList[i] = Meter.FilterList[i].Clone();
            }
            filtersFlowPanel.Controls.AddRange(Meter.FilterList.ToArray());
            EnableMoveButtons();
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
                Meter.SourceImage = new Mat(_loadSaveDialog.openBrowser.FileName);
                Render();
                SetDisableableControls(true);
            }
        }

        public void Render(object sender = null, EventArgs e = null)
        {
            OutputImageBox.Image = DemoUtilities.MatToBitmap(Meter.ModifiedImage);
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
            Close();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void addFilterButton_Click(object sender, EventArgs e)
        {
            BaseFilter filter = ((BaseFilter)filtersComboBox.SelectedItem).Clone();
            Meter.Add(filter);
            filtersFlowPanel.Controls.Add(filter);
            EnableMoveButtons();
        }

        private void filtersComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            addFilterButton.Enabled = (filtersComboBox.SelectedIndex != -1);
        }

        public Mat returnImage()
        {
            if (DialogResult == DialogResult.OK)
            {
                return Meter.ModifiedImage;
            }
            return Meter.SourceImage;
        }

        public void EnableMoveButtons()
        {
            var list = filtersFlowPanel.Controls;
            if (list.Count > 0)
            {
                if (list.Count == 1)
                {
                    ((BaseFilter)list[0]).EnableMoveButtons(3);
                }
                else
                {
                    foreach (BaseFilter filter in list)
                    {
                        filter.EnableMoveButtons(0);
                    }
                    ((BaseFilter)list[0]).EnableMoveButtons(1);
                    ((BaseFilter)list[list.Count - 1]).EnableMoveButtons(2);
                }
            }
        }

        public void RenderList()
        {
            filtersFlowPanel.Controls.Clear();
            filtersFlowPanel.Controls.AddRange(Meter.FilterList.ToArray());
            EnableMoveButtons();
        }
    }
}
