using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoGrafos
{
    public class Grafo
    {
        public const int INF = 1_000_000_000;

        public int NumeroNodos { get; }
        public bool EsDirigido { get; set; }

        // Matriz de pesos (ponderaciones)
        public int[,] Pesos { get; }

        public Grafo(int numeroNodos, bool esDirigido)
        {
            NumeroNodos = numeroNodos;
            EsDirigido = esDirigido;
            Pesos = new int[numeroNodos, numeroNodos];

            for (int i = 0; i < numeroNodos; i++)
            {
                for (int j = 0; j < numeroNodos; j++)
                {
                    Pesos[i, j] = (i == j) ? 0 : INF;
                }
            }
        }

        public void AsignarArista(int origen, int destino, int costo)
        {
            if (origen < 0 || origen >= NumeroNodos || destino < 0 || destino >= NumeroNodos)
                throw new ArgumentOutOfRangeException("Nodo fuera de rango.");

            if (origen == destino) return;

            Pesos[origen, destino] = costo;

            // Si no es dirigido, se refleja en sentido contrario
            if (!EsDirigido)
                Pesos[destino, origen] = costo;
        }

        public IEnumerable<(int destino, int costo)> ObtenerVecinos(int nodo)
        {
            for (int v = 0; v < NumeroNodos; v++)
            {
                if (Pesos[nodo, v] < INF && nodo != v)
                    yield return (v, Pesos[nodo, v]);
            }
        }
    }
}