using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personel_takip_otomasyonu
{
    public partial class FrmAnaSayfa : Form
    {
        public FrmAnaSayfa()
        {
            InitializeComponent();
        }

        private void btnDepartman_Click(object sender, EventArgs e)
        {
            frmDepartmanlar depart = new frmDepartmanlar();
            depart.ShowDialog();
        }

        private void btnPersonelEkle_Click(object sender, EventArgs e)
        {
            frmPersonelEkle perso = new frmPersonelEkle();
            perso.ShowDialog();
        }

        private void btnPersonelListele_Click(object sender, EventArgs e)
        {
            frmPersonelListele lst = new frmPersonelListele();
            lst.ShowDialog();
        }

        private void FrmAnaSayfa_Load(object sender, EventArgs e)
        {
            frmKullanici kullanici = new frmKullanici();
            kullanici.ShowDialog();
        }

        private void btnMaasZamları_Click(object sender, EventArgs e)
        {
            frmYapılanZamlar zam = new frmYapılanZamlar();
            zam.ShowDialog();
        }

        private void btnprim_Click(object sender, EventArgs e)
        {
            frmPrimler prim = new frmPrimler();
            prim.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmMesaiEkle frm = new frmMesaiEkle();
            frm.ShowDialog();
        }

        private void btnMesailer_Click(object sender, EventArgs e)
        {
            frmMesailer frm = new frmMesailer();
            frm.ShowDialog();
        }

        private void btnizinHarektEkle_Click(object sender, EventArgs e)
        {
            frmizinHareketEkle frm = new frmizinHareketEkle();
            frm.ShowDialog();
        }

        private void btnizinHareketlistele_Click(object sender, EventArgs e)
        {
            frmizinHareketListele frm = new frmizinHareketListele();
            frm.ShowDialog();
        }

        private void panelIslemler_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
