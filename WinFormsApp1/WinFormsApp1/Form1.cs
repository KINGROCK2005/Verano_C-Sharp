namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox7_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            textBox5.Enabled = false;
            textBox6.Enabled = false; 

        }

        private void maskedTextBox3_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox4_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            double kg1, kg2, kg3, gr1, gr2, gr3, lb1, lb2, lb3;

            try
            {
                kg1 = double.Parse(maskedTextBox4.Text);
                kg2= double.Parse(maskedTextBox5.Text);
                kg3 = double.Parse(maskedTextBox6.Text);
                if (kg1 < 0 || kg2 < 0|| kg3 < 0)
                {
                    MessageBox.Show("No pueden ser negativo", "Advertencia");
                    maskedTextBox4.Text = "";
                    maskedTextBox5.Text = "";
                    maskedTextBox6.Text = "";

                }
                else
                {
                    gr1 = kg1 * 1000;
                    textBox1.Text = gr1.ToString(); 
                    lb1 = kg1 * 2.205;
                    textBox2.Text = lb1.ToString();

                    gr2 = kg2 * 1000;
                    textBox5.Text = gr2.ToString();
                    lb2 = kg2 * 2.205;
                    textBox6.Text = lb2.ToString();

                    gr3 = kg3 * 1000;
                    textBox3.Text = gr3.ToString();
                    lb3 = kg3 * 2.205;
                    textBox4.Text=lb3.ToString();

/*                    nf = p1 + p2 + p3 + p4;
                    textBox1.Text = nf.ToString();*/
                }



            }
            catch (Exception)
            {
                MessageBox.Show("No puede ser nulo", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }


        }
        private void button9_Click(object sender, EventArgs e)
        {
            maskedTextBox4.Text = "";
            maskedTextBox5.Text = "";
            maskedTextBox6.Text = "";

        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}