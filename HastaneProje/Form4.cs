using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneProje
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void hastaGirişiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hastagırısformu h = new Hastagırısformu();
            h.MdiParent = this;
            h.Show();
            h.Location = new Point(0, 65);

        }

        private void doktorGirişiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Doktorgiris d = new Doktorgiris();
            d.MdiParent = this;
            d.Show();
            d.Location = new Point(0, 65);
        }

        private void sekreterGirişiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sekretergiris s = new sekretergiris();
            s.MdiParent = this;
            s.Show();
            s.Location = new Point(0, 65);
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ulasım u = new ulasım();
            u.MdiParent = this;
            u.Show();
            u.Location = new Point(0, 65);
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            
            textBox2.Text = DateTime.Now.ToLongTimeString(); // sadece saat 
            textBox1.Text = DateTime.Now.ToLongDateString();
        }

        private void çıkışToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Ulasımweb u = new Ulasımweb();
            u.MdiParent = this;
            u.Show();
            u.Location = new Point(0, 65);
        }

        private void çıkışToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Çıkmak İstediğinizden Emin misiniz ?", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (sonuc == DialogResult.No)
            {

                return;
            }
            Application.Exit();
        }
    }
}
