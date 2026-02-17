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
            ((System.ComponentModel.ISupportInitialize)(this.nudNodos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDistancias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSiguiente)).BeginInit();
            this.SuspendLayout();
            // 
            // nudNodos
            // 
            this.nudNodos.Location = new System.Drawing.Point(88, 64);
            this.nudNodos.Name = "nudNodos";
            this.nudNodos.Size = new System.Drawing.Size(120, 31);
            this.nudNodos.TabIndex = 0;
            this.nudNodos.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // btnCrearGrafo
            // 
            this.btnCrearGrafo.Location = new System.Drawing.Point(681, 58);
            this.btnCrearGrafo.Name = "btnCrearGrafo";
            this.btnCrearGrafo.Size = new System.Drawing.Size(146, 43);
            this.btnCrearGrafo.TabIndex = 1;
            this.btnCrearGrafo.Text = "Crear grafo";
            this.btnCrearGrafo.UseVisualStyleBackColor = true;
            this.btnCrearGrafo.Click += new System.EventHandler(this.btnCrearGrafo_Click);
            // 
            // dgvPesos
            // 
            this.dgvPesos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPesos.Location = new System.Drawing.Point(67, 138);
            this.dgvPesos.Name = "dgvPesos";
            this.dgvPesos.RowHeadersWidth = 82;
            this.dgvPesos.RowTemplate.Height = 33;
            this.dgvPesos.Size = new System.Drawing.Size(962, 477);
            this.dgvPesos.TabIndex = 2;
            // 
            // chkDirigido
            // 
            this.chkDirigido.AutoSize = true;
            this.chkDirigido.Location = new System.Drawing.Point(283, 66);
            this.chkDirigido.Name = "chkDirigido";
            this.chkDirigido.Size = new System.Drawing.Size(117, 29);
            this.chkDirigido.TabIndex = 3;
            this.chkDirigido.Text = "Dirigido";
            this.chkDirigido.UseVisualStyleBackColor = true;
            // 
            // chkCeroSinArista
            // 
            this.chkCeroSinArista.AutoSize = true;
            this.chkCeroSinArista.Location = new System.Drawing.Point(449, 65);
            this.chkCeroSinArista.Name = "chkCeroSinArista";
            this.chkCeroSinArista.Size = new System.Drawing.Size(163, 29);
            this.chkCeroSinArista.TabIndex = 4;
            this.chkCeroSinArista.Text = "0 = no arista";
            this.chkCeroSinArista.UseVisualStyleBackColor = true;
            // 
            // cbOrigen
            // 
            this.cbOrigen.FormattingEnabled = true;
            this.cbOrigen.Location = new System.Drawing.Point(99, 729);
            this.cbOrigen.Name = "cbOrigen";
            this.cbOrigen.Size = new System.Drawing.Size(121, 33);
            this.cbOrigen.TabIndex = 5;
            // 
            // btnDijkstra
            // 
            this.btnDijkstra.Location = new System.Drawing.Point(269, 723);
            this.btnDijkstra.Name = "btnDijkstra";
            this.btnDijkstra.Size = new System.Drawing.Size(146, 43);
            this.btnDijkstra.TabIndex = 6;
            this.btnDijkstra.Text = "Dijkstra";
            this.btnDijkstra.UseVisualStyleBackColor = true;
            this.btnDijkstra.Click += new System.EventHandler(this.btnDijkstra_Click);
            // 
            // txtDijkstra
            // 
            this.txtDijkstra.Location = new System.Drawing.Point(77, 811);
            this.txtDijkstra.Multiline = true;
            this.txtDijkstra.Name = "txtDijkstra";
            this.txtDijkstra.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDijkstra.Size = new System.Drawing.Size(390, 224);
            this.txtDijkstra.TabIndex = 7;
            // 
            // btnFloyd
            // 
            this.btnFloyd.Location = new System.Drawing.Point(547, 723);
            this.btnFloyd.Name = "btnFloyd";
            this.btnFloyd.Size = new System.Drawing.Size(146, 43);
            this.btnFloyd.TabIndex = 8;
            this.btnFloyd.Text = "Floyd–Warshall";
            this.btnFloyd.UseVisualStyleBackColor = true;
            this.btnFloyd.Click += new System.EventHandler(this.btnFloyd_Click);
            // 
            // dgvDistancias
            // 
            this.dgvDistancias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDistancias.Location = new System.Drawing.Point(523, 811);
            this.dgvDistancias.Name = "dgvDistancias";
            this.dgvDistancias.RowHeadersWidth = 82;
            this.dgvDistancias.RowTemplate.Height = 33;
            this.dgvDistancias.Size = new System.Drawing.Size(240, 150);
            this.dgvDistancias.TabIndex = 9;
            // 
            // dgvSiguiente
            // 
            this.dgvSiguiente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSiguiente.Location = new System.Drawing.Point(789, 811);
            this.dgvSiguiente.Name = "dgvSiguiente";
            this.dgvSiguiente.RowHeadersWidth = 82;
            this.dgvSiguiente.RowTemplate.Height = 33;
            this.dgvSiguiente.Size = new System.Drawing.Size(240, 150);
            this.dgvSiguiente.TabIndex = 10;
            // 
            // txtCaminosFloyd
            // 
            this.txtCaminosFloyd.Location = new System.Drawing.Point(511, 980);
            this.txtCaminosFloyd.Multiline = true;
            this.txtCaminosFloyd.Name = "txtCaminosFloyd";
            this.txtCaminosFloyd.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCaminosFloyd.Size = new System.Drawing.Size(390, 224);
            this.txtCaminosFloyd.TabIndex = 11;
            // 
            // panelDibujo
            // 
            this.panelDibujo.Location = new System.Drawing.Point(1161, 215);
            this.panelDibujo.Name = "panelDibujo";
            this.panelDibujo.Size = new System.Drawing.Size(575, 331);
            this.panelDibujo.TabIndex = 12;
            // 
            // btnRedibujar
            // 
            this.btnRedibujar.Location = new System.Drawing.Point(1398, 92);
            this.btnRedibujar.Name = "btnRedibujar";
            this.btnRedibujar.Size = new System.Drawing.Size(146, 43);
            this.btnRedibujar.TabIndex = 13;
            this.btnRedibujar.Text = "Dibujar";
            this.btnRedibujar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1793, 1338);
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
    }
}

