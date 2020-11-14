using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo.Superclases
{
    public class Empleado : Persona
    {

        public Empleado(string nombre, string ci, int codigoEmpleado, int sueldoHora)
            : base(nombre, ci)
        {
            CodigoEmpleado = codigoEmpleado;
            SueldoHora = sueldoHora;
        }

        public int CodigoEmpleado { get; set; }
        public int SueldoHora { get; set; }

        public double CalcularSueldoTotal(int horasTrabajadas)
        {
            return SueldoHora * horasTrabajadas;
        }

        public override string ToString()
        {
            return string.Format("Nombre.- {0} , Codigo.- {1}, Sueldo.- {2}$",
                NombreCompleto, CodigoEmpleado, CalcularSueldoTotal(176));
        }
    }
}
