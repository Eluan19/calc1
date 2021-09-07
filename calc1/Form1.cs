using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calc1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMais_Click(object sender, EventArgs e)
        {
            int valor1, valor2, resultado;

            valor1 = Convert.ToInt32(textBox1.Text);
            valor2 = Convert.ToInt32(textBox2.Text);

            resultado = valor1 + valor2;
            lblResultado.Text = resultado.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int valor1, valor2, resultado;

            valor1 = Convert.ToInt32(textBox1.Text);
            valor2 = Convert.ToInt32(textBox2.Text);

            resultado = valor1 - valor2;
            lblResultado.Text = resultado.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int valor1, valor2, resultado;

            valor1 = Convert.ToInt32(textBox1.Text);
            valor2 = Convert.ToInt32(textBox2.Text);

            resultado = valor1 * valor2;
            lblResultado.Text = resultado.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int valor1, valor2, resultado;

            valor1 = Convert.ToInt32(textBox1.Text);
            valor2 = Convert.ToInt32(textBox2.Text);

            resultado = valor1 / valor2;
            lblResultado.Text = resultado.ToString();
        }
    }
}
