using LibreriaPOO.Superclases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaPOO.Models
{
    // a nivel de clase vimos que tiene dos niveles public que permite acceder a la clase en cualquier lugar
    // del actual ensamblado o de otro ensamblado, internal para poder usar la clase solo dentro del mismo ensamblado
    public class Motocicleta : Vehiculo
    {
        public Motocicleta(int recorrido, int codigoMotor)
            : base(recorrido, codigoMotor)
        { }

        public void verCodigo()
        {
            Console.WriteLine(CodigoMotor);
        }
    }
}
