using InterfaceClass.Clases;
using InterfaceClass.InterfaceClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceClass.controllers
{
    public class EstudianteController
    {
        List<Estudiante> listaEstudiantes;

        public EstudianteController()
        {
            listaEstudiantes = new List<Estudiante>();
        }

        public List<Estudiante> ListaEstudiantes
        {
            get { return listaEstudiantes; }
            private set { listaEstudiantes = value; }
        }

        public void AgregarEstudiante(string nombre, string codigo, string curso)
        {
            listaEstudiantes.Add(new Estudiante(nombre, codigo, curso));
        }

        public List<Estudiante> FiltrarLista(IFiltro filtro, string parametroFiltro)
        {
            List<Estudiante> listaResultado = new List<Estudiante>();
            foreach (Estudiante estudiante in listaEstudiantes)
            {
                if (filtro.FiltrarPor(estudiante, parametroFiltro))
                {
                    listaResultado.Add(estudiante);
                }
            }

            return listaResultado;
        }
    }
}
