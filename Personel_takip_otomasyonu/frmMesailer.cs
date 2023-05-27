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
    public partial class frmMesailer : Form
    {
        public frmMesailer()
        {
            InitializeComponent();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMesailer_Load(object sender, EventArgs e)
        {
            int yil = DateTime.Now.Year;
            for (int i = yil; i >= yil - 5; i--)
            {
                comboYil.Items.Add(i);
            }

            veritabani.Listele_Ara(dataGridView1, "select * from Mesailer");
        }

        private void txtPersonelID_TextChanged(object sender, EventArgs e)
        {
            Primler.PersonelAdSoyadGetir(txtPersonelID, txtAdSoyad);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow.Cells["OdemeDurumu"].Value.ToString() == "Ödenmedi")
            {
                txtMesaiID.Text = dataGridView1.CurrentRow.Cells["MesaiID"].Value.ToString();
                txtPersonelID.Text = dataGridView1.CurrentRow.Cells["PersonelID"].Value.ToString();
                txtMesaiSaatUcreti.Text = dataGridView1.CurrentRow.Cells["MesaiSaatUcerti"].Value.ToString();
                txtAciklama.Text = dataGridView1.CurrentRow.Cells["Aciklama"].Value.ToString();

                string baslangic = dataGridView1.CurrentRow.Cells["BaslangicSaati"].Value.ToString();
                string bitis = dataGridView1.CurrentRow.Cells["BitisSaati"].Value.ToString();
                string donem = dataGridView1.CurrentRow.Cells["Donem"].Value.ToString();

                dateTimeBaslangic.Text = baslangic.Substring(0, 10);
                maskedtxtBaslangic.Text = baslangic.Substring(11);
                dateTimeBitis.Text = baslangic.Substring(0, 10);
                maskedtxtBitis.Text = baslangic.Substring(11);

                int say = donem.IndexOf("/");
                comboAy.Text = donem.Substring(0, say);
                comboYil.Text = donem.Substring(say + 1);
            }

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


            }
        }

        private void btnPersonelMesaileri_Click(object sender, EventArgs e)
        {
            frmPersonelMesaileri frm = new frmPersonelMesaileri();
            frm.ShowDialog();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
                if (item is ComboBox)
                {
                    item.Text = "";
                }
                if (item is MaskedTextBox)
                {
                    item.Text = "";
                }
            }
            dateTimeBaslangic.Value = DateTime.Now;
            dateTimeBitis.Value = DateTime.Now;
        }

        private void btnTumMesaileriOde_Click(object sender, EventArgs e)
        {
            Mesailer m = new Mesailer();
            Kullanicilar k = new Kullanicilar();
            Personeller p = new Personeller();
            m.OdemeDurumu = "Ödendi";

            string sql = "update Mesailer set OdemeDurumu='" + m.OdemeDurumu + "' where OdemeDurumu='Ödenmedi'";
            SqlCommand komut = new SqlCommand();
            veritabani.ESG(komut, sql);
            MessageBox.Show("Ödenmeyen Tüm Mesailer Ödendi", "Mesai Ödeme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            veritabani.Listele_Ara(dataGridView1, "select * from Mesailer");
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                if (dataGridView1.Rows[i].Cells["OdemeDurumu"].Value.ToString() == "Ödenmedi")
                {
                    m.MesaiID = int.Parse(dataGridView1.Rows[i].Cells["MesaiID"].Value.ToString());
                    p.PersonelID = int.Parse(dataGridView1.Rows[i].Cells["PersonelID"].Value.ToString());
                    m.Islem = m.MesaiID + "Nolu Mesai Ücreti Ödendi";
                    m.Aciklama = "Tüm Mesaileri Ödeme";
                    MesaiHareketleriEkle(k, m, p);
                }
            }
            btnTemizle.PerformClick();
        }

        void MesaiHareketleriEkle(Kullanicilar k, Mesailer m, Personeller p)
        {
            k.KullaniciID = Kullanicilar.kid;
            string sql = "insert into MesaiHarektleri values('" + k.KullaniciID + "','" + p.PersonelID + "','" + m.MesaiID + "','" + m.Islem + "','" + m.Aciklama + "',@Tarih,) ";
            SqlCommand komut = new SqlCommand();
            komut.Parameters.Add("@Tarih", SqlDbType.Date).Value = DateTime.Now;
            veritabani.ESG(komut, sql);
        }

        private void btnMesaiOde_Click(object sender, EventArgs e)
        {
            Mesailer m = new Mesailer();
            Kullanicilar k = new Kullanicilar();
            Personeller p = new Personeller();
            p.PersonelID = int.Parse(txtPersonelID.Text);

            m.OdemeDurumu = "Ödendi";
            m.MesaiID = int.Parse(txtMesaiID.Text);
            m.Islem = m.MesaiID + "Nolu Mesai İçin Ödeme Yapıldı ";
            m.Aciklama = "Mesai Ödeme";
            string sql = "update Mesailer set OdemeDurumu='" + m.OdemeDurumu + "' where MesaiID='" + m.MesaiID + "'";
            SqlCommand komut = new SqlCommand();
            veritabani.ESG(komut, sql);
            MessageBox.Show(m.MesaiID + "Nolu Mesai Ücreti Ödendi", "Mesai Ödeme", MessageBoxButtons.OK, MessageBoxIcon.Information);

            MesaiHareketleriEkle(k, m, p);
            btnTemizle.PerformClick();
            veritabani.Listele_Ara(dataGridView1, "select * from Mesailer");
        }

        private void btnSıl_Click(object sender, EventArgs e)
        {
            Mesailer m = new Mesailer();
            Personeller p = new Personeller();
            Kullanicilar k = new Kullanicilar();
            m.MesaiID = int.Parse(txtMesaiID.Text);
            p.PersonelID = int.Parse(txtPersonelID.Text);
            m.Islem = m.MesaiID + "Nolu Mesai Kaydı Silindi";
            m.Aciklama = "Mesai Silme";
            if (MessageBox.Show("Bu Kayıt Silinsin Mi? ", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string sql = "delete from Mesailer where MesaiID='" + m.MesaiID + "'";
                SqlCommand komut = new SqlCommand();
                veritabani.ESG(komut, sql);
                MessageBox.Show(m.MesaiID + "Nolu MesaiID Kaydı Silindi", "Mesai Silme", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                MesaiHareketleriEkle(k, m, p);
                btnTemizle.PerformClick();
                veritabani.Listele_Ara(dataGridView1, "select * from Mesailer");
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Mesailer m = new Mesailer();
            Personeller p = new Personeller();
            Kullanicilar k = new Kullanicilar();
            p.PersonelID = int.Parse(txtPersonelID.Text);
            m.MesaiID = int.Parse(txtMesaiID.Text);
            m.Baslangic_Saati = dateTimeBaslangic.Text + "" + maskedtxtBaslangic.Text;
            m.Baslangic_Saati = dateTimeBitis.Text + "" + maskedtxtBitis.Text;
            m.MesaiSaatUcreti = decimal.Parse(txtMesaiSaatUcreti.Text);
            m.Tutar = decimal.Parse(txtTutar.Text);
            m.Donem = comboAy.Text + "/" + comboYil.Text;
            m.Aciklama = txtAciklama.Text;
            string sql = "update Mesailer set PersonelID='" + p.PersonelID + "',BaslangicSaati='" + m.Baslangic_Saati + "',BitisSaati='" + m.Bitis_Saati + "',MesaiSaatUcreti=@MesaiSaatUcreti,Tutar=@Tutar,Donem='" + m.Donem + "',Aciklama='" + m.Aciklama + "' where MesaiID='" + m.MesaiID + "'";
            SqlCommand komut = new SqlCommand();
            komut.Parameters.Add("@MesaiSaatUcreti", SqlDbType.Decimal).Value = m.MesaiSaatUcreti;
            komut.Parameters.Add("@Tutar", SqlDbType.Decimal).Value = m.Tutar;
            veritabani.ESG(komut, sql);
            MessageBox.Show(m.MesaiID + "Nolu Mesai Kaydı Güncellendi", "Mesai Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);

            m.Islem = m.MesaiID + "Nolu MesaiID için Güncelleme Yapıldı ";
            m.Aciklama = "Mesai Güncelleme";
            MesaiHareketleriEkle(k, m, p);
            btnTemizle.PerformClick();
            veritabani.Listele_Ara(dataGridView1, "select * from Mesailer");
        }
    }
}
