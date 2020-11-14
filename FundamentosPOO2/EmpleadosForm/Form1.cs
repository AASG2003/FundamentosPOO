using Polimorfismo.Controllers;
using Polimorfismo.Superclases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmpleadosForm
{
    public partial class Form1 : Form
    {

        EmpleadosController controller;

        public Form1()
        {
            InitializeComponent();
            controller = new EmpleadosController();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre = textBox1.Text;
            string ci = textBox2.Text;
            int codigoEmpleado = Convert.ToInt32(textBox3.Text);
            int sueldoEmpleado = Convert.ToInt32(textBox4.Text);
            controller.AgregarEmpleado(nombre, ci, codigoEmpleado, sueldoEmpleado, true);
            LimpiarCampos();
            CargarLista();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string nombre = textBox1.Text;
            string ci = textBox2.Text;
            int codigoEmpleado = Convert.ToInt32(textBox3.Text);
            int sueldoEmpleado = Convert.ToInt32(textBox4.Text);
            controller.AgregarEmpleado(nombre, ci, codigoEmpleado, sueldoEmpleado, false);
            LimpiarCampos();
            CargarLista();
        }

        private void LimpiarCampos()
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            textBox4.Text = string.Empty;
        }

        private void CargarLista()
        {
            listBox1.Items.Clear();
            foreach (Empleado empleado in controller.ListaEmpleados)
            {
                listBox1.Items.Add(empleado);
            }
        }
    }
}
