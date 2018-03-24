using System;
using System.Windows.Forms;
using OpenMTRDemo.Forms;
using OpenMTRDemo.Models;
using OpenCvSharp;
using System.Collections.Generic;

namespace OpenMTRDemo.Filters
{
    public partial class IsolateFilter : BaseFilter
    {
        private bool _preventDoubleRender = true;

        public IsolateFilter(ExpandedImageForm Editor, MeterImage Meter, int threshold = 300)
        {
            this.Editor = Editor;
            this.Meter = Meter;
            InitializeComponent();
            FilterName = "Isolate";
            thresholdTrackBar.Value = threshold;
            thresholdNumeric.Value = threshold * (decimal).01;
        }

        public override void ApplyFilter(Mat image)
        {
            if (image.Type() == MatType.CV_8UC1)
            {
                Cv2.FindContours(image, out Point[][] contours, out HierarchyIndex[] hierarchy, RetrievalModes.External, ContourApproximationModes.ApproxSimple);
                Rect rect = new Rect(0, 0, image.Width, image.Height);
                var contourList = new List<Point[]>(contours);
                contourList.TrimExcess();

                foreach (Point[] point in contourList)
                {

                    double area = Cv2.BoundingRect(point).Width * Cv2.BoundingRect(point).Height;
                    if (area >= 0.01 * image.Width * image.Height * (float)thresholdNumeric.Value && area < rect.Width * rect.Height)
                    {
                        rect = Cv2.BoundingRect(point);
                    }
                }
                Cv2.GetRectSubPix(image, rect.Size, new Point2f(rect.X + rect.Width / 2, rect.Y + rect.Height / 2), image);
            }
        }

        private void threshold_ValueChanged(object sender, EventArgs e)
        {
            int value = (sender == thresholdNumeric) ? (int)(((NumericUpDown)sender).Value * 100) : ((TrackBar)sender).Value;
            thresholdNumeric.Value = (decimal)(value * 0.01);
            thresholdTrackBar.Value = value;
            _preventDoubleRender = !_preventDoubleRender;
            if (_preventDoubleRender)
            {
                Render();
            }
        }

        public override BaseFilter Clone()
        {
            return new IsolateFilter(Editor, Meter, thresholdTrackBar.Value);
        }
    }
}
