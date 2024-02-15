namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        Form1 T= new Form1();
        public Form1()
        {
            InitializeComponent();
        }

        private void tablaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            T.MdiParent = this;
            T.Show();
        }
    }
}
