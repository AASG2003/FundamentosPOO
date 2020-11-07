using FigurasGeometricas.Superclases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigurasGeometricas.Clases
{
    public class Cuadrado : FiguraGeometrica
    {
        public Cuadrado(int baseFigura, int alturaFigura)
            : base(baseFigura, alturaFigura)
        {}

        public override int CalcularArea()
        {
            return Convert.ToInt32(Math.Pow(BaseFigura, 2));
        }

        public int CalcularArea(int angulo)
        {
            return Convert.ToInt32(Math.Pow(BaseFigura, 2));
        }

        public override int Perimetro()
        {
            return 4 * BaseFigura;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
