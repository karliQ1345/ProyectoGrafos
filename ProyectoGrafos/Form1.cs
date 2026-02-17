using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoGrafos
{
    public partial class Form1 : Form
    {
        private Grafo _grafo;
        private PointF[] _posiciones;
        public Form1()
        {
            InitializeComponent();
            btnCrearGrafo.Click += btnCrearGrafo_Click;

            btnRedibujar.Click += (s, e) => panelDibujo.Invalidate();

            panelDibujo.Paint += PanelDibujo_Paint;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCrearGrafo_Click(object sender, EventArgs e)
        {

            int n = (int)nudNodos.Value;
            bool dirigido = chkDirigido.Checked;

            _grafo = new Grafo(n, dirigido);

            ConfigurarGridMatriz(dgvPesos, n, editable: true);

            // Diagonal en 0
            for (int i = 0; i < n; i++)
                dgvPesos.Rows[i].Cells[i].Value = 0;

            // Combo de origen
            cbOrigen.Items.Clear();
            for (int i = 0; i < n; i++)
                cbOrigen.Items.Add($"Nodo {i}");
            cbOrigen.SelectedIndex = 0;

            // Posiciones para dibujar
            _posiciones = CrearLayoutCircular(panelDibujo.ClientSize, n);

            // Limpieza de salidas
            txtDijkstra.Clear();
            txtCaminosFloyd.Clear();
            dgvDistancias.Columns.Clear();
            dgvSiguiente.Columns.Clear();

            panelDibujo.Invalidate();
        }

        private void btnDijkstra_Click(object sender, EventArgs e)
        {
            if (_grafo == null) return;

            LeerPesosDesdeGrid(_grafo);

            int origen = cbOrigen.SelectedIndex;
            var resultado = Algoritmos.EjecutarDijkstra(_grafo, origen);

            var sb = new StringBuilder();
            sb.AppendLine($"Dijkstra desde Nodo {origen}");
            sb.AppendLine("----------------------------------");

            for (int v = 0; v < _grafo.NumeroNodos; v++)
            {
                if (resultado.Distancia[v] >= Grafo.INF)
                {
                    sb.AppendLine($"Nodo {v}: sin camino");
                    continue;
                }

                var camino = Algoritmos.ObtenerCaminoDesdePadres(v, resultado.Padre);
                sb.AppendLine($"Nodo {v}: costo = {resultado.Distancia[v]} | camino = {string.Join(" -> ", camino.Select(x => $"N{x}"))}");
            }

            txtDijkstra.Text = sb.ToString();
            panelDibujo.Invalidate();
        }

        private void btnFloyd_Click(object sender, EventArgs e)
        {
            if (_grafo == null) return;

            LeerPesosDesdeGrid(_grafo);

            var (distancias, siguiente) = Algoritmos.EjecutarFloydWarshall(_grafo);

            // Mostrar matrices
            ConfigurarGridMatriz(dgvDistancias, _grafo.NumeroNodos, editable: false);
            ConfigurarGridMatriz(dgvSiguiente, _grafo.NumeroNodos, editable: false);

            for (int i = 0; i < _grafo.NumeroNodos; i++)
            {
                for (int j = 0; j < _grafo.NumeroNodos; j++)
                {
                    dgvDistancias.Rows[i].Cells[j].Value =
                        (distancias[i, j] >= Grafo.INF) ? "INF" : distancias[i, j].ToString();

                    dgvSiguiente.Rows[i].Cells[j].Value = siguiente[i, j].ToString(); // -1 o siguiente nodo
                }
            }

            // Listado de caminos
            var sb = new StringBuilder();
            sb.AppendLine("Floyd–Warshall: caminos mínimos entre todos los pares");
            sb.AppendLine("----------------------------------------------------");

            for (int i = 0; i < _grafo.NumeroNodos; i++)
            {
                for (int j = 0; j < _grafo.NumeroNodos; j++)
                {
                    if (i == j) continue;

                    if (distancias[i, j] >= Grafo.INF)
                    {
                        sb.AppendLine($"N{i} -> N{j}: sin camino");
                        continue;
                    }

                    var camino = Algoritmos.ReconstruirCamino(i, j, siguiente);
                    sb.AppendLine($"N{i} -> N{j}: costo = {distancias[i, j]} | camino = {string.Join(" -> ", camino.Select(x => $"N{x}"))}");
                }
            }

            txtCaminosFloyd.Text = sb.ToString();
            panelDibujo.Invalidate();
        }
        private void LeerPesosDesdeGrid(Grafo grafo)
        {
            int n = grafo.NumeroNodos;
            bool ceroEsSinArista = chkCeroSinArista.Checked;

            // Reiniciar matriz
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    grafo.Pesos[i, j] = (i == j) ? 0 : Grafo.INF;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == j) continue;

                    var obj = dgvPesos.Rows[i].Cells[j].Value;
                    string texto = (obj == null) ? "" : obj.ToString().Trim();

                    if (string.IsNullOrEmpty(texto)) continue;

                    if (!int.TryParse(texto, out int costo)) continue;

                    if (costo < 0)
                        throw new Exception("No uses pesos negativos con Dijkstra.");

                    if (ceroEsSinArista && costo == 0)
                        continue;

                    grafo.AsignarArista(i, j, costo);
                }
            }
        }

        // -------------------- CONFIGURAR DATAGRIDVIEW --------------------
        private void ConfigurarGridMatriz(DataGridView dgv, int n, bool editable)
        {
            dgv.Columns.Clear();
            dgv.Rows.Clear();

            dgv.AllowUserToAddRows = false;
            dgv.RowHeadersWidth = 70;
            dgv.ReadOnly = !editable;

            for (int j = 0; j < n; j++)
            {
                dgv.Columns.Add($"c{j}", $"N{j}");
                dgv.Columns[j].Width = 55;
            }

            dgv.Rows.Add(n);
            for (int i = 0; i < n; i++)
                dgv.Rows[i].HeaderCell.Value = $"N{i}";
        }

        // -------------------- DIBUJO --------------------
        private void PanelDibujo_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            if (_grafo == null || _posiciones == null) return;

            using (var lapizArista = new Pen(Color.Gray, 2))
            using (var fuente = new Font("Segoe UI", 9))
            using (var brochaTexto = new SolidBrush(Color.Black))
            {
                // Aristas
                for (int u = 0; u < _grafo.NumeroNodos; u++)
                {
                    for (int v = 0; v < _grafo.NumeroNodos; v++)
                    {
                        int w = _grafo.Pesos[u, v];
                        if (u == v || w >= Grafo.INF) continue;

                        DibujarLineaConFlecha(e.Graphics, lapizArista, _posiciones[u], _posiciones[v], _grafo.EsDirigido);

                        // peso en el medio
                        var medio = new PointF(
                            (_posiciones[u].X + _posiciones[v].X) / 2f,
                            (_posiciones[u].Y + _posiciones[v].Y) / 2f
                        );

                        e.Graphics.DrawString(w.ToString(), fuente, brochaTexto, medio);
                    }
                }

                // Nodos
                float radio = 18f;
                using (var brochaNodo = new SolidBrush(Color.LightSkyBlue))
                using (var lapizNodo = new Pen(Color.DodgerBlue, 2))
                {
                    for (int i = 0; i < _grafo.NumeroNodos; i++)
                    {
                        var p = _posiciones[i];

                        e.Graphics.FillEllipse(brochaNodo, p.X - radio, p.Y - radio, 2 * radio, 2 * radio);
                        e.Graphics.DrawEllipse(lapizNodo, p.X - radio, p.Y - radio, 2 * radio, 2 * radio);

                        string etiqueta = "N" + i;
                        var tam = e.Graphics.MeasureString(etiqueta, fuente);
                        e.Graphics.DrawString(etiqueta, fuente, brochaTexto, p.X - tam.Width / 2, p.Y - tam.Height / 2);
                    }
                }
            }
        }


        private PointF[] CrearLayoutCircular(Size tamPanel, int n)
        {
            float cx = tamPanel.Width / 2f;
            float cy = tamPanel.Height / 2f;
            float radio = Math.Min(tamPanel.Width, tamPanel.Height) * 0.38f;

            var pos = new PointF[n];

            for (int i = 0; i < n; i++)
            {
                double ang = (2 * Math.PI * i) / n;
                pos[i] = new PointF(
                    cx + (float)(radio * Math.Cos(ang)),
                    cy + (float)(radio * Math.Sin(ang))
                );
            }

            return pos;
        }

        private void DibujarLineaConFlecha(Graphics g, Pen lapiz, PointF a, PointF b, bool dirigido)
        {
            g.DrawLine(lapiz, a, b);

            if (!dirigido) return;

            // flecha simple
            var dx = b.X - a.X;
            var dy = b.Y - a.Y;
            var len = Math.Sqrt(dx * dx + dy * dy);
            if (len < 0.001) return;

            float ux = (float)(dx / len);
            float uy = (float)(dy / len);

            // punta
            PointF punta = new PointF(b.X - ux * 22, b.Y - uy * 22);

            // alas
            PointF izq = new PointF(
                punta.X - ux * 10 - uy * 6,
                punta.Y - uy * 10 + ux * 6
            );

            PointF der = new PointF(
                punta.X - ux * 10 + uy * 6,
                punta.Y - uy * 10 - ux * 6
            );

            g.DrawLine(lapiz, punta, izq);
            g.DrawLine(lapiz, punta, der);
        }
    }
}
