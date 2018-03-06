using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using OpenCvSharp;
using OpenMTRDemo.Forms;

namespace OpenMTRDemo.Filters
{
    public partial class BaseFilter : UserControl
    {
        public string FilterName;
        public ExpandedImageForm Editor;
        public FlowLayoutPanel FiltersPanel;
        public string ListableName { get { return FilterName;  } }

        public BaseFilter()
        {
            InitializeComponent();
        }

        public virtual void ApplyFilter(Mat image) { }

        public virtual BaseFilter Clone()
        {
            throw new NotImplementedException();
        }

        public void SetLabel()
        {
            nameLabel.Text = FilterName;
        }

        public void Render()
        {
            if (Editor != null)
            {
                Editor.Render();
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
            this.Dispose(true);
            Editor.EnableMoveButtons();
        }

        private void moveButton_Click(object sender, EventArgs e)
        {try
            {
                var source = FiltersPanel.Controls;
                var reorder = new List<Control>();
                int index = source.IndexOf(this) + ((sender == moveUpButton) ? -1 : +1);
                if (index < 0 || index >= source.Count)
                {
                    throw new IndexOutOfRangeException();
                }
                source.Remove(this);
                reorder.Add(this);
                int count = source.Count;
                for(int i = index; i < count; i++)
                {
                    reorder.Add(source[index]);
                    source.RemoveAt(index);
                }
                source.AddRange(reorder.ToArray());
                Editor.EnableMoveButtons();
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("The filter was not declared properly for this button to work.");
            }
        }

        public void EnableMoveButtons(int position)
        {
            moveUpButton.Enabled = (position == 0 || position == 2);
            moveDownButton.Enabled = (position == 0 || position == 1);
        }
    }
}
