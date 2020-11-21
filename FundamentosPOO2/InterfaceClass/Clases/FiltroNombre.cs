using InterfaceClass.InterfaceClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceClass.Clases
{
    public class FiltroNombre : IFiltro
    {
        public bool FiltrarPor(Estudiante estudiante, string parametroFiltrar)
        {
            return estudiante.NombreEstudiante.Equals(parametroFiltrar);
        }

        public override string ToString()
        {
            return string.Format("Filtrar por Nombre");
        }
    }
}
