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
using System.Drawing.Printing;

namespace HastaneProje
{ 
    public partial class Recete : Form
    {
        public Recete()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        //public string tc;
        public string ad;
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void Recete_Load(object sender, EventArgs e)
        {
            
            
            textBox6.Text = DateTime.Now.ToLongDateString();
            textBox4.Text = ad;
            SqlCommand komut = new SqlCommand("Select DoktorAd,DoktorSoyad from Tbl_Doktorlar where DoktorTc=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", label2.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                textBox4.Text = dr[0] + " " + dr[1];
            }
            bgl.baglanti().Close();
        }
        Bitmap bmp;
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
           
            e.Graphics.DrawImage(bmp,0,0);

           
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
           
            Graphics g = this.CreateGraphics();
            bmp = new Bitmap(this.Size.Width, this.Size.Height, g);
            Graphics mg = Graphics.FromImage(bmp);
            mg.CopyFromScreen(this.Location.X, this.Location.Y, 0,0, this.Size);
            printPreviewDialog1.ShowDialog();


        }

      

        private void button2_Click(object sender, EventArgs e)
        {
          //  if (printPreviewDialog2.ShowDialog() == DialogResult.OK)
             //   printDocument2.Print();
            PrintDocument PD = new PrintDocument();
            PD.PrintPage += new PrintPageEventHandler(printDocument2_PrintPage);

            try
            {
                PD.Print();
            }
            catch
            {
                Console.WriteLine("Yazıcı çıktısı alınamıyor...");
            }
            finally
            {
                PD.Dispose();
            }

        }

        private void printDocument2_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            /*e.Graphics.DrawString(textBox7.Text, new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new PointF(100, 100));*/
            e.Graphics.DrawRectangle(Pens.Red, 20, 20, 100, 100);
        }
    }
}
