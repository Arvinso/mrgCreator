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
        Image SceneImage;
        Image SpriteImage;

        Bitmap resultBitmap;

        bool spriteSet = false;
        bool sceneSet = false;

        public mrgCreator()
        {
            InitializeComponent();
            MergeAndCompress_btn.Enabled = false;
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
                SpriteImage = Image.FromStream(openFileDialog1.OpenFile());
                SpritePreview.Image = SpriteImage.GetThumbnailImage(SpritePreview.Width, SpritePreview.Height, myCallback, IntPtr.Zero);
                spriteSet = true;
                Enable_Merge_Compress();
            }

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
                SceneImage = Image.FromStream(openFileDialog1.OpenFile());
                ScenePreview.Image = SceneImage.GetThumbnailImage(ScenePreview.Width, ScenePreview.Height, myCallback, IntPtr.Zero);
                sceneSet = true;
                Enable_Merge_Compress();
            }
        }

        private void Enable_Merge_Compress()
        {
            if(sceneSet == true && spriteSet == true)
            {
                MergeAndCompress_btn.Enabled = true;
            }
            textBox1.Text = "test";           
        }

        private void MergeAndCompress_btn_Click(object sender, EventArgs e)
        {            
            Image.GetThumbnailImageAbort myCallback = new Image.GetThumbnailImageAbort(ThumbnailCallback);
            Bitmap sceneBitmap = new Bitmap(SceneImage);
            Bitmap spriteBitmap = new Bitmap(SpriteImage);

            resultBitmap = sceneBitmap;

            int scenemidwidth = sceneBitmap.Width / 2;
            int scenemidtheight = sceneBitmap.Height / 2;

            int Itstartx = scenemidwidth - (spriteBitmap.Width / 2);
            int Itstarty = scenemidtheight - (spriteBitmap.Height / 2);
                       
            textBox1.Text = Itstartx.ToString();
            textBox2.Text = Itstarty.ToString();

            for (int x = 0; x < spriteBitmap.Width; x++)
            {
                for (int y = 0; y < spriteBitmap.Height; y++)
                {                   
                    Color spritecolor = spriteBitmap.GetPixel(x, y);
                    
                    if(spritecolor.G != 0)
                    {
                        resultBitmap.SetPixel(x + Itstartx, y + Itstarty, spritecolor);
                    }                                
                }
            }

    




            MergedPreviewBox.Image = resultBitmap.GetThumbnailImage(MergedPreviewBox.Width, MergedPreviewBox.Height, myCallback, IntPtr.Zero);           
        }
    }
}
