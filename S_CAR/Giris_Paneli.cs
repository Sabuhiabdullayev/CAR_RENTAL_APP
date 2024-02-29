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

namespace S_CAR
{
    public partial class Giris_Paneli : Form
    {
        public Giris_Paneli()
        {
            InitializeComponent();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (check_pas_show.Checked == true)
            {
                text_password.UseSystemPasswordChar = false;

            }
            else
            {
                text_password.UseSystemPasswordChar = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        SqlConnection baglanti = new SqlConnection(@"Data Source=ADMIN-ПК;Initial Catalog=S_Cardb;Integrated Security=True");

        private void btn_giris_Click(object sender, EventArgs e)
        {

            baglanti.Open();
            string sql = "Select * From Giris_tbl where Istifadead=@adi And Sifre=@sifresi";
            SqlParameter prm1 = new SqlParameter("adi", text_admin.Text.Trim());
            SqlParameter prm2 = new SqlParameter("sifresi", text_password.Text.Trim());
            SqlCommand komut = new SqlCommand(sql, baglanti);
            komut.Parameters.Add(prm1);
            komut.Parameters.Add(prm2);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(komut);
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                Form form3 = new Masinlarin_Icaresi();
                form3.Show();
                this.Hide();

            }
            else
            {
                text_password.ForeColor = Color.Red;
                errorProvider1.SetError(text_password, "Istifadeci Adi veya Sifre Sehvi!");

            }


            //string kayit = "insert into Admin_tbl(Admin,Sifre) values(@Admin,@Sifre)";
            //SqlCommand komut = new SqlCommand(kayit, baglanti);
            //komut.Parameters.AddWithValue("@Admin", text_admin.Text);
            //komut.Parameters.AddWithValue("@Sifre", text_password.Text);
            //komut.ExecuteNonQuery();


            baglanti.Close();


        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 formqeydiyyat = new Form2();
            formqeydiyyat.Show();
            this.Hide();
        }

        private void text_password_TextChanged(object sender, EventArgs e)
        {
            text_password.ForeColor = Color.White;
        }
    }
}