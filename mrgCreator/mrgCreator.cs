using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Accord.Math;
using Accord.Imaging;
using System.IO;
using System.IO.Compression;

namespace mrgCreator
{
    public struct MRGfile
    {
        public int width;
        public int height;

        public List<int> zigzagY;
        public List<int> zigzagU;
        public List<int> zigzagV;

        public int quality; 
        
        public MRGfile(List<int> Y, List<int> U, List<int> V, int Quality, int Width, int Height)
        {
            this.zigzagY = Y;
            this.zigzagU = U;
            this.zigzagV = V;
            this.quality = Quality;
            this.width = Width;
            this.height = Height;
        }       
    }


    struct Yuv
    {
        public double Yf;      //Conversion from RGB
        public double Uf;      //Conversion from RGB
        public double Vf;      //Conversion from RGB

        public int Ynorm;           //normalized values
        public int Unorm;           //normalized values
        public int Vnorm;           //normalized values

        public double Ydct;      //DCT values
        public double Udct;      //DCT values
        public double Vdct;      //DCT values

        public int Yquant;        //After quantization
        public int Uquant;        //After quantization
        public int Vquant;        //After quantization
                
    }

    struct myYcBc
    {           
        public int width;
        public int height;

        public Yuv [,]ycbcrArr;

        public List<int> zigzagY;
        public List<int> zigzagU;
        public List<int> zigzagV;

        public myYcBc(int width, int height)
        {
            //Y = new byte[width, height];
            //Cb = new byte[width, height];
            //Cr = new byte[width, height];

            ycbcrArr = new Yuv[width, height];
            zigzagY = new List<int>();
            zigzagU = new List<int>();
            zigzagV = new List<int>();

            this.width = width;
            this.height = height;                        
        }        
    }

    public struct Coords
    {
        public int xvalue;
        public int yvalue;
      
        public Coords(int x, int y) : this()
        {
            this.xvalue = x;
            this.yvalue = y;
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

        int QuantizationQuality = 50;


        public mrgCreator()
        {
            InitializeComponent();
            MergeAndCompress_btn.Enabled = false;

            for (int rows = 0; rows < 8; rows++)
            Matrixviewer.Rows.Add();

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

            for (int y = 0; y < spriteBitmap.Height; y++)
            {
                for (int x = 0; x < spriteBitmap.Width; x++)
                {                   
                    Color spritecolor = spriteBitmap.GetPixel(x, y);
                    
                    if(spritecolor.G != 0)
                    {
                        resultBitmap.SetPixel(x + Itstartx, y + Itstarty, spritecolor);
                    }                                
                }
            }

            MergedPreviewBox.Image = resultBitmap.GetThumbnailImage(MergedPreviewBox.Width, MergedPreviewBox.Height, myCallback, IntPtr.Zero);

            

            //////////
            ///////////////MERGING    DONE 
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////

//////////
///////////////Start of Compression part
////////////////////////////////////////////////////////////////////////////////////////////////////////////////


            //////////
            ///////////////Convert to YUV
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            

            //////////
            /////////////// add some pixels on both axis resulting multiple of 8
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            int zeroExtensionsX = 8 - (resultBitmap.Width % 8);
            int zeroExtensionsY = 8 - (resultBitmap.Height % 8);                      

            MyOwnYcbcr = new myYcBc(resultBitmap.Width + zeroExtensionsX, resultBitmap.Height + zeroExtensionsY);
              
            for (int y = 0; y < resultBitmap.Height; y++)
            {
                for (int x = 0; x < resultBitmap.Width; x++)
                {
                    Color resultcolor = resultBitmap.GetPixel(x, y);

                    Yuv ycrcb = new Yuv();
                                        
                    RGB rgbcolor = new RGB(resultcolor);
                    
                    ycrcb.Yf = YCbCr.FromRGB(rgbcolor).Y * 255;                   
                
                    //4:2:0 sampling
                    if(y % 2 == 0 && x % 2 == 0)
                    {
                        ycrcb.Uf = YCbCr.FromRGB(rgbcolor).Cr * 255;
                        ycrcb.Vf = YCbCr.FromRGB(rgbcolor).Cb * 255;
                    }
                    else
                    {
                        ycrcb.Uf = 0;
                        ycrcb.Vf = 0;
                    }

                    MyOwnYcbcr.ycbcrArr[x, y] = ycrcb;
                }
            }
                                   
            //////////
            /////////////// Normalize to -128 <-> 127 range
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            for (int y = 0; y < MyOwnYcbcr.height; y++)
            {
                for (int x = 0; x < MyOwnYcbcr.width; x++)
                {
                    Yuv ycColorspaceEdit = MyOwnYcbcr.ycbcrArr[x, y];
            
                    ycColorspaceEdit.Ynorm = (int)((ycColorspaceEdit.Yf) - 128);

                    if (y % 2 == 0 && x % 2 == 0)
                    {
                        ycColorspaceEdit.Unorm = (int)((ycColorspaceEdit.Uf) - 128);
                        ycColorspaceEdit.Vnorm = (int)((ycColorspaceEdit.Vf) - 128);
                    }         
                    else
                    {
                        ycColorspaceEdit.Unorm = (int)(ycColorspaceEdit.Uf);
                        ycColorspaceEdit.Vnorm = (int)(ycColorspaceEdit.Vf);
                    }     

                    MyOwnYcbcr.ycbcrArr[x,y] = ycColorspaceEdit;                     
                }
            }

            //////////
            /////////////// DCT matrix Creation
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            //double[,]DCTmatrix;
            //DCTmatrix = new double[8, 8];
            //
            //for (int i = 0; i < 8; i++)
            //{
            //    for(int j = 0; j < 8; j++)
            //    {
            //        if(i == 0)
            //        {
            //            DCTmatrix[i,j] = 1 / Math.Sqrt(8);
            //        }
            //        else if(i > 0)
            //        {
            //            DCTmatrix[i, j] = Math.Sqrt( (2f/8f )) *  Math.Cos((((2 * j) + 1) * i * Math.PI) / (2 * 8)) ;
            //        }
            //    }
            //}


            //////////
            /////////////// DCT matrix Transposed
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            //double[,] DCTmatrixTransposed;
            //DCTmatrixTransposed = new double[8, 8];
            //
            //for (int i = 0; i < 8; i++)
            //{
            //    for (int j = 0; j < 8; j++)
            //    {
            //        DCTmatrixTransposed[i, j] = DCTmatrix[j, i];
            //    }
            //}

            //////////
            /////////////// 8 by 8 traversal and applying DCT to Merged picture
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            //double[,] DCTresult;
            //DCTresult = new double[8, 8];

            double[,] YtempDCT = new double[8, 8];
            double[,] UtempDCT = new double[8, 8];
            double[,] VtempDCT = new double[8, 8];


            for (int y = 0; y < MyOwnYcbcr.height; y += 8)
            {
                for (int x = 0; x < MyOwnYcbcr.width; x += 8)
                {
                    if (x <= MyOwnYcbcr.width - 8 && y <= MyOwnYcbcr.height - 8) //safeguard against out of bounds error
                    {                       

                        for (int ity = y; ity < y + 8; ity++)
                        {
                            for (int itx = x; itx < x + 8; itx++)
                            {
                                YtempDCT[ity - y, itx - x] = MyOwnYcbcr.ycbcrArr[itx, ity].Ynorm;
                                UtempDCT[ity - y, itx - x] = MyOwnYcbcr.ycbcrArr[itx, ity].Unorm;
                                VtempDCT[ity - y, itx - x] = MyOwnYcbcr.ycbcrArr[itx, ity].Vnorm;                                
                            }
                        }

                        CosineTransform.DCT(YtempDCT);
                        CosineTransform.DCT(UtempDCT);
                        CosineTransform.DCT(VtempDCT);

                        for (int ity = y; ity < y + 8; ity++)
                        {
                            for (int itx = x; itx < x + 8; itx++)
                            {
                                MyOwnYcbcr.ycbcrArr[itx, ity].Ydct = YtempDCT[ity - y, itx - x];
                                MyOwnYcbcr.ycbcrArr[itx, ity].Udct = UtempDCT[ity - y, itx - x];
                                MyOwnYcbcr.ycbcrArr[itx, ity].Vdct = VtempDCT[ity - y, itx - x];
                            }
                        }
                    }
                }
            }


            //default quality value of 50;

            int[,] QuantMatrix;
            QuantMatrix = new int[8, 8] { { 16,11,10,16,24,40,51,61 },
                                          { 12,12,14,19,26,58,60,55 },
                                          { 14,13,16,24,40,57,69,56 },
                                          { 14,17,22,29,51,87,80,62 },
                                          { 18,22,37,56,68,109,103,77 },
                                          { 24,35,55,64,81,104,113,92 },
                                          { 49,64,78,87,103,121,120,101 },
                                          { 72,92,95,98,112,100,103,99 },
                                        };

            // changing quality value
            if(QuantizationQuality != 50)
            {
                for (int x = 0; x < 8; x++)
                {
                    for (int y = 0; y < 8; y++)
                    {
                        if(QuantizationQuality > 50)
                        {
                            QuantMatrix[x, y] = (int)(QuantMatrix[x, y] * ((float)(100 - QuantizationQuality) / 50f));
                            if(QuantMatrix[x,y] > 255)
                            {
                                QuantMatrix[x, y] = 255;
                            }
                            if(QuantMatrix[x, y] == 0)
                            {
                                QuantMatrix[x, y] = 1;
                            }
                        }
                        else if(QuantizationQuality < 50)
                        {
                            QuantMatrix[x, y] = QuantMatrix[x, y] * ( 50 / QuantizationQuality);
                            if (QuantMatrix[x, y] > 255)
                            {
                                QuantMatrix[x, y] = 255;
                            }
                            else if (QuantMatrix[x, y] == 0)
                            {
                                QuantMatrix[x, y] = 1;
                            }
                        }
                    }
                }
            }


            //////////
            /////////////// 8 by 8 traversal and appyling Quantization
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////


            for (int y = 0; y < MyOwnYcbcr.height; y += 8)
            {
                for (int x = 0; x < MyOwnYcbcr.width; x += 8)
                {
                    for (int ity = y; ity < y + 8; ity++)
                    {
                        for (int itx = x; itx < x + 8; itx++)
                        {
                            if (itx < MyOwnYcbcr.width && ity < MyOwnYcbcr.height)
                            {
                                MyOwnYcbcr.ycbcrArr[itx, ity].Yquant = (int)Math.Round(MyOwnYcbcr.ycbcrArr[itx, ity].Ydct / QuantMatrix[itx - x, ity - y]);
                                MyOwnYcbcr.ycbcrArr[itx, ity].Uquant = (int)Math.Round(MyOwnYcbcr.ycbcrArr[itx, ity].Udct / QuantMatrix[itx - x, ity - y]);
                                MyOwnYcbcr.ycbcrArr[itx, ity].Vquant = (int)Math.Round(MyOwnYcbcr.ycbcrArr[itx, ity].Vdct / QuantMatrix[itx - x, ity - y]);
                            }
                        }
                    }
                }
            }
            
            //////////
            /////////////// 8 by 8 traversal and appyling ZIG ZAG
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////
         

            for (int y = 0; y < MyOwnYcbcr.height; y += 8)
            {
                for (int x = 0; x < MyOwnYcbcr.width; x += 8)
                {
                    if (x <= MyOwnYcbcr.width - 8 && y <= MyOwnYcbcr.height - 8) //safeguard against out of bounds error
                    {

                        int[,] YZbuffer = new int[8, 8];
                        int[,] UZbuffer = new int[8, 8];
                        int[,] VZbuffer = new int[8, 8];
                        // make a copy in buffer so that zigzag can copy it over to the original. 

                        for (int buffery = y; buffery < y + 8; buffery++)
                        {
                            for (int bufferx = x; bufferx < x + 8; bufferx++)
                            {
                                YZbuffer[bufferx - x, buffery - y] = MyOwnYcbcr.ycbcrArr[bufferx, buffery].Yquant;
                                UZbuffer[bufferx - x, buffery - y] = MyOwnYcbcr.ycbcrArr[bufferx, buffery].Uquant;
                                VZbuffer[bufferx - x, buffery - y] = MyOwnYcbcr.ycbcrArr[bufferx, buffery].Vquant;
                            }
                        }

                        // copy zigzag wise from the buffer to the original

                        for (int ity = y; ity < y + 8; ity++)
                        {
                            for (int itx = x; itx < x + 8; itx++)
                            {
                                if (itx < MyOwnYcbcr.width && ity < MyOwnYcbcr.height)
                                {
                                    Coords Targetcoords;

                                    Targetcoords = ZZtraverseValue(itx - x, ity - y);

                                    MyOwnYcbcr.zigzagY.Add(YZbuffer[Targetcoords.xvalue, Targetcoords.yvalue]);
                                    MyOwnYcbcr.zigzagU.Add(UZbuffer[Targetcoords.xvalue, Targetcoords.yvalue]);
                                    MyOwnYcbcr.zigzagV.Add(VZbuffer[Targetcoords.xvalue, Targetcoords.yvalue]);                                    
                                }
                            }
                        }                      
                    }
                }
            }
    

            

            Coords testcoords;

            testcoords.xvalue = 920;
            testcoords.yvalue = 0;

            for (int y = testcoords.yvalue; y < testcoords.yvalue + 8; y++)
            {
                for (int x = testcoords.xvalue; x < testcoords.xvalue + 8; x++)
                {
                    Matrixviewer.Rows[y - testcoords.yvalue].Cells[x- testcoords.xvalue].Value = MyOwnYcbcr.ycbcrArr[x, y].Yquant;                    
                    //Matrixviewer.Rows[x].Cells[y].Value = QuantMatrix[x, y];
                    //Matrixviewer.Rows[x].Cells[y].Value = testoutputmatrix[x, y];
                }
            }

            Merged_width_txtbx.Text = MyOwnYcbcr.width.ToString();
            Merged_height_txtbx.Text = MyOwnYcbcr.height.ToString();

            textBox1.Text = MyOwnYcbcr.zigzagU.Count.ToString();
            textBox2.Text = (MyOwnYcbcr.width * MyOwnYcbcr.height).ToString();

            textBox3.Text = MyOwnYcbcr.zigzagV[7360].ToString();

            //for (int y = 0; y < 8; y++)
            //{
            //    for (int x = 0; x < 8; x++)
            //    {
            //        Matrixviewer.Rows[x].Cells[y].Value = testdata[x,y];
            //        //Matrixviewer.Rows[x].Cells[y].Value = QuantMatrix[x, y];
            //        //Matrixviewer.Rows[x].Cells[y].Value = testoutputmatrix[x, y];
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

        public Coords ZZtraverseValue(int x, int y)
        {
            Coords[,] ZigZagLookupTable = new Coords[8, 8]{ 
            { new Coords(0,0),new Coords(1,0),new Coords(0,1),new Coords(0,2),new Coords(1,1),new Coords(2,0),new Coords(3,0),new Coords(2,1) },
            { new Coords(1,2),new Coords(0,3),new Coords(0,4),new Coords(1,3),new Coords(2,2),new Coords(3,1),new Coords(4,0),new Coords(5,0) },
            { new Coords(4,1),new Coords(3,2),new Coords(2,3),new Coords(1,4),new Coords(0,5),new Coords(0,6),new Coords(1,5),new Coords(2,4) },
            { new Coords(3,3),new Coords(4,2),new Coords(5,1),new Coords(6,0),new Coords(7,0),new Coords(6,1),new Coords(5,2),new Coords(4,3) },
            { new Coords(3,4),new Coords(2,5),new Coords(1,6),new Coords(0,7),new Coords(1,7),new Coords(2,6),new Coords(3,5),new Coords(4,4) },
            { new Coords(5,3),new Coords(6,2),new Coords(7,1),new Coords(7,2),new Coords(6,3),new Coords(5,4),new Coords(4,5),new Coords(3,6) },
            { new Coords(2,7),new Coords(3,7),new Coords(4,6),new Coords(5,5),new Coords(6,4),new Coords(7,3),new Coords(7,4),new Coords(6,5) },
            { new Coords(5,6),new Coords(4,7),new Coords(5,7),new Coords(6,6),new Coords(7,5),new Coords(7,6),new Coords(6,7),new Coords(7,7) },
            };

            return ZigZagLookupTable[y , x];
        }


        public double[,] MultiplyMatrix(double[,] a, double [,] b, int x, int y)
        {
            double[,] c = new double[x, y];

            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    c[i, j] = 0;

                    for (int k = 0; k < 2; k++)
                    {
                        c[i, j] += a[i, k] * b[k, j];
                    }
                }
            }
            return c;
        }

        
        private void ChangeQuality(object sender, EventArgs e)
        {
            qualityset.Text = QualitytrackBar.Value.ToString();
            QuantizationQuality = QualitytrackBar.Value;
        }

        private void CreateMrg_btn_Click(object sender, EventArgs e)
        {
            MRGfile mrgfile = new MRGfile(MyOwnYcbcr.zigzagY, MyOwnYcbcr.zigzagU, MyOwnYcbcr.zigzagV, QuantizationQuality, MyOwnYcbcr.width, MyOwnYcbcr.height);

            string filename = "buffer";

            if (File.Exists(filename))
            {
                File.Delete(filename);
            }

            StreamWriter sw = new StreamWriter(filename);
                       
            sw.WriteLine(mrgfile.quality.ToString());
            sw.WriteLine(mrgfile.width.ToString());
            sw.WriteLine(mrgfile.height.ToString());

            foreach (int element in mrgfile.zigzagY)
            {
                sw.WriteLine(element);               
            }
            foreach (int element in mrgfile.zigzagU)
            {
                sw.WriteLine(element);
            }
            foreach (int element in mrgfile.zigzagV)
            {
                sw.WriteLine(element);
            }

            sw.Close();
                        
            using (FileStream origfs = new FileStream(filename, FileMode.Open))
            {                
                using (FileStream compressedFileStream = File.Create("compressed.mrg"))
                {
                        using (GZipStream compressionStream = new GZipStream(compressedFileStream, CompressionMode.Compress))
                        {
                            origfs.CopyTo(compressionStream);
                        }
                }           

            }

            if (File.Exists(filename))
            {
                File.Delete(filename);
            }
            
        }
    }
}


        //// Construct a BinaryFormatter and use it to serialize the data to the stream.
        //BinaryFormatter formatter = new BinaryFormatter();
        //try
        //{
        //    formatter.Serialize(fs, mrgfile);
        //}
        //catch (SerializationException error)
        //{
        //    Console.WriteLine("Failed to serialize. Reason: " + error.Message);
        //    throw;
        //}
        //finally
        //{
        //    fs.Close();
        //}