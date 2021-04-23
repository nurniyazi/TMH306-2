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
    public partial class thresholdFr : Form
    {
        Bitmap kaynak, islem;
        public thresholdFr()
        {
            InitializeComponent();
        }

        private void elleDeğerGirmeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int gen = kaynak.Width;
            int yuk = kaynak.Height;
            int thresholdDegeri = 100; 
            islem = new Bitmap(gen, yuk);

            for (int y = 0; y < yuk; y++)
            {
                for (int x = 0; x < gen; x++)
                {
                    Color piksel = kaynak.GetPixel(x, y);
                    int griDeger = (piksel.R + piksel.G + piksel.B) / 3;

                    if (griDeger > thresholdDegeri) { griDeger = 255; }
                    else
                    {
                        griDeger = 0;
                    }


                    Color griPiksel = Color.FromArgb(griDeger, griDeger, griDeger);
                    islem.SetPixel(x, y, griPiksel);
                }
            }
            islemBox.Image = islem;
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
