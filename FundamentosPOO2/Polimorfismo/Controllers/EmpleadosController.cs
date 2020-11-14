using Polimorfismo.Clases;
using Polimorfismo.Superclases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo.Controllers
{
    public class EmpleadosController
    {
        List<Empleado> listaEmpleados;

        public EmpleadosController()
        {
            listaEmpleados = new List<Empleado>();
        }

        public List<Empleado> ListaEmpleados
        {
            get { return listaEmpleados; } private set { }
        }

        public void AgregarEmpleado(string nombre, string ci, int codigo,
            int sueldo, bool esEmpeladoFijo)
        {
            Empleado nuevoEmpleado = null;
            if (esEmpeladoFijo)
                nuevoEmpleado = new EmpleadoPlanta(nombre, ci, codigo, sueldo);
            else
                nuevoEmpleado = new EmpleadoConsultor(nombre, ci, codigo, sueldo);

            listaEmpleados.Add(nuevoEmpleado);
        }

        public Empleado BuscarEmpelado(int codigoEmpelado)
        {
            return null;
        }
    }
}
