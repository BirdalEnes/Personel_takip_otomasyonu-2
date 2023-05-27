namespace Personel_takip_otomasyonu
{
    partial class FrmAnaSayfa
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
            this.btnDepartman = new System.Windows.Forms.Button();
            this.btnPersonelEkle = new System.Windows.Forms.Button();
            this.btnPersonelListele = new System.Windows.Forms.Button();
            this.btnMaasZamları = new System.Windows.Forms.Button();
            this.btnprim = new System.Windows.Forms.Button();
            this.btnmesaiekle = new System.Windows.Forms.Button();
            this.btnMesailer = new System.Windows.Forms.Button();
            this.btnizinHareketlistele = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDepartman
            // 
            this.btnDepartman.Location = new System.Drawing.Point(12, 11);
            this.btnDepartman.Name = "btnDepartman";
            this.btnDepartman.Size = new System.Drawing.Size(194, 42);
            this.btnDepartman.TabIndex = 0;
            this.btnDepartman.Text = "Departmanlar";
            this.btnDepartman.UseVisualStyleBackColor = true;
            this.btnDepartman.Click += new System.EventHandler(this.btnDepartman_Click);
            // 
            // btnPersonelEkle
            // 
            this.btnPersonelEkle.Location = new System.Drawing.Point(13, 164);
            this.btnPersonelEkle.Name = "btnPersonelEkle";
            this.btnPersonelEkle.Size = new System.Drawing.Size(194, 42);
            this.btnPersonelEkle.TabIndex = 1;
            this.btnPersonelEkle.Text = "Personel Ekle";
            this.btnPersonelEkle.UseVisualStyleBackColor = true;
            this.btnPersonelEkle.Click += new System.EventHandler(this.btnPersonelEkle_Click);
            // 
            // btnPersonelListele
            // 
            this.btnPersonelListele.Location = new System.Drawing.Point(12, 309);
            this.btnPersonelListele.Name = "btnPersonelListele";
            this.btnPersonelListele.Size = new System.Drawing.Size(194, 42);
            this.btnPersonelListele.TabIndex = 2;
            this.btnPersonelListele.Text = "Personel Listele";
            this.btnPersonelListele.UseVisualStyleBackColor = true;
            this.btnPersonelListele.Click += new System.EventHandler(this.btnPersonelListele_Click);
            // 
            // btnMaasZamları
            // 
            this.btnMaasZamları.Location = new System.Drawing.Point(12, 62);
            this.btnMaasZamları.Name = "btnMaasZamları";
            this.btnMaasZamları.Size = new System.Drawing.Size(194, 42);
            this.btnMaasZamları.TabIndex = 2;
            this.btnMaasZamları.Text = "Maaş Zamları";
            this.btnMaasZamları.UseVisualStyleBackColor = true;
            this.btnMaasZamları.Click += new System.EventHandler(this.btnMaasZamları_Click);
            // 
            // btnprim
            // 
            this.btnprim.Location = new System.Drawing.Point(13, 215);
            this.btnprim.Name = "btnprim";
            this.btnprim.Size = new System.Drawing.Size(194, 42);
            this.btnprim.TabIndex = 2;
            this.btnprim.Text = "Pirimler";
            this.btnprim.UseVisualStyleBackColor = true;
            this.btnprim.Click += new System.EventHandler(this.btnprim_Click);
            // 
            // btnmesaiekle
            // 
            this.btnmesaiekle.Location = new System.Drawing.Point(13, 356);
            this.btnmesaiekle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnmesaiekle.Name = "btnmesaiekle";
            this.btnmesaiekle.Size = new System.Drawing.Size(194, 42);
            this.btnmesaiekle.TabIndex = 3;
            this.btnmesaiekle.Text = "Mesai Ekle";
            this.btnmesaiekle.UseVisualStyleBackColor = true;
            this.btnmesaiekle.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnMesailer
            // 
            this.btnMesailer.Location = new System.Drawing.Point(13, 113);
            this.btnMesailer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMesailer.Name = "btnMesailer";
            this.btnMesailer.Size = new System.Drawing.Size(194, 42);
            this.btnMesailer.TabIndex = 4;
            this.btnMesailer.Text = "Mesailer";
            this.btnMesailer.UseVisualStyleBackColor = true;
            this.btnMesailer.Click += new System.EventHandler(this.btnMesailer_Click);
            // 
            // btnizinHareketlistele
            // 
            this.btnizinHareketlistele.Location = new System.Drawing.Point(12, 262);
            this.btnizinHareketlistele.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnizinHareketlistele.Name = "btnizinHareketlistele";
            this.btnizinHareketlistele.Size = new System.Drawing.Size(194, 42);
            this.btnizinHareketlistele.TabIndex = 6;
            this.btnizinHareketlistele.Text = "izin hareket listele";
            this.btnizinHareketlistele.UseVisualStyleBackColor = true;
            this.btnizinHareketlistele.Click += new System.EventHandler(this.btnizinHareketlistele_Click);
            // 
            // FrmAnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(238, 431);
            this.Controls.Add(this.btnDepartman);
            this.Controls.Add(this.btnmesaiekle);
            this.Controls.Add(this.btnprim);
            this.Controls.Add(this.btnizinHareketlistele);
            this.Controls.Add(this.btnPersonelEkle);
            this.Controls.Add(this.btnPersonelListele);
            this.Controls.Add(this.btnMesailer);
            this.Controls.Add(this.btnMaasZamları);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Name = "FrmAnaSayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ana Sayfa";
            this.Load += new System.EventHandler(this.FrmAnaSayfa_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDepartman;
        private System.Windows.Forms.Button btnPersonelEkle;
        private System.Windows.Forms.Button btnPersonelListele;
        private System.Windows.Forms.Button btnMaasZamları;
        private System.Windows.Forms.Button btnprim;
        private System.Windows.Forms.Button btnmesaiekle;
        private System.Windows.Forms.Button btnMesailer;
        private System.Windows.Forms.Button btnizinHareketlistele;
    }
}

