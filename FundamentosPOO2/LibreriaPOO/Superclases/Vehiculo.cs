using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaPOO.Superclases
{
    public abstract class Vehiculo
    {
        // attr
        private int codigoMotor;

        //constructor
        public Vehiculo(int recorrido, int codigoMotor)
        {
            Recorrido = recorrido;
            CodigoMotor = codigoMotor;
        }

        // properties
        public int Recorrido { get; set; }

        public int CodigoMotor
        {
            get { return codigoMotor; }
            set { codigoMotor = value; }
        }

        // metodo
        public int Kilometraje()
        {
            return Recorrido * 100;
        }

        internal double Desgaste()
        {
            return Kilometraje() / 10;
        }

        public static string CompararRecorrido(Vehiculo vehiculo1, Vehiculo vehiculo2)
        {
            if (vehiculo1.Kilometraje() > vehiculo2.Kilometraje())
            {
                return "La vehiculo1 tiene mayor recorrido";
            }
            else
            {
                return "La vehiculo2 tiene mayor recorrido";
            }
        }
    }
}
