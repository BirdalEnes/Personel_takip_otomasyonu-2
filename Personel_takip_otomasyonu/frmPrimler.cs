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
    public partial class frmPrimler : Form
    {
        public frmPrimler()
        {
            InitializeComponent();
        }

        private void frmPrimler_Load(object sender, EventArgs e)
        {
            int yil = int.Parse(DateTime.Now.Year.ToString());
            for (int i = yil; i >= (yil - 5); i--)
            {
                comboYil.Items.Add(i);

            }
            veritabani.Listele_Ara(dataGridView1, "select PersonelID,Adi,Soyadi,Maasi,GirisTarihi from Personeller");
        }

        private void btnPrımEkle_Click(object sender, EventArgs e)
        {
            Primler p = new Primler();
            p.KullaniciID = Kullanicilar.kid;
            p.Donem = comboAy.Text + "/" + comboYil.Text;
            p.PrimTutari = decimal.Parse(txtPrımTutarı.Text);
            p.Aciklama = txtAciklama.Text;
            p.Tarih = DateTime.Now;
            if (radioKısıOzel.Checked)
            {
                p.PersonelID = int.Parse(txtPersonelID.Text);
                string sql = "insert into Primler(KullaniciID,PersonelID,Donem,PrimTutari,Aciklama,Tarih)" + " " +
                    "values('" + p.KullaniciID + "','" + p.PersonelID + "','" + p.Donem + "',@PrimTutari,'" + p.Aciklama + "',@Tarih)";
                SqlCommand komut = new SqlCommand();
                komut.Parameters.Add("@PrimTutari", SqlDbType.Decimal).Value = p.PrimTutari;
                komut.Parameters.Add("@Tarih", SqlDbType.Date).Value = p.Tarih;
                veritabani.ESG(komut, sql);
                MessageBox.Show("İşlem Başarılı", "Prim kaydı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (radioTumpersonelPrım.Checked)
            {
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    string sql = "insert into Primler(KullaniciID,PersonelID,Donem,PrimTutari,Aciklama,Tarih)" + " " +
                    "values('" + p.KullaniciID + "','" + dataGridView1.Rows[i].Cells[0].Value + "','" + p.Donem + "',@PrimTutari,'" + p.Aciklama + "',@Tarih)";
                    SqlCommand komut = new SqlCommand();
                    komut.Parameters.Add("@PrimTutari", SqlDbType.Decimal).Value = p.PrimTutari;
                    komut.Parameters.Add("@Tarih", SqlDbType.Date).Value = p.Tarih;
                    veritabani.ESG(komut, sql);
                    MessageBox.Show("İşlem Başarılı", "Prim kaydı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                MessageBox.Show("İşlem Başarılı", "Prim kaydı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            btnTemızle.PerformClick();

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtPersonelID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtPersonelAdSoyad.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString() + "" + dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }

        private void btnPrımGoster_Click(object sender, EventArgs e)
        {
            frmPrimleriGöster prımgoster = new frmPrimleriGöster();
            prımgoster.ShowDialog();
        }

        private void btnPersoneleGorePrım_Click(object sender, EventArgs e)
        {
            frmPrimÖde frm = new frmPrimÖde();
            frm.txtPersonelID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            frm.txtPersonelAdSoyad.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString() + " " +
                dataGridView1.CurrentRow.Cells[2].Value.ToString();
            veritabani.Listele_Ara(frm.dataGridView1,"select * from Primler where PersonelID='"+frm.txtPersonelID.Text+"'");
            frm.ShowDialog();
        }

        private void btnCıkıs_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void btnPersoneleGorePrım_Click_1(object sender, EventArgs e)
        {

        }
    }
}
