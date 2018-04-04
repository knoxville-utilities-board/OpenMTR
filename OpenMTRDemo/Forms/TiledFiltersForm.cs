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
        
        private MeterImage _sourceMeter;
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
                _sourceMeter = new MeterImage(loadSaveDialog.openBrowser.FileName, new Mat(loadSaveDialog.openBrowser.FileName));
                LoadAllImagePanes();
            }
        }

        private void LoadAllImagePanes()
        {
            _meterList = new List<KeyValPair<PictureBox>>();
            _meterList.Add(new KeyValPair<PictureBox>(pictureBoxSource, _sourceMeter));
            _meterList.Add(new KeyValPair<PictureBox>(pictureBoxIsolated, _sourceMeter.Clone()));
            _meterList.Add(new KeyValPair<PictureBox>(pictureBoxDial1, _sourceMeter.Clone()));
            _meterList.Add(new KeyValPair<PictureBox>(pictureBoxDial2, _sourceMeter.Clone()));
            _meterList.Add(new KeyValPair<PictureBox>(pictureBoxDial3, _sourceMeter.Clone()));
            _meterList.Add(new KeyValPair<PictureBox>(pictureBoxDial4, _sourceMeter.Clone()));
            DemoUtilities.loadImage(pictureBoxSource, _sourceMeter.ModifiedImage);
        }

        private void Pane_DblClickHandler(object sender, EventArgs e)
        {
            KeyValPair<PictureBox> kvp = FindKvp(sender);
            var expandedImageForm = new ExpandedImageForm(kvp.Meter.Clone());
            if (expandedImageForm.ShowDialog() == DialogResult.OK)
            {
                kvp.Meter = expandedImageForm.Meter;
                DemoUtilities.loadImage((PictureBox)sender, kvp.Meter.ModifiedImage);
                
                if (expandedImageForm.Cascade)
                {
                    int[] typeList = { 2, 3 }; //types 2 and 3 are warp and isolate filters, respectively
                    _meterList[1].Meter = new MeterImage("Isolated Image", expandedImageForm.Meter.CascadeImage(typeList));
                    try
                    {
                        pictureBoxIsolated.Enabled = false;
                        dialsBox.Enabled = true;
                        dialsBox.Visible = true;
                        LoadDials(expandedImageForm);
                    }
                    catch (NullReferenceException)
                    {
                        pictureBoxIsolated.Enabled = true;
                        dialsBox.Enabled = false;
                        dialsBox.Visible = false;
                        DemoUtilities.loadImage(pictureBoxIsolated, _meterList[1].Meter.ModifiedImage);
                    }
                }
            }
        }

        private KeyValPair<PictureBox> FindKvp(object sender)
        {
            foreach(var kvp in _meterList)
            {
                if (sender == kvp.Id)
                {
                    return kvp;
                }
            }
            throw new NullReferenceException();
        }

        private void LoadDials(ExpandedImageForm expandedImageForm)
        {
            _meterList[2].Meter = expandedImageForm.Dials[0];
            _meterList[3].Meter = expandedImageForm.Dials[1];
            _meterList[4].Meter = expandedImageForm.Dials[2];
            _meterList[5].Meter = expandedImageForm.Dials[3];
            DemoUtilities.loadImage(pictureBoxDial1, _meterList[2].Meter.ModifiedImage);
            DemoUtilities.loadImage(pictureBoxDial2, _meterList[3].Meter.ModifiedImage);
            DemoUtilities.loadImage(pictureBoxDial3, _meterList[4].Meter.ModifiedImage);
            DemoUtilities.loadImage(pictureBoxDial4, _meterList[5].Meter.ModifiedImage);
        }
    }
}
