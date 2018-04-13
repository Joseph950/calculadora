using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        Double c1 = 0, c2 = 0, Suma, Resta, Multiplicacion, Division;

        private void Dividir_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            c1 = Double.Parse(textBox1.Text);
            c2 = Double.Parse(textBox2.Text);
            Division = c1 / c2;
            listBox1.Items.Add(Division.ToString());
        }

        private void Multiplicar_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            c1 = Double.Parse(textBox1.Text);
            c2 = Double.Parse(textBox2.Text);
            Multiplicacion = c1 * c2;
            listBox1.Items.Add(Multiplicacion.ToString());
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Restar_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            c1 = Double.Parse(textBox1.Text);
            c2 = Double.Parse(textBox2.Text);
            Resta = c1 - c2;
            listBox1.Items.Add(Resta.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            c1 = Double.Parse(textBox1.Text);
            c2 = Double.Parse(textBox2.Text);
            Suma = c1 + c2;
            listBox1.Items.Add(Suma.ToString());
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
