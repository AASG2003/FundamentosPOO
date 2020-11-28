using InterfaceClass.Clases;
using InterfaceClass.controllers;
using InterfaceClass.InterfaceClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstudianteUI
{
    public partial class Form1 : Form
    {
        EstudianteController controller;

        public Form1()
        {
            InitializeComponent();
            controller = new EstudianteController();
            InicializarFiltros();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre = textBox1.Text;
            string codigo = textBox2.Text;
            string curso = textBox3.Text;
            string ci = textBox5.Text;
            controller.AgregarEstudiante(nombre, codigo, curso, ci);
            ActualizarLista(controller.ListaEstudiantes);
            limpiarCampos();
        }

        private void ActualizarLista(List<Estudiante> lista)
        {
            listBox1.Items.Clear();
            foreach (Estudiante estudiante in lista)
            {
                listBox1.Items.Add(estudiante);
            }
        }

        private void limpiarCampos()
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            textBox5.Text = string.Empty;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<Estudiante> listaFiltrada = controller.FiltrarLista(
                (IFiltro)comboBox1.SelectedItem, textBox4.Text);
            ActualizarLista(listaFiltrada);
            textBox4.Text = string.Empty;
        }

        private void InicializarFiltros()
        {
            comboBox1.Items.Add(new FiltroNombre());
            comboBox1.Items.Add(new FiltroCodigo());
            comboBox1.Items.Add(new FiltroCurso());
            comboBox1.Items.Add(new FiltroCarnet());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ActualizarLista(controller.ListaEstudiantes);
        }

        private void ChangeColor(object sender, EventArgs e)
        {
            this.button1.BackColor = Color.Green;
        }

        private void ChangeBackColor(object sender, EventArgs e)
        {
            this.button1.BackColor = Color.Yellow;
        }
    }
}
