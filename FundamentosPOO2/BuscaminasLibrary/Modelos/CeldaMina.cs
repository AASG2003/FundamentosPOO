using BuscaminasLibrary.Modelos.ClasesPadre;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuscaminasLibrary.Modelos
{
    public class CeldaMina : Celda
    {
        public override string ToString()
        {
            return EsVisible ? string.Format("  {0}  ","M") : string.Format("({0},{1})", Coordenadas.Fila, Coordenadas.Columna);
        }
    }
}
