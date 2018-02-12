using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using OpenMTR;
using OpenCvSharp;

namespace OpenMTRDemo
{
    public partial class MainForm : Form
    {
        OpenFileDialog FileBrowser;
        Meter meter;
        public MainForm()
        {
            FileBrowser = new OpenFileDialog();
            FileBrowser.Filter = "Image Files|*.bmp;*.jpeg;*.jpg;*.gif";
            InitializeComponent();
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FileBrowser.ShowDialog() == DialogResult.OK)
            {
                SetMeter(FileBrowser.FileName);
                Render();
            }
        }

        private void SetMeter(string path)
        {
            string metaPath = Regex.Replace(Path.GetFullPath(path), @"\.(bmp|gif|jpe?g|png)$", ".txt", RegexOptions.IgnoreCase);
            int metaData;
            try
            {
                metaData = Int32.Parse(File.ReadAllText(metaPath));
            }
            catch
            {
                metaData = -1;
            }
            meter = new Meter(path, new Mat(path), new Mat(path), metaData);
            Render();
        }

        private void Render()
        {
            inputImageBox.Image = DemoUtilities.MatToBitmap(meter.SourceImage);
            RenderOutput();
        }
        private void RenderOutput()
        {
            outputImageBox.Image = DemoUtilities.MatToBitmap(meter.ModifiedImage);
        }
    }
}
