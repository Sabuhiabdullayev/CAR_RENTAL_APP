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
    public partial class S_CARS_Form : Form
    {
        public S_CARS_Form()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=ADMIN-ПК;Initial Catalog=S_Cardb;Integrated Security=True");

        private void S_CARS_Form_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * From Icare_masinlar", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = (dr["id"]).ToString();
                ekle.SubItems.Add(dr["Ad"].ToString());
                ekle.SubItems.Add(dr["Soyad"].ToString());
                ekle.SubItems.Add(dr["Email"].ToString());
                ekle.SubItems.Add(dr["Adress"].ToString());
                ekle.SubItems.Add(dr["Masinadi"].ToString());
                ekle.SubItems.Add(dr["Masinmodel"].ToString());
                ekle.SubItems.Add(dr["Telefon"].ToString());
                ekle.SubItems.Add(dr["Evtelefon"].ToString());
                ekle.SubItems.Add(dr["Sexsiyyet"].ToString());
                ekle.SubItems.Add(dr["Icarevaxt"].ToString());
                ekle.SubItems.Add(dr["il"].ToString());
                ekle.SubItems.Add(dr["Qiymet"].ToString());
                listView1.Items.Add(ekle);
            }
            baglanti.Close();
        }

        private void maşınİcarəyəVerməkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Masinlarin_Icaresi form3 = new Masinlarin_Icaresi();
            form3.TopLevel = false;
            panel1.Controls.Add(form3);
            form3.Show();
            form3.Dock = DockStyle.Fill;
            form3.BringToFront();
        }

        private void təzəMaşınıQəbulEtməkToolStripMenuItem_Click(object sender, EventArgs e)
        {

            panel1.Controls.Clear();
            Sisteme_masin_qebulu masinqebulu = new Sisteme_masin_qebulu();
            masinqebulu.TopLevel = false;
            panel1.Controls.Add(masinqebulu);
            masinqebulu.Show();
            masinqebulu.Dock = DockStyle.Fill;
            masinqebulu.BringToFront();
        }

        private void icaredekiMaşınlarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
         
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
