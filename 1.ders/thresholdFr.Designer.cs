namespace _1.ders
{
    partial class thresholdFr
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.dosyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thresholdYönetemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.elleDeğerGirmeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kaynakBox = new System.Windows.Forms.PictureBox();
            this.islemBox = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kaynakBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.islemBox)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaToolStripMenuItem,
            this.thresholdYönetemleriToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1253, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // dosyaToolStripMenuItem
            // 
            this.dosyaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acToolStripMenuItem});
            this.dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            this.dosyaToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.dosyaToolStripMenuItem.Text = "Dosya";
            // 
            // acToolStripMenuItem
            // 
            this.acToolStripMenuItem.Name = "acToolStripMenuItem";
            this.acToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.acToolStripMenuItem.Text = "Ac";
            this.acToolStripMenuItem.Click += new System.EventHandler(this.acToolStripMenuItem_Click);
            // 
            // thresholdYönetemleriToolStripMenuItem
            // 
            this.thresholdYönetemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.elleDeğerGirmeToolStripMenuItem});
            this.thresholdYönetemleriToolStripMenuItem.Name = "thresholdYönetemleriToolStripMenuItem";
            this.thresholdYönetemleriToolStripMenuItem.Size = new System.Drawing.Size(161, 24);
            this.thresholdYönetemleriToolStripMenuItem.Text = "Threshold Yöntemleri";
            // 
            // elleDeğerGirmeToolStripMenuItem
            // 
            this.elleDeğerGirmeToolStripMenuItem.Name = "elleDeğerGirmeToolStripMenuItem";
            this.elleDeğerGirmeToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.elleDeğerGirmeToolStripMenuItem.Text = "Elle değer girme";
            this.elleDeğerGirmeToolStripMenuItem.Click += new System.EventHandler(this.elleDeğerGirmeToolStripMenuItem_Click);
            // 
            // kaynakBox
            // 
            this.kaynakBox.Location = new System.Drawing.Point(22, 68);
            this.kaynakBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.kaynakBox.Name = "kaynakBox";
            this.kaynakBox.Size = new System.Drawing.Size(587, 637);
            this.kaynakBox.TabIndex = 7;
            this.kaynakBox.TabStop = false;
            // 
            // islemBox
            // 
            this.islemBox.Location = new System.Drawing.Point(634, 68);
            this.islemBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.islemBox.Name = "islemBox";
            this.islemBox.Size = new System.Drawing.Size(587, 637);
            this.islemBox.TabIndex = 6;
            this.islemBox.TabStop = false;
            // 
            // thresholdFr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1253, 654);
            this.Controls.Add(this.kaynakBox);
            this.Controls.Add(this.islemBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "thresholdFr";
            this.Text = "thresholdFr";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kaynakBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.islemBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dosyaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thresholdYönetemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem elleDeğerGirmeToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox kaynakBox;
        private System.Windows.Forms.PictureBox islemBox;
    }
}