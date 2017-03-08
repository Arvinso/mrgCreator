using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using AForge.Imaging;

namespace mrgCreator
{
    struct Yuv
    {
        public double Yf;
        public double Uf;
        public double Vf;

        public int Y;
        public int U;
        public int V;
    }

    struct myYcBc
    {        
        //byte [,]Y ;
        //byte [,]Cb;
        //byte [,]Cr;

        public int width;
        public int height;

        public Yuv [,]ycbcrArr;

        public myYcBc(int width, int height)
        {
            //Y = new byte[width, height];
            //Cb = new byte[width, height];
            //Cr = new byte[width, height];

            ycbcrArr = new Yuv[width, height];

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
                       
            //textBox1.Text = Itstartx.ToString();
            //textBox2.Text = Itstarty.ToString();

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


            //convert to ycrbc

            MyOwnYcbcr = new myYcBc(resultBitmap.Width, resultBitmap.Height);

            for (int x = 0; x < resultBitmap.Width; x++)
            {
                for (int y = 0; y < resultBitmap.Height; y++)
                {
                    Color resultcolor = resultBitmap.GetPixel(x, y);

                    Yuv ycrcb = new Yuv();
                    //YCbCr blankvalues = new YCbCr();
                    //RGB rgbcolor = new RGB(resultcolor);
                    //
                    //ycrcb.Y = YCbCr.FromRGB(rgbcolor).Y;
                    //ycrcb.Cr = YCbCr.FromRGB(rgbcolor).Cr;
                    //ycrcb.Cb = YCbCr.FromRGB(rgbcolor).Cb;
                    
                    ycrcb.Yf = (0.299 * resultcolor.R) + (0.587 * resultcolor.G) + (0.114 * resultcolor.B);

                    //4:2:0 sampling
                    if(y % 2 == 0 && x % 2 == 0)
                    {
                        ycrcb.Uf = (-0.147 * resultcolor.R) + (-0.289 * resultcolor.G) + (0.436 * resultcolor.B);
                        ycrcb.Vf = (0.615 * resultcolor.R) + (-0.515 * resultcolor.G) + (-0.100 * resultcolor.B);
                    }
                    else
                    {
                        ycrcb.Uf = 0;
                        ycrcb.Vf = 0;
                    }

                    MyOwnYcbcr.ycbcrArr[x, y] = ycrcb;
                }
            }

             for(int rows = 0; rows < 8; rows++)
            Matrixviewer.Rows.Add();
                        
            //normalize values to -128 to 127 range;

            for (int x = 0; x < MyOwnYcbcr.width; x++)
            {
                for (int y = 0; y < MyOwnYcbcr.height; y++)
                {
                    Yuv ycColorspaceEdit = MyOwnYcbcr.ycbcrArr[x, y];
            
                    ycColorspaceEdit.Y = (int)((ycColorspaceEdit.Yf) - 128);

                    if (y % 2 == 0 && x % 2 == 0)
                    {
                        ycColorspaceEdit.U = (int)((ycColorspaceEdit.Uf) - 128);
                        ycColorspaceEdit.V = (int)((ycColorspaceEdit.Vf) - 128);
                    }         
                    else
                    {
                        ycColorspaceEdit.U = (int)(ycColorspaceEdit.Uf);
                        ycColorspaceEdit.V = (int)(ycColorspaceEdit.Vf);
                    }     

                    MyOwnYcbcr.ycbcrArr[x,y] = ycColorspaceEdit;                     
                }
            }

            //DCT creation
                       
            double [,]DCTmatrix;
            DCTmatrix = new double[8, 8];

            for(int i = 0; i < 8; i++)
            {
                for(int j = 0; j < 8; j++)
                {
                    if(i == 0)
                    {
                        DCTmatrix[i,j] = 1 / Math.Sqrt(8);
                    }
                    else if(i > 0)
                    {
                        DCTmatrix[i, j] = Math.Sqrt( (2f/8f )) *  Math.Cos((((2 * j) + 1) * i * Math.PI) / (2 * 8)) ;
                    }
                }
            }

            //DCT creation Transposed

            double[,] DCTmatrixTransposed;
            DCTmatrixTransposed = new double[8, 8];

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    DCTmatrixTransposed[i, j] = DCTmatrix[j, i];
                }
            }

            
            ////////////////////
            
            // 8 by 8 traversal

            for (int y = 0; y < MyOwnYcbcr.height; y += 8)
            {
                for (int x = 0; x < MyOwnYcbcr.width; x += 8)
                {


                    for (int ity = y; ity < y + 8; ity++)
                    {
                        for (int itx = x; itx < x + 8; itx++)
                        {



                            
                        }
                    }


                }
            }















            for (int x = 0; x < 8; x++)
            {
                for (int y = 0; y < 8; y++)
                {
                    Matrixviewer.Rows[x].Cells[y].Value = MyOwnYcbcr.ycbcrArr[x, y].U;
                }
            }

            //for (int itx = reference; itx < reference + 8; itx++)
            //{
            //    for (int ity = reference; ity < reference + 8; ity++)
            //    {
            //        
            //    }
            //}







            //for (int x = 0; x < 8; x++)
            //{                
            //    for (int y = 0; y < 8; y++)
            //    {
            //        Matrixviewer.Rows[y].Cells[x].Value = MyOwnYcbcr.ycbcrArr[x, y].Y;                    
            //    }
            //}








        }
    }
}
