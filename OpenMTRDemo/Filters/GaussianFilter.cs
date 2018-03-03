﻿using OpenCvSharp;
using OpenMTRDemo.Forms;
using System.Windows.Forms;

namespace OpenMTRDemo.Filters
{
    public partial class GaussianFilter : BaseFilter
    {
        public GaussianFilter(ExpandedImageForm Editor = null, FlowLayoutPanel filtersPanel = null)
        {
            InitializeComponent();
            this.Editor = Editor;
            FiltersPanel = filtersPanel;
            FilterName = "Gaussian Blur";
            SetLabel();
        }

        public override void ApplyFilter(Mat image)
        {
            Cv2.GaussianBlur(image, image, new OpenCvSharp.Size(horizontalTrackBar.Value * 2 + 3, verticalTrackBar.Value * 2 + 3), 0);
        }

        private void kernelChanged(object sender, System.EventArgs e)
        {
            Render();
        }

        public class Listable : BaseFilterListable
        {
            public Listable(ExpandedImageForm form, FlowLayoutPanel panel)
            {
                Form = form;
                Panel = panel;
                Name = "Gaussian Blur";
            }

            public override BaseFilter Instance()
            {
                return new GaussianFilter(Form, Panel);
            }
        }
    }
}