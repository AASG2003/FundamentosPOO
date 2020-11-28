using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuscaminasLibrary.Modelos.ClasesPadre
{
    

    public abstract class Celda
    {
        public bool EsVisible { get; set; }
        public Coordenadas Coordenadas { get; set; }
    }
}
