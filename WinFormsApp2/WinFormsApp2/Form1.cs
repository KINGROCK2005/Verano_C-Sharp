namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        int contraseñaIncorrecta = 3;
        int intentosF = 0;
        public Form1()
        {
            InitializeComponent();
        }

        public void fn_prba_() 
        {
            //progressBar1.Increment(1);
           if(progressBar1.Value < 100)
            {
                progressBar1.Value += 10;
                //ProgressBar1.Value++;

                label4.Text =progressBar1.Value.ToString() + "%";
            }

           if(progressBar1.Value == progressBar1.Maximum)
            {
                timer1.Enabled = false;
                timer1.Stop();
                //Invoca el formulario
                new MDI().Show();
                this.Hide();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if(progressBar1.Value < 100)
            {
                progressBar1.Value += 1;
                //prograsBar1++;

                label4.Text = progressBar1.Value.ToString()+ "%";
            }
            if(progressBar1.Value == progressBar1.Maximum)
            {
                timer1.Enabled = false;
                timer1.Stop();
                //Aqui invocamos el nuevo formulario
                new MDI().Show();
                this.Hide();
            }

        }

        private void Congelar() 
        {
            intentosF++;

            if(intentosF == 1)
            {
                MessageBox.Show("Fue bloqueado, espere 30 segundos");
                Thread.Sleep(30000);
                textBox2.Enabled = true;
                textBox1.Enabled = true;
                contraseñaIncorrecta = 3;

            }

            if(intentosF == 2)
            {
                MessageBox.Show("Fue bloqueado, espere 40 segundos");
                Thread.Sleep(40000);
                textBox2.Enabled = true;
                textBox1.Enabled = true;
                contraseñaIncorrecta = 3;
            }

            if (intentosF > 2)
            {
                MessageBox.Show("Fue bloqueado 1 minuto");
                Thread.Sleep(60000);
                textBox2.Enabled = true;
                textBox1.Enabled = true;
                contraseñaIncorrecta = 3;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "Keeners" && textBox2.Text == "DuraCell")
            {
                timer1.Start();
                timer1_Tick(sender, e);
            }
            else
            {
                contraseñaIncorrecta--;


                MessageBox.Show("Contraseña Incorrecta o Usuario Incorrecto");

            }
            if(contraseñaIncorrecta == 0)
            {
                textBox2.Enabled = false;
                textBox1.Enabled = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            fn_prba_();
            timer1.Enabled = true;

            if(progressBar1.Value == progressBar1.Maximum)
            {
                timer1.Enabled = false;
                timer1.Stop();
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox1.Focus();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}