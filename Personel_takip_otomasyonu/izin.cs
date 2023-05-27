using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personel_takip_otomasyonu
{
    internal class izin : Personeller
    {
        public izin()
        {
            izin.sql = "select * from izinTurleri";
            izin.values = "izinTurID";
            izin.text = "izinTuru";
        }

        private int _izinHareketID;
        private int _izinTurID;
        private string _KullaniciID;
        private string _izinTuru;
        private DateTime _izinBaslangic;
        private DateTime _izinBitis;
        private DateTime _Saat;

        public int IzinHareketID { get => _izinHareketID; set => _izinHareketID = value; }
        public int IzinTurID { get => _izinTurID; set => _izinTurID = value; }
        public string KullaniciID { get => _KullaniciID; set => _KullaniciID = value; }
        public string IzinTuru { get => _izinTuru; set => _izinTuru = value; }
        public DateTime IzinBaslangic { get => _izinBaslangic; set => _izinBaslangic = value; }
        public DateTime IzinBitis { get => _izinBitis; set => _izinBitis = value; }
        public DateTime Saat { get => _Saat; set => _Saat = value; }

        public static SqlDataReader ListvieweKayitGetir(ListView lst)
        {
            lst.Items.Clear();
            veritabani.baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from izinTurleri", veritabani.baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = read[0].ToString();
                ekle.SubItems.Add(read[1].ToString());
                lst.Items.Add(ekle);
            }
            veritabani.baglanti.Close();
            return read;
        }
    }
}
