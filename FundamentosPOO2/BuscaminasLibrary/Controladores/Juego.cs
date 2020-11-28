using BuscaminasLibrary.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuscaminasLibrary.Controladores
{
    public class Juego
    {
        public Juego()
        {
            TableroJuego = new Tablero(Dificultad.baja);
        }

        public Tablero TableroJuego { get; set; }

        public void VerCelda(int ejeX, int ejeY)
        {
            TableroJuego.VerCelda(ejeX, ejeY);
        }
    }
}
