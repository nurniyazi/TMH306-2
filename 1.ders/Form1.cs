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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pikselAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pikselFr pikselFormu = new pikselFr();
            pikselFormu.ShowDialog();

        }

        private void işlemlerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void invertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            invertFr İnvertFormu = new invertFr();
            İnvertFormu.ShowDialog();
        }

        private void parlaklikToolStripMenuItem_Click(object sender, EventArgs e)
        {
            parlaklikFr parlaklikFormu = new parlaklikFr();
            parlaklikFormu.ShowDialog();
        }

        private void griYöntemlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            griFr griFormu = new griFr();
            griFormu.ShowDialog();
        }

        private void thresholdYöntemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            thresholdFr thresholdFormu = new thresholdFr();
            thresholdFormu.ShowDialog();

        }

        private void ikiliGörüntüIşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ikiliGoruntu ikiliGoruntuFormu = new ikiliGoruntu();
            ikiliGoruntuFormu.ShowDialog();
        }
    }
}
