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
    public partial class Sisteme_masin_qebulu : Form
    {
        public Sisteme_masin_qebulu()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=ADMIN-ПК;Initial Catalog=S_Cardb;Integrated Security=True");
        private void Sisteme_masin_qebulu_Load(object sender, EventArgs e)
        {

            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select masinid,masinad From masin_adlari", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                comboBox_Adi.Items.Add(dr["masinad"].ToString());
                comboBox_Adi.DisplayMember = (dr["masinad"].ToString());
                comboBox_Adi.ValueMember = (dr["masinid"].ToString());

            }
            baglanti.Close();

        }

        private void btn_picture_sekil_open_Click(object sender, EventArgs e)
        {
              openFileDialog1.ShowDialog();
            pictureBox_sekil.ImageLocation = openFileDialog1.FileName;
        }

        private void xuiSuperButton1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            try
            {
                SqlCommand komut2 = new SqlCommand("insert into masin_modelleri(masinid,modelad,il,masinsekili,qiymet) values(@1,@2,@3,@4,@5)", baglanti);
                komut2.Parameters.AddWithValue("@1", comboBox_Adi.ValueMember);
                komut2.Parameters.AddWithValue("@2", txt_masinmodel.Text.ToString());
                komut2.Parameters.AddWithValue("@3", txt_IL.Text.ToString());
                komut2.Parameters.AddWithValue("@4", pictureBox_sekil.ImageLocation.ToString());
                komut2.Parameters.AddWithValue("@5", txt_qiymet.Text.ToString());
                komut2.ExecuteNonQuery();
                MessageBox.Show("Qeyd Olundu");
            }
            catch (Exception)
            {

                MessageBox.Show("Qeyd Olunmadi");
            }
            baglanti.Close();
        }

        private void txt_masinmodel_TextChanged(object sender, EventArgs e)
        {

        }

		private void comboBox_Adi_SelectedIndexChanged(object sender, EventArgs e)
		{
            comboBox_Adi.Items.Clear();
            comboBox_Adi.Text = "";
            baglanti.Open();
            SqlCommand komut22 = new SqlCommand("Select modelad From masin_modelleri where masinid=@1", baglanti);
            komut22.Parameters.AddWithValue("@1", comboBox_Adi.SelectedIndex + 1);
            SqlDataReader dr22 = komut22.ExecuteReader();
            while (dr22.Read())
            {
                comboBox_Adi.Items.Add(dr22[0]);
            }
            baglanti.Close();

        }
    }
}
