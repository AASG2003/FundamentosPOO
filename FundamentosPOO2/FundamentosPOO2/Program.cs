
using FigurasGeometricas.Clases;
using FigurasGeometricas.Superclases;
using FundamentosPOOEstudiantes.Controllers;
using FundamentosPOOEstudiantes.Models;
using LibreriaPOO.Controllers;
using LibreriaPOO.Models;
using LibreriaPOO.Superclases;
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

            //EstudiantesController estController = new EstudiantesController();
            //estController.AgregarEstudiante("Emilson", 2563);
            //estController.AgregarEstudiante("Carlos", 32547);
            //estController.AgregarEstudiante("Carla", 98541);
            //foreach (Estudiante estudiante in estController.ListaEstudiantes)
            //{
            //    Console.WriteLine("Estudiante {0}", estudiante.Nombre);
            //}

            // Las clases abstractas solo pueden manejar la herencia de forma similar a una herencia normal
            // pero no permiten crear instancias de esa clase o sea no puedo crear objetos Vehiculo
            //Vehiculo vehiculo1 = new Vehiculo(100, 2563);
            //Motocicleta motocicleta1 = new Motocicleta(50, 32145);
            //Automovil automovil1 = new Automovil(150, 2589);
            ////Console.WriteLine(vehiculo1.Kilometraje());
            //Console.WriteLine(motocicleta1.Kilometraje());
            //Console.WriteLine(automovil1.Kilometraje());

            Cuadrado cuadrado = new Cuadrado(10, 10);
            Rectangulo rectangulo = new Rectangulo(10, 15);
            Triangulo triangulo = new Triangulo(10, 15);
            //Console.WriteLine("el area del cuadrado es {0} y su perimetro es {1}"
            //    , cuadrado.CalcularArea(), cuadrado.Perimetro());
            //Console.WriteLine("el area del triangulo es {0} y su perimetro es {1}"
            //    , triangulo.CalcularArea(), triangulo.Perimetro());
            //Console.WriteLine("el area del rectangulo es {0} y su perimetro es {1}"
            //    , rectangulo.CalcularArea(), rectangulo.Perimetro());

            //FiguraGeometrica figura1 = new FiguraGeometrica(23,20);

            // Boxing uboxing
            Cuadrado cuadradoAux = null;
            Object initialBox = cuadrado;
            initialBox = triangulo;
            // usando el operador is
            //if (initialBox is Cuadrado)
            //    cuadradoAux = (Cuadrado)initialBox;
            // usando el operador as
            cuadradoAux = initialBox as Cuadrado;
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
