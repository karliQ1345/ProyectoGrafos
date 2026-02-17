namespace ProyectoGrafos
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.nudNodos = new System.Windows.Forms.NumericUpDown();
            this.btnCrearGrafo = new System.Windows.Forms.Button();
            this.dgvPesos = new System.Windows.Forms.DataGridView();
            this.chkDirigido = new System.Windows.Forms.CheckBox();
            this.chkCeroSinArista = new System.Windows.Forms.CheckBox();
            this.cbOrigen = new System.Windows.Forms.ComboBox();
            this.btnDijkstra = new System.Windows.Forms.Button();
            this.txtDijkstra = new System.Windows.Forms.TextBox();
            this.btnFloyd = new System.Windows.Forms.Button();
            this.dgvDistancias = new System.Windows.Forms.DataGridView();
            this.dgvSiguiente = new System.Windows.Forms.DataGridView();
            this.txtCaminosFloyd = new System.Windows.Forms.TextBox();
            this.panelDibujo = new System.Windows.Forms.Panel();
            this.btnRedibujar = new System.Windows.Forms.Button();
            this.lblRealizadopor = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblEncabezado = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudNodos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDistancias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSiguiente)).BeginInit();
            this.SuspendLayout();
            // 
            // nudNodos
            // 
            this.nudNodos.Location = new System.Drawing.Point(54, 146);
            this.nudNodos.Margin = new System.Windows.Forms.Padding(2);
            this.nudNodos.Name = "nudNodos";
            this.nudNodos.Size = new System.Drawing.Size(80, 22);
            this.nudNodos.TabIndex = 0;
            this.nudNodos.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // btnCrearGrafo
            // 
            this.btnCrearGrafo.Location = new System.Drawing.Point(449, 142);
            this.btnCrearGrafo.Margin = new System.Windows.Forms.Padding(2);
            this.btnCrearGrafo.Name = "btnCrearGrafo";
            this.btnCrearGrafo.Size = new System.Drawing.Size(97, 28);
            this.btnCrearGrafo.TabIndex = 1;
            this.btnCrearGrafo.Text = "Crear grafo";
            this.btnCrearGrafo.UseVisualStyleBackColor = true;
            this.btnCrearGrafo.Click += new System.EventHandler(this.btnCrearGrafo_Click);
            // 
            // dgvPesos
            // 
            this.dgvPesos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPesos.Location = new System.Drawing.Point(40, 193);
            this.dgvPesos.Margin = new System.Windows.Forms.Padding(2);
            this.dgvPesos.Name = "dgvPesos";
            this.dgvPesos.RowHeadersWidth = 82;
            this.dgvPesos.RowTemplate.Height = 33;
            this.dgvPesos.Size = new System.Drawing.Size(641, 305);
            this.dgvPesos.TabIndex = 2;
            // 
            // chkDirigido
            // 
            this.chkDirigido.AutoSize = true;
            this.chkDirigido.Location = new System.Drawing.Point(184, 147);
            this.chkDirigido.Margin = new System.Windows.Forms.Padding(2);
            this.chkDirigido.Name = "chkDirigido";
            this.chkDirigido.Size = new System.Drawing.Size(76, 20);
            this.chkDirigido.TabIndex = 3;
            this.chkDirigido.Text = "Dirigido";
            this.chkDirigido.UseVisualStyleBackColor = true;
            // 
            // chkCeroSinArista
            // 
            this.chkCeroSinArista.AutoSize = true;
            this.chkCeroSinArista.Location = new System.Drawing.Point(294, 147);
            this.chkCeroSinArista.Margin = new System.Windows.Forms.Padding(2);
            this.chkCeroSinArista.Name = "chkCeroSinArista";
            this.chkCeroSinArista.Size = new System.Drawing.Size(100, 20);
            this.chkCeroSinArista.TabIndex = 4;
            this.chkCeroSinArista.Text = "0 = no arista";
            this.chkCeroSinArista.UseVisualStyleBackColor = true;
            // 
            // cbOrigen
            // 
            this.cbOrigen.FormattingEnabled = true;
            this.cbOrigen.Location = new System.Drawing.Point(61, 546);
            this.cbOrigen.Margin = new System.Windows.Forms.Padding(2);
            this.cbOrigen.Name = "cbOrigen";
            this.cbOrigen.Size = new System.Drawing.Size(82, 24);
            this.cbOrigen.TabIndex = 5;
            // 
            // btnDijkstra
            // 
            this.btnDijkstra.Location = new System.Drawing.Point(174, 542);
            this.btnDijkstra.Margin = new System.Windows.Forms.Padding(2);
            this.btnDijkstra.Name = "btnDijkstra";
            this.btnDijkstra.Size = new System.Drawing.Size(97, 28);
            this.btnDijkstra.TabIndex = 6;
            this.btnDijkstra.Text = "Dijkstra";
            this.btnDijkstra.UseVisualStyleBackColor = true;
            this.btnDijkstra.Click += new System.EventHandler(this.btnDijkstra_Click);
            // 
            // txtDijkstra
            // 
            this.txtDijkstra.Location = new System.Drawing.Point(40, 598);
            this.txtDijkstra.Margin = new System.Windows.Forms.Padding(2);
            this.txtDijkstra.Multiline = true;
            this.txtDijkstra.Name = "txtDijkstra";
            this.txtDijkstra.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDijkstra.Size = new System.Drawing.Size(306, 300);
            this.txtDijkstra.TabIndex = 7;
            // 
            // btnFloyd
            // 
            this.btnFloyd.Location = new System.Drawing.Point(497, 543);
            this.btnFloyd.Margin = new System.Windows.Forms.Padding(2);
            this.btnFloyd.Name = "btnFloyd";
            this.btnFloyd.Size = new System.Drawing.Size(97, 28);
            this.btnFloyd.TabIndex = 8;
            this.btnFloyd.Text = "Floyd–Warshall";
            this.btnFloyd.UseVisualStyleBackColor = true;
            this.btnFloyd.Click += new System.EventHandler(this.btnFloyd_Click);
            // 
            // dgvDistancias
            // 
            this.dgvDistancias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDistancias.Location = new System.Drawing.Point(731, 598);
            this.dgvDistancias.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDistancias.Name = "dgvDistancias";
            this.dgvDistancias.RowHeadersWidth = 82;
            this.dgvDistancias.RowTemplate.Height = 33;
            this.dgvDistancias.Size = new System.Drawing.Size(273, 222);
            this.dgvDistancias.TabIndex = 9;
            // 
            // dgvSiguiente
            // 
            this.dgvSiguiente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSiguiente.Location = new System.Drawing.Point(1070, 598);
            this.dgvSiguiente.Margin = new System.Windows.Forms.Padding(2);
            this.dgvSiguiente.Name = "dgvSiguiente";
            this.dgvSiguiente.RowHeadersWidth = 82;
            this.dgvSiguiente.RowTemplate.Height = 33;
            this.dgvSiguiente.Size = new System.Drawing.Size(273, 222);
            this.dgvSiguiente.TabIndex = 10;
            // 
            // txtCaminosFloyd
            // 
            this.txtCaminosFloyd.Location = new System.Drawing.Point(398, 598);
            this.txtCaminosFloyd.Margin = new System.Windows.Forms.Padding(2);
            this.txtCaminosFloyd.Multiline = true;
            this.txtCaminosFloyd.Name = "txtCaminosFloyd";
            this.txtCaminosFloyd.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCaminosFloyd.Size = new System.Drawing.Size(318, 300);
            this.txtCaminosFloyd.TabIndex = 11;
            // 
            // panelDibujo
            // 
            this.panelDibujo.Location = new System.Drawing.Point(765, 193);
            this.panelDibujo.Margin = new System.Windows.Forms.Padding(2);
            this.panelDibujo.Name = "panelDibujo";
            this.panelDibujo.Size = new System.Drawing.Size(469, 305);
            this.panelDibujo.TabIndex = 12;
            // 
            // btnRedibujar
            // 
            this.btnRedibujar.Location = new System.Drawing.Point(952, 147);
            this.btnRedibujar.Margin = new System.Windows.Forms.Padding(2);
            this.btnRedibujar.Name = "btnRedibujar";
            this.btnRedibujar.Size = new System.Drawing.Size(97, 28);
            this.btnRedibujar.TabIndex = 13;
            this.btnRedibujar.Text = "Dibujar";
            this.btnRedibujar.UseVisualStyleBackColor = true;
            this.btnRedibujar.Click += new System.EventHandler(this.btnRedibujar_Click);
            // 
            // lblRealizadopor
            // 
            this.lblRealizadopor.AutoSize = true;
            this.lblRealizadopor.Location = new System.Drawing.Point(51, 71);
            this.lblRealizadopor.Name = "lblRealizadopor";
            this.lblRealizadopor.Size = new System.Drawing.Size(281, 16);
            this.lblRealizadopor.TabIndex = 36;
            this.lblRealizadopor.Text = "Realizado por: Cristhian Guajan y Karla Quelal";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(505, 37);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(127, 16);
            this.lblTitulo.TabIndex = 35;
            this.lblTitulo.Text = "Grafos y Recorridos";
            // 
            // lblEncabezado
            // 
            this.lblEncabezado.AutoSize = true;
            this.lblEncabezado.Location = new System.Drawing.Point(470, 9);
            this.lblEncabezado.Name = "lblEncabezado";
            this.lblEncabezado.Size = new System.Drawing.Size(190, 16);
            this.lblEncabezado.TabIndex = 37;
            this.lblEncabezado.Text = "Universidad Técnica del Norte";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 16);
            this.label1.TabIndex = 38;
            this.label1.Text = "Número de Grafos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(809, 564);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 16);
            this.label2.TabIndex = 39;
            this.label2.Text = "Ponderaciones";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1168, 564);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 16);
            this.label3.TabIndex = 40;
            this.label3.Text = "Recorridos";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1400, 924);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblEncabezado);
            this.Controls.Add(this.lblRealizadopor);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnRedibujar);
            this.Controls.Add(this.panelDibujo);
            this.Controls.Add(this.txtCaminosFloyd);
            this.Controls.Add(this.dgvSiguiente);
            this.Controls.Add(this.dgvDistancias);
            this.Controls.Add(this.btnFloyd);
            this.Controls.Add(this.txtDijkstra);
            this.Controls.Add(this.btnDijkstra);
            this.Controls.Add(this.cbOrigen);
            this.Controls.Add(this.chkCeroSinArista);
            this.Controls.Add(this.chkDirigido);
            this.Controls.Add(this.dgvPesos);
            this.Controls.Add(this.btnCrearGrafo);
            this.Controls.Add(this.nudNodos);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudNodos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDistancias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSiguiente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudNodos;
        private System.Windows.Forms.Button btnCrearGrafo;
        private System.Windows.Forms.DataGridView dgvPesos;
        private System.Windows.Forms.CheckBox chkDirigido;
        private System.Windows.Forms.CheckBox chkCeroSinArista;
        private System.Windows.Forms.ComboBox cbOrigen;
        private System.Windows.Forms.Button btnDijkstra;
        private System.Windows.Forms.TextBox txtDijkstra;
        private System.Windows.Forms.Button btnFloyd;
        private System.Windows.Forms.DataGridView dgvDistancias;
        private System.Windows.Forms.DataGridView dgvSiguiente;
        private System.Windows.Forms.TextBox txtCaminosFloyd;
        private System.Windows.Forms.Panel panelDibujo;
        private System.Windows.Forms.Button btnRedibujar;
        private System.Windows.Forms.Label lblRealizadopor;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblEncabezado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

