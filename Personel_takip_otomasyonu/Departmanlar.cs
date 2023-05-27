using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personel_takip_otomasyonu
{
    internal class Departmanlar
    {
        private int _DepartmanID;
        private string _Departman;
        private string _Aciklama;

        public int DepartmanID { get => _DepartmanID; set => _DepartmanID = value; }
        public string Departman { get => _Departman; set => _Departman = value; }
        public string Aciklama { get => _Aciklama; set => _Aciklama = value; }

        public static SqlDataReader DepartmanGetir(ListView lst)
        {
            lst.Items.Clear();
            veritabani.baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from Departmanlar", veritabani.baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = read[0].ToString();
                ekle.SubItems.Add(read[1].ToString());
                ekle.SubItems.Add(read[2].ToString());
                lst.Items.Add(ekle);
            }
            veritabani.baglanti.Close();
            return read;
        }
    }
}
