using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaPOO.Models
{
    // a nivel de clase vimos que tiene dos niveles public que permite acceder a la clase en cualquier lugar
    // del actual ensamblado o de otro ensamblado, internal para poder usar la clase solo dentro del mismo ensamblado
    public class Motocicleta
    {
        private int codigoMotor;

        public int Recorrido { get; set; }

        // A nivel de funciones vemos qie las funcones public pueden ser llamadas desde cualquier otra clase en el actual
        // ensamblado o en otro ensamblado, las private no pueden ser llamdas en ningun ensamblado, las internal solo
        //  pueden ser llamadas en el mismo ensamblado
        public int Kilometraje()
        {
            return Recorrido * 100;
        }

        internal double Desgaste()
        {
            return Kilometraje() / 10;
        }

        public static string CompararRecorrido(Motocicleta moto1, Motocicleta moto2)
        {
            if (moto1.Kilometraje() > moto2.Kilometraje())
            {
                return "La moto1 tiene mayor recorrido";
            }
            else
            {
                return "La moto2 tiene mayor recorrido";
            }
        }
    }
}
