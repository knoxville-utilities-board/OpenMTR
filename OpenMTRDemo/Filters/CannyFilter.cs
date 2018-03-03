﻿using OpenCvSharp;
using OpenMTRDemo.Forms;
using System.Windows.Forms;

namespace OpenMTRDemo.Filters
{
    public partial class CannyFilter : BaseFilter
    {
        public CannyFilter(ExpandedImageForm Editor = null, FlowLayoutPanel filtersPanel = null)
        {
            InitializeComponent();
            this.Editor = Editor;
            FiltersPanel = filtersPanel;
            FilterName = "Canny Filter";
            SetLabel();
        }

        public override void ApplyFilter(Mat image)
        {
            Cv2.Canny(image.Clone(), image, thresholdTrackBar1.Value, thresholdTrackBar2.Value);
        }

        private void threshold_ValueChanged(object sender, System.EventArgs e)
        {
            int value;
            if (sender == thresholdNumber1 || sender == thresholdNumber2)
            {
                value = (int)((NumericUpDown)sender).Value;
            }
            else
            {
                value = ((TrackBar)sender).Value;
            }
            if (sender == thresholdNumber1 || sender == thresholdTrackBar1)
            {
                thresholdNumber1.Value = value;
                thresholdTrackBar1.Value = value;
            }
            else
            {
                thresholdNumber2.Value = value;
                thresholdTrackBar2.Value = value;
            }
            Render();
        }

        public class Listable : BaseFilterListable
        {
            public Listable(ExpandedImageForm form, FlowLayoutPanel panel)
            {
                Form = form;
                Panel = panel;
                Name = "Canny Filter";
            }

            public override BaseFilter Instance()
            {
                return new CannyFilter(Form, Panel);
            }
        }
    }
}