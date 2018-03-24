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
                LoadKeyValueList();
                LoadAllImagePanes();
            }
        }

        private void LoadKeyValueList()
        {
            _meterList = new List<KeyValPair<PictureBox>>();

            _meterList.Add(new KeyValPair<PictureBox>(pictureBoxSource, _meter));
            _meterList.Add(new KeyValPair<PictureBox>(pictureBoxPane1, _meter.Clone()));
            _meterList.Add(new KeyValPair<PictureBox>(pictureBoxPane2, _meter.Clone()));
            _meterList.Add(new KeyValPair<PictureBox>(pictureBoxPane3, _meter.Clone()));
            _meterList.Add(new KeyValPair<PictureBox>(pictureBoxPane4, _meter.Clone()));
            _meterList.Add(new KeyValPair<PictureBox>(pictureBoxPane5, _meter.Clone()));
            _meterList.Add(new KeyValPair<PictureBox>(pictureBoxPane6, _meter.Clone()));
            _meterList.Add(new KeyValPair<PictureBox>(pictureBoxGray, _meter.Clone()));
            _meterList.Add(new KeyValPair<PictureBox>(pictureBoxSobel, _meter.Clone()));
            _meterList.Add(new KeyValPair<PictureBox>(pictureBoxCanny, _meter.Clone()));
            _meterList.Add(new KeyValPair<PictureBox>(pictureBoxLaplace, _meter.Clone()));
            _meterList.Add(new KeyValPair<PictureBox>(pictureBoxScharr, _meter.Clone()));
        }

        private void LoadAllImagePanes()
        {
            _grayMat = _meterList[7].Meter;
            _sobelMat = _meterList[8].Meter;
            _cannyMat = _meterList[9].Meter;
            _laplacianMat = _meterList[10].Meter;
            _scharrMat = _meterList[11].Meter;

            _grayMat.Add(new GrayFilter());
            _sobelMat.Add(new SobelFilter());
            _cannyMat.Add(new CannyFilter());
            _laplacianMat.Add(new LaplacianFilter());
            _scharrMat.Add(new ScharrFilter());

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
