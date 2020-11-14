using Polimorfismo.Superclases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo.Clases
{
    public class EmpleadoPlanta : Empleado
    {
        public EmpleadoPlanta(string nombre, string ci, int codigoEmpleado, int sueldoHora)
            :base(nombre, ci, codigoEmpleado, sueldoHora)
        {}

        public int CodigoSerguro { get; set; }

        public override string ToString()
        {
            string cadenaBase = base.ToString();
            return string.Format("Empleado de planta {0}", cadenaBase);
        }
    }
}
