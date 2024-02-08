using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class MDI : Form
    {
        Form1 L = new Form1();
        Figuras f = new Figuras();
        public MDI()
        {
            InitializeComponent();
        }

        private void figurasGeometricasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f.MdiParent = this;
            f.Show();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            L.MdiParent = this;
            L.Show();
        }
    }
}
