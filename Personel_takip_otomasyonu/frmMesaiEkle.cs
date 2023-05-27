using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personel_takip_otomasyonu
{
    public partial class frmMesaiEkle : Form
    {
        public frmMesaiEkle()
        {
            InitializeComponent();
        }

        private void btncıkıs_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMesaiEkle_Load(object sender, EventArgs e)
        {
            int yil = DateTime.Now.Year;
            for (int i = yil; i >= yil - 5; i--)
            {
                comboYil.Items.Add(i);
            }
            YapilanZamlar.ComboyaPersonelGetir(comboPersonelAdsoyad);
        }

        Label lbl;
        private void comboPersonelAdsoyad_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbl = new Label();
            YapilanZamlar.ComboSeciliPersonelIDGetir(comboPersonelAdsoyad, lbl);
            MessageBox.Show(lbl.Text);
        }

        private void btnmesaiekle_Click(object sender, EventArgs e)
        {
            Kullanicilar k = new Kullanicilar();
            Personeller p = new Personeller();
            Mesailer m = new Mesailer();
            k.KullaniciID = Kullanicilar.kid;
            p.PersonelID = int.Parse(lbl.Text);
            m.Baslangic_Saati = dateTimeBaslangic.Text + " " + maskedtxtBaslangic.Text;
            m.Bitis_Saati = dateTimeBitis.Text + " " + maskedtxtBitis.Text;
            m.MesaiSaatUcreti = decimal.Parse(txtMesaiSaatUcreti.Text);
            m.Tutar = decimal.Parse(txtTutar.Text);
            m.Donem = comboAy.Text + "/" + comboYil.Text;
            m.Aciklama = txtAciklama.Text;
            m.Tarih = DateTime.Now;
            string sql = "insert into Mesailer(KullanıcıID,PersonelID,BaslangicSaati,BitisSaati,MesaiSaatUcreti,Tutar,Donem,Aciklama,Tarih) values('" + k.KullaniciID + "','" + p.PersonelID + "','" + m.Baslangic_Saati + "','" + m.Bitis_Saati + "',@MesaiSaatUcreti,@Tutar,'" + m.Donem + "','" + m.Aciklama + "',@Tarih)";
            SqlCommand komut = new SqlCommand();
            komut.Parameters.Add("@MesaiSaatUcreti", SqlDbType.Decimal).Value = m.MesaiID;
            komut.Parameters.Add("@Tutar", SqlDbType.Decimal).Value = m.Tutar;
            komut.Parameters.Add("@Tarih", SqlDbType.Date).Value = m.Tarih;
            veritabani.ESG(komut, sql);
            MessageBox.Show("Mesai Bilgileri Eklendi", "Mesailer", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void txtTutar_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtMesaiSaatUcreti_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string baslangic = dateTimeBaslangic.Text + "" + maskedtxtBaslangic.Text;
                string bitis = dateTimeBitis.Text + "" + maskedtxtBitis.Text;
                TimeSpan saatfarki = DateTime.Parse(bitis) - DateTime.Parse(baslangic);
                double MesaiSaatUcreti = double.Parse(txtMesaiSaatUcreti.Text);
                double tutar = saatfarki.TotalHours * MesaiSaatUcreti;
                txtTutar.Text = tutar.ToString("0.00");
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
