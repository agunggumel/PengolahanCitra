using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace pengolahanCitra
{
    public partial class Form1 : Form
    {
        Bitmap gam, gambar2;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            OpenFileDialog ofile = new OpenFileDialog();
            if (ofile.ShowDialog() == DialogResult.OK)
            {
                gam = new Bitmap(new Bitmap(ofile.FileName), pictureBox1.Width, pictureBox1.Height);
                pictureBox1.Image = gam;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int i, j, rata, R, G , B;
            if (gam != null)
            {
                gambar2 = new Bitmap(gam);
                for (i = 0; i <= gambar2.Width - 1; i++)
                {
                    for (j = 0; j <= gambar2.Height - 1; j++)
                    {
                        Color pixelColor = gambar2.GetPixel(i, j);
                        R = pixelColor.R;
                        G = pixelColor.G;
                        B = pixelColor.B;
                        rata = Convert.ToInt32((R + G + B) / 3);
                        if (rata > 127)
                            rata = 255;
                        else
                            rata = 0;
                        Color newpixelColor = Color.FromArgb(rata, rata, rata);
                        gambar2.SetPixel(i, j, newpixelColor);
                    }
                }
                pictureBox2.Image = gambar2;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int i, j, rata, R, G,Blu;
            if (gam != null)
            {
                gambar2 = new Bitmap(gam);
                for (i = 0; i <= gambar2.Width - 1; i++)
                {
                    for (j = 0; j <= gambar2.Height - 1; j++)
                    {
                        Color pixelColor = gambar2.GetPixel(i, j);
                        R = pixelColor.R;
                        G = pixelColor.G;
                        Blu = pixelColor.B;
                        rata = Convert.ToInt32((merah + hijau + Blu) / 3);

                        Color newpixelColor = Color.FromArgb(rata, rata, rata);
                        gambar2.SetPixel(i, j, newpixelColor);
                    }
                }
                pictureBox2.Image = gambar2;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if(textBox1.Text==""){
                MessageBox.Show("Insert Angka");
            
            
                }else{
                    Bitmap bmp = new Bitmap(pictureBox1.Image);
                    Bitmap bmp2 = new Bitmap(pictureBox1.Image);
                    int r, g, b;
                    Color c;
                    int val = (int)Convert.ToInt32(textBox1.Text);
                    Cursor = Cursors.WaitCursor;
                    for (int i = 0; i < bmp.Width; i++)
                    {
                        for (int j = 0; j < bmp.Height; j++)
                        {
                            c = bmp.GetPixel(i, j);
                            r = c.R + val;
                            g = c.G + val;
                            b = c.B + val;
                            if (r > 255) r = 255;
                            if (g > 255) g = 255;
                            if (b > 255) b = 255;
                            if (r < 0) r = 0;
                            if (g < 0) g = 0;
                            if (b < 0) b = 0;
                            bmp2.SetPixel(i, j, Color.FromArgb(r, g, b));
                        }
                    }
                    pictureBox2.Image = bmp2;
                    Cursor = Cursors.Default;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            int i, j, rata, R, G, B;
          
            if (gam != null)
            {
                gambar2 = new Bitmap(gam);
                for (i = 0; i <= gambar2.Width - 1; i++)
                {
                    for (j = 0; j <= gambar2.Height - 1; j++)
                    {
                        Color pixelColor = gambar2.GetPixel(i, j);
                       
                        R = pixelColor.R;
                        G = pixelColor.G;
                        B = pixelColor.B;
                        rata = Convert.ToInt32((R + G + B) / 3);
                        int xi = 255 - rata;


                        Color newpixelColor = Color.FromArgb(xi, xi, xi);
                        gambar2.SetPixel(i, j, newpixelColor);
                    }
                }
                pictureBox2.Image = gambar2;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int i, j;
            int R, G, B;
            int cR, cG, cB;
            if (textBox1.Text == "")
            {
                MessageBox.Show("Insert Angka");


            }
            else
            {
            float c = Convert.ToSingle(textBox1.Text); 
            float[] h = new float[256];
            
            
            if (gam!= null)
            {
                gambar2 = new Bitmap(gam);
                for (i = 0; i <= gambar2.Width - 1; i++)
                {
                    for (j = 0; j <= gambar2.Height - 1; j++)
                    {
                        Color pixelColor = gambar2.GetPixel(i, j);
                        R = pixelColor.R;
                        G = pixelColor.G;
                        B = pixelColor.B;

                        int xg = (int)((pixelColor.R + pixelColor.G + pixelColor.B) / 3);
                        cRed = Convert.ToInt32(R*c);
                        cGreen = Convert.ToInt32(G * c);
                        cBlue = Convert.ToInt32(B * c);
                        int xc = (int)(c*xg);

                        if (cR >= 255 || cG>=255 || cB>=255)
                        {
                            cR = 255;
                            cG=255;
                            cB=255;
                            Color newpixelColor = Color.FromArgb(cR, cG, cB);
                            gambar2.SetPixel(i, j, newpixelColor);
                         
                        }
                        
                       
                    }
                }
                pictureBox2.Image = gambar2;
            }
                }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int i, j;
            int R, G, B;
            int nr, ng, nb;
            if (textBox1.Text == "")
            {
                MessageBox.Show("Insert Number");
            }
            else { 
            int val = (int)Convert.ToInt32(textBox1.Text);
            if (gam != null)
            {
                gambar2 = new Bitmap(gam);
                for (i = 0; i <= gambar2.Width - 1; i++)
                {
                    for (j = 0; j <= gambar2.Height - 1; j++)
                    {
                      Color pixelColor = gambar2.GetPixel(i, j);
                         
                       R = pixelColor.R;
                       G = pixelColor.G;
                       B = pixelColor.B;
                       nr = val - R;
                       ng = val - G;
                       nb = val - B;
                            if (nr < 0) { 
                                nr = 0;
                            }
                            else
                            {
                                nr = nr;
                            }
                            if (ng < 0) { 
                                ng = 0;
                            }
                            else
                            {
                                ng = ng;
                            }
                            if (nb < 0) { 

                                nb = 0;
                            }
                            else
                            {
                                nb = nb;
                            }
                            
                            Color newpixelColor = Color.FromArgb(nr, ng, nb);
                            gambar2.SetPixel(i, j, newpixelColor);

                    
                        }
                    
                                            
                }
                pictureBox2.Image = gambar2;
            }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
           int i, j, R, G, B;
            int mR, mG, mB;
           if (textBox1.Text == "")
           {
               MessageBox.Show("Insert Number");


           }
           else if (Convert.ToInt32(textBox1.Text) >= 9)
           {
               MessageBox.Show("Range untuk m-bit pangkat maks 8 (2^8 =256 RGB)");
           }
           else
           { 
            if (gam != null)
            {
                gambar2 = new Bitmap(gam);

                for (i = 0; i <= gambar2.Width - 1; i++)
                {
                    for (j = 0; j <= gambar2.Height - 1; j++)
                    {
                        int val = Convert.ToInt32(textBox1.Text);
                        double bit = Math.Pow(2, val);
                        Color pixelColor = gambar2.GetPixel(i, j);
                        R = pixelColor.R;
                        G = pixelColor.G;
                        B = pixelColor.B;
                        
                        
                       
                      
                        mR = Convert.ToInt32(bit*(R/bit));
                        mG = Convert.ToInt32(bit*(G/bit));
                        mB = Convert.ToInt32(bit*(B/bit));
                        
                        int b1 = (int)(bit - 1);

                        if (mR >= b1 && mR!=0)
                            mR = 255;
                        else
                            mR = 0;

                        if (mG >= b1 && mG!=0)
                            mG = 255;
                        else
                            mG = 0;

                        if (mB >= b1 && mG!=0)
                            mB = 255;
                        else
                            mB = 0;
                       
                        Color newpixelColor = Color.FromArgb(mR,mG,mB);
                        gambar2.SetPixel(i, j, newpixelColor);
                    }
                }
                pictureBox2.Image = gambar2;
        }
           }
    }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
}
    }