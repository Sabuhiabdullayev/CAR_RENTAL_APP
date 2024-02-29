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
    public partial class Masinlarin_Icaresi : Form
    {
        public Masinlarin_Icaresi()
        {
            InitializeComponent();
        }
       
         SqlConnection baglanti = new SqlConnection(@"Data Source=ADMIN-ПК;Initial Catalog=S_Cardb;Integrated Security=True");
        int sayi;
        int toplam = 0;
        private void Form3_Load(object sender, EventArgs e)
        {
        
            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("Select masinad From masin_adlari", baglanti);
            SqlDataReader dr1 = komut1.ExecuteReader();
            while (dr1.Read())
            {
                combo_masinad.Items.Add(dr1[0]);
            }
            baglanti.Close();
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            picture_ozel_sekil.ImageLocation = openFileDialog1.FileName;
            pictur_text.Text = openFileDialog1.FileName;
        }

        private void masin_icare_btn_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            //SqlCommand komut = new SqlCommand("insert into Icare_masinlar(Ad,Soyad,Email,Adress,Telefon,Evtelefon,Masinadi,Masinmodel) values('" + txt_ad.Text.ToString() + "','" + txt_soyad.Text.ToString() + "','" + txt_email.Text.ToString() + "','" + txt_adress.Text.ToString() + "','" +
            //    txt_tel.Text.ToString() + "','" + txt_ev_tel.Text.ToString() + "','"+combo_masinad.Text.ToString()+"',;'"+combo_masinmodel.Text.ToString()+"')", baglanti);
            //komut.ExecuteNonQuery();
            //baglanti.Close();

            try
            {

                SqlCommand komut = new SqlCommand("insert into Icare_masinlar(Ad,Soyad,Email,Adress,Masinadi,Masinmodel,Masinsekil,Telefon,Evtelefon,Sexsiyyet,Ozelsekil,Icarevaxt,il,Qiymet) values(@ad,@soyad,@email,@adress,@masinadi,@masinmodel,@masinsekil,@telefon,@evtelefon,@sexsiyyet,@ozelsekil,@icarevaxt,@il,@qiymet)", baglanti);
                komut.Parameters.AddWithValue("@ad", txt_ad.Text);
                komut.Parameters.AddWithValue("@soyad", txt_soyad.Text);
                komut.Parameters.AddWithValue("@email", txt_email.Text);
                komut.Parameters.AddWithValue("@adress", txt_adress.Text);
                komut.Parameters.AddWithValue("@masinadi", combo_masinad.Text);
                komut.Parameters.AddWithValue("@masinmodel", combo_masinad.Text);
                komut.Parameters.AddWithValue("@masinsekil", masin_pictur.Text);
                komut.Parameters.AddWithValue("@telefon", txt_tel.Text);
                komut.Parameters.AddWithValue("@evtelefon", txt_ev_tel.Text);
                komut.Parameters.AddWithValue("@sexsiyyet", txt_sexsiyyet.Text);
                komut.Parameters.AddWithValue("@ozelsekil", pictur_text.Text);
                komut.Parameters.AddWithValue("@icarevaxt", txt_vaxt.Text);
                komut.Parameters.AddWithValue("@il", masin_ili.Text);
                komut.Parameters.AddWithValue("@qiymet", txt_qiymet.Text);
                komut.ExecuteNonQuery();
                 baglanti.Close();

                MessageBox.Show("Qeyd Olundu");
            }
            catch (Exception)
            {

                MessageBox.Show("Xeta");
            }

           
        }

        private void Picture_masin_btn(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            picture_masin_sekil.ImageLocation = openFileDialog1.FileName;
            masin_pictur.Text = openFileDialog1.FileName;
        }

       

        private void combo_masinadl_SelectedIndexChanged(object sender, EventArgs e)
        {
            combo_masinmodel.Items.Clear();
            combo_masinmodel.Text = "";
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("Select modelad From masin_modelleri where masinid=@1", baglanti);
            komut2.Parameters.AddWithValue("@1", combo_masinad.SelectedIndex + 1);
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                combo_masinmodel.Items.Add(dr2[0]);
            }
            baglanti.Close();
        }

        private void combo_masinmodell_SelectedIndexChanged(object sender, EventArgs e)
        {
            label1.Text = "";

            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("Select qiymet From masin_modelleri where modelid=@2", baglanti);
            komut3.Parameters.AddWithValue("@2", combo_masinmodel.SelectedIndex + 1);

           
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                label_sayi.Text = dr3[0].ToString();
         
            }
            baglanti.Close();
            baglanti.Open();
            SqlCommand komut4 = new SqlCommand("Select masinsekili From masin_modelleri where modelid=@3", baglanti);
            komut4.Parameters.AddWithValue("@3", combo_masinmodel.SelectedIndex + 1);
            SqlDataReader dr4 = komut4.ExecuteReader();
            while (dr4.Read())
            {

                picture_masin_sekil.ImageLocation = dr4[0].ToString();
            }
            baglanti.Close();
            baglanti.Open();
            SqlCommand komut5 = new SqlCommand("Select il From masin_modelleri where modelid=@2", baglanti);
            komut5.Parameters.AddWithValue("@2", combo_masinmodel.SelectedIndex + 1);


            SqlDataReader dr5 = komut5.ExecuteReader();
            while (dr5.Read())
            {
                masin_ili.Text = dr5[0].ToString();

            }
            baglanti.Close();



        }

        private void Txt_vaxt(object sender, EventArgs e)
        {
            sayi = Convert.ToInt16(label_sayi.Text);
            if (txt_vaxt.Text == "1 Gün")
            {
                toplam = sayi * 1;

            }
            if (txt_vaxt.Text == "2 Gün")
            {
                toplam = sayi * 2;

            }
            if (txt_vaxt.Text == "1 Həftə")
            {
                toplam = sayi * 4;

            }
            if (txt_vaxt.Text == "2 Həftə")
            {
                toplam = sayi * 7;

            }
            if (txt_vaxt.Text == "1 Ay")
            {
                toplam = sayi * 11;

            }
            if (txt_vaxt.Text == "2 Ay")
            {
                toplam = sayi * 21;
            }
            if (txt_vaxt.Text == "6 Ay")
            {
                toplam = sayi * 28;

            }
            if (txt_vaxt.Text == "1 İl")
            {
                toplam = sayi * 35;

            }

            txt_qiymet.Text = toplam.ToString() + " AZN";
        }



        
    }
}
