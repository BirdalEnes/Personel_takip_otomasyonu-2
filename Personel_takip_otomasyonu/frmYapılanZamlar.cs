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
    public partial class frmYapılanZamlar : Form
    {
        public frmYapılanZamlar()
        {
            InitializeComponent();
            cmPersonel.SelectedIndex = 0;
            radioYuzde.Checked = true;
        }

        private void btncikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmYapılanZamlar_Load(object sender, EventArgs e)
        {
            int yil = int.Parse(DateTime.Now.Year.ToString());
            for (int i = yil; i >= (yil - 5); i--)
            {
                comboYil.Items.Add(i);

            }
            YapilanZamlar.ComboyaPersonelGetir(cmPersonel);
        }

        private void radioYuzde_CheckedChanged(object sender, EventArgs e)
        {
            txtZam.Enabled = false;
            txtYuzde.Enabled = true;
        }

        private void radioFıyat_CheckedChanged(object sender, EventArgs e)
        {
            txtYuzde.Enabled = false;
            txtZam.Enabled = true;

        }

        private void cmPersonel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmPersonel.SelectedIndex == 0)
            {
                lblPersonelID.Text = "0";
                return;
            }
            YapilanZamlar.ComboSeciliPersonelIDGetir(cmPersonel, lblPersonelID);
        }

        private void btnOnay_Click(object sender, EventArgs e)
        {
            Kullanicilar k = new Kullanicilar();
            YapilanZamlar y = new YapilanZamlar();
            y.Donem = comboAy.Text + "/" + comboYil.Text;
            y.Personel = cmPersonel.Text;
            k.KullaniciID = Kullanicilar.kid;

            y.Aciklama = txtAciklama.Text;
            y.Tarih = DateTime.Now;

            if (radioYuzde.Checked)
            {
                y.Yuzde = decimal.Parse(txtYuzde.Text);
                if (cmPersonel.SelectedIndex == 0)
                {
                    string sql = "update Personeller set Maasi=Maasi+(Maasi*'" + y.Yuzde + "')/100";
                    SqlCommand komut = new SqlCommand();
                    veritabani.ESG(komut, sql);
                    MessageBox.Show("Tüm Personellerin Maaşına " + y.Yuzde + " Zam Yapıldı", "Maaş Zammı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    string sql = "update Personeller set Maasi=Maasi+(Maasi*'" + y.Yuzde + "')/100 where PersonelID='" + lblPersonelID.Text + "'";
                    SqlCommand komut = new SqlCommand();
                    veritabani.ESG(komut, sql);
                    MessageBox.Show("" + cmPersonel.Text + " Personelinin Maaşına " + y.Yuzde + " Zam Yapıldı", "Maaş Zammı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                string sql2 = "insert into YapilanZamlar(KullaniciID,Donem,Personeller,Yuzde,Aciklma,Tarih)" + "values('" + k.KullaniciID + "','" + y.Donem + "','" + y.Personel + "',@Yuzde,'" + k.Aciklama + "',@Tarih)";
                SqlCommand komut2 = new SqlCommand();
                komut2.Parameters.Add("@Yuzde", SqlDbType.Decimal).Value = y.Yuzde;
                komut2.Parameters.Add("@Tarih", SqlDbType.Date).Value = y.Tarih;

                veritabani.ESG(komut2, sql2);
            }
            if (radioFıyat.Checked)
            {
                y.Fiyat = decimal.Parse(txtZam.Text);
                if (cmPersonel.SelectedIndex == 0)
                {
                    string sql = "update Personeller set Maasi=Maasi+'" + y.Fiyat + "'";
                    SqlCommand komut = new SqlCommand();
                    veritabani.ESG(komut, sql);
                    MessageBox.Show("Tüm Personellerin Maaşına " + y.Fiyat + " TL Zam Yapıldı", "Maaş Zammı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    string sql = "update Personeller set Maasi=Maasi+'" + y.Fiyat + "'where PersonelID='" + lblPersonelID.Text + "'";
                    SqlCommand komut = new SqlCommand();
                    veritabani.ESG(komut, sql);
                    MessageBox.Show("" + cmPersonel.Text + " Personelinin Maaşına " + y.Fiyat + " TL Zam Yapıldı", "Maaş Zammı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                string sql2 = "insert into YapilanZamlar(KullaniciID,Donem,Personeller,Fiyat,Aciklma,Tarih)" + "values('" + k.KullaniciID + "','" + y.Donem + "','" + y.Personel + "',@Fiyat,'" + k.Aciklama + "',@Tarih)";
                SqlCommand komut2 = new SqlCommand();
                komut2.Parameters.Add("@Fiyat", SqlDbType.Decimal).Value = y.Fiyat;
                komut2.Parameters.Add("@Tarih", SqlDbType.Date).Value = y.Tarih;
            }
        }
    }
}
