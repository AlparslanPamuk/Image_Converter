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

namespace Image_Converter
{
    public partial class Form1 : Form
    {

        Bitmap newBitmap;
        Image file;
        Boolean opened = false;
        int BlurLevel = 1;

        public Form1()
        {
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
            }   }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            BlurLevel = int.Parse(trackBar1.Value.ToString());
        }
    }
}
