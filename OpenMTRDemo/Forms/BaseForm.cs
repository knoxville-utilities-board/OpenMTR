using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenMTRDemo.Forms
{
    public partial class BaseForm : Form
    {
        public BaseForm()
        {
            InitializeComponent();
        }

        private void BaseForm_Load(object sender, EventArgs e)
        {

        }

        public virtual void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        public virtual void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        public virtual void CloseToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to exit?", "Are you sure?", MessageBoxButtons.YesNo);

            if(dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void tiledFiltersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TiledFiltersForm tiledFiltersForm = new TiledFiltersForm();
            tiledFiltersForm.ShowDialog();
        }

        private void aboutOpenMTRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.StartPosition = FormStartPosition.CenterParent;
            aboutForm.ShowDialog(this);
        }
    }
}
