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
    public partial class Form2 : Form
    {
        private int n = 0;
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double precio, cantidad, sbtotal, SUtotal = 0, impuesto, total = 0;
            precio = double.Parse(textBox3.Text);
            cantidad = double.Parse(textBox4.Text);


            dataGridView1.Rows[n].Cells[0].Value = textBox1.Text;
            dataGridView1.Rows[n].Cells[1].Value = textBox2.Text;
            dataGridView1.Rows[n].Cells[2].Value = textBox3.Text;
            dataGridView1.Rows[n].Cells[3].Value = textBox4.Text;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (n != 1)
            {
                dataGridView1.Rows.RemoveAt(n);
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            textBox5.Enabled = false;
            textBox6.Enabled = false;
            textBox7.Enabled = false;

        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (e.KeyChar == '.')
            {

                if (textBox3.Text.Contains("."))
                {
                    e.Handled = true;
                }
            }
            else if (textBox3.Text.Contains("."))
            {
                string[] parts = textBox1.Text.Split('.');
                if (parts.Length > 1 && parts[1].Length >= 5)
                {
                    e.Handled = true;
                }
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (e.KeyChar == '.')
            {

                if (textBox4.Text.Contains("."))
                {
                    e.Handled = true;
                }
            }
            else if (textBox4.Text.Contains("."))
            {
                string[] parts = textBox1.Text.Split('.');
                if (parts.Length > 1 && parts[1].Length >= 5)
                {
                    e.Handled = true;
                }
            }
        }

        
    }
}
