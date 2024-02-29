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

namespace S_CAR
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {

        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=ADMIN-ПК;Initial Catalog=S_Cardb;Integrated Security=True");

        private void btn_qeydiyyat_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Giris_tbl(Ad,Soyad,Istifadead,Email,Dogum,Sifre) values('" + text_ad.Text.ToString() + "','" +
            text_soyad.Text.ToString() + "','" + text_istifadead.Text.ToString() + "','" + text_email.Text.ToString() + "','" + text_dogum.Text.ToString() + "','" + text_sifre.Text.ToString() + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

      
		private void btn_girispaneli_Click(object sender, EventArgs e)
		{

            Giris_Paneli giris = new Giris_Paneli();
            giris.Show();
            this.Hide();
		}
	}
}
