namespace ApartmanKayit
{
    partial class frmAnaSayfa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAnaSayfa));
            this.btnDaireler = new DevExpress.XtraEditors.SimpleButton();
            this.btnKayitIslemleri = new DevExpress.XtraEditors.SimpleButton();
            this.btnGiderler = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // btnDaireler
            // 
            this.btnDaireler.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDaireler.Appearance.ForeColor = System.Drawing.Color.Red;
            this.btnDaireler.Appearance.Options.UseFont = true;
            this.btnDaireler.Appearance.Options.UseForeColor = true;
            this.btnDaireler.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDaireler.ImageOptions.Image")));
            this.btnDaireler.Location = new System.Drawing.Point(34, 72);
            this.btnDaireler.Name = "btnDaireler";
            this.btnDaireler.Size = new System.Drawing.Size(196, 51);
            this.btnDaireler.TabIndex = 0;
            this.btnDaireler.Text = "Daireler";
            this.btnDaireler.Click += new System.EventHandler(this.btnDaireler_Click);
            // 
            // btnKayitIslemleri
            // 
            this.btnKayitIslemleri.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKayitIslemleri.Appearance.ForeColor = System.Drawing.Color.Red;
            this.btnKayitIslemleri.Appearance.Options.UseFont = true;
            this.btnKayitIslemleri.Appearance.Options.UseForeColor = true;
            this.btnKayitIslemleri.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKayitIslemleri.ImageOptions.Image")));
            this.btnKayitIslemleri.Location = new System.Drawing.Point(34, 247);
            this.btnKayitIslemleri.Name = "btnKayitIslemleri";
            this.btnKayitIslemleri.Size = new System.Drawing.Size(196, 51);
            this.btnKayitIslemleri.TabIndex = 1;
            this.btnKayitIslemleri.Text = "Kayıt İşlemleri";
            this.btnKayitIslemleri.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // btnGiderler
            // 
            this.btnGiderler.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGiderler.Appearance.ForeColor = System.Drawing.Color.Red;
            this.btnGiderler.Appearance.Options.UseFont = true;
            this.btnGiderler.Appearance.Options.UseForeColor = true;
            this.btnGiderler.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGiderler.ImageOptions.Image")));
            this.btnGiderler.Location = new System.Drawing.Point(34, 158);
            this.btnGiderler.Name = "btnGiderler";
            this.btnGiderler.Size = new System.Drawing.Size(196, 51);
            this.btnGiderler.TabIndex = 2;
            this.btnGiderler.Text = "Giderler";
            this.btnGiderler.Click += new System.EventHandler(this.btnGiderler_Click);
            // 
            // frmAnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(345, 332);
            this.Controls.Add(this.btnGiderler);
            this.Controls.Add(this.btnKayitIslemleri);
            this.Controls.Add(this.btnDaireler);
            this.Name = "frmAnaSayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ana Sayfa";
            this.Load += new System.EventHandler(this.frmAnaSayfa_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnDaireler;
        private DevExpress.XtraEditors.SimpleButton btnKayitIslemleri;
        private DevExpress.XtraEditors.SimpleButton btnGiderler;
    }
}