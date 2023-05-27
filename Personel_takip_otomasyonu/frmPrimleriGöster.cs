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
    public partial class frmPrimleriGöster : Form
    {
        public frmPrimleriGöster()
        {
            InitializeComponent();
        }

        private void frmPrimleriGöster_Load(object sender, EventArgs e)
        {
            veritabani.Listele_Ara(dataGridView1, "select * from Primler");
            int yil = int.Parse(DateTime.Now.Year.ToString());
            for (int i = yil; i >= (yil - 5); i--)
            {
                comboYil.Items.Add(i);

            }

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow.Cells["OdemeDurumu"].Value.ToString() == "Ödenmedi")
            {
                txtPrımID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txtPersonelID.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txtPrımTutarı.Text = dataGridView1.CurrentRow.Cells["PrimTutari"].Value.ToString();
                txtAciklama.Text = dataGridView1.CurrentRow.Cells["Aciklama"].Value.ToString();
            }
        }

        private void txtPersonelID_TextChanged(object sender, EventArgs e)
        {
            Primler.PersonelAdSoyadGetir(txtPersonelID, txtPersonelAdSoyad);
        }

        private void btnDonemDegıstır_Click(object sender, EventArgs e)
        {
            Kullanicilar k = new Kullanicilar();
            k.KullaniciID = Kullanicilar.kid;
            Primler p = new Primler();
            p.Donem = comboAy.Text + "/" + comboYil.Text;
            p.PrimID = int.Parse(txtPrımID.Text);
            p.PersonelID = int.Parse(txtPersonelID.Text);
            p.Islem = "Dönem Bilgisi Değişti";
            p.Aciklama = "Secili kaydın dönem bilgisi değişti";
            p.Tarih = DateTime.Now;
            string sql = "update Primler set Donem='" + p.Donem + "' where PrımID='" + p.PrimID + "'";
            SqlCommand komut = new SqlCommand();
            veritabani.ESG(komut, sql);

            string sql2 = "insert into PrimHareketleri values('" + k.KullaniciID + "','" + p.PersonelID + "'," +
                "'" + p.PrimID + "','" + p.Islem + "','" + p.Aciklama + "',@Tarih) ";
            SqlCommand komut2 = new SqlCommand();
            komut2.Parameters.Add("@Tarih", SqlDbType.Date).Value = p.Tarih;
            veritabani.ESG(komut2, sql2);

            veritabani.Listele_Ara(dataGridView1, "select * from Primler");
            MessageBox.Show("Prim için dönem değişikliği yapıldı", "Dönem Değişikliği", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnTemızle.PerformClick();
        }

        private void btnTumPrımlerıOde_Click(object sender, EventArgs e)
        {
            Primler p = new Primler();
            p.OdemeDurumu = "Ödendi";
            string sql = "update Primler set OdemeDonem='" + p.OdemeDurumu + "' where OdemeDurumu='Ödenmedi'";
            SqlCommand komut = new SqlCommand();
            veritabani.ESG(komut, sql);

            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                if (dataGridView1.Rows[i].Cells["OdemeDurumu"].Value.ToString() == "Ödenmedi")
                {
                    Kullanicilar k = new Kullanicilar();
                    k.KullaniciID = Kullanicilar.kid;
                    p.PersonelID = int.Parse(dataGridView1.Rows[i].Cells["PersonelID"].Value.ToString());
                    p.PrimID = int.Parse(dataGridView1.Rows[i].Cells["PrımID"].Value.ToString());
                    p.Islem = "Tüm personellerin ödenmeyen primleri ödendi";
                    p.Aciklama = "Tüm personellerin ödenmeyen primleri ödendi";

                    string sql2 = "insert into PrimHareketleri values('" + k.KullaniciID + "','" + p.PersonelID + "'," +
               "'" + p.PrimID + "','" + p.Islem + "','" + p.Aciklama + "',@Tarih) ";
                    SqlCommand komut2 = new SqlCommand();
                    komut2.Parameters.Add("@Tarih", SqlDbType.Date).Value = p.Tarih;
                    veritabani.ESG(komut2, sql2);
                }
            }



            veritabani.Listele_Ara(dataGridView1, "select * from Primler");
            MessageBox.Show("Ödenmeyen Tüm Primler Ödendi", "Prim Ödemeleri", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnTemızle.PerformClick();
        }

        private void PrımOde_Click(object sender, EventArgs e)
        {
            Kullanicilar k = new Kullanicilar();
            k.KullaniciID = Kullanicilar.kid;
            Primler p = new Primler();
            p.PersonelID = int.Parse(txtPersonelID.Text);
            p.Aciklama = txtAciklama.Text;
            p.Islem = p.PersonelID + "nolu personel" + txtPersonelAdSoyad.Text + "için ödeme yapıldı";
            p.Tarih = DateTime.Now;
            p.OdemeDurumu = "Ödendi";
            p.PrimID = int.Parse(txtPrımID.Text);
            string sql = "update Primler set OdemeDonem='" + p.OdemeDurumu + "' where PrımId='" + p.PrimID + "'";
            SqlCommand komut = new SqlCommand();
            veritabani.ESG(komut, sql);
            string sql2 = "insert into PrimHareketleri values('" + k.KullaniciID + "','" + p.PersonelID + "','" + p.PrimID + "','" + p.Islem + "','" + p.Aciklama + "',@Tarih)";
            SqlCommand komut2 = new SqlCommand();
            veritabani.Listele_Ara(dataGridView1, "select * from Primler");
            komut2.Parameters.Add("@Tarih", SqlDbType.Date).Value = p.Tarih;
            veritabani.ESG(komut2, sql2);
            MessageBox.Show("Secili kayda göre Prim Ödendi", "Prim Ödemeleri", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnTemızle.PerformClick();
        }

        private void btnTemızle_Click(object sender, EventArgs e)
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
            }
        }

        private void btnCıkıs_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPrımGuncelle_Click(object sender, EventArgs e)
        {
            Kullanicilar k = new Kullanicilar();
            k.KullaniciID = Kullanicilar.kid;
            Primler p = new Primler();
            p.PrimID = int.Parse(txtPrımID.Text);
            p.PersonelID = int.Parse(txtPersonelID.Text);
            p.PrimTutari = decimal.Parse(txtPrımTutarı.Text);
            p.Aciklama = txtAciklama.Text;
            p.Islem = p.PrimID + "bilgileri değiştirildi";
            string sql = "update Primler set PersonelID='" + p.PersonelID + "',PrimTutari=@PrimTutari,Aciklama='" + p.Aciklama + "' where PrımId='" + p.PrimID + "'";
            SqlCommand komut = new SqlCommand();
            veritabani.ESG(komut, sql);
            /////////
            string sql2 = "insert into PrimHareketleri values('" + k.KullaniciID + "','" + p.PersonelID + "','" + p.PrimID + "','" + p.Islem + "','" + p.Aciklama + "',@Tarih)";
            SqlCommand komut2 = new SqlCommand();
            veritabani.Listele_Ara(dataGridView1, "select * from Primler");
            komut2.Parameters.Add("@Tarih", SqlDbType.Date).Value = p.Tarih;
            veritabani.ESG(komut2, sql2);
            //////////
            veritabani.Listele_Ara(dataGridView1, "select * from Primler");
            MessageBox.Show("Secili kaydın Prim Bİlgileri Güncellendi", "Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnTemızle.PerformClick();
        }

        private void btnPrımSıl_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Kayıt Silinsin mi?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Kullanicilar k = new Kullanicilar();
                k.KullaniciID = Kullanicilar.kid;
                Primler p = new Primler();
                p.PersonelID = int.Parse(dataGridView1.CurrentRow.Cells["PersonelId"].Value.ToString());
                p.PrimID = int.Parse(dataGridView1.CurrentRow.Cells["PrimId"].Value.ToString());
                p.Aciklama = "Kayıt Silindi";
                p.Islem = p.PrimID + "Nolu Prim Kaydı Silindi";


                string sql = "delete from Primler where PrımId='" + p.PrimID + "'";
                SqlCommand komut = new SqlCommand();
                komut.Parameters.AddWithValue("@PrimTutari", SqlDbType.Decimal).Value = p.PrimTutari;
                veritabani.ESG(komut, sql);
                ////////////
                string sql2 = "insert into PrimHareketleri values('" + k.KullaniciID + "','" + p.PersonelID + "','" + p.PrimID + "','" + p.Islem + "','" + p.Aciklama + "',@Tarih)";
                SqlCommand komut2 = new SqlCommand();
                veritabani.Listele_Ara(dataGridView1, "select * from Primler");
                komut2.Parameters.Add("@Tarih", SqlDbType.Date).Value = p.Tarih;
                veritabani.ESG(komut2, sql2);
                ////////////

                veritabani.Listele_Ara(dataGridView1, "select * from Primler");
                MessageBox.Show("Prim Kaydı Silindi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnTemızle.PerformClick();
            }
        }

    }
}
