using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1.ders
{
    public partial class griFr : Form
    {
        Bitmap kaynak, islem;
        public griFr()
        {
            InitializeComponent();
        }

        private void griFr_Load(object sender, EventArgs e)
        {

        }

        private void ortalamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int gen = kaynak.Width;
            int yuk = kaynak.Height;
            islem = new Bitmap(gen, yuk);

            for (int y = 0; y < yuk; y++)
            {
                for (int x = 0; x < gen; x++)
                {
                    Color piksel = kaynak.GetPixel(x, y);
                    int griDeger = (piksel.R + piksel.G + piksel.B)/3;
                    Color griPiksel = Color.FromArgb(griDeger, griDeger, griDeger);
                    islem.SetPixel(x, y,griPiksel);
                }
            }
            islemBox.Image = islem;
        }

        private void bT709AlgoritmasiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int gen = kaynak.Width;
            int yuk = kaynak.Height;
            islem = new Bitmap(gen, yuk);

            for (int y = 0; y < yuk; y++)
            {
                for (int x = 0; x < gen; x++)
                {
                    Color piksel = kaynak.GetPixel(x, y);
                    byte griDeger = (byte)(piksel.R*0.2125+piksel.G*0.7154+ piksel.B*0.072);
                    Color griPiksel = Color.FromArgb(griDeger, griDeger, griDeger);
                    islem.SetPixel(x, y, griPiksel);
                }
            }
            islemBox.Image = islem;
        }

        private void lumaYöntemiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int gen = kaynak.Width;
            int yuk = kaynak.Height;
            islem = new Bitmap(gen, yuk);

            for (int y = 0; y < yuk; y++)
            {
                for (int x = 0; x < gen; x++)
                {
                    Color piksel = kaynak.GetPixel(x, y);
                    byte griDeger =(byte)(piksel.R*0.3+piksel.G*0.95+piksel.B*0.11);
                    Color griPiksel = Color.FromArgb(griDeger, griDeger, griDeger);
                    islem.SetPixel(x, y, griPiksel);
                }
            }
            islemBox.Image = islem;
        }

        private void açıklıkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int gen = kaynak.Width;
            int yuk = kaynak.Height;
            islem = new Bitmap(gen, yuk);

            for (int y = 0; y < yuk; y++)
            {
                for (int x = 0; x < gen; x++)
                {
                    Color piksel = kaynak.GetPixel(x, y);
                    int griDeger = (Math.Max(piksel.R,piksel.G)+ Math.Min(piksel.R, piksel.G))/2;
                    Color griPiksel = Color.FromArgb(griDeger, griDeger, griDeger);
                    islem.SetPixel(x, y, griPiksel);
                }
            }
            islemBox.Image = islem;
        }

        private void normalizeYöntemiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int gen = kaynak.Width;
            int yuk = kaynak.Height;
            islem = new Bitmap(gen, yuk);

            for (int y = 0; y < yuk; y++)
            {
                for (int x = 0; x < gen; x++)
                {
                    Color piksel = kaynak.GetPixel(x, y);
                    int griDeger = piksel.R+piksel.G+piksel.B;
                    int red = 1;
                    if (griDeger == 0)
                      {
                        griDeger = 0;
                      }
                    else
                     { 
                        red = 255 * piksel.R / griDeger;

                     }
                    Color griPiksel = Color.FromArgb(red,red,red);
                    islem.SetPixel(x, y, griPiksel);
                }
            }
            islemBox.Image = islem;
        }

        private void renkKanalıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int gen = kaynak.Width;
            int yuk = kaynak.Height;
            islem = new Bitmap(gen, yuk);

            for (int y = 0; y < yuk; y++)
            {
                for (int x = 0; x < gen; x++)
                {
                    Color piksel = kaynak.GetPixel(x, y);
                    int griDeger = (piksel.R);
                    Color griPiksel = Color.FromArgb(piksel.R, piksel.R,piksel.R);
                    islem.SetPixel(x, y, griPiksel);
                }
            }
            islemBox.Image = islem;
        }

        private void dosyaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void acToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                kaynak = new Bitmap(openFileDialog1.FileName);
                kaynakBox.Image = kaynak;
            }
        }
    }
}
