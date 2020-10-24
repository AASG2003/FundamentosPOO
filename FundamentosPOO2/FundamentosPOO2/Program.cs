
using LibreriaPOO.Models;
using System;

namespace FundamentosPOO2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Motocicleta moto1 = new Motocicleta() { Recorrido = 3 };
            Motocicleta moto2 = new Motocicleta() { Recorrido = 8};
            Motocicleta moto3 = moto1;
            moto3.Recorrido = 10;
            Console.WriteLine(moto1.Kilometraje());
            Console.WriteLine(moto2.Kilometraje());
            Console.WriteLine(Motocicleta.CompararRecorrido(moto1, moto2));
        }
    }
}
