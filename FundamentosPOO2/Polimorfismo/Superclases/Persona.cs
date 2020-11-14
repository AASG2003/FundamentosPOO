using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo.Superclases
{
    public class Persona
    {
        public Persona(string nombre, string ci)
        {
            NombreCompleto = nombre;
            CI = ci;
        }

        public string NombreCompleto { get; set; }
        public string CI { get; set; }
    }
}
