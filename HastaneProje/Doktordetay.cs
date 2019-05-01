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
    public partial class Doktordetay : Form
    {
        public Doktordetay()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
        public string tc;
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void Doktordetay_Load(object sender, EventArgs e)
        {
           
            label2.Text = tc;
            SqlCommand komut = new SqlCommand("Select DoktorAd,DoktorSoyad from Tbl_Doktorlar where DoktorTc=@p1 ", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", label2.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while(dr.Read())
            {
                label4.Text = dr[0] + " " + dr[1];
                textBox1.Text = "İyi Günler Sekreter Hanım Ben:"+" "+ label4.Text;
            }
            bgl.baglanti().Close();





            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select  RandevuTarih,RandevuSaat,Tbl_Hastalar.HastaAd,Tbl_Hastalar.HastaSoyad,Tbl_Hastalar.HastaTc  From Tbl_Hastalar inner join Tbl_Randevular on Tbl_Randevular.HastaTc=Tbl_Hastalar.HastaTc where RandevuDoktor='" + label4.Text+"'order by RandevuTarih", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            /*"Select RandevuTarih,RandevuSaat,RandevuBrans,RandevuDoktor,HastaTc from Tbl_Randevular where RandevuDoktor='" + label4.Text + "' Order By RandevuTarih*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Recete r = new Recete();
            r.MdiParent = this.MdiParent;
            r.ad = label4.Text;
            r.Show();
            r.Location = new Point(0, 65);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Tbl_Mesaj (Mesaj) values (@p1)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", textBox1.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Mesajınız Gönderildi", "Gönderildi Bilgisi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
