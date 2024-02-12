namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int nota1, nota2, notaf;
            nota1 = int.Parse(textBox1.Text);
            nota2 = int.Parse(textBox2.Text);

            try
            {
                if (nota1 > 50 || nota2 > 50)
                {
                    MessageBox.Show("La nota ingresada debe ser menor o igual a 50");
                }
            }catch(FormatException ex)
            {
                MessageBox.Show("Valor incorrecto");
            }
            notaf = nota1 + nota2;

            if (notaf > 100)
            {
                textBox3.Text = (" ");
            }
            else
            {
                textBox3.Text = notaf.ToString();
            }
            if(notaf < 60)
            {
                textBox4.Text = ("No");
            }
            else if(notaf < 100)
            {
                textBox4.Text = ("Si");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox3.Enabled = false;
            textBox4.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}