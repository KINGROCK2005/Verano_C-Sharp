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
        Form1 f = new Form1();
        Notas n = new Notas();
        public MDI()
        {
            InitializeComponent();
        }

        private void MDI_Load(object sender, EventArgs e)
        {

        }

        private void inssLaboralToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f.MdiParent = this;
            f.Show();
        }

        private void notasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            n.MdiParent = this;
            n.Show();
        }
    }
}
