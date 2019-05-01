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
    public partial class Giriş : Form
    {
        public Giriş()
        {
            InitializeComponent();
        }

        private void hastaGirişToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hastagırısformu h = new Hastagırısformu();
            h.MdiParent = this;
            h.Show();
            h.Location = new Point(150, 100);
            
           
        }

        private void Giriş_Load(object sender, EventArgs e)
        {

        }

        private void doktorGirişToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Doktorgiris d = new Doktorgiris();
            d.MdiParent = this;
            d.Show();
            d.Location = new Point(150, 100);
        }
    }
}
