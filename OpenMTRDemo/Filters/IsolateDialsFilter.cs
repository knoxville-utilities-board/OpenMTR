using System;
using System.Collections.Generic;
using OpenCvSharp;
using OpenMTRDemo.Forms;
using OpenMTRDemo.Models;
using System.Windows.Forms;
using System.Threading;

namespace OpenMTRDemo.Filters
{
    public partial class IsolateDialsFilter : BaseFilter
    {
        private List<CircleSegment> _circleList;

        public IsolateDialsFilter(ExpandedImageForm Editor, MeterImage Meter, List<CircleSegment> circleList = null)
        {
            this.Editor = Editor;
            this.Meter = Meter;
            _circleList = (circleList == null) ? new List<CircleSegment>() : circleList;
            FilterName = "Isolate Dials";
            Type = 3;
            InitializeComponent();
        }

        public override void ApplyFilter(Mat image)
        {
            if (image.Type() == MatType.CV_8UC1)
            {
                _circleList = new List<CircleSegment>();
                CircleSegment[] circles = Cv2.HoughCircles(image, HoughMethods.Gradient, 1, (Math.Min(image.Height, image.Width) / 12), 250, 100, (Math.Min(image.Height, image.Width) / 20), (Math.Min(image.Height, image.Width) / 3));
                foreach (CircleSegment circle in circles)
                {
                    Point center = circle.Center;
                    int count = 0;
                    foreach (CircleSegment otherCircle in circles)
                    {
                        if (!circle.Equals(otherCircle))
                        {
                            if (Math.Abs(center.Y - otherCircle.Center.Y) < image.Height / 10)
                            {
                                count++;
                            }
                        }
                    }
                    if (count == 3)
                    {
                        _circleList.Add(circle);
                    }
                }
                if (_circleList.Count == 4)
                {
                    foreach (CircleSegment circle in _circleList)
                    {
                        Cv2.Circle(image, circle.Center, (int)circle.Radius, new Scalar(255), (Math.Min(image.Height, image.Width) / 60));
                    }
                }
                else
                {
                    foreach (CircleSegment circle in circles)
                    {
                        Cv2.Circle(image, circle.Center, (int)circle.Radius, new Scalar(255), (Math.Min(image.Height, image.Width) / 60));
                    }
                }
            }
        }

        public override void Cascade(Mat image)
        {
            if (_circleList.Count == 4)
            {
                Editor.Dials = new MeterImage[4];
                SortCircles();
                for (int i = 0; i < 4; i++)
                {
                    Point center = _circleList[i].Center;
                    int diameter = (int)(_circleList[i].Radius * 2 + 1);
                    Mat output = new Mat();
                    Cv2.GetRectSubPix(image, new Size(diameter, diameter), center, output);
                    Editor.Dials[i] = new MeterImage("", output);
                }
            }
        }

        private void SortCircles()
        {
            List<CircleSegment> unsortedList = new List<CircleSegment>(_circleList.ToArray());
            _circleList.Clear();
            for (int i = 0; i < 4; i++)
            {
                CircleSegment least = unsortedList[0];
                foreach (CircleSegment circle in unsortedList)
                {
                    least = (least.Center.X < circle.Center.X) ? least : circle;
                }
                unsortedList.Remove(least);
                _circleList.Add(least);
            }
        }

        public override BaseFilter Clone()
        {
            return new IsolateDialsFilter(Editor, Meter, _circleList);
        }

        private void isolateButton_Click(object sender, EventArgs e)
        {
            Editor.DialogResult = DialogResult.OK;
            Editor.Cascade = true;
            Editor.Close();
        }
    }
}
