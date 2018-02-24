using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenMTRDemo.Models
{
    class LoadSaveDialog
    {
        public OpenFileDialog openBrowser;
        public SaveFileDialog saveBrowser;

        public LoadSaveDialog()
        {
            openBrowser = new OpenFileDialog();
            saveBrowser = new SaveFileDialog();
            openBrowser.Filter = "Image Files|*.bmp;*.gif;*.jpg;*.jpeg;*.png";
            saveBrowser.Filter = "JPG|*.jpg";
            
        }

        public String getOpenFilter()
        {
            return openBrowser.Filter;
        }

        public String getSaveFilter()
        {
            return saveBrowser.Filter;
        }



    }
}
