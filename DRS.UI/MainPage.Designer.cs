
namespace DRS.UI
{
    partial class MainPage
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
            this.hastaİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hastaKayitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hastaListesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doktorİslemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DoktorKayitEkrani = new System.Windows.Forms.ToolStripMenuItem();
            this.doktorListesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.randevuİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.randevuKayitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.randevuListesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çikişToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hastaİşlemleriToolStripMenuItem,
            this.doktorİslemleriToolStripMenuItem,
            this.randevuİşlemleriToolStripMenuItem,
            this.çikişToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(396, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hastaİşlemleriToolStripMenuItem
            // 
            this.hastaİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hastaKayitToolStripMenuItem,
            this.hastaListesiToolStripMenuItem});
            this.hastaİşlemleriToolStripMenuItem.Name = "hastaİşlemleriToolStripMenuItem";
            this.hastaİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.hastaİşlemleriToolStripMenuItem.Text = "Hasta İşlemleri";
            this.hastaİşlemleriToolStripMenuItem.Click += new System.EventHandler(this.hastaİşlemleriToolStripMenuItem_Click);
            // 
            // hastaKayitToolStripMenuItem
            // 
            this.hastaKayitToolStripMenuItem.Name = "hastaKayitToolStripMenuItem";
            this.hastaKayitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.hastaKayitToolStripMenuItem.Text = "Hasta Kayıt";
            this.hastaKayitToolStripMenuItem.Click += new System.EventHandler(this.hastaKayıtToolStripMenuItem_Click);
            // 
            // hastaListesiToolStripMenuItem
            // 
            this.hastaListesiToolStripMenuItem.Name = "hastaListesiToolStripMenuItem";
            this.hastaListesiToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.hastaListesiToolStripMenuItem.Text = "Hasta Listesi";
            this.hastaListesiToolStripMenuItem.Click += new System.EventHandler(this.hastaListesiToolStripMenuItem_Click);
            // 
            // doktorİslemleriToolStripMenuItem
            // 
            this.doktorİslemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DoktorKayitEkrani,
            this.doktorListesiToolStripMenuItem});
            this.doktorİslemleriToolStripMenuItem.Name = "doktorİslemleriToolStripMenuItem";
            this.doktorİslemleriToolStripMenuItem.Size = new System.Drawing.Size(102, 20);
            this.doktorİslemleriToolStripMenuItem.Text = "Doktor İşlemleri";
            // 
            // DoktorKayitEkrani
            // 
            this.DoktorKayitEkrani.Name = "DoktorKayitEkrani";
            this.DoktorKayitEkrani.Size = new System.Drawing.Size(180, 22);
            this.DoktorKayitEkrani.Text = "Doktor Kayıt";
            this.DoktorKayitEkrani.Click += new System.EventHandler(this.doktorKayitToolStripMenuItem_Click);
            // 
            // doktorListesiToolStripMenuItem
            // 
            this.doktorListesiToolStripMenuItem.Name = "doktorListesiToolStripMenuItem";
            this.doktorListesiToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.doktorListesiToolStripMenuItem.Text = "Doktor Listesi";
            this.doktorListesiToolStripMenuItem.Click += new System.EventHandler(this.doktorListesiToolStripMenuItem_Click);
            // 
            // randevuİşlemleriToolStripMenuItem
            // 
            this.randevuİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.randevuKayitToolStripMenuItem,
            this.randevuListesiToolStripMenuItem});
            this.randevuİşlemleriToolStripMenuItem.Name = "randevuİşlemleriToolStripMenuItem";
            this.randevuİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(112, 20);
            this.randevuİşlemleriToolStripMenuItem.Text = "Randevu İşlemleri";
            // 
            // randevuKayitToolStripMenuItem
            // 
            this.randevuKayitToolStripMenuItem.Name = "randevuKayitToolStripMenuItem";
            this.randevuKayitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.randevuKayitToolStripMenuItem.Text = "Randevu Kayıt";
            // 
            // randevuListesiToolStripMenuItem
            // 
            this.randevuListesiToolStripMenuItem.Name = "randevuListesiToolStripMenuItem";
            this.randevuListesiToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.randevuListesiToolStripMenuItem.Text = "Randevu Listesi";
            // 
            // çikişToolStripMenuItem
            // 
            this.çikişToolStripMenuItem.Name = "çikişToolStripMenuItem";
            this.çikişToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.çikişToolStripMenuItem.Text = "Çıkış";
            this.çikişToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 276);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainPage";
            this.Text = "MainPage";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hastaİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hastaKayitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hastaListesiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doktorİslemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DoktorKayitEkrani;
        private System.Windows.Forms.ToolStripMenuItem doktorListesiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem randevuİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem randevuKayitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem randevuListesiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çikişToolStripMenuItem;
    }
}