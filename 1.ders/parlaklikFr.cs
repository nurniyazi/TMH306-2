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
    public partial class parlaklikFr : Form
    {
        Bitmap kaynak, islem;
        public parlaklikFr()
        {
            InitializeComponent();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label1.Text = "Piksel:"+ trackBar1.Value.ToString();
            int gen = kaynak.Width;
            int yuk = kaynak.Height;
            islem = new Bitmap(gen, yuk);

            for (int y = 0; y < yuk; y++)
            {
                for (int x = 0; x < gen; x++)
                {
                    Color piksel = kaynak.GetPixel(x, y);
                    int red = piksel.R + trackBar1.Value;
                    int green = piksel.G + trackBar1.Value;
                    int blue = piksel.B + trackBar1.Value;
                    if (red < 0) red = 0;
                    if (red >255) red = 255;
                    if (green < 0) green = 0;
                    if (green > 255) green = 255;
                    if (blue < 0) blue = 0;
                    if (blue > 255) blue = 255;
                    Color yeniPiksel = Color.FromArgb(red,green,blue);
                    islem.SetPixel(x, y, yeniPiksel);
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
