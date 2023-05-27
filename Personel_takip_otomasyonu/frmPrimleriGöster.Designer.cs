namespace Personel_takip_otomasyonu
{
    partial class frmPrimleriGöster
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtPersonelAdSoyad = new System.Windows.Forms.TextBox();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.txtPrımTutarı = new System.Windows.Forms.TextBox();
            this.txtPersonelID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboYil = new System.Windows.Forms.ComboBox();
            this.comboAy = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPrımID = new System.Windows.Forms.TextBox();
            this.btnDonemDegıstır = new System.Windows.Forms.Button();
            this.btnTumPrımlerıOde = new System.Windows.Forms.Button();
            this.PrımOde = new System.Windows.Forms.Button();
            this.btnPrımGuncelle = new System.Windows.Forms.Button();
            this.btnPrımSıl = new System.Windows.Forms.Button();
            this.btnCıkıs = new System.Windows.Forms.Button();
            this.btnTemızle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(775, 306);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // txtPersonelAdSoyad
            // 
            this.txtPersonelAdSoyad.Location = new System.Drawing.Point(145, 365);
            this.txtPersonelAdSoyad.Name = "txtPersonelAdSoyad";
            this.txtPersonelAdSoyad.Size = new System.Drawing.Size(121, 20);
            this.txtPersonelAdSoyad.TabIndex = 35;
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(386, 365);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(383, 45);
            this.txtAciklama.TabIndex = 32;
            // 
            // txtPrımTutarı
            // 
            this.txtPrımTutarı.Location = new System.Drawing.Point(386, 339);
            this.txtPrımTutarı.Name = "txtPrımTutarı";
            this.txtPrımTutarı.Size = new System.Drawing.Size(121, 20);
            this.txtPrımTutarı.TabIndex = 33;
            // 
            // txtPersonelID
            // 
            this.txtPersonelID.Location = new System.Drawing.Point(145, 339);
            this.txtPersonelID.Name = "txtPersonelID";
            this.txtPersonelID.Size = new System.Drawing.Size(121, 20);
            this.txtPersonelID.TabIndex = 34;
            this.txtPersonelID.TextChanged += new System.EventHandler(this.txtPersonelID_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(80, 342);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "PersonelID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 371);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Personel Ad Soyad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(339, 315);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Dönem";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(330, 368);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "Açıklama";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(323, 342);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "Prim Tutarı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(513, 315);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(12, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "\\";
            // 
            // comboYil
            // 
            this.comboYil.FormattingEnabled = true;
            this.comboYil.Location = new System.Drawing.Point(531, 312);
            this.comboYil.Name = "comboYil";
            this.comboYil.Size = new System.Drawing.Size(130, 21);
            this.comboYil.TabIndex = 25;
            // 
            // comboAy
            // 
            this.comboAy.FormattingEnabled = true;
            this.comboAy.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.comboAy.Location = new System.Drawing.Point(386, 312);
            this.comboAy.Name = "comboAy";
            this.comboAy.Size = new System.Drawing.Size(121, 21);
            this.comboAy.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(98, 317);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "Prim ID";
            // 
            // txtPrımID
            // 
            this.txtPrımID.Location = new System.Drawing.Point(145, 313);
            this.txtPrımID.Name = "txtPrımID";
            this.txtPrımID.Size = new System.Drawing.Size(121, 20);
            this.txtPrımID.TabIndex = 34;
            // 
            // btnDonemDegıstır
            // 
            this.btnDonemDegıstır.Location = new System.Drawing.Point(667, 312);
            this.btnDonemDegıstır.Name = "btnDonemDegıstır";
            this.btnDonemDegıstır.Size = new System.Drawing.Size(102, 43);
            this.btnDonemDegıstır.TabIndex = 36;
            this.btnDonemDegıstır.Text = "Dönem Değiştir";
            this.btnDonemDegıstır.UseVisualStyleBackColor = true;
            this.btnDonemDegıstır.Click += new System.EventHandler(this.btnDonemDegıstır_Click);
            // 
            // btnTumPrımlerıOde
            // 
            this.btnTumPrımlerıOde.Location = new System.Drawing.Point(21, 424);
            this.btnTumPrımlerıOde.Name = "btnTumPrımlerıOde";
            this.btnTumPrımlerıOde.Size = new System.Drawing.Size(107, 40);
            this.btnTumPrımlerıOde.TabIndex = 37;
            this.btnTumPrımlerıOde.Text = "Tüm Primleri Öde";
            this.btnTumPrımlerıOde.UseVisualStyleBackColor = true;
            this.btnTumPrımlerıOde.Click += new System.EventHandler(this.btnTumPrımlerıOde_Click);
            // 
            // PrımOde
            // 
            this.PrımOde.Location = new System.Drawing.Point(134, 424);
            this.PrımOde.Name = "PrımOde";
            this.PrımOde.Size = new System.Drawing.Size(107, 40);
            this.PrımOde.TabIndex = 37;
            this.PrımOde.Text = "Prim Öde";
            this.PrımOde.UseVisualStyleBackColor = true;
            this.PrımOde.Click += new System.EventHandler(this.PrımOde_Click);
            // 
            // btnPrımGuncelle
            // 
            this.btnPrımGuncelle.Location = new System.Drawing.Point(247, 424);
            this.btnPrımGuncelle.Name = "btnPrımGuncelle";
            this.btnPrımGuncelle.Size = new System.Drawing.Size(107, 40);
            this.btnPrımGuncelle.TabIndex = 37;
            this.btnPrımGuncelle.Text = "Prim Güncelle";
            this.btnPrımGuncelle.UseVisualStyleBackColor = true;
            this.btnPrımGuncelle.Click += new System.EventHandler(this.btnPrımGuncelle_Click);
            // 
            // btnPrımSıl
            // 
            this.btnPrımSıl.Location = new System.Drawing.Point(360, 424);
            this.btnPrımSıl.Name = "btnPrımSıl";
            this.btnPrımSıl.Size = new System.Drawing.Size(107, 40);
            this.btnPrımSıl.TabIndex = 37;
            this.btnPrımSıl.Text = "Prim Sil";
            this.btnPrımSıl.UseVisualStyleBackColor = true;
            this.btnPrımSıl.Click += new System.EventHandler(this.btnPrımSıl_Click);
            // 
            // btnCıkıs
            // 
            this.btnCıkıs.Location = new System.Drawing.Point(599, 424);
            this.btnCıkıs.Name = "btnCıkıs";
            this.btnCıkıs.Size = new System.Drawing.Size(107, 40);
            this.btnCıkıs.TabIndex = 39;
            this.btnCıkıs.Text = "Çıkış";
            this.btnCıkıs.UseVisualStyleBackColor = true;
            this.btnCıkıs.Click += new System.EventHandler(this.btnCıkıs_Click);
            // 
            // btnTemızle
            // 
            this.btnTemızle.Location = new System.Drawing.Point(477, 424);
            this.btnTemızle.Name = "btnTemızle";
            this.btnTemızle.Size = new System.Drawing.Size(107, 40);
            this.btnTemızle.TabIndex = 38;
            this.btnTemızle.Text = "Temizle";
            this.btnTemızle.UseVisualStyleBackColor = true;
            this.btnTemızle.Click += new System.EventHandler(this.btnTemızle_Click);
            // 
            // frmPrimleriGöster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(775, 486);
            this.Controls.Add(this.btnCıkıs);
            this.Controls.Add(this.btnTemızle);
            this.Controls.Add(this.btnPrımSıl);
            this.Controls.Add(this.btnPrımGuncelle);
            this.Controls.Add(this.PrımOde);
            this.Controls.Add(this.btnTumPrımlerıOde);
            this.Controls.Add(this.btnDonemDegıstır);
            this.Controls.Add(this.txtPersonelAdSoyad);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.txtPrımTutarı);
            this.Controls.Add(this.txtPrımID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtPersonelID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboYil);
            this.Controls.Add(this.comboAy);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmPrimleriGöster";
            this.Text = "frmPrimleriGöster";
            this.Load += new System.EventHandler(this.frmPrimleriGöster_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtPersonelAdSoyad;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.TextBox txtPrımTutarı;
        private System.Windows.Forms.TextBox txtPersonelID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboYil;
        private System.Windows.Forms.ComboBox comboAy;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPrımID;
        private System.Windows.Forms.Button btnDonemDegıstır;
        private System.Windows.Forms.Button btnTumPrımlerıOde;
        private System.Windows.Forms.Button PrımOde;
        private System.Windows.Forms.Button btnPrımGuncelle;
        private System.Windows.Forms.Button btnPrımSıl;
        private System.Windows.Forms.Button btnCıkıs;
        private System.Windows.Forms.Button btnTemızle;
    }
}