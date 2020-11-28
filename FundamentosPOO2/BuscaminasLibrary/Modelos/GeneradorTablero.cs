using BuscaminasLibrary.Modelos.ClasesPadre;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuscaminasLibrary.Modelos
{
    public class GeneradorTablero
    {
        public Celda[,] GenerarTablero(int tamanio)
        {
            Celda[,] nuevoTablero = new Celda[tamanio, tamanio];
            nuevoTablero = AgregarMinas(nuevoTablero, tamanio);
            nuevoTablero = AgregarIndicadores(nuevoTablero, tamanio);
            return nuevoTablero;
        }

        private Celda[,] AgregarMinas(Celda[,] celdas, int tamanio)
        {
            Random numeroRandomico = new Random();
            double cantMinas = tamanio * tamanio * 0.2;
            for (int index = 1; index < cantMinas; index++)
            {
                int ejeX = numeroRandomico.Next(0, tamanio);
                int ejeY = numeroRandomico.Next(0, tamanio - 1);
                Coordenadas coordenadas = new Coordenadas(
                    ejeX, ejeY);
                CeldaMina mina = new CeldaMina() { Coordenadas = coordenadas, EsVisible = false };
                celdas[ejeX, ejeY] = mina;
            }
            return celdas;
        }

        private Celda[,] AgregarIndicadores(Celda[,] celdas, int tamanio)
        {
            for (int ejeX = 0; ejeX < tamanio; ejeX++)
            {
                for (int ejeY = 0; ejeY < tamanio; ejeY++)
                {
                    if (celdas[ejeX, ejeY] == null)
                    {
                        Coordenadas coordenadas = new Coordenadas(ejeX, ejeY);
                        CeldaIndicador indicador = new CeldaIndicador() {
                             CantidadMinas = CalcularMinasAlrededor(celdas, coordenadas, tamanio),
                             Coordenadas = coordenadas,
                             EsVisible = false
                        };
                        celdas[ejeX, ejeY] = indicador;
                    }
                }
            }
            return celdas;
        }

        private int CalcularMinasAlrededor(Celda[,] celdas, Coordenadas coordenadas, int tamanio)
        {
            int contadorMinas = 0;
            for (int ejeX = 0; ejeX < tamanio; ejeX++)
            {
                for (int ejeY = 0; ejeY < tamanio; ejeY++)
                {
                    if ((ejeX == coordenadas.Fila - 1 || ejeX == coordenadas.Fila || ejeX == coordenadas.Fila + 1) && 
                        (ejeY == coordenadas.Columna - 1 || ejeY == coordenadas.Columna || ejeY == coordenadas.Columna + 1))
                    {
                        if (celdas[ejeX, ejeY] is CeldaMina)
                            contadorMinas++;
                    }
                }
            }
            return contadorMinas;
        }
    }
}
