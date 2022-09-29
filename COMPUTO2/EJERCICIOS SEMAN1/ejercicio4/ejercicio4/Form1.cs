using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            textBox2.Text = "0";
            label1.Text = "Escoja una acción de las siguientes: ";
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            double numero1 = Convert.ToDouble(textBox1.Text);
            double numero2 = Convert.ToDouble(textBox2.Text);
            double suma = numero1 + numero2;
            label2.Text = "Respuesta: " + suma.ToString();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            double numero1 = Convert.ToDouble(textBox1.Text);
            double numero2 = Convert.ToDouble(textBox2.Text);
            double resta = numero1 - numero2;
            label2.Text = "Respuesta: " + resta.ToString();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            double numero1 = Convert.ToDouble(textBox1.Text);
            double numero2 = Convert.ToDouble(textBox2.Text);
            double multiplicacion = numero1 * numero2;
            label2.Text = "Respuesta: " + multiplicacion.ToString();
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            double numero1 = Convert.ToDouble(textBox1.Text);
            double numero2 = Convert.ToDouble(textBox2.Text);
            double division = numero1 / numero2;
            label2.Text = "Respuesta: " + division.ToString();
        }
    }
}
