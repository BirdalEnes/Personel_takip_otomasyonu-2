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
    public partial class frmDepartmanlar : Form
    {
        public frmDepartmanlar()
        {
            InitializeComponent();
        }

        private void frmDepartmanlar_Load(object sender, EventArgs e)
        {
            Departmanlar.DepartmanGetir(listView1);
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            Departmanlar d = new Departmanlar();
            d.Departman = txtDepartman.Text;
            d.Aciklama = txtAciklama.Text;

            string sorgu = "insert into Departmanlar values('" + d.Departman + "','" + d.Aciklama + "')";
            SqlCommand komut = new SqlCommand("", veritabani.baglanti);
            veritabani.ESG(komut, sorgu);
            MessageBox.Show("Kayıt Eklendi");
            Departmanlar.DepartmanGetir(listView1);
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            Departmanlar d = new Departmanlar();
            d.DepartmanID = int.Parse(txtDepartmanID.Text);
            d.Departman = txtDepartman.Text;
            d.Aciklama = txtAciklama.Text;

            string sorgu = "update Departmanlar set departman='" + d.Departman + "',aciklama='" + d.Aciklama + "' where DepartmanID='" + d.DepartmanID + "'";
            SqlCommand komut = new SqlCommand("", veritabani.baglanti);
            veritabani.ESG(komut, sorgu);
            MessageBox.Show("Kayıt Güncellendi");
            Departmanlar.DepartmanGetir(listView1);
        }

        private void btnsıl_Click(object sender, EventArgs e)
        {

            if (listView1.SelectedItems.Count > 0)
            {
                Departmanlar d = new Departmanlar();
                d.DepartmanID = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);

                string sorgu = "delete from departmanlar where departmanID='" + d.Departman + "' ";
                SqlCommand komut = new SqlCommand("", veritabani.baglanti);
                veritabani.ESG(komut, sorgu);
                MessageBox.Show("Kayıt Silindi");
                Departmanlar.DepartmanGetir(listView1);
            }
            else
            {
                MessageBox.Show("Önce Kayıt Secilmelidir", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btncikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            txtDepartmanID.Text = listView1.SelectedItems[0].SubItems[0].Text;
            txtDepartman.Text = listView1.SelectedItems[0].SubItems[1].Text;
            txtAciklama.Text = listView1.SelectedItems[0].SubItems[2].Text;
        }
    }
}
