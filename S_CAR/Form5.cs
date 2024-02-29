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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=ADMIN-ПК;Initial Catalog=S_Cardb;Integrated Security=True");
     

        private void Form5_Load(object sender, EventArgs e)
        {
          
        }
        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            try
            {
                SqlCommand komut2 = new SqlCommand("insert into masin_modelleri(masinid,modelad,qiymet,il) values(@1,@2,@3,@4)", baglanti);
                komut2.Parameters.AddWithValue("@1", comboBox1.ValueMember);
                komut2.Parameters.AddWithValue("@2", textBox1.Text.ToString());
                komut2.Parameters.AddWithValue("@3", textBox3.Text.ToString());
                komut2.Parameters.AddWithValue("@4", textBox2.Text.ToString());
                komut2.ExecuteNonQuery();
                MessageBox.Show("Qeyd Olundu");
            }
            catch (Exception)
            {

                MessageBox.Show("Qeyd Olunmadi");
            }
            baglanti.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            comboBox2.Text = "";
            baglanti.Open();
            SqlCommand komut22 = new SqlCommand("Select modelad From masin_modelleri where masinid=@1", baglanti);
            komut22.Parameters.AddWithValue("@1", comboBox1.SelectedIndex + 1);
            SqlDataReader dr22 = komut22.ExecuteReader();
            while (dr22.Read())
            {
                comboBox2.Items.Add(dr22[0]);
            }
            baglanti.Close();

         


            textBox4.Text = comboBox1.ValueMember;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("Select qiymet From masin_modelleri where modelid=@2", baglanti);
            komut3.Parameters.AddWithValue("@2", comboBox2.SelectedIndex + 1);


            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                textBox3.Text = dr3[0].ToString();

            }
            baglanti.Close();
            baglanti.Open();
            SqlCommand komut4 = new SqlCommand("Select masinsekili From qiymet_tbl where modelid=@3", baglanti);
            komut4.Parameters.AddWithValue("@3", comboBox2.SelectedIndex + 1);
            SqlDataReader dr4 = komut4.ExecuteReader();
            while (dr4.Read())
            {

                pictureBox1.ImageLocation = dr4[0].ToString();
            }
            baglanti.Close();

        }
    }
    }

