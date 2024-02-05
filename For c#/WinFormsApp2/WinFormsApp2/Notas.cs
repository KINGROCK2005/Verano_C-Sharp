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
    public partial class Notas : Form
    {
        public Notas()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double nota1,nota2,nota3,nota4, notafinal = 0;

            nota1 =double.Parse(maskedTextBox1.Text = (0).ToString());
            nota2 =double.Parse(maskedTextBox2.Text = (0).ToString());
            nota3 =double.Parse(maskedTextBox3.Text = (0).ToString());
            nota4 =double.Parse(maskedTextBox4.Text = (0).ToString());

            if ((nota1 <= 0 || nota1 > 25) && (nota2 <= 0 || nota2 > 25) && (nota3 <= 0 || nota3 > 25) && (nota4 <= 0 || nota4 > 25) ) 
            {
                MessageBox.Show("No puede ser negativo o mayor a 25.", "ADVERTENCIA");
                
            }
            else
            {
                notafinal = nota1 + nota2 + nota3 + nota4;
                textBox1.Text = notafinal.ToString();
            }
        }
        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox3_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox4_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            maskedTextBox1.Text = "";
            textBox1.Text = "";
            
            maskedTextBox1.Focus();
            maskedTextBox2.Focus();
            maskedTextBox3.Focus();
            maskedTextBox4.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
