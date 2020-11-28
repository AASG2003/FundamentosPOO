using BuscaminasLibrary.Modelos.ClasesPadre;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuscaminasLibrary.Modelos
{
    public enum Dificultad
    {
        baja,
        media,
        alta
    }

    public class Tablero
    {
        GeneradorTablero generador;
        public Tablero(Dificultad dificultad)
        {
            generador = new GeneradorTablero();
            InicializarTablero(dificultad);
        }

        public Celda[,] Celdas { get; set; }
        public int Tamanio { get; set; }
        public Dificultad Dificultad { get; set; }

        private void ReiniciarTablero(Dificultad dificultad)
        {
            InicializarTablero(dificultad);
        }

        private void InicializarTablero(Dificultad dificultad)
        {
            if (dificultad == Dificultad.baja)
                Tamanio = 10;
            else if (dificultad == Dificultad.media)
                Tamanio = 20;
            else Tamanio = 30;
            Celdas = generador.GenerarTablero(Tamanio);
        }

        public void VerCelda(int ejeX, int ejeY)
        {
            Celdas[ejeX, ejeY].EsVisible = true;
        }
    }
}
