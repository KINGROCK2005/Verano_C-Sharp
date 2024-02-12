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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double distancia, velocidad, tiempo;

            distancia = int.Parse(textBox1.Text);
            tiempo = int.Parse(textBox3.Text);


            if (1000 < distancia || distancia < 0 || 1000 < tiempo || tiempo < 0 ) 
            {
                MessageBox.Show("Ingreso invalido");
            }

            velocidad = distancia * tiempo;
            textBox3.Text = velocidad.ToString();
        }

        

        private void Form3_Load(object sender, EventArgs e)
        {
            textBox2.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }
    }
}
