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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void hastaGirişiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hastagırısformu h = new Hastagırısformu();
            h.MdiParent = this;
            h.Show();
            h.Location = new Point(0,100);
        }

        private void doktorGirişiToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Doktorgiris d = new Doktorgiris();
            d.MdiParent = this;
            d.Show();
            d.Location = new Point(0,100);
        }
    }
}
