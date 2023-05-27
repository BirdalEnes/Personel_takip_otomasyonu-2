using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Personel_takip_otomasyonu
{
    internal class YapilanZamlar
    {
        #region zamlar
        private int _ZamID;
        private string _Donem;
        private string _Personel;
        private decimal _Yuzde;
        private decimal _Fiyat;
        private string _Aciklama;
        private DateTime _Tarih;

        public int ZamID { get => _ZamID; set => _ZamID = value; }
        public string Donem { get => _Donem; set => _Donem = value; }
        public string Personel { get => _Personel; set => _Personel = value; }
        public decimal Yuzde { get => _Yuzde; set => _Yuzde = value; }
        public decimal Fiyat { get => _Fiyat; set => _Fiyat = value; }
        public string Aciklama { get => _Aciklama; set => _Aciklama = value; }
        public DateTime Tarih { get => _Tarih; set => _Tarih = value; }
        #endregion

        public static SqlDataReader ComboyaPersonelGetir(ComboBox cmb)
        {
            veritabani.baglanti.Open();
            SqlCommand komut = new SqlCommand("select PersonelID,Adi,Soyadi from Personeller", veritabani.baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                cmb.Items.Add(read[0] + "." + read[1] + " " + read[2]);
            }
            veritabani.baglanti.Close();
            return read;
        }
        public static SqlDataReader ComboSeciliPersonelIDGetir(ComboBox combo, Label lbl_PersonelID)
        {
            veritabani.baglanti.Open();
            SqlCommand komut = new SqlCommand("select PersonelID,Adi,Soyadi from Personeller", veritabani.baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                if (combo.SelectedItem.ToString() == read[0] + "." + read[1] + " " + read[2])
                {
                    lbl_PersonelID.Text = read[0].ToString();
                }
            }
            veritabani.baglanti.Close();
            return read;
        }
    }
}
