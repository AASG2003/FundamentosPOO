using InterfaceClass.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceClass.InterfaceClass
{
    public interface IFiltro
    {
        bool FiltrarPor(Estudiante estudiante, string parametroFiltrar);
    }
}
