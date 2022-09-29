using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sumayresta
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
            textBox3.Text = "Eliga si desea sumar o restar los numeros";


        }

        private void button1_Click(object sender, EventArgs e)
        {
            double numero1 = Convert.ToDouble(textBox1.Text);
            double numero2 = Convert.ToDouble(textBox2.Text);
            double suma = numero1 + numero2;
            label2.Text = "Respuesta: " + suma.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double numero2 = Convert.ToDouble(textBox2.Text);
            double numero1 = Convert.ToDouble(textBox1.Text);
            double resta = numero1 - numero2;
            label2.Text = "Respuesta: " + resta.ToString();
           
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
             
        }
    }
}
