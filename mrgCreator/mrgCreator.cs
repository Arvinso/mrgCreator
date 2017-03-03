using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mrgCreator
{
    public partial class mrgCreator : Form
    {
        Image Scene;
        Image Sprite;

        public mrgCreator()
        {
            InitializeComponent();
        }

        public bool ThumbnailCallback()
        {
            return false;
        }

        private void OpenSpriteImage_Click(object sender, EventArgs e)
        {
            // Displays an OpenFileDialog so the user can select a Cursor.
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Image Files(*.BMP;*.JPG;*.JPEG;*.GIF;*.PNG)|*.BMP;*.JPG;*.JPEG;*.GIF;*.PNG|All files (*.*)|*.*";
            openFileDialog1.Title = "Select an Image File";

            // Show the Dialog.

            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Image.GetThumbnailImageAbort myCallback = new Image.GetThumbnailImageAbort(ThumbnailCallback);
                Scene = Image.FromStream(openFileDialog1.OpenFile());
                SpritePreview.Image = Scene.GetThumbnailImage(ScenePreview.Width, ScenePreview.Height, myCallback, IntPtr.Zero);
            }

            Enable_Merge_Compress();
        }

        private void OpenSceneImage_Click(object sender, EventArgs e)
        {
            // Displays an OpenFileDialog so the user can select a Cursor.
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Image Files(*.BMP;*.JPG;*.JPEG;*.GIF;*.PNG)|*.BMP;*.JPG;*.JPEG;*.GIF;*.PNG|All files (*.*)|*.*";
            openFileDialog1.Title = "Select an Image File";

            // Show the Dialog.

            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Image.GetThumbnailImageAbort myCallback = new Image.GetThumbnailImageAbort(ThumbnailCallback);
                Scene = Image.FromStream(openFileDialog1.OpenFile());
                ScenePreview.Image = Scene.GetThumbnailImage(ScenePreview.Width, ScenePreview.Height, myCallback, IntPtr.Zero);               
            }
        }

        private void Enable_Merge_Compress()
        {
            textBox1.Text = "hello";

        }


    }
}
