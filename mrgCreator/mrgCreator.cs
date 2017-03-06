using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Imaging;

namespace mrgCreator
{
    struct myYcBc
    {        
        //byte [,]Y ;
        //byte [,]Cb;
        //byte [,]Cr;

        int width;
        int height;

        public YCbCr [,]ycbcrArr;

        public myYcBc(int width, int height)
        {
            //Y = new byte[width, height];
            //Cb = new byte[width, height];
            //Cr = new byte[width, height];

            ycbcrArr = new YCbCr[width, height];

            this.width = width;
            this.height = height;            
        }
        public void DisplayMyownYcbr()
        {
            
        }
    }

    public partial class mrgCreator : Form
    {
        System.Drawing.Image SceneImage;
        System.Drawing.Image SpriteImage;

        Bitmap resultBitmap;

        myYcBc MyOwnYcbcr;

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
                System.Drawing.Image.GetThumbnailImageAbort myCallback = new System.Drawing.Image.GetThumbnailImageAbort(ThumbnailCallback);
                SpriteImage = System.Drawing.Image.FromStream(openFileDialog1.OpenFile());
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
                System.Drawing.Image.GetThumbnailImageAbort myCallback = new System.Drawing.Image.GetThumbnailImageAbort(ThumbnailCallback);
                SceneImage = System.Drawing.Image.FromStream(openFileDialog1.OpenFile());
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
            System.Drawing.Image.GetThumbnailImageAbort myCallback = new System.Drawing.Image.GetThumbnailImageAbort(ThumbnailCallback);
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

            CreateYcbc(resultBitmap);

            MergedPreviewBox.Image = resultBitmap.GetThumbnailImage(MergedPreviewBox.Width, MergedPreviewBox.Height, myCallback, IntPtr.Zero);           
        }

        private void CreateYcbc(Bitmap resultBitmap)
        {
            MyOwnYcbcr = new myYcBc(resultBitmap.Width, resultBitmap.Height);    
                      
            for (int x = 0; x < resultBitmap.Width; x++)
            {
                for (int y = 0; y < resultBitmap.Height; y++)
                {
                    Color resultcolor = resultBitmap.GetPixel(x, y);

                    YCbCr ycrcb = new YCbCr();
                    RGB rgbcolor = new RGB(resultcolor);

                    ycrcb.Y = YCbCr.FromRGB(rgbcolor).Y;
                    ycrcb.Cr = YCbCr.FromRGB(rgbcolor).Cr;
                    ycrcb.Cb = YCbCr.FromRGB(rgbcolor).Cb;

                    MyOwnYcbcr.ycbcrArr[x, y] = ycrcb;                            
                }
            }
            textBox1.Text = MyOwnYcbcr.ycbcrArr[5, 5].Y.ToString();       
        }
    }
}
