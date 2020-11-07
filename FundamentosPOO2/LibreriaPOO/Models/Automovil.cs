using LibreriaPOO.Superclases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaPOO.Models
{
    public class Automovil : Vehiculo
    {
        public Automovil(int recorrido, int codigoMotor)
            : base(recorrido, codigoMotor)
        { }
    }
}
