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
    public partial class frmPersonelListele : Form
    {
        public frmPersonelListele()
        {
            InitializeComponent();
        }

        private void frmPersonelListele_Load(object sender, EventArgs e)
        {
            Personeller.ComboyaDepartmanGetir(cmbDepartman);
            YenileListele();
        }

        private void YenileListele()
        {
            veritabani.Listele_Ara(dataGridView1, "select p.PersonelID,p.Adi,p.Soyadi,p.Telefon,p.Adres,p.Email," + "d.DepartmanID,p.Durumu,p.Maasi,p.GİrisTarihi,p.Aciklama from Personeller p,Departmanlar d" + " where p.DepartmanID = d.DepartmanID  ");
            lblToplamKayit.Text = "Toplam" + (dataGridView1.Rows.Count - 1) + "Kayıt Listelendi ";
            decimal toplammaas = 0;
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                toplammaas += decimal.Parse(dataGridView1.Rows[i].Cells["Maasi"].Value.ToString());
            }
            lblToplamMaas.Text = "Toplam Maaş Tutarı = " + toplammaas.ToString("0.00") + "TL";
        }

        void Temizle()
        {
            dateTimePicker1.Value = DateTime.Now;
            cmbDepartman.Text = "";
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }
        Personeller p = new Personeller();
        Kullanicilar k = new Kullanicilar();
        private void btnGuncelle_Click(object sender, EventArgs e)
        {

            p.PersonelID = int.Parse(txtPersonelID.Text);
            p.Adi = TxtPersonelAd.Text;
            p.Soyadi = txtPersonelSoyad.Text;
            p.Telefon = txtTelefon.Text;
            p.Adres = txtAdres.Text;
            p.Email = txtEmail.Text;
            p.DepartmanID = (int)cmbDepartman.SelectedValue;
            p.Maasi = decimal.Parse(txtMaas.Text);
            p.GirisTarihi = dateTimePicker1.Value;
            p.Aciklama = txtAciklama.Text;
            string sorgu = "Update Personeller set Adi='" + p.Adi + "',Soyadi='" + p.Soyadi + "',Telefon='" + p.Telefon + "',Adres='" + p.Adres + "',Email='" + p.Email + "',DepartmanID='" + p.DepartmanID + "',Maasi=@Maasi,GirisTarihi=@GirisTarihi,Aciklama=@Aciklama" + "where PersonelID";
            SqlCommand komut = new SqlCommand();
            komut.Parameters.Add("@Maasi", SqlDbType.Decimal).Value = p.Maasi;
            komut.Parameters.Add("@GirisTarihi", SqlDbType.Decimal).Value = p.GirisTarihi;
            veritabani.ESG(komut, sorgu);
            p.Islem = p.PersonelID + " nolu personelin bilgileri güncellendi";
            p.Aciklama = "Personel Güncelleme";
            Personeller.PersonelislemEkle(p, k);
            Temizle();
            MessageBox.Show("Kayıt Güncellendi", "Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            YenileListele();
        }
        private void btncikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnSıl_Click(object sender, EventArgs e)
        {

            p.PersonelID = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());

            //string sorgu = "delete from Personeller where PersonelID='" + p.PersonelID + "'";
            //SqlCommand komut = new SqlCommand();
            //veritabani.ESG(komut, sorgu);
            p.CikisTarihi = DateTime.Now;
            string sorgu2 = "update Personeller set durum='Pasif', CikisTarihi=@CikisTarihi where PersonelID='" + p.PersonelID + "'";
            SqlCommand komut2 = new SqlCommand();
            komut2.Parameters.Add("@CikisTarihi", SqlDbType.Date).Value = p.CikisTarihi;
            veritabani.ESG(komut2, sorgu2);
            p.Islem = p.PersonelID + " nolu personel işten çıkarıldı";
            p.Aciklama = "İşten çıkarma ";
            Personeller.PersonelislemEkle(p, k);
            Temizle();
            MessageBox.Show("Kayıt Silindi", "Silme İşlemi ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            YenileListele();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtPersonelID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            TxtPersonelAd.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtPersonelSoyad.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtTelefon.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtAdres.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtEmail.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            cmbDepartman.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            txtMaas.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            dateTimePicker1.Value = DateTime.Parse(dataGridView1.CurrentRow.Cells[9].Value.ToString());
            txtAciklama.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            veritabani.Listele_Ara(dataGridView1, "select p.PersonelID,p.Adi,p.Soyadi,p.Telefon,p.Adres,p.Email," + "d.DepartmanID,p.Durumu,p.Maasi,p.GİrisTarihi,p.Aciklama from " +
              "Personeller p,Departmanlar d" + " where p.DepartmanID = d.DepartmanID and  Adi like '%" + txtPersonelAdıAra.Text + "%'");


        }

        private void txtPersonelIDAra_TextChanged(object sender, EventArgs e)
        {
            veritabani.Listele_Ara(dataGridView1, "select p.PersonelID,p.Adi,p.Soyadi,p.Telefon,p.Adres,p.Email," + "d.DepartmanID,p.Durumu,p.Maasi,p.GİrisTarihi,p.Aciklama from " +
               "Personeller p,Departmanlar d" + " where p.DepartmanID = d.DepartmanID and  PersonelID like '%" + txtPersonelIDAra.Text + "%'");
        }

        private void txtPersonelSoyadAra_TextChanged(object sender, EventArgs e)
        {
            veritabani.Listele_Ara(dataGridView1, "select p.PersonelID,p.Adi,p.Soyadi,p.Telefon,p.Adres,p.Email," + "d.DepartmanID,p.Durumu,p.Maasi,p.GİrisTarihi,p.Aciklama from " +
               "Personeller p,Departmanlar d" + " where p.DepartmanID = d.DepartmanID and  Soyadi like '%" + txtPersonelSoyadAra.Text + "%'");

        }

        private void PersonelTelefonAra_TextChanged(object sender, EventArgs e)
        {
            veritabani.Listele_Ara(dataGridView1, "select p.PersonelID,p.Adi,p.Soyadi,p.Telefon,p.Adres,p.Email," + "d.DepartmanID,p.Durumu,p.Maasi,p.GİrisTarihi,p.Aciklama from " +
               "Personeller p,Departmanlar d" + " where p.DepartmanID = d.DepartmanID and  Telefon like '%" + txtPersonelTelefonAra.Text + "%'");

        }

        private void dateTimePickerGirisTarihi_ValueChanged(object sender, EventArgs e)
        {
            Personeller.TariheGoreAra(dateTimePickerGirisTarihi, dataGridView1);


        }
    }
}
