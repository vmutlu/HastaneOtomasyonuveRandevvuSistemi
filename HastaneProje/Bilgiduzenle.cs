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

namespace HastaneProje
{
    public partial class Bilgiduzenle : Form
    {
        public Bilgiduzenle()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        public string tc;
        
        private void Bilgiduzenle_Load(object sender, EventArgs e)
        {
            maskedTextBox1.Text =tc;
            SqlCommand baglan = new SqlCommand("Select *from Tbl_Hastalar where HastaTc=@p1", bgl.baglanti());
            baglan.Parameters.AddWithValue("@p1", maskedTextBox1.Text);
            SqlDataReader dr = baglan.ExecuteReader();
            while(dr.Read())
            {
                textBox2.Text = dr[1].ToString();
                textBox3.Text = dr[2].ToString();
                maskedTextBox2.Text = dr[4].ToString();
                textBox1.Text = dr[5].ToString();
                comboBox1.Text = dr[6].ToString();

            }
            bgl.baglanti().Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update Tbl_Hastalar set HastaAd=@p1,HastaSoyad=@p2,HastaTel=@p3,HastaSifre=@p4,HastaCınsıyet=@p5 where HastaTc=@p6", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", textBox2.Text);
            komut.Parameters.AddWithValue("@p2", textBox3.Text);
            komut.Parameters.AddWithValue("@p3", maskedTextBox2.Text);
            komut.Parameters.AddWithValue("@p4", textBox1.Text);
            komut.Parameters.AddWithValue("@p5", comboBox1.Text);
            komut.Parameters.AddWithValue("@p6", maskedTextBox1.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Bilgileriniz Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dene d = new dene();
            d.MdiParent = this.MdiParent;
            d.Show();
            d.Location = new Point(0, 65);
        }
    }
}
