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
using OpenMTRDemo.Models;
using OpenMTRDemo.Filters;

namespace OpenMTRDemo.Forms
{
    public partial class TiledFiltersForm : BaseForm
    {
        private MeterImage _meter;
        private MeterImage _cannyMat;
        private MeterImage _grayMat;
        private MeterImage _sobelMat;
        private MeterImage _laplacianMat;
        private MeterImage _scharrMat;
        private MeterImage _meterPane1;
        private MeterImage _meterPane2;
        private MeterImage _meterPane3;
        private MeterImage _meterPane4;
        private MeterImage _meterPane5;
        private MeterImage _meterPane6;
        private List<KeyValPair<PictureBox>> _meterList;

        public TiledFiltersForm()
        {
            InitializeComponent();
        }

        public override void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadSaveDialog loadSaveDialog = new LoadSaveDialog();
            if (loadSaveDialog.openBrowser.ShowDialog() == DialogResult.OK)
            {
                _meter = new MeterImage(loadSaveDialog.openBrowser.FileName, new Mat(loadSaveDialog.openBrowser.FileName));
                LoadAllImagePanes();
            }
        }

        private void LoadAllImagePanes()
        {
            _cannyMat = _meter.Clone();
            _grayMat = _meter.Clone();
            _sobelMat = _meter.Clone();
            _laplacianMat = _meter.Clone();
            _scharrMat = _meter.Clone();
            _meterPane1 = _meter.Clone();
            _meterPane2 = _meter.Clone();
            _meterPane3 = _meter.Clone();
            _meterPane4 = _meter.Clone();
            _meterPane5 = _meter.Clone();
            _meterPane6 = _meter.Clone();

            _cannyMat.Add(new CannyFilter());
            _grayMat.Add(new GrayFilter());
            _sobelMat.Add(new SobelFilter());
            _laplacianMat.Add(new LaplacianFilter());
            _scharrMat.Add(new ScharrFilter());

            _meterList = new List<KeyValPair<PictureBox>>();

            _meterList.Add(new KeyValPair<PictureBox>(pictureBoxSource ,_meter));
            _meterList.Add(new KeyValPair<PictureBox>(pictureBoxPane1, _meterPane1));
            _meterList.Add(new KeyValPair<PictureBox>(pictureBoxPane2, _meterPane2));
            _meterList.Add(new KeyValPair<PictureBox>(pictureBoxPane3, _meterPane3));
            _meterList.Add(new KeyValPair<PictureBox>(pictureBoxPane4, _meterPane4));
            _meterList.Add(new KeyValPair<PictureBox>(pictureBoxPane5, _meterPane5));
            _meterList.Add(new KeyValPair<PictureBox>(pictureBoxPane6, _meterPane6));
            _meterList.Add(new KeyValPair<PictureBox>(pictureBoxGray, _grayMat));
            _meterList.Add(new KeyValPair<PictureBox>(pictureBoxSobel, _sobelMat));
            _meterList.Add(new KeyValPair<PictureBox>(pictureBoxCanny, _cannyMat));
            _meterList.Add(new KeyValPair<PictureBox>(pictureBoxLaplace, _laplacianMat));
            _meterList.Add(new KeyValPair<PictureBox>(pictureBoxScharr, _scharrMat));

            foreach (KeyValPair<PictureBox> kvp in _meterList)
            {
                DemoUtilities.loadImage(kvp.Id, kvp.Meter.ModifiedImage);
            }
        }

        private void Pane_DblClickHandler(object sender, EventArgs e)
        {
            try
            {
                ExpandedImageForm expandedImageForm;
                KeyValPair<PictureBox> meterPair = null;
                foreach (KeyValPair<PictureBox> kvp in _meterList)
                {
                    if (sender == kvp.Id)
                    {
                        meterPair = kvp;
                        break;
                    }
                }

                expandedImageForm = new ExpandedImageForm(meterPair.Meter);
                expandedImageForm.ShowDialog();
                if(expandedImageForm.DialogResult == DialogResult.OK)
                {
                    DemoUtilities.loadImage(meterPair.Id, meterPair.Meter.ModifiedImage);
                }
                expandedImageForm.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Error Opening Image", "Error", MessageBoxButtons.OK);
            }
        }

    }
}