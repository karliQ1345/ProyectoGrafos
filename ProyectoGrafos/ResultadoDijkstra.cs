using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoGrafos
{
    public class ResultadoDijkstra
    {
        public int[] Distancia { get; set; } = Array.Empty<int>();
        public int[] Padre { get; set; } = Array.Empty<int>();
    }
}
