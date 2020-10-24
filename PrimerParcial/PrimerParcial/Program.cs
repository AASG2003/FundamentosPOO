using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerParcial
{
    class Program
    {
        static void Main(string[] args)
        {
            // pregunta 2
            //int x = 10;
            //int y = ++x; // y = (x = x +1)
            //int z = y++; // z = y; y = y +1 

            //int count = 0;

            //while (count < 5)
            //{
            //    if (count == 3)
            //        break;
            //    count++;
            //}
            //int i = 0;
            //i += 1;
            //int[,] a = new int[2, 3] {};
            //int[,] b = { { 7, 1, 3 }, { 2, 9, 6 } };
            // regla de incremento n - 1 * 10 +5, caso inicial de 0
            //0 -5 -55   si nicio en 0
            //1 5 45 445
            //int indexLimit = 5;
            //int indexIni = 1;
            //int count = 1;
            //while (count <= indexLimit)
            //{
            //    Console.WriteLine(indexIni);
            //    indexIni = ((indexIni - 1) * 10) + 5;
            //    count++;
            //}

            //string texto = "11211";
            //string result = InvertirTexto(texto, 0);
            //if (texto.Equals(result))
            //{
            //    Console.WriteLine("El texto es un palindromo");
            //}
            //else
            //{
            //    Console.WriteLine("El texto no es un palindromo");
            //}

            string texto = "Hola Fundamentos!!";
            char ini = 'o';
            char fin = 'g';
            string result = FuncionReplace(texto, ini, fin);
        }

        public static string FuncionReplace(string textoIni, char charIni, char charFin)
        {
            string resultado = string.Empty;
            for (int index = 0; index < textoIni.Length; index++)
            {
                if (textoIni[index] == charIni)
                {
                    resultado = resultado + charFin;
                }
                else
                {
                    resultado = resultado + textoIni[index];
                }
            }
            return resultado;
        }

        //public static string InvertirTexto(string textoInicial, int index)
        //{
        //    if (index == textoInicial.Length - 1)
        //        return textoInicial[textoInicial.Length - 1].ToString();
        //    else
        //        return InvertirTexto(textoInicial, index + 1) + textoInicial[index].ToString();
        //}
    }
}
