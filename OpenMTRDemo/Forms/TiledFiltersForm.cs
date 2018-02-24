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
using OpenMTRDemo.Models;

namespace OpenMTRDemo.Forms
{
    public partial class TiledFiltersForm : BaseForm
    {
        List<KeyValPair> kvpList;
        BindingSource bindingSource;
        private Meter _meter;
        private Mat _cannyMat;
        private Mat _grayMat;
        private Mat _sobelMat;
        private Mat _laplacianMat;
        private Mat _scharrMat;
        private Meter _meterPane1;
        private Meter _meterPane2;
        private Meter _meterPane3;
        private Meter _meterPane4;
        private Meter _meterPane5;
        private Meter _meterPane6;

        public TiledFiltersForm()
        {
            InitializeComponent();
            menuStrip1.Items.Remove(tiledFiltersToolStripMenuItem);
            this.WindowState = FormWindowState.Maximized;
        }

        public override void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadSaveDialog loadSaveDialog = new LoadSaveDialog();
            if (loadSaveDialog.openBrowser.ShowDialog() == DialogResult.OK)
            {
                _meter = new Meter(loadSaveDialog.openBrowser.FileName, new Mat(loadSaveDialog.openBrowser.FileName), new Mat(loadSaveDialog.openBrowser.FileName), -1);
                LoadAllImagePanes();
                CreateListOfKeyValuePairs();
                LoadComboBox();
            }
        }

        public void CreateListOfKeyValuePairs()
        {
            kvpList = new List<KeyValPair>();
            kvpList.Add(new KeyValPair("Pane 1", _meterPane1));
            kvpList.Add(new KeyValPair("Pane 2", _meterPane1));
            kvpList.Add(new KeyValPair("Pane 3", _meterPane1));
            kvpList.Add(new KeyValPair("Pane 4", _meterPane1));
            kvpList.Add(new KeyValPair("Pane 5", _meterPane1));
            kvpList.Add(new KeyValPair("Pane 6", _meterPane1));
        }

        private void LoadComboBox()
        {
            bindingSource = new BindingSource();
            bindingSource.DataSource = kvpList;
            comboBox1.DisplayMember = "Id";
            comboBox1.ValueMember = "meter";
            comboBox1.DataSource = bindingSource.DataSource;
            
        }

        private void LoadAllImagePanes()
        {
            _cannyMat = _meter.SourceImage.Clone();
            _grayMat = _meter.SourceImage.Clone();
            _sobelMat = _meter.SourceImage.Clone();
            _laplacianMat = _meter.SourceImage.Clone();
            _scharrMat = _meter.SourceImage.Clone();

            _meterPane1 = new Meter();
            _meterPane2 = new Meter();
            _meterPane3 = new Meter();
            _meterPane4 = new Meter();
            _meterPane5 = new Meter();
            _meterPane6 = new Meter();

            _meterPane1.SourceImage = _meter.SourceImage.Clone();
            _meterPane2.SourceImage = _meter.SourceImage.Clone();
            _meterPane3.SourceImage = _meter.SourceImage.Clone();
            _meterPane4.SourceImage = _meter.SourceImage.Clone();
            _meterPane5.SourceImage = _meter.SourceImage.Clone();
            _meterPane6.SourceImage = _meter.SourceImage.Clone();

            //OpenCVSharp required Mat data type to not be null when databound.
            _meterPane1.ModifiedImage = _meter.SourceImage.Clone();
            _meterPane2.ModifiedImage = _meter.SourceImage.Clone();
            _meterPane3.ModifiedImage = _meter.SourceImage.Clone();
            _meterPane4.ModifiedImage = _meter.SourceImage.Clone();
            _meterPane5.ModifiedImage = _meter.SourceImage.Clone();
            _meterPane6.ModifiedImage = _meter.SourceImage.Clone();

            Cv2.CvtColor(_grayMat, _grayMat, ColorConversionCodes.BGR2GRAY);
            Cv2.Canny(_grayMat, _cannyMat, 225, 255);
            Cv2.Sobel(_sobelMat, _sobelMat, MatType.CV_8U, xorder: 1, yorder: 0, ksize: -1);
            Cv2.Laplacian(_laplacianMat, _laplacianMat, MatType.CV_8U, 3, 1, 0);
            Cv2.Scharr(_grayMat, _scharrMat, MatType.CV_8U, xorder: 0, yorder: 1);

            DemoUtilities.loadImage(pictureBoxSource, _meter.SourceImage);
            DemoUtilities.loadImage(pictureBoxPane1, _meterPane1.SourceImage);
            DemoUtilities.loadImage(pictureBoxPane2, _meterPane2.SourceImage);
            DemoUtilities.loadImage(pictureBoxPane3, _meterPane3.SourceImage);
            DemoUtilities.loadImage(pictureBoxPane4, _meterPane4.SourceImage);
            DemoUtilities.loadImage(pictureBoxPane5, _meterPane5.SourceImage);
            DemoUtilities.loadImage(pictureBoxPane6, _meterPane6.SourceImage);
            DemoUtilities.loadImage(pictureBoxGray, _grayMat);
            DemoUtilities.loadImage(pictureBoxSobel, _sobelMat);
            DemoUtilities.loadImage(pictureBoxCanny, _cannyMat);
            DemoUtilities.loadImage(pictureBoxLaplace, _laplacianMat);
            DemoUtilities.loadImage(pictureBoxScharr, _scharrMat);
        }

        private void checkBoxGuassianBlur_CheckedChanged(object sender, EventArgs e)
        {
            KeyValPair keyValuePair = new KeyValPair();
            int kernelXValue = (int)numericUpDown1.Value;
            int kernelYValue = (int)numericUpDown2.Value;

            keyValuePair = getMeterKeyValuePair();
            Mat image = keyValuePair.meter.SourceImage;

            try
            {
                if (checkBoxGuassianBlur.Checked)
                {
                    Cv2.GaussianBlur(keyValuePair.meter.SourceImage, keyValuePair.meter.ModifiedImage, new OpenCvSharp.Size(kernelXValue, kernelYValue), 0, 1, BorderTypes.Default);
                    UpdateModifiedImage(keyValuePair);
                    image = keyValuePair.meter.ModifiedImage;
                    DemoUtilities.loadImage(GetSelectedPictureBox(), image);
                }
                DemoUtilities.loadImage(GetSelectedPictureBox(), image);
            }
            catch (Exception)
            {
                checkBoxGuassianBlur.Checked = false;
            }
        }

        private KeyValPair getMeterKeyValuePair()
        {
           foreach(KeyValPair kvp in kvpList)
            {
                if (kvp.Equals(comboBox1.SelectedValue))
                {
                    return kvp;
                }
            }
            return null;
        }

        private void UpdateModifiedImage(KeyValPair modified)
        {
            foreach(KeyValPair toModify in kvpList)
            {
                if (toModify.Id.Equals(modified.Id))
                {
                    toModify.meter.ModifiedImage = modified.meter.ModifiedImage;
                }
            }
        }

        private PictureBox GetSelectedPictureBox()
        {
            KeyValPair keyValPair = (KeyValPair)comboBox1.SelectedItem;

            switch (keyValPair.Id)
            {
                case "Pane 1":
                    return pictureBoxPane1;
                case "Pane 2":
                    return pictureBoxPane2;
                case "Pane 3":
                    return pictureBoxPane3;
                case "Pane 4":
                    return pictureBoxPane4;
                case "Pane 5":
                    return pictureBoxPane5;
                default:
                    return pictureBoxPane6;
            }
        }

        private void Pane_DblClickHandler(object sender, EventArgs e)
        {
            try
            {
                ExpandedImageForm expandedImageForm;
                PictureBox pictureBox = sender as PictureBox;
                Bitmap image = (Bitmap)pictureBox.Image;

                Mat mat = OpenCvSharp.Extensions.BitmapConverter.ToMat(image);

                expandedImageForm = new ExpandedImageForm(mat);
                expandedImageForm.ShowDialog();
                expandedImageForm.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Error Opening Image", "Error", MessageBoxButtons.OK);
            }
        }
    }
}

