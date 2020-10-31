using FundamentosPOOEstudiantes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentosPOOEstudiantes.Controllers
{
    public class EstudiantesController
    {
        List<Estudiante> listaEstudaintes;

        public EstudiantesController()
        {
            listaEstudaintes = new List<Estudiante>();
        }

        public List<Estudiante> ListaEstudiantes { get { return listaEstudaintes; } private set { listaEstudaintes = value; } }

        public void AgregarEstudiante(string nombre, int ci)
        {
            Estudiante est = new Estudiante() { Nombre=nombre, CI = ci };
            listaEstudaintes.Add(est);
        }
    }
}
