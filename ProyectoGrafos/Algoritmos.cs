using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoGrafos
{
    public static class Algoritmos
    {
        public static ResultadoDijkstra EjecutarDijkstra(Grafo grafo, int origen)
        {
            int n = grafo.NumeroNodos;
            var dist = new int[n];
            var padre = new int[n];
            var visitado = new bool[n];

            for (int i = 0; i < n; i++)
            {
                dist[i] = Grafo.INF;
                padre[i] = -1;
                visitado[i] = false;
            }
            dist[origen] = 0;

            for (int iter = 0; iter < n - 1; iter++)
            {
                int u = -1;
                int mejor = Grafo.INF;

                // buscar el no visitado con menor distancia
                for (int i = 0; i < n; i++)
                {
                    if (!visitado[i] && dist[i] < mejor)
                    {
                        mejor = dist[i];
                        u = i;
                    }
                }

                if (u == -1) break; // ya no hay alcanzables
                visitado[u] = true;

                foreach (var (v, costo) in grafo.ObtenerVecinos(u))
                {
                    if (!visitado[v] && dist[u] + costo < dist[v])
                    {
                        dist[v] = dist[u] + costo;
                        padre[v] = u;
                    }
                }
            }

            return new ResultadoDijkstra { Distancia = dist, Padre = padre };
        }

        // Floyd-Warshall: distancias + matriz "siguiente" para reconstruir caminos
        public static (int[,] distancias, int[,] siguiente) EjecutarFloydWarshall(Grafo grafo)
        {
            int n = grafo.NumeroNodos;
            var dist = new int[n, n];
            var next = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    dist[i, j] = grafo.Pesos[i, j];

                    if (i == j || grafo.Pesos[i, j] >= Grafo.INF)
                        next[i, j] = -1;
                    else
                        next[i, j] = j; // el siguiente desde i hacia j empieza yendo a j
                }
            }

            for (int k = 0; k < n; k++)
            {
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        if (dist[i, k] >= Grafo.INF || dist[k, j] >= Grafo.INF)
                            continue;

                        int nuevaDist = dist[i, k] + dist[k, j];

                        if (nuevaDist < dist[i, j])
                        {
                            dist[i, j] = nuevaDist;
                            next[i, j] = next[i, k];
                        }
                    }
                }
            }

            return (dist, next);
        }

        // Reconstruye el camino usando la matriz "siguiente"
        public static List<int> ReconstruirCamino(int origen, int destino, int[,] siguiente)
        {
            if (siguiente[origen, destino] == -1)
                return new List<int>(); // no existe camino

            var camino = new List<int> { origen };

            while (origen != destino)
            {
                origen = siguiente[origen, destino];
                if (origen == -1) return new List<int>(); // seguridad
                camino.Add(origen);
            }

            return camino;
        }

        // Reconstruye camino desde el arreglo Padre[] que deja Dijkstra
        public static List<int> ObtenerCaminoDesdePadres(int destino, int[] padre)
        {
            var camino = new List<int>();
            int actual = destino;

            while (actual != -1)
            {
                camino.Add(actual);
                actual = padre[actual];
            }

            camino.Reverse();
            return camino;
        }
    }
}
