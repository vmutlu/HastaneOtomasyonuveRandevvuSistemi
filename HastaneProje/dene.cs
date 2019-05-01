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
    public partial class dene : Form
    {
        public dene()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
       
        
        public string tc;
        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

       

        private void button1_Click(object sender, EventArgs e)
        { 
            kayıtkontrol();
           // if(durum==true)
           // {

            
            SqlCommand komut = new SqlCommand("insert into Tbl_Randevular (RandevuTarih,RandevuSaat,RandevuBrans,RandevuDoktor,HastaTc) values (@p1,@p2,@p3,@p4,@p5)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", label2.Text);
            komut.Parameters.AddWithValue("@p2", label5.Text);
            komut.Parameters.AddWithValue("@p3", comboBox4.Text);
            komut.Parameters.AddWithValue("@p4", comboBox3.Text);
            komut.Parameters.AddWithValue("@p5", maskedTextBox3.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Randevu Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
          //  }
           /* else
            {
                MessageBox.Show("Bu Tarih ve saatte randevu vardır.Randevu alamazsınız");
            }*/
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            label2.Text = monthCalendar1.SelectionStart.ToShortDateString();
        }
        bool durum=true;
        private void kayıtkontrol()
        {
            durum = true;
          
            SqlCommand komut = new SqlCommand("Select *from Tbl_Randevular", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                if (maskedTextBox3.Text == "59677075804")
                {
                    if (label2.Text == dr["RandevuTarih"].ToString())
                    {
                        durum = false;
                        if (label5.Text == dr["RandevuSaat"].ToString())
                        {

                            durum = false;
                        }

                    }
                }
                if(maskedTextBox3.Text=="11111111111")
                {

                }
               
            }
            bgl.baglanti().Close();


        }
        void listele()
        {

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select RandevuTarih,RandevuSaat,RandevuBrans RandevuDoktor,HastaTc  from Tbl_Randevular where HastaTc='"+maskedTextBox3.Text.ToString()+"' ", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void dene_Load(object sender, EventArgs e)
        {
           
            SqlCommand komut = new SqlCommand("Select *from Tbl_Randevular", bgl.baglanti());
            SqlDataReader drr = komut.ExecuteReader();
            while (drr.Read())
            {
              
                    if (drr["RandevuTarih"].ToString() == dataGridView1.ToString())
                    {

                        if (drr["RandevuSaat"].ToString() == button2.Text)
                        {
                            button2.Enabled = false;

                        }
                        else if (drr["RandevuSaat"].ToString() == button3.Text)
                        {
                            button3.Enabled = false;
                        }
                        else if (drr["RandevuSaat"].ToString() == button4.Text)
                        {
                            button4.Enabled = false;
                        }
                        else if (drr["RandevuSaat"].ToString() == button5.Text)
                        {
                            button5.Enabled = false;
                        }
                        else if (drr["RandevuSaat"].ToString() == button6.Text)
                        {
                            button6.Enabled = false;
                        }
                        else if (drr["RandevuSaat"].ToString() == button7.Text)
                        {
                            button7.Enabled = false;
                        }
                        else if (drr["RandevuSaat"].ToString() == button8.Text)
                        {
                            button8.Enabled = false;
                        }
                        else if (drr["RandevuSaat"].ToString() == button9.Text)
                        {
                            button9.Enabled = false;
                        }
                        else if (drr["RandevuSaat"].ToString() == button10.Text)
                        {
                            button10.Enabled = false;
                        }
                        else if (drr["RandevuSaat"].ToString() == button11.Text)
                        {
                            button11.Enabled = false;
                        }
                        else if (drr["RandevuSaat"].ToString() == button12.Text)
                        {
                            button12.Enabled = false;
                        }
                        else if (drr["RandevuSaat"].ToString() == button13.Text)
                        {
                            button13.Enabled = false;
                        }

                    }
              
            }
            bgl.baglanti().Close();


            maskedTextBox3.Text = tc;
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select RandevuTarih,RandevuSaat,RandevuBrans,RandevuDoktor,HastaTc from Tbl_Randevular  where HastaTc='" + maskedTextBox3.Text.ToString()+ "' ", bgl.baglanti());
            
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            SqlCommand kt = new SqlCommand("Select BransAd from Tbl_Brans", bgl.baglanti());
            SqlDataReader dr2 = kt.ExecuteReader();
            while (dr2.Read())
            {
                comboBox4.Items.Add(dr2[0]);
            }
            bgl.baglanti().Close();


            SqlCommand baglan = new SqlCommand("Select *from Tbl_Hastalar where HastaTc=@p1", bgl.baglanti());
            baglan.Parameters.AddWithValue("@p1", maskedTextBox3.Text);
            SqlDataReader dr = baglan.ExecuteReader();
            while (dr.Read())
            {
                textBox1.Text = dr[1].ToString();
                textBox3.Text = dr[2].ToString();
                maskedTextBox2.Text = dr[4].ToString();
                textBox4.Text = dr[5].ToString();
                comboBox1.Text = dr[6].ToString();

            }
            bgl.baglanti().Close();


        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
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

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Bilgiduzenle d = new Bilgiduzenle();
            d.MdiParent = this.MdiParent;
            d.tc = maskedTextBox3.Text;
            d.Show();
            d.Location = new Point(0, 65);
        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label5.Text = button2.Text;
            button2.Enabled = false;
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label5.Text = button3.Text;
            button3.Enabled = false;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            label5.Text = button4.Text;
            button4.Enabled = false;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            label5.Text = button5.Text;
            button5.Enabled = false;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            label5.Text = button6.Text;
            button6.Enabled = false;

        }

        private void button7_Click(object sender, EventArgs e)
        {
            label5.Text = button7.Text;
            button7.Enabled = false;

        }

        private void button8_Click(object sender, EventArgs e)
        {
            label5.Text = button8.Text;
            button8.Enabled = false;

        }

        private void button9_Click(object sender, EventArgs e)
        {
            label5.Text = button9.Text;
            button9.Enabled = false;

        }

        private void button10_Click(object sender, EventArgs e)
        {
            label5.Text = button10.Text;
            button10.Enabled = false;

        }

        private void button11_Click(object sender, EventArgs e)
        {
            label5.Text = button11.Text;
            button11.Enabled = false;

        }

        private void button12_Click(object sender, EventArgs e)
        {
            label5.Text = button12.Text;
            button12.Enabled = false;

        }

        private void button13_Click(object sender, EventArgs e)
        {
            label5.Text = button13.Text;
            button13.Enabled = false;

        }
    }
}
