using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        Form1 n = new Form1();
        Form3 v = new Form3();
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void notasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            n.MdiParent = this;
            n.Show();
        }

        private void velocidadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v.MdiParent = this;
            v.Show();
        }
    }
}
