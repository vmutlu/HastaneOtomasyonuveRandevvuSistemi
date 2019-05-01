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
    public partial class Hastagırısformu : Form
    {
        public Hastagırısformu()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void Hastagırısformu_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
          
        }

        private void maskedTextBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void keydown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                if (maskedTextBox1.Text == "59677075804" || maskedTextBox1.Text == "59677075805" || maskedTextBox1.Text == "11111111111" || maskedTextBox1.Text == "22222222222" || maskedTextBox1.Text == "33333333333")
                {
                    SqlCommand komut = new SqlCommand("Select *from Tbl_Hastalar where HastaTc=@p1 ", bgl.baglanti());
                    komut.Parameters.AddWithValue("@p1", maskedTextBox1.Text);

                    SqlDataReader dr = komut.ExecuteReader();
                    if (dr.Read())
                    {
                        dene d = new dene();
                        d.MdiParent = this.MdiParent;
                        d.tc = maskedTextBox1.Text;
                        d.Show();
                        d.Location = new Point(0, 65);

                    }
                    else
                    {
                        MessageBox.Show("Hatalı Tc Kimlik No", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    bgl.baglanti().Close();
                }
            }
        }
    }
}
