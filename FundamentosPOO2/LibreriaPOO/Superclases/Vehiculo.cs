﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaPOO.Superclases
{
    public class Vehiculo
    {
        protected int codigoMotor;
        public int Recorrido { get; set; }
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
