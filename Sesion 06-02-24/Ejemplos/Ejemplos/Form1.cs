namespace Ejemplos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
            txtIP.Enabled = false;
            txtIng.Text = "º1";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double ing, il, ip;
            ing = double.Parse(txtIng.Text);
           
            if (txtIng.Text==String.Empty)
            {
                MessageBox.Show("No puede ser nulo", "Advertencia");
                
            }
            else
            {
                if (ing <= 0 || ing > 500000)
                {
                    MessageBox.Show("No puede ser negativo ni cero ni mayor a 500000", "Advertencia");
                    txtIng.Text = "";

                }
                else
                {
                    if(cboTI.SelectedItem.Equals("Laboral"))
                        {il = ing * 0.07;
                    textBox1.Text = il.ToString();

                    }
                    else
                    {
                        ip = ing * .22;
                        txtIP.Text = ip.ToString();
                    }

                    
                }
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtIng.Text = "";
            textBox1.Text = "";
            txtIng.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}