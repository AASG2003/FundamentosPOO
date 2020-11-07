using FigurasGeometricas.Superclases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigurasGeometricas.Clases
{
    public class Rectangulo : FiguraGeometrica
    {
        public Rectangulo(int baseFigura, int alturaFigura)
            : base(baseFigura, alturaFigura)
        { }

        public override int CalcularArea()
        {
            return AlturaFigura * BaseFigura;
        }

        public override int Perimetro()
        {
            return 2 * BaseFigura + 2 * AlturaFigura;
        }
    }
}
