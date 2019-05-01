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
    public partial class sekretergiris : Form
    {
        public sekretergiris()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                if (maskedTextBox1.Text == "59677075804" && textBox1.Text == "1234")
                {
                    SqlCommand komut = new SqlCommand("Select * from Tbl_Sekreter where SekreterTc=@p1 and SekreterSıfre=@p2", bgl.baglanti());
                    komut.Parameters.AddWithValue("@p1", maskedTextBox1.Text);
                    komut.Parameters.AddWithValue("@p2", textBox1.Text);
                    SqlDataReader dr = komut.ExecuteReader();
                    if (dr.Read())
                    {
                        sekreterdetay s = new sekreterdetay();
                        s.MdiParent = this.MdiParent;
                        s.Show();
                        s.Location = new Point(0, 65);
                    }
                    else
                    {
                        MessageBox.Show("Hatalı Tc veya Şifre");

                    }
                    bgl.baglanti().Close();
                }
            }
        }
    }
}
