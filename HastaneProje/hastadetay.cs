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
    public partial class hastadetay : Form
    {
        public hastadetay()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void label3_Click(object sender, EventArgs e)
        {

        }
        public string tc;
        private void hastadetay_Load(object sender, EventArgs e)
        {
             label2.Text = tc;

           


            /*  SqlCommand komut = new SqlCommand("Select HastaAd,HastaSoyad from Tbl_Hastalar where HastaTc=@p1", bgl.baglanti());
            //  komut.Parameters.AddWithValue("@p1", label2.Text);
              SqlDataReader dr = komut.ExecuteReader();
              while(dr.Read())
              {
                 // label4.Text = dr[0] +" "+ dr[1];
              }
              bgl.baglanti().Close();

              //randevu gecmısı
              */



            //SqlDataAdapter da = new SqlDataAdapter("Select * from Tbl_Randevular where HastaTc ="+tc, bgl.baglanti());
            //DataTable dt = new DataTable();
            //da.Fill(dt);
            //dataGridView1.DataSource = dt;

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select *from Tbl_Randevular where HastaTc='59677075804'" , bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            //Branslar

            SqlCommand kt = new SqlCommand("Select BransAd from Tbl_Brans",bgl.baglanti());
            SqlDataReader dr2 = kt.ExecuteReader();
            while(dr2.Read())
            {
                comboBox4.Items.Add(dr2[0]);
            }
            bgl.baglanti().Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Bilgiduzenle d = new Bilgiduzenle();
            d.MdiParent = this.MdiParent;
            d.Show();
            d.Location = new Point(0, 65);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Tbl_Randevular (RandevuTarih,RandevuSaat,RandevuBrans,RandevuDoktor,HastaTc) values (@p1,@p2,@p3,@p4,@p5)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", maskedTextBox1.Text);
            komut.Parameters.AddWithValue("@p2", maskedTextBox2.Text);
            komut.Parameters.AddWithValue("@p3", comboBox4.Text);
            komut.Parameters.AddWithValue("@p4", comboBox3.Text);
            komut.Parameters.AddWithValue("@p5", maskedTextBox3.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Randevu Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           



        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox3.Items.Clear();
            SqlCommand komut = new SqlCommand("Select DoktorAd,DoktorSoyad from Tbl_Doktorlar where DoktorBrans=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", comboBox4.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                comboBox3.Items.Add(dr[0] + " " + dr[1]);
            }
            bgl.baglanti().Close();

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("Select *from Tbl_Randevular where RandevuBrans='" + comboBox4.Text + "'" + "and RandevuDoktor='" + comboBox3.Text + "'and RandevuDurum=0", bgl.baglanti());
            da1.Fill(dt1);
            dataGridView2.DataSource = dt1; //
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int sec = dataGridView2.SelectedCells[0].RowIndex;
            textBox2.Text = dataGridView2.Rows[sec].Cells[0].Value.ToString();
        }
    }
}
