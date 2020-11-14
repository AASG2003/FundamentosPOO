using Polimorfismo.Superclases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo.Clases
{
    public class EmpleadoConsultor : Empleado
    {
        public EmpleadoConsultor(string nombre, string ci, int codigoEmpleado, int sueldoHora)
            : base(nombre, ci, codigoEmpleado, sueldoHora)
        {}

        public DateTime FechaLimite { get; set; }
    }
}
