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
    public partial class sekreterdetay : Form
    {
        public sekreterdetay()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
        
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void button4_Click(object sender, EventArgs e)
        {


            doktorpaneli d = new doktorpaneli();
            d.MdiParent = this.MdiParent;
            d.Show();
            d.Location = new Point(0, 65);
        }

        private void sekreterdetay_Load(object sender, EventArgs e)
        {
           

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select *from Tbl_Brans", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            DataTable dt2 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("Select DoktorAd,DoktorSoyad,DoktorBrans from Tbl_Doktorlar", bgl.baglanti());
            da1.Fill(dt2);
            dataGridView2.DataSource = dt2;

            //brans getirme combobax
            SqlCommand k = new SqlCommand("Select BransAd from Tbl_Brans", bgl.baglanti());
            SqlDataReader drr = k.ExecuteReader();
            while(drr.Read())
            {
                comboBox1.Items.Add(drr[0]);
            }
            bgl.baglanti().Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Tbl_Randevular (RandevuTarih,RandevuSaat,RandevuBrans,RandevuDoktor,HastaTc) values (@p1,@p2,@p3,@p4,@p5)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",maskedTextBox1.Text);
            komut.Parameters.AddWithValue("@p2",maskedTextBox2.Text);
            komut.Parameters.AddWithValue("@p3",comboBox1.Text);
            komut.Parameters.AddWithValue("@p4",comboBox2.Text);
            komut.Parameters.AddWithValue("@p5", maskedTextBox3.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Randevu Olusturuldu", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            SqlCommand c = new SqlCommand("Select DoktorAd,DoktorSoyad From Tbl_Doktorlar where DoktorBrans=@p1", bgl.baglanti());
            c.Parameters.AddWithValue("@p1", comboBox1.Text);
            SqlDataReader dr = c.ExecuteReader();
            while(dr.Read())
            {
                comboBox2.Items.Add(dr[0] + " " + dr[1]);
            }
            bgl.baglanti().Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            brans b = new brans();
            b.MdiParent = this.MdiParent;
            b.Show();
            b.Location = new Point(0, 65);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            randevulistesi r = new randevulistesi();
            r.MdiParent = this.MdiParent;
            r.Show();
            r.Location = new Point(0, 65);
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
             Mesaj b = new Mesaj();
            b.MdiParent = this.MdiParent;
            b.Show();
            b.Location = new Point(0, 65);
        }
    }
}
