using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace semana9
{
    public partial class Form1 : Form
    {
        public Form1()
        { 
            InitializeComponent();
        }
        Empleados Empleado = new Empleados();
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ID;

            if (!int.TryParse(txtID.Text, out ID))

            {
                errorProvider1.SetError(txtID, "No ingresó un ID válido");
                txtNombre.Focus();
                return;
            }
            errorProvider1.SetError(txtID, "");


            if (txtNombre.Text == "")
            {
                errorProvider1.SetError(txtNombre, "No ingresó el nombre");
                txtNombre.Focus();
                return;
            }

            errorProvider1.SetError(txtNombre, "");

            if (txtDUI.Text == "")
            {
                errorProvider1.SetError(txtDUI, "No ingresó el DUI");
                txtNombre.Focus();
                return;
            }

            errorProvider1.SetError(txtNombre, "");


            double Salario;

            if (!double.TryParse(txtSalario.Text, out Salario))

            {
                errorProvider1.SetError(txtSalario, "No ingresó el salario de forma correcta");
                txtSalario.Focus();
                return;
            }
            errorProvider1.SetError(txtID, "");

            Empleado.Id = Convert.ToInt32(txtID.Text);
         Empleado.Nombre = txtNombre.Text;
         Empleado.Dui = txtDUI.Text;
         Empleado.Salario = Convert.ToInt32(txtSalario.Text);
            Registro.Text = "¡Registro guardado!";
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btAFP_TextChanged(object sender, EventArgs e)
        {
        }

        private void AFP_Click(object sender, EventArgs e)
        {
            txtAFP.Text = Empleado.AFP(Empleado.Salario).ToString();
        }

        private void txtAFP_TextChanged(object sender, EventArgs e)
        {

        }

        private void ISSS_Click(object sender, EventArgs e)
        {
            txtISSS.Text = Empleado.ISSS(Empleado.Salario).ToString();
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            
        }

        private void txtSalN_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtSalN.Text = Empleado.Salneto(Empleado.Salario).ToString();
        }

        private void txtDUI_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
