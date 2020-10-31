
using FundamentosPOOEstudiantes.Controllers;
using FundamentosPOOEstudiantes.Models;
using LibreriaPOO.Controllers;
using LibreriaPOO.Models;
using System;

namespace FundamentosPOO2
{
    class Program
    {
        static TiendaController tienda = new TiendaController();

        static void Main(string[] args)
        {

            //Console.WriteLine();
            //Motocicleta moto1 = new Motocicleta() { Recorrido = 3 };
            //Motocicleta moto2 = new Motocicleta() { Recorrido = 8};
            //Motocicleta moto3 = moto1;
            //moto3.Recorrido = 10;
            //Console.WriteLine(moto1.Kilometraje());
            //Console.WriteLine(moto2.Kilometraje());
            //Console.WriteLine(Motocicleta.CompararRecorrido(moto1, moto2));
            //while (true)
            //{
            //    Console.WriteLine("Ingrese 1 para agregar una motocicleta o 2 para ver la lista");
            //    int index = Convert.ToInt32(Console.ReadLine());
            //    switch (index)
            //    {
            //        case 1:
            //            AgregarMotocicleta();
            //            break;
            //        case 2:
            //            VerMotocicletas();
            //            break;
            //    }
            //}

            EstudiantesController estController = new EstudiantesController();
            estController.AgregarEstudiante("Emilson", 2563);
            estController.AgregarEstudiante("Carlos", 32547);
            estController.AgregarEstudiante("Carla", 98541);
            foreach (Estudiante estudiante in estController.ListaEstudiantes)
            {
                Console.WriteLine("Estudiante {0}", estudiante.Nombre);
            }
        }

        //public static void AgregarMotocicleta()
        //{
        //    Console.WriteLine("Ingrese Codigo de motor");
        //    int codigo = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("Ingrese Recorrido de motocicleta");
        //    int recorrido = Convert.ToInt32(Console.ReadLine());
        //    tienda.AgregarMotocicleta(codigo, recorrido);
        //}

        //public static void VerMotocicletas()
        //{
        //    foreach (Motocicleta moto in tienda.motocicletas)
        //    {
        //        Console.WriteLine("Moto con recorrido {0}", moto.Recorrido);
        //    }
        //}
    }
}
