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
        private Meter meter;
        private Mat cannyMat;
        private Mat grayMat;
        private Mat sobelMat;
        private Mat laplacianMat;
        private Mat scharrMat;
        private Meter meterPane1;
        private Meter meterPane2;
        private Meter meterPane3;
        private Meter meterPane4;
        private Meter meterPane5;
        private Meter meterPane6;

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
                meter = new Meter(loadSaveDialog.openBrowser.FileName, new Mat(loadSaveDialog.openBrowser.FileName), new Mat(loadSaveDialog.openBrowser.FileName), -1);
                LoadAllImagePanes();
                CreateDictionary();
                LoadComboBox();
            }
        }

        public void CreateDictionary()
        {
            kvpList = new List<KeyValPair>();
            kvpList.Add(new KeyValPair("Pane 1", meterPane1));
            kvpList.Add(new KeyValPair("Pane 2", meterPane1));
            kvpList.Add(new KeyValPair("Pane 3", meterPane1));
            kvpList.Add(new KeyValPair("Pane 4", meterPane1));
            kvpList.Add(new KeyValPair("Pane 5", meterPane1));
            kvpList.Add(new KeyValPair("Pane 6", meterPane1));
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
            cannyMat = meter.SourceImage.Clone();
            grayMat = meter.SourceImage.Clone();
            sobelMat = meter.SourceImage.Clone();
            laplacianMat = meter.SourceImage.Clone();
            scharrMat = meter.SourceImage.Clone();

            meterPane1 = new Meter();
            meterPane2 = new Meter();
            meterPane3 = new Meter();
            meterPane4 = new Meter();
            meterPane5 = new Meter();
            meterPane6 = new Meter();

            meterPane1.SourceImage = meter.SourceImage.Clone();
            meterPane2.SourceImage = meter.SourceImage.Clone();
            meterPane3.SourceImage = meter.SourceImage.Clone();
            meterPane4.SourceImage = meter.SourceImage.Clone();
            meterPane5.SourceImage = meter.SourceImage.Clone();
            meterPane6.SourceImage = meter.SourceImage.Clone();

            //OpenCVSharp required Mat data type to not be null when databound.
            meterPane1.ModifiedImage = meter.SourceImage.Clone();
            meterPane2.ModifiedImage = meter.SourceImage.Clone();
            meterPane3.ModifiedImage = meter.SourceImage.Clone();
            meterPane4.ModifiedImage = meter.SourceImage.Clone();
            meterPane5.ModifiedImage = meter.SourceImage.Clone();
            meterPane6.ModifiedImage = meter.SourceImage.Clone();

            Cv2.CvtColor(grayMat, grayMat, ColorConversionCodes.BGR2GRAY);
            Cv2.Canny(grayMat, cannyMat, 225, 255);
            Cv2.Sobel(sobelMat, sobelMat, MatType.CV_8U, xorder: 1, yorder: 0, ksize: -1);
            Cv2.Laplacian(laplacianMat, laplacianMat, MatType.CV_8U, 3, 1, 0);
            Cv2.Scharr(grayMat, scharrMat, MatType.CV_8U, xorder: 0, yorder: 1);

            DemoUtilities.loadImage(pictureBoxSource, meter.SourceImage);
            DemoUtilities.loadImage(pictureBoxPane1, meterPane1.SourceImage);
            DemoUtilities.loadImage(pictureBoxPane2, meterPane2.SourceImage);
            DemoUtilities.loadImage(pictureBoxPane3, meterPane3.SourceImage);
            DemoUtilities.loadImage(pictureBoxPane4, meterPane4.SourceImage);
            DemoUtilities.loadImage(pictureBoxPane5, meterPane5.SourceImage);
            DemoUtilities.loadImage(pictureBoxPane6, meterPane6.SourceImage);
            DemoUtilities.loadImage(pictureBoxGray, grayMat);
            DemoUtilities.loadImage(pictureBoxSobel, sobelMat);
            DemoUtilities.loadImage(pictureBoxCanny, cannyMat);
            DemoUtilities.loadImage(pictureBoxLaplace, laplacianMat);
            DemoUtilities.loadImage(pictureBoxScharr, scharrMat);
        }

        private void pictureBoxSource_DoubleClick(object sender, EventArgs e)
        {
            ExpandedImageForm expandedImageForm = new ExpandedImageForm(meter.SourceImage);
            expandedImageForm.ShowDialog();
            expandedImageForm.Close();
        }

        private void pictureBoxGray_DoubleClick(object sender, EventArgs e)
        {
            ExpandedImageForm expandedImageForm = new ExpandedImageForm(grayMat);
            expandedImageForm.ShowDialog();
            expandedImageForm.Close();
        }

        private void pictureBoxCanny_DoubleClick(object sender, EventArgs e)
        {
            ExpandedImageForm expandedImageForm = new ExpandedImageForm(cannyMat);
            expandedImageForm.ShowDialog();
            expandedImageForm.Close();
        }

        private void pictureBoxSobel_DoubleClick(object sender, EventArgs e)
        {
            ExpandedImageForm expandedImageForm = new ExpandedImageForm(sobelMat);
            expandedImageForm.ShowDialog();
            expandedImageForm.Close();
        }

        private void pictureBoxLaplace_DoubleClick(object sender, EventArgs e)
        {
            ExpandedImageForm expandedImageForm = new ExpandedImageForm(laplacianMat);
            expandedImageForm.ShowDialog();
            expandedImageForm.Close();
        }

        private void pictureBoxScharr_DoubleClick(object sender, EventArgs e)
        {
            ExpandedImageForm expandedImageForm = new ExpandedImageForm(scharrMat);
            expandedImageForm.ShowDialog();
            expandedImageForm.Close();
        }

        private void pictureBoxPane1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                ExpandedImageForm expandedImageForm;
                if (meterPane1.ModifiedImage == meterPane1.SourceImage)
                {
                    expandedImageForm = new ExpandedImageForm(meterPane1.SourceImage);
                    expandedImageForm.ShowDialog();
                    expandedImageForm.Close();
                }
                else
                {
                    expandedImageForm = new ExpandedImageForm(meterPane1.ModifiedImage);
                    expandedImageForm.ShowDialog();
                    expandedImageForm.Close();
                }
                
            }
            catch (Exception)
            {

            }
        }

        private void pictureBoxPane2_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                ExpandedImageForm expandedImageForm;
                if (meterPane1.ModifiedImage == meterPane1.SourceImage)
                {
                    expandedImageForm = new ExpandedImageForm(meterPane2.SourceImage);
                    expandedImageForm.ShowDialog();
                    expandedImageForm.Close();
                }
                else
                {
                    expandedImageForm = new ExpandedImageForm(meterPane2.ModifiedImage);
                    expandedImageForm.ShowDialog();
                    expandedImageForm.Close();
                }

            }
            catch (Exception)
            {

            }
        }

        private void pictureBoxPane3_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                ExpandedImageForm expandedImageForm;
                if (meterPane1.ModifiedImage == meterPane1.SourceImage)
                {
                    expandedImageForm = new ExpandedImageForm(meterPane3.SourceImage);
                    expandedImageForm.ShowDialog();
                    expandedImageForm.Close();
                }
                else
                {
                    expandedImageForm = new ExpandedImageForm(meterPane3.ModifiedImage);
                    expandedImageForm.ShowDialog();
                    expandedImageForm.Close();
                }

            }
            catch (Exception)
            {

            }
        }

        private void pictureBoxPane4_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                ExpandedImageForm expandedImageForm;
                if (meterPane1.ModifiedImage == meterPane4.SourceImage)
                {
                    expandedImageForm = new ExpandedImageForm(meterPane4.SourceImage);
                    expandedImageForm.ShowDialog();
                    expandedImageForm.Close();
                }
                else
                {
                    expandedImageForm = new ExpandedImageForm(meterPane4.ModifiedImage);
                    expandedImageForm.ShowDialog();
                    expandedImageForm.Close();
                }

            }
            catch (Exception)
            {

            }
        }

        private void pictureBoxPane5_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                ExpandedImageForm expandedImageForm;
                if (meterPane1.ModifiedImage == meterPane5.SourceImage)
                {
                    expandedImageForm = new ExpandedImageForm(meterPane5.SourceImage);
                    expandedImageForm.ShowDialog();
                    expandedImageForm.Close();
                }
                else
                {
                    expandedImageForm = new ExpandedImageForm(meterPane5.ModifiedImage);
                    expandedImageForm.ShowDialog();
                    expandedImageForm.Close();
                }

            }
            catch (Exception)
            {

            }
        }

        private void pictureBoxPane6_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                ExpandedImageForm expandedImageForm;
                if (meterPane1.ModifiedImage == meterPane6.SourceImage)
                {
                    expandedImageForm = new ExpandedImageForm(meterPane6.SourceImage);
                    expandedImageForm.ShowDialog();
                    expandedImageForm.Close();
                }
                else
                {
                    expandedImageForm = new ExpandedImageForm(meterPane6.ModifiedImage);
                    expandedImageForm.ShowDialog();
                    expandedImageForm.Close();
                }
            }
            catch (Exception)
            {

            }
        }

        private void checkBoxGuassianBlur_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                KeyValPair keyValuePair = new KeyValPair();
                keyValuePair = getMeterKeyValuePair();
                if (checkBoxGuassianBlur.Checked)
                {
                    
                    Cv2.GaussianBlur(keyValuePair.meter.SourceImage, keyValuePair.meter.ModifiedImage, new OpenCvSharp.Size((int)numericUpDown1.Value, (int)numericUpDown2.Value), 0, 1, BorderTypes.Default);
                    UpdateModifiedImage(keyValuePair);
                    DemoUtilities.loadImage(GetSelectedPictureBox(), keyValuePair.meter.ModifiedImage);
                }
                else
                {
                    DemoUtilities.loadImage(GetSelectedPictureBox(), keyValuePair.meter.SourceImage);
                }
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
            if (keyValPair.Id.Equals("Pane 1"))
            {
                return pictureBoxPane1;
            }
            else if (keyValPair.Id.Equals("Pane 2"))
            {
                return pictureBoxPane2;
            }
            else if (keyValPair.Id.Equals("Pane 3"))
            {
                return pictureBoxPane3;
            }
            else if (keyValPair.Id.Equals("Pane 4"))
            {
                return pictureBoxPane4;
            }
            else if (keyValPair.Id.Equals("Pane 5"))
            {
                return pictureBoxPane5;
            }
            else
            {
                return pictureBoxPane6;
            }
        }
    }
}

