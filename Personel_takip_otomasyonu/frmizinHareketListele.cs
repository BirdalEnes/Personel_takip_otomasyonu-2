using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Personel_takip_otomasyonu
{
    public partial class frmizinHareketListele : Form
    {
        public frmizinHareketListele()
        {
            InitializeComponent();
        }

        private void btnizinTurleri_Click(object sender, EventArgs e)
        {
            frmizinturleri frm = new frmizinturleri();
            frm.ShowDialog();
        }

        izin Izin = new izin();

        private void frmizinHareketListele_Load(object sender, EventArgs e)
        {
            veritabani.Listele_Ara(dataGridView1, "select izinHareketID,PersonelID,KullaniciID,tur.izinTuru,izinBaslangic,izinBitis,İslem,Aciklama,Tarih,Saat from izinHareketleri i, izinTurleri tur where i.izinTurID=tur.izinTurID ");
            Personeller.comboyakayitgetir(comboizinTuru);
        }
        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            izin i = new izin();
            i.IzinHareketID = int.Parse(txtizinHareketID.Text);
            i.PersonelID = int.Parse(txtPersonelID.Text);
            i.KullaniciID = Kullanicilar.kid;
            i.IzinTurID = (int)comboizinTuru.SelectedValue;
            i.IzinBaslangic = dateTimeizinBaslangic.Value;
            i.IzinBitis = dateTimeizinBitis.Value;
            i.Aciklama = txtAciklama.Text;
            i.Tarih = DateTime.Now;
            i.Saat = DateTime.Now;
            i.Islem = i.IzinHareketID + "nolu izin bilgileri güncellendi";
            string sql = "update izinHareketleri set PersonelID='" + i.PersonelID + "',izinTurID='" + i.IzinTurID + "',izinBAslangic=@izinBaslangic,izinBitis=@izinBitis,islem='" + i.Islem + "',Aciklama='" + i.Aciklama + "',Tarih=@Tarih,Saat=@Saat where izinHaereketID='" + i.IzinHareketID + "'";
            SqlCommand komut = new SqlCommand();
            komut.Parameters.Add("@izinBaslangic", SqlDbType.Date).Value = i.IzinBaslangic;
            komut.Parameters.Add("@izinBitis", SqlDbType.Date).Value = i.IzinBitis;
            komut.Parameters.Add("@Tarih", SqlDbType.Date).Value = i.Tarih;
            komut.Parameters.Add("@Saat", SqlDbType.DateTime).Value = i.Saat;
            try
            {
                veritabani.ESG(komut, sql);
                MessageBox.Show("İzin bilgileri güncellendi", "güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                veritabani.Listele_Ara(dataGridView1, "select izinHareketID,PersonelID,KullaniciID,tur.izinTuru,izinBaslangic,izinBitis,İslem,Aciklama,Tarih,Saat from izinHareketleri i, izinTurleri tur where i.izinTurID=tur.izinTurID ");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Uyarı");
            }
        }

        private void txtPersonelID_TextChanged(object sender, EventArgs e)
        {
            Primler.PersonelAdSoyadGetir(txtPersonelID, txtAdSoyad);
            if (txtPersonelID.Text == "")
            {
                txtAdSoyad.Text = "";
            }
        }

        private void Temizle()
        {
            dateTimeizinBaslangic.Value = DateTime.Now;
            dateTimeizinBitis.Value = DateTime.Now;
            Personeller.comboyakayitgetir(comboizinTuru);
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            izin i = new izin();
            i.PersonelID = int.Parse(txtPersonelID.Text);
            i.KullaniciID = Kullanicilar.kid;
            i.IzinTurID = (int)comboizinTuru.SelectedValue;
            i.IzinBaslangic = dateTimeizinBaslangic.Value;
            i.IzinBitis = dateTimeizinBitis.Value;
            i.Islem = i.PersonelID + "-" + txtAdSoyad.Text + "için" + comboizinTuru.Text + "oluşturuldu";
            i.Aciklama = txtAciklama.Text;
            i.Tarih = DateTime.Now;
            i.Saat = DateTime.Now;
            string sql = "insert into izinHareketleri values('" + i.PersonelID + "','" + i.KullaniciID + "','" + i.IzinTurID + "',@izinBaslangic,@izinBitis,'" + i.Islem + "','" + i.Aciklama + "',@Tarih,@Saat)";
            SqlCommand komut = new SqlCommand();
            komut.Parameters.Add("@izinBaslangic", SqlDbType.Date).Value = i.IzinBaslangic;
            komut.Parameters.Add("@izinBitis", SqlDbType.Date).Value = i.IzinBitis;
            komut.Parameters.Add("@Tarih", SqlDbType.Date).Value = i.Tarih;
            komut.Parameters.Add("@Saat", SqlDbType.DateTime).Value = i.Saat;
            try
            {
                veritabani.ESG(komut, sql);
                MessageBox.Show("İzin Kaydı Oluşturuldu", "İzin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                veritabani.Listele_Ara(dataGridView1, "select izinHareketID,PersonelID,KullaniciID,tur.izinTuru,izinBaslangic,izinBitis,İslem,Aciklama,Tarih,Saat from izinHareketleri i, izinTurleri tur where i.izinTurID=tur.izinTurID ");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Uyarı");
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtizinHareketID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtPersonelID.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            comboizinTuru.Text = dataGridView1.CurrentRow.Cells["izinTuru"].Value.ToString();
            dateTimeizinBaslangic.Text = dataGridView1.CurrentRow.Cells["izinBaslangic"].Value.ToString();
            dateTimeizinBitis.Text = dataGridView1.CurrentRow.Cells["izinBitis"].Value.ToString();
            txtAciklama.Text = dataGridView1.CurrentRow.Cells["Aciklama"].Value.ToString();

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            izin i = new izin();
            i.IzinHareketID = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            string sql = "delete from izinHareketleri where izinHareketID='" + i.IzinHareketID + "'";
            SqlCommand komut = new SqlCommand();
            try
            {
                veritabani.ESG(komut, sql);
                MessageBox.Show("İzin bilgileri silindi", "Uyari", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                veritabani.Listele_Ara(dataGridView1, "select izinHareketID,PersonelID,KullaniciID,tur.izinTuru,izinBaslangic,izinBitis,İslem,Aciklama,Tarih,Saat from izinHareketleri i, izinTurleri tur where i.izinTurID=tur.izinTurID ");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Uyarı");
            }
        }

        private void btnexeleAktar_Click(object sender, EventArgs e)
        {

        }
    }
}
