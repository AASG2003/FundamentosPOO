using BuscaminasLibrary.Controladores;
using BuscaminasLibrary.Modelos.ClasesPadre;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuscaminasConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            Juego juego = new Juego();

            while (true) {
                for (int fila = 0; fila < juego.TableroJuego.Tamanio; fila++)
                {

                    for (int columna = 0; columna < juego.TableroJuego.Tamanio; columna++)
                    {
                        Console.Write(juego.TableroJuego.Celdas[fila,columna]);
                        Console.Write(" ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("Seleccione una coordenada");
                Console.WriteLine("Ingrese Fila");
                int filaCoor = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese Columna");
                int columnaCoor = Convert.ToInt32(Console.ReadLine());

                juego.VerCelda(filaCoor, columnaCoor);
            }
        }
    }
}
