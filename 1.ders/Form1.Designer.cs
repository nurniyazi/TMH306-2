namespace _1.ders
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.işlemlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pikselAlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.invertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parlaklikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.griYöntemlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thresholdYöntemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ikiliGörüntüIşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.işlemlerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(933, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // işlemlerToolStripMenuItem
            // 
            this.işlemlerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pikselAlToolStripMenuItem,
            this.invertToolStripMenuItem,
            this.parlaklikToolStripMenuItem,
            this.griYöntemlerToolStripMenuItem,
            this.thresholdYöntemleriToolStripMenuItem,
            this.ikiliGörüntüIşlemleriToolStripMenuItem});
            this.işlemlerToolStripMenuItem.Name = "işlemlerToolStripMenuItem";
            this.işlemlerToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.işlemlerToolStripMenuItem.Text = "işlemler";
            this.işlemlerToolStripMenuItem.Click += new System.EventHandler(this.işlemlerToolStripMenuItem_Click);
            // 
            // pikselAlToolStripMenuItem
            // 
            this.pikselAlToolStripMenuItem.Name = "pikselAlToolStripMenuItem";
            this.pikselAlToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.pikselAlToolStripMenuItem.Text = "piksel al";
            this.pikselAlToolStripMenuItem.Click += new System.EventHandler(this.pikselAlToolStripMenuItem_Click);
            // 
            // invertToolStripMenuItem
            // 
            this.invertToolStripMenuItem.Name = "invertToolStripMenuItem";
            this.invertToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.invertToolStripMenuItem.Text = "invert";
            this.invertToolStripMenuItem.Click += new System.EventHandler(this.invertToolStripMenuItem_Click);
            // 
            // parlaklikToolStripMenuItem
            // 
            this.parlaklikToolStripMenuItem.Name = "parlaklikToolStripMenuItem";
            this.parlaklikToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.parlaklikToolStripMenuItem.Text = "parlaklik";
            this.parlaklikToolStripMenuItem.Click += new System.EventHandler(this.parlaklikToolStripMenuItem_Click);
            // 
            // griYöntemlerToolStripMenuItem
            // 
            this.griYöntemlerToolStripMenuItem.Name = "griYöntemlerToolStripMenuItem";
            this.griYöntemlerToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.griYöntemlerToolStripMenuItem.Text = "Gri Yöntemleri";
            this.griYöntemlerToolStripMenuItem.Click += new System.EventHandler(this.griYöntemlerToolStripMenuItem_Click);
            // 
            // thresholdYöntemleriToolStripMenuItem
            // 
            this.thresholdYöntemleriToolStripMenuItem.Name = "thresholdYöntemleriToolStripMenuItem";
            this.thresholdYöntemleriToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.thresholdYöntemleriToolStripMenuItem.Text = "Threshold Yöntemleri";
            this.thresholdYöntemleriToolStripMenuItem.Click += new System.EventHandler(this.thresholdYöntemleriToolStripMenuItem_Click);
            // 
            // ikiliGörüntüIşlemleriToolStripMenuItem
            // 
            this.ikiliGörüntüIşlemleriToolStripMenuItem.Name = "ikiliGörüntüIşlemleriToolStripMenuItem";
            this.ikiliGörüntüIşlemleriToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.ikiliGörüntüIşlemleriToolStripMenuItem.Text = "ikili Görüntü işlemleri";
            this.ikiliGörüntüIşlemleriToolStripMenuItem.Click += new System.EventHandler(this.ikiliGörüntüIşlemleriToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 554);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem işlemlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pikselAlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem invertToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parlaklikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem griYöntemlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thresholdYöntemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ikiliGörüntüIşlemleriToolStripMenuItem;
    }
}

