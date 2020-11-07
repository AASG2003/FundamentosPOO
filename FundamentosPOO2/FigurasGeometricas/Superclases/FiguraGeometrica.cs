using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigurasGeometricas.Superclases
{
    public abstract class FiguraGeometrica
    {
        public FiguraGeometrica(int baseFigura, int alturaFigura)
        {
            BaseFigura = baseFigura;
            AlturaFigura = alturaFigura;
        }

        public int BaseFigura { get; set; }
        public int AlturaFigura { get; set; }

        // mantenemos una impementacion de funcion en caso de tener funcionalidad y en caso de no necesitar
        // una funcion personalizada
        //public int CalcularArea()
        //{
        //    return BaseFigura * AlturaFigura;
        //}

        //public int Perimetro()
        //{
        //    return 2 * AlturaFigura + 2 * BaseFigura; 
        //}

        // si necesito una funcion personalizada por cada clase hija
        // es preferible crear una funcion abstracta, y asi implementar de forma parcial la clase abstracta

        abstract public int CalcularArea();
        abstract public int Perimetro();
    }
}
