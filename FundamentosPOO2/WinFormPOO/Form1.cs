using LibreriaPOO.Controllers;
using LibreriaPOO.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormPOO
{
    public partial class Form1 : Form
    {
        // declarando variables
        TiendaController tienda;

        public Form1()
        {
            InitializeComponent();
            tienda = new TiendaController();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int codigo = Convert.ToInt32(textBox2.Text);
            int recorrido = Convert.ToInt32(textBox1.Text);
            tienda.AgregarMotocicleta(codigo, recorrido);
            MessageBox.Show("Motocicleta agregada exitosamente");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (Motocicleta moto in tienda.motocicletas)
            {
               MessageBox.Show(string.Format("Moto con recorrido {0}", moto.Recorrido));
            }
        }
    }
}
