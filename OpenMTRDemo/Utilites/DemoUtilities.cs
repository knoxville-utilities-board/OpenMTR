using System.Drawing;
using System.IO;
using System.Windows.Forms;
using OpenCvSharp;
using OpenMTR;

namespace OpenMTRDemo
{
    public static class DemoUtilities
    {

        public static void loadImage(PictureBox pictureBox, Mat mat)
        {
            pictureBox.Image = MatToBitmap(mat);
        }

        public static Bitmap FileToBitmap(string fileName)
        {
            Bitmap bitmap;
            using (Stream bmpStream = System.IO.File.Open(fileName, System.IO.FileMode.Open))
            {
                Image image = Image.FromStream(bmpStream);

                bitmap = new Bitmap(image);

            }
            return bitmap;
        }

        public static Bitmap MatToBitmap(Mat image)
        {
            return OpenCvSharp.Extensions.BitmapConverter.ToBitmap(image);
        }
    }
}
