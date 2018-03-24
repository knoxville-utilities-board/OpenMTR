using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using OpenCvSharp;
using OpenMTRDemo.Forms;
using OpenMTRDemo.Models;

namespace OpenMTRDemo.Filters
{
    public partial class BaseFilter : UserControl
    {
        public ExpandedImageForm Editor { get; set; }
        public MeterImage Meter { get; set; }
        public string FilterName { get; set; }

        public BaseFilter()
        {
            InitializeComponent();
        }

        private void BaseFilter_Load(object sender, EventArgs e)
        {
            nameLabel.Text = FilterName;
        }

        public virtual void ApplyFilter(Mat image) { }

        public virtual BaseFilter Clone()
        {
            throw new NotImplementedException();
        }

        public void Render()
        {
            if (Editor != null)
            {
                Editor.Render(this);
            }
        }

        private void button_MouseHover(object sender, EventArgs e)
        {
            ((Label)sender).BackColor = Color.Silver;
        }

        private void button_MouseLeave(object sender, EventArgs e)
        {
            ((Label)sender).BackColor = Color.Transparent;
        }

        private void button_MouseDown(object sender, MouseEventArgs e)
        {
            ((Label)sender).BackColor = Color.Gray;
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            Meter.FilterList.Remove(this);
            Meter.FilterList.TrimExcess();
            this.Dispose(true);
            Editor.EnableMoveButtons();
            Editor.Render();
        }

        private void moveButton_Click(object sender, EventArgs e)
        {try
            {
                int oldIndex = Meter.FilterList.IndexOf(this);
                int newIndex = oldIndex + ((sender == moveUpButton) ? -1 : 1);
                if (newIndex < 0 || newIndex >= Meter.FilterList.Count)
                {
                    throw new IndexOutOfRangeException();
                }
                Meter.FilterList[oldIndex] = Meter.FilterList[newIndex];
                Meter.FilterList[newIndex] = this;
                Editor.RenderList();
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("The filter was not declared properly for this button to work.");
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("The filter cannot be moved up/down when it is already at the top/bottom.");
            }
        }

        public void EnableMoveButtons(int position)
        {
            moveUpButton.Enabled = (position == 0 || position == 2);
            moveDownButton.Enabled = (position == 0 || position == 1);
        }
    }
}
