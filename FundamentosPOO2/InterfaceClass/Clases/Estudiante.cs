using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceClass.Clases
{
    public class Estudiante
    {

        public Estudiante(string nombre, string codigo, string curso)
        {
            NombreEstudiante = nombre;
            CodigoEstudiante = codigo;
            Curso = curso;
        }

        public string NombreEstudiante { get; set; }
        public string CodigoEstudiante { get; set; }
        public string Curso { get; set; }

        public override string ToString()
        {
            return string.Format("Nombre.- {0}, Codigo.- {1}, Curso.- {2}",
                NombreEstudiante, CodigoEstudiante, Curso);
        }
    }
}
