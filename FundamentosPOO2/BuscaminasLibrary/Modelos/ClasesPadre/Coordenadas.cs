using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuscaminasLibrary.Modelos.ClasesPadre
{
    public class Coordenadas
    {
        public Coordenadas(int fila, int columna)
        {
            Fila = fila;
            Columna = columna;
        }

        public int Fila { get; set; }
        public int Columna { get; set; }
    }
}
