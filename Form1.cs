using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Threading;

namespace Image_Converter
{
    //http://gaffarsalkim.blogspot.com/2012/04/c-da-backgroundworker-kullanm.html
    public partial class Form1 : Form
    {

        Bitmap newBitmap;
        Image file;
        Boolean opened = false;
        int BlurLevel = 1;
        int trackValue = 0;
        int LastCol = 0;
        float contrast = 0;
        float gamma = 1;



        public static Bitmap AdjustBrightness(Bitmap Image, int Value)
        {           //Taken the algorithm from https://stackoverflow.com/questions/23865511/contrast-with-color-matrix //

            Bitmap TempBitmap = Image; // to store
            float FinalValuePamuk = (float)Value / 255.0f;
            Bitmap newBitmap = new Bitmap(TempBitmap.Width, TempBitmap.Height); // to store new updated image
            Graphics NewGraphics = Graphics.FromImage(newBitmap);
            float[][] FloatColorMatrix = 
            {
                new float[] {1,0,0,0,0},
                new float[] {0,1,0,0,0},        //double dimension array
                new float[] {0,0,1,0,0},
                new float[] {0,0,0,1,0},
                new float[] {FinalValuePamuk,FinalValuePamuk,FinalValuePamuk,1,1 }
            };
            ColorMatrix NewColorMatrix = new ColorMatrix(FloatColorMatrix);
            ImageAttributes Attributes = new ImageAttributes();
            Attributes.SetColorMatrix(NewColorMatrix);
            NewGraphics.DrawImage(TempBitmap, new Rectangle(0, 0, TempBitmap.Width, TempBitmap.Height), 0, 0, TempBitmap.Width, TempBitmap.Height, GraphicsUnit.Pixel, Attributes);
            Attributes.Dispose();
            NewGraphics.Dispose();
            return newBitmap;

        }


        public Form1()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
            
        }

        private void btnopen_Click(object sender, EventArgs e)
        {
            DialogResult dr = openFileDialog1.ShowDialog();

            if(dr == DialogResult.OK)
            {
                file = Image.FromFile(openFileDialog1.FileName);
                newBitmap = new Bitmap(openFileDialog1.FileName);
                pictureBox1.Image = file;
                opened = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dr = saveFileDialog1.ShowDialog();

            if (dr == DialogResult.OK)
            {
                if (opened)
                {
                    if (saveFileDialog1.FileName.Substring(saveFileDialog1.FileName.Length - 3).ToLower() == "bmp")
                    {
                        file.Save(saveFileDialog1.FileName, ImageFormat.Bmp);
                    }
                    if (saveFileDialog1.FileName.Substring(saveFileDialog1.FileName.Length - 3).ToLower() == "jpg")
                    {
                        file.Save(saveFileDialog1.FileName, ImageFormat.Jpeg);
                    }
                    if (saveFileDialog1.FileName.Substring(saveFileDialog1.FileName.Length - 3).ToLower() == "png")
                    {
                        file.Save(saveFileDialog1.FileName, ImageFormat.Png);
                    }
                    if (saveFileDialog1.FileName.Substring(saveFileDialog1.FileName.Length - 3).ToLower() == "gif")
                    {
                        file.Save(saveFileDialog1.FileName, ImageFormat.Gif);
                    }
                }
                else
                    MessageBox.Show("You need to pick a image first!", "Mustafa Alparslan Pamuk Image_Converter Program", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btngreyscale_Click(object sender, EventArgs e)
        {
            for (int x = 0; x<newBitmap.Width; x++)
            {
                for(int y= 0; y<newBitmap.Height; y++)
                {
                    Color originalcolorMustafaAlparslanPamuk = newBitmap.GetPixel(x, y);

                    int greyscalePamuk = (int)((originalcolorMustafaAlparslanPamuk.R * .3) + (originalcolorMustafaAlparslanPamuk.G * .59) + (originalcolorMustafaAlparslanPamuk.B * .11));

                    Color newColorPamuk = Color.FromArgb(greyscalePamuk, greyscalePamuk, greyscalePamuk);

                    newBitmap.SetPixel(x, y, newColorPamuk);
                }
            }
            pictureBox1.Image = newBitmap;
        }

        private void btnblur_Click(object sender, EventArgs e)
        {
            //Thread th1 = new Thread(new ThreadStart(Do_blur));
            //th1.Start();
            Do_blur();
           
        }

        private void Do_blur()
        {
            for (int x = BlurLevel; x <= newBitmap.Width - BlurLevel; x++)
            {
                for (int y = BlurLevel; y <= newBitmap.Height - BlurLevel; y++)
                {
                    try
                    {
                        Color prevX = newBitmap.GetPixel(x - BlurLevel, y);
                        Color nextX = newBitmap.GetPixel(x + BlurLevel, y);
                        Color prevY = newBitmap.GetPixel(x, y - BlurLevel);
                        Color nextY = newBitmap.GetPixel(x, y + BlurLevel);

                        int avgRed = (int)((prevX.R + nextX.R + prevY.R + nextY.R) / 4);
                        int avgGreen = (int)((prevX.G + nextX.G + prevY.G + nextY.G) / 4);
                        int avgBlue = (int)((prevX.B + nextX.B + prevY.B + nextY.B) / 4);

                        newBitmap.SetPixel(x, y, Color.FromArgb(avgRed, avgGreen, avgBlue));
                    }
                    catch (Exception)
                    {


                    }
                }
                pictureBox1.Image = newBitmap;
            }
        }
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            trackBar1.Value += 0;
            lblBlur.Text = trackBar1.Value.ToString();
            BlurLevel = int.Parse(trackBar1.Value.ToString());
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            LblBrightness.Text = trackBar2.Value.ToString();

            pictureBox1.Image = AdjustBrightness(newBitmap, trackBar2.Value);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Mustafa Alparslan Pamuk | Image Converter Program.";
            trackBar4.Value += 1;
            
            

        }

        private void trackBar2_MouseCaptureChanged(object sender, EventArgs e)
        {
            trackValue = this.trackBar1.Value;
        }

        private void btninvert_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Started.");
            backgroundWorker1.RunWorkerAsync();
            //Do_invert();
            MessageBox.Show("Done.");
        }

        private void Do_invert()
        {
            for (int x = 0; x < newBitmap.Width; x++)
            {
                for (int y = 0; y < newBitmap.Height; y++)
                {
                    Color Pixel = newBitmap.GetPixel(x, y);

                    int Red = Pixel.R;
                    int Green = Pixel.G;
                    int Blue = Pixel.B;

                    newBitmap.SetPixel(x, y, Color.FromArgb(255 - Red, 255 - Green, 255 - Blue));

                }
            }
            pictureBox1.Image = newBitmap;
        }

        private void btnEmboss_Click(object sender, EventArgs e)
        {
            Bitmap nB = new Bitmap(newBitmap.Width, newBitmap.Height);

            for(int x=1; x<=newBitmap.Width - 1; x++)
            {
                for(int y=1; y<= newBitmap.Height - 1; y++)
                {
                    nB.SetPixel(x, y, Color.DarkGray);
                }
            }

            for(int x=1; x<=newBitmap.Width - 1; x++)
            {
                for(int y=1; y<= newBitmap.Height -1; y++)
                {
                    try
                    {
                        Color pixel = newBitmap.GetPixel(x, y);

                        int ColVal = (pixel.R + pixel.G + pixel.B);

                        if (LastCol == 0) LastCol = (pixel.R + pixel.G + pixel.B);

                        int diff;

                        if (ColVal > LastCol) { diff = ColVal - LastCol; } else { diff = LastCol - ColVal; }

                        if(diff >100)
                        {
                            nB.SetPixel(x, y, Color.Gray);
                            LastCol = ColVal;
                        }
                    }
                    catch (Exception)
                    {

                            
                    }
                }
            }

            for (int y = 1; y <= newBitmap.Height - 1; y++)
            {
                for (int x = 1; x<=newBitmap.Width - 1; x++)
                {
                    try
                    {
                        Color pixel = newBitmap.GetPixel(x, y);

                        int colVal = (pixel.R + pixel.G + pixel.B);

                        if (LastCol == 0)
                        {
                            LastCol = (pixel.R + pixel.G + pixel.B);
                        }
                        int diff;

                        if(colVal > LastCol)
                        {
                            diff = colVal - LastCol; } else { diff = LastCol - colVal;
                        }

                        if(diff > 100)
                        {
                            nB.SetPixel(x, y, Color.Gray);
                            LastCol = colVal;
                        }
                    }
                    catch (Exception)
                    {

                        
                    }
                }
            }
            for (int y=1; y<= newBitmap.Height - 1; y++)
            {
                for ( int x = 1; x <= newBitmap.Width - 1; x++)
                {
                    try
                    {
                        Color pixel = newBitmap.GetPixel(x, y);

                        int colVal = (pixel.R + pixel.G + pixel.B);

                        if(LastCol == 0)
                        {
                            LastCol = (pixel.R + pixel.G + pixel.B);

                        }

                        int diff;

                        if (colVal > LastCol)
                        {
                            diff = colVal - LastCol;
                        }
                        else
                            diff = LastCol - colVal;

                        if ( diff > 100 )
                        {
                            nB.SetPixel(x, y, Color.Gray);
                            LastCol = colVal;
                        }
                    }
                    catch (Exception)
                    {

                      
                    }
                }
            }
            pictureBox1.Image = nB;
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            lblContrast.Text = trackBar3.Value.ToString();

            contrast = 0.04f * trackBar3.Value;

            Bitmap bmPamuk = new Bitmap(newBitmap.Width, newBitmap.Height);

            Graphics g = Graphics.FromImage(bmPamuk);
            ImageAttributes iaMustafaAlparslanPAmuk = new ImageAttributes();

            ColorMatrix cm = new ColorMatrix(new float[][] {
                new float[]{contrast, 0f, 0f, 0f, 0f },
                new float[]{0f,contrast,0f,0f,0f},
                new float[]{0f,0f,contrast,0f,0f},
                new float[]{0f,0f,0f,1f,0f},
                new float[]{0.001f,0.001f,0.001f,0f,1f} });

            iaMustafaAlparslanPAmuk.SetColorMatrix(cm);

            g.DrawImage(newBitmap, new Rectangle(0, 0, newBitmap.Width, newBitmap.Height), 0, 0, newBitmap.Width, newBitmap.Height, GraphicsUnit.Pixel, iaMustafaAlparslanPAmuk);
            g.Dispose();
            iaMustafaAlparslanPAmuk.Dispose();
            pictureBox1.Image = bmPamuk;
        }

        private void trackBar4_Scroll(object sender, EventArgs e)
        {
            try
            {
                lblGamma.Text = trackBar4.Value.ToString();

                gamma = 0.04f * trackBar4.Value;

                Bitmap bm = new Bitmap(newBitmap.Width, newBitmap.Height);

                Graphics gMustafaAlparslanPamuk = Graphics.FromImage(bm);
                ImageAttributes iaPamuk = new ImageAttributes();

                iaPamuk.SetGamma(gamma);

                gMustafaAlparslanPamuk.DrawImage(newBitmap, new Rectangle(0, 0, newBitmap.Width, newBitmap.Height), 0, 0, newBitmap.Width, newBitmap.Height, GraphicsUnit.Pixel, iaPamuk);
                gMustafaAlparslanPamuk.Dispose();
                iaPamuk.Dispose();
                pictureBox1.Image = bm;
            }
            catch (Exception )
            {
                MessageBox.Show("Gamma value can not be 0!","Mustafa Alparslan Pamuk | Image Converter Program",MessageBoxButtons.OK,MessageBoxIcon.Error);
               
            }

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            Do_invert();
        }
    }
}
