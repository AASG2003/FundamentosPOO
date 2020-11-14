using FigurasGeometricas.Superclases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigurasGeometricas.Clases
{
    public class Triangulo : FiguraGeometrica
    {
        public Triangulo(int baseFigura, int alturaFigura)
            : base(baseFigura, alturaFigura)
        { }

        public override int CalcularArea()
        {
            return (BaseFigura * AlturaFigura) / 2;
        }

        public override int Perimetro()
        {
            return 2 * AlturaFigura + BaseFigura;
        }

        public int CalcularHipotenusa()
        {
            return 10;
        }
    }
}
