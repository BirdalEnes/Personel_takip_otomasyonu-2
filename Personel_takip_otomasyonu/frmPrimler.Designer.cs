namespace Personel_takip_otomasyonu
{
    partial class frmPrimler
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboYil = new System.Windows.Forms.ComboBox();
            this.comboAy = new System.Windows.Forms.ComboBox();
            this.radioTumpersonelPrım = new System.Windows.Forms.RadioButton();
            this.radioKısıOzel = new System.Windows.Forms.RadioButton();
            this.txtPersonelID = new System.Windows.Forms.TextBox();
            this.txtPersonelAdSoyad = new System.Windows.Forms.TextBox();
            this.txtPrımTutarı = new System.Windows.Forms.TextBox();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnPrımEkle = new System.Windows.Forms.Button();
            this.btnPrımGoster = new System.Windows.Forms.Button();
            this.btnPersoneleGorePrım = new System.Windows.Forms.Button();
            this.btnTemızle = new System.Windows.Forms.Button();
            this.btnCıkıs = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 22);
            this.label2.TabIndex = 15;
            this.label2.Text = "Prim Tutarı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(315, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 22);
            this.label1.TabIndex = 14;
            this.label1.Text = "\\";
            // 
            // comboYil
            // 
            this.comboYil.FormattingEnabled = true;
            this.comboYil.Location = new System.Drawing.Point(362, 157);
            this.comboYil.Name = "comboYil";
            this.comboYil.Size = new System.Drawing.Size(130, 30);
            this.comboYil.TabIndex = 13;
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
            this.comboAy.Location = new System.Drawing.Point(173, 157);
            this.comboAy.Name = "comboAy";
            this.comboAy.Size = new System.Drawing.Size(121, 30);
            this.comboAy.TabIndex = 12;
            // 
            // radioTumpersonelPrım
            // 
            this.radioTumpersonelPrım.AutoSize = true;
            this.radioTumpersonelPrım.Location = new System.Drawing.Point(235, 12);
            this.radioTumpersonelPrım.Name = "radioTumpersonelPrım";
            this.radioTumpersonelPrım.Size = new System.Drawing.Size(237, 26);
            this.radioTumpersonelPrım.TabIndex = 17;
            this.radioTumpersonelPrım.TabStop = true;
            this.radioTumpersonelPrım.Text = "Tüm Personeller İçin Prim";
            this.radioTumpersonelPrım.UseVisualStyleBackColor = true;
            // 
            // radioKısıOzel
            // 
            this.radioKısıOzel.AutoSize = true;
            this.radioKısıOzel.Location = new System.Drawing.Point(48, 12);
            this.radioKısıOzel.Name = "radioKısıOzel";
            this.radioKısıOzel.Size = new System.Drawing.Size(159, 26);
            this.radioKısıOzel.TabIndex = 16;
            this.radioKısıOzel.TabStop = true;
            this.radioKısıOzel.Text = "Kişiye Özel Prim";
            this.radioKısıOzel.UseVisualStyleBackColor = true;
            // 
            // txtPersonelID
            // 
            this.txtPersonelID.Location = new System.Drawing.Point(173, 64);
            this.txtPersonelID.Name = "txtPersonelID";
            this.txtPersonelID.Size = new System.Drawing.Size(319, 29);
            this.txtPersonelID.TabIndex = 18;
            // 
            // txtPersonelAdSoyad
            // 
            this.txtPersonelAdSoyad.Location = new System.Drawing.Point(173, 110);
            this.txtPersonelAdSoyad.Name = "txtPersonelAdSoyad";
            this.txtPersonelAdSoyad.Size = new System.Drawing.Size(319, 29);
            this.txtPersonelAdSoyad.TabIndex = 19;
            // 
            // txtPrımTutarı
            // 
            this.txtPrımTutarı.Location = new System.Drawing.Point(173, 202);
            this.txtPrımTutarı.Name = "txtPrımTutarı";
            this.txtPrımTutarı.Size = new System.Drawing.Size(319, 29);
            this.txtPrımTutarı.TabIndex = 18;
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(173, 250);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(319, 63);
            this.txtAciklama.TabIndex = 18;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 386);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(751, 202);
            this.dataGridView1.TabIndex = 20;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 22);
            this.label3.TabIndex = 15;
            this.label3.Text = "Personel Ad Soyad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 22);
            this.label4.TabIndex = 15;
            this.label4.Text = "PersonelID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(98, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 22);
            this.label5.TabIndex = 15;
            this.label5.Text = "Dönem";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(83, 253);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 22);
            this.label6.TabIndex = 15;
            this.label6.Text = "Açıklama";
            // 
            // btnPrımEkle
            // 
            this.btnPrımEkle.Location = new System.Drawing.Point(130, 330);
            this.btnPrımEkle.Name = "btnPrımEkle";
            this.btnPrımEkle.Size = new System.Drawing.Size(116, 50);
            this.btnPrımEkle.TabIndex = 21;
            this.btnPrımEkle.Text = "Prim Ekle";
            this.btnPrımEkle.UseVisualStyleBackColor = true;
            this.btnPrımEkle.Click += new System.EventHandler(this.btnPrımEkle_Click);
            // 
            // btnPrımGoster
            // 
            this.btnPrımGoster.Location = new System.Drawing.Point(7, 330);
            this.btnPrımGoster.Name = "btnPrımGoster";
            this.btnPrımGoster.Size = new System.Drawing.Size(116, 50);
            this.btnPrımGoster.TabIndex = 22;
            this.btnPrımGoster.Text = "Prim Göster";
            this.btnPrımGoster.UseVisualStyleBackColor = true;
            this.btnPrımGoster.Click += new System.EventHandler(this.btnPrımGoster_Click);
            // 
            // btnPersoneleGorePrım
            // 
            this.btnPersoneleGorePrım.Location = new System.Drawing.Point(252, 330);
            this.btnPersoneleGorePrım.Name = "btnPersoneleGorePrım";
            this.btnPersoneleGorePrım.Size = new System.Drawing.Size(163, 50);
            this.btnPersoneleGorePrım.TabIndex = 23;
            this.btnPersoneleGorePrım.Text = "Personel Primleri";
            this.btnPersoneleGorePrım.UseVisualStyleBackColor = true;
            this.btnPersoneleGorePrım.Click += new System.EventHandler(this.btnPersoneleGorePrım_Click_1);
            // 
            // btnTemızle
            // 
            this.btnTemızle.Location = new System.Drawing.Point(419, 330);
            this.btnTemızle.Name = "btnTemızle";
            this.btnTemızle.Size = new System.Drawing.Size(116, 50);
            this.btnTemızle.TabIndex = 21;
            this.btnTemızle.Text = "Temizle";
            this.btnTemızle.UseVisualStyleBackColor = true;
            this.btnTemızle.Click += new System.EventHandler(this.btnTemızle_Click);
            // 
            // btnCıkıs
            // 
            this.btnCıkıs.Location = new System.Drawing.Point(541, 330);
            this.btnCıkıs.Name = "btnCıkıs";
            this.btnCıkıs.Size = new System.Drawing.Size(163, 50);
            this.btnCıkıs.TabIndex = 23;
            this.btnCıkıs.Text = "Çıkış";
            this.btnCıkıs.UseVisualStyleBackColor = true;
            this.btnCıkıs.Click += new System.EventHandler(this.btnCıkıs_Click);
            // 
            // frmPrimler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(751, 588);
            this.Controls.Add(this.btnCıkıs);
            this.Controls.Add(this.btnPersoneleGorePrım);
            this.Controls.Add(this.btnTemızle);
            this.Controls.Add(this.btnPrımGoster);
            this.Controls.Add(this.btnPrımEkle);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtPersonelAdSoyad);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.txtPrımTutarı);
            this.Controls.Add(this.txtPersonelID);
            this.Controls.Add(this.radioTumpersonelPrım);
            this.Controls.Add(this.radioKısıOzel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboYil);
            this.Controls.Add(this.comboAy);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmPrimler";
            this.Text = "Prim Sayfası";
            this.Load += new System.EventHandler(this.frmPrimler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboYil;
        private System.Windows.Forms.ComboBox comboAy;
        private System.Windows.Forms.RadioButton radioTumpersonelPrım;
        private System.Windows.Forms.RadioButton radioKısıOzel;
        private System.Windows.Forms.TextBox txtPersonelID;
        private System.Windows.Forms.TextBox txtPersonelAdSoyad;
        private System.Windows.Forms.TextBox txtPrımTutarı;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnPrımEkle;
        private System.Windows.Forms.Button btnPrımGoster;
        private System.Windows.Forms.Button btnPersoneleGorePrım;
        private System.Windows.Forms.Button btnTemızle;
        private System.Windows.Forms.Button btnCıkıs;
    }
}