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
    public partial class frmizinturleri : Form
    {
        public frmizinturleri()
        {
            InitializeComponent();
        }

        private void frmizinturleri_Load(object sender, EventArgs e)
        {
            izin.ListvieweKayitGetir(listView1);
        }

        private void temizle()
        {
            txtizinTurID.Text = "";
            txtizinTuru.Text = "";
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {

            try
            {
                izin i = new izin();
                i.IzinTuru = txtizinTuru.Text;
                string sql = "insert into izinTürleri values('" + i.IzinTuru + "')";
                SqlCommand komut = new SqlCommand();
                veritabani.ESG(komut, sql);
                MessageBox.Show("Kayıt Eklendi", "Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Information);
                izin.ListvieweKayitGetir(listView1);
                temizle();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Hata Türü");
            }
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            try
            {
                izin i = new izin();
                i.IzinTurID = int.Parse(txtizinTurID.Text);
                i.IzinTuru = txtizinTuru.Text;
                string sql = "update izinTurleri set izinTuru='" + i.IzinTuru + "' where izinTurID='" + i.IzinTurID + "'";
                SqlCommand komut = new SqlCommand();
                veritabani.ESG(komut, sql);
                MessageBox.Show("Kayıt Güncellendi", "Güncellem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                izin.ListvieweKayitGetir(listView1);
                temizle();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Hata Türü");
            }
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            txtizinTurID.Text = listView1.SelectedItems[0].SubItems[0].Text;
            txtizinTuru.Text = listView1.SelectedItems[0].SubItems[1].Text;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {

                izin i = new izin();
                i.IzinTurID = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
                string sql = "delete from izinTurleri where izinTurID='" + i.IzinTurID + "'";
                SqlCommand komut = new SqlCommand();
                veritabani.ESG(komut, sql);
                MessageBox.Show("Kayıt silindi", "silme", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                izin.ListvieweKayitGetir(listView1);
                temizle();
            }
            else
            {
                MessageBox.Show("Önce kayıt secilmelidir", "uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
