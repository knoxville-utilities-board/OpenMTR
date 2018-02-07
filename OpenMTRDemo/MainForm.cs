using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenMTR;

namespace OpenMTRDemo
{
    public partial class MainForm : Form
    {
        OpenFileDialog fileBrowser;
        OpenMTR.Meter dataObject;
        public MainForm()
        {
            fileBrowser = new OpenFileDialog();
            fileBrowser.Filter = "Image Files|*.bmp;*.jpeg;*.jpg;*.gif";
            InitializeComponent();
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fileBrowser.ShowDialog() == DialogResult.OK)
            {
                dataObject = ReadData.GetDataObject(fileBrowser.FileName);
                render();
            }
        }

        private void render()
        {
            inputImageBox.Image = ImageConvert.MatToBitmap(dataObject.SourceImage);
            renderOutput();
        }
        private void renderOutput()
        {
            outputImageBox.Image = ImageConvert.MatToBitmap(dataObject.ModifiedImage);
        }
        
    }
}
