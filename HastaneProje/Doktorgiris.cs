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
    public partial class Doktorgiris : Form
    {
        public Doktorgiris()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();

        private void button2_Click(object sender, EventArgs e)
        {
        }
       // Form2 f = new Form2();
        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void Doktorgiris_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                if (textBox1.Text == "123" && maskedTextBox1.Text == "11111111111")
                {
                    SqlCommand komut = new SqlCommand("Select *from Tbl_Doktorlar where DoktorTc=@p1 and DoktorSıfre=@p2", bgl.baglanti());
                    komut.Parameters.AddWithValue("@p1", maskedTextBox1.Text);
                    komut.Parameters.AddWithValue("@p2", textBox1.Text);
                    SqlDataReader dr = komut.ExecuteReader();
                    if (dr.Read())
                    {
                        Doktordetay d = new Doktordetay();
                        d.MdiParent = this.MdiParent;
                        d.tc = maskedTextBox1.Text;
                        d.Show();
                        d.Location = new Point(0, 65);


                    }
                    else
                    {
                        MessageBox.Show("Hatalı Tc Kimlik No veya Şifre.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    bgl.baglanti().Close();
                }

                if (textBox1.Text == "123" && maskedTextBox1.Text == "22222222222")
                {
                    SqlCommand komut = new SqlCommand("Select *from Tbl_Doktorlar where DoktorTc=@p1 and DoktorSıfre=@p2", bgl.baglanti());
                    komut.Parameters.AddWithValue("@p1", maskedTextBox1.Text);
                    komut.Parameters.AddWithValue("@p2", textBox1.Text);
                    SqlDataReader dr = komut.ExecuteReader();
                    if (dr.Read())
                    {
                        Doktordetay d = new Doktordetay();
                        d.MdiParent = this.MdiParent;
                        d.tc = maskedTextBox1.Text;
                        d.Show();
                        d.Location = new Point(0, 65);


                    }
                    else
                    {
                        MessageBox.Show("Hatalı Tc Kimlik No veya Şifre.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    bgl.baglanti().Close();
                }

                if (textBox1.Text == "123" && maskedTextBox1.Text == "33333333333")
                {
                    SqlCommand komut = new SqlCommand("Select *from Tbl_Doktorlar where DoktorTc=@p1 and DoktorSıfre=@p2", bgl.baglanti());
                    komut.Parameters.AddWithValue("@p1", maskedTextBox1.Text);
                    komut.Parameters.AddWithValue("@p2", textBox1.Text);
                    SqlDataReader dr = komut.ExecuteReader();
                    if (dr.Read())
                    {
                        Doktordetay d = new Doktordetay();
                        d.MdiParent = this.MdiParent;
                        d.tc = maskedTextBox1.Text;
                        d.Show();
                        d.Location = new Point(0, 65);


                    }
                    else
                    {
                        MessageBox.Show("Hatalı Tc Kimlik No veya Şifre.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    bgl.baglanti().Close();
                }
                if (textBox1.Text == "123" && maskedTextBox1.Text == "44444444444")
                {
                    SqlCommand komut = new SqlCommand("Select *from Tbl_Doktorlar where DoktorTc=@p1 and DoktorSıfre=@p2", bgl.baglanti());
                    komut.Parameters.AddWithValue("@p1", maskedTextBox1.Text);
                    komut.Parameters.AddWithValue("@p2", textBox1.Text);
                    SqlDataReader dr = komut.ExecuteReader();
                    if (dr.Read())
                    {
                        Doktordetay d = new Doktordetay();
                        d.MdiParent = this.MdiParent;
                        d.tc = maskedTextBox1.Text;
                        d.Show();
                        d.Location = new Point(0, 65);


                    }
                    else
                    {
                        MessageBox.Show("Hatalı Tc Kimlik No veya Şifre.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    bgl.baglanti().Close();
                }
                if (textBox1.Text == "123" && maskedTextBox1.Text == "55555555555")
                {
                    SqlCommand komut = new SqlCommand("Select *from Tbl_Doktorlar where DoktorTc=@p1 and DoktorSıfre=@p2", bgl.baglanti());
                    komut.Parameters.AddWithValue("@p1", maskedTextBox1.Text);
                    komut.Parameters.AddWithValue("@p2", textBox1.Text);
                    SqlDataReader dr = komut.ExecuteReader();
                    if (dr.Read())
                    {
                        Doktordetay d = new Doktordetay();
                        d.MdiParent = this.MdiParent;
                        d.tc = maskedTextBox1.Text;
                        d.Show();
                        d.Location = new Point(0, 65);


                    }
                    else
                    {
                        MessageBox.Show("Hatalı Tc Kimlik No veya Şifre.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    bgl.baglanti().Close();
                }
                if (textBox1.Text == "123" && maskedTextBox1.Text == "66666666666")
                {
                    SqlCommand komut = new SqlCommand("Select *from Tbl_Doktorlar where DoktorTc=@p1 and DoktorSıfre=@p2", bgl.baglanti());
                    komut.Parameters.AddWithValue("@p1", maskedTextBox1.Text);
                    komut.Parameters.AddWithValue("@p2", textBox1.Text);
                    SqlDataReader dr = komut.ExecuteReader();
                    if (dr.Read())
                    {
                        Doktordetay d = new Doktordetay();
                        d.MdiParent = this.MdiParent;
                        d.tc = maskedTextBox1.Text;
                        d.Show();
                        d.Location = new Point(0, 65);


                    }
                    else
                    {
                        MessageBox.Show("Hatalı Tc Kimlik No veya Şifre.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    bgl.baglanti().Close();
                }
                if (textBox1.Text == "123" && maskedTextBox1.Text == "77777777777")
                {
                    SqlCommand komut = new SqlCommand("Select *from Tbl_Doktorlar where DoktorTc=@p1 and DoktorSıfre=@p2", bgl.baglanti());
                    komut.Parameters.AddWithValue("@p1", maskedTextBox1.Text);
                    komut.Parameters.AddWithValue("@p2", textBox1.Text);
                    SqlDataReader dr = komut.ExecuteReader();
                    if (dr.Read())
                    {
                        Doktordetay d = new Doktordetay();
                        d.MdiParent = this.MdiParent;
                        d.tc = maskedTextBox1.Text;
                        d.Show();
                        d.Location = new Point(0, 65);


                    }
                    else
                    {
                        MessageBox.Show("Hatalı Tc Kimlik No veya Şifre.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    bgl.baglanti().Close();
                }
                if (textBox1.Text == "123" && maskedTextBox1.Text == "88888888888")
                {
                    SqlCommand komut = new SqlCommand("Select *from Tbl_Doktorlar where DoktorTc=@p1 and DoktorSıfre=@p2", bgl.baglanti());
                    komut.Parameters.AddWithValue("@p1", maskedTextBox1.Text);
                    komut.Parameters.AddWithValue("@p2", textBox1.Text);
                    SqlDataReader dr = komut.ExecuteReader();
                    if (dr.Read())
                    {
                        Doktordetay d = new Doktordetay();
                        d.MdiParent = this.MdiParent;
                        d.tc = maskedTextBox1.Text;
                        d.Show();
                        d.Location = new Point(0, 65);


                    }
                    else
                    {
                        MessageBox.Show("Hatalı Tc Kimlik No veya Şifre.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    bgl.baglanti().Close();
                }
                if (textBox1.Text == "123" && maskedTextBox1.Text == "99999999999")
                {
                    SqlCommand komut = new SqlCommand("Select *from Tbl_Doktorlar where DoktorTc=@p1 and DoktorSıfre=@p2", bgl.baglanti());
                    komut.Parameters.AddWithValue("@p1", maskedTextBox1.Text);
                    komut.Parameters.AddWithValue("@p2", textBox1.Text);
                    SqlDataReader dr = komut.ExecuteReader();
                    if (dr.Read())
                    {
                        Doktordetay d = new Doktordetay();
                        d.MdiParent = this.MdiParent;
                        d.tc = maskedTextBox1.Text;
                        d.Show();
                        d.Location = new Point(0, 65);


                    }
                    else
                    {
                        MessageBox.Show("Hatalı Tc Kimlik No veya Şifre.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    bgl.baglanti().Close();
                }
            }
        }
    }
}
