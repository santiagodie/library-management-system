namespace Presentacion
{
    partial class UC_Inicio
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbBienvenida = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.lbNVencidos = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.lbNSala = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.lbNHoy = new System.Windows.Forms.Label();
            this.dgvPrestamos = new System.Windows.Forms.DataGridView();
            this.dgvVencidos = new System.Windows.Forms.DataGridView();
            this.dgvDevoluciones = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvActivos = new System.Windows.Forms.DataGridView();
            this.gbDevoluciones = new System.Windows.Forms.GroupBox();
            this.gbPrestamos = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestamos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVencidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDevoluciones)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActivos)).BeginInit();
            this.gbDevoluciones.SuspendLayout();
            this.gbPrestamos.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbBienvenida
            // 
            this.lbBienvenida.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lbBienvenida.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbBienvenida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBienvenida.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbBienvenida.Location = new System.Drawing.Point(0, 0);
            this.lbBienvenida.Name = "lbBienvenida";
            this.lbBienvenida.Size = new System.Drawing.Size(587, 25);
            this.lbBienvenida.TabIndex = 0;
            this.lbBienvenida.Text = "Bienvenido al Gestor de Sala.";
            this.lbBienvenida.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Controls.Add(this.lbBienvenida);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(587, 113);
            this.panel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this.panel4, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel3, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 25);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(587, 88);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.lbNVencidos);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(410, 10);
            this.panel4.Margin = new System.Windows.Forms.Padding(20, 10, 20, 10);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(157, 68);
            this.panel4.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Prestamos vencidos";
            // 
            // lbNVencidos
            // 
            this.lbNVencidos.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbNVencidos.Location = new System.Drawing.Point(0, 0);
            this.lbNVencidos.Name = "lbNVencidos";
            this.lbNVencidos.Size = new System.Drawing.Size(157, 16);
            this.lbNVencidos.TabIndex = 0;
            this.lbNVencidos.Text = "0";
            this.lbNVencidos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Info;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.lbNSala);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(215, 10);
            this.panel2.Margin = new System.Windows.Forms.Padding(20, 10, 20, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(155, 68);
            this.panel2.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Personas en Sala";
            // 
            // lbNSala
            // 
            this.lbNSala.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbNSala.Location = new System.Drawing.Point(0, 0);
            this.lbNSala.Margin = new System.Windows.Forms.Padding(10);
            this.lbNSala.Name = "lbNSala";
            this.lbNSala.Size = new System.Drawing.Size(155, 16);
            this.lbNSala.TabIndex = 2;
            this.lbNSala.Text = "0";
            this.lbNSala.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.lbNHoy);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(20, 10);
            this.panel3.Margin = new System.Windows.Forms.Padding(20, 10, 20, 10);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(155, 68);
            this.panel3.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.Location = new System.Drawing.Point(28, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Préstamos hoy";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbNHoy
            // 
            this.lbNHoy.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbNHoy.Location = new System.Drawing.Point(0, 0);
            this.lbNHoy.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.lbNHoy.Name = "lbNHoy";
            this.lbNHoy.Size = new System.Drawing.Size(155, 16);
            this.lbNHoy.TabIndex = 0;
            this.lbNHoy.Text = "0";
            this.lbNHoy.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // dgvPrestamos
            // 
            this.dgvPrestamos.AllowUserToAddRows = false;
            this.dgvPrestamos.AllowUserToDeleteRows = false;
            this.dgvPrestamos.AllowUserToResizeColumns = false;
            this.dgvPrestamos.AllowUserToResizeRows = false;
            this.dgvPrestamos.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvPrestamos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrestamos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPrestamos.GridColor = System.Drawing.SystemColors.Info;
            this.dgvPrestamos.Location = new System.Drawing.Point(3, 18);
            this.dgvPrestamos.Name = "dgvPrestamos";
            this.dgvPrestamos.ReadOnly = true;
            this.dgvPrestamos.RowHeadersVisible = false;
            this.dgvPrestamos.RowHeadersWidth = 51;
            this.dgvPrestamos.RowTemplate.Height = 24;
            this.dgvPrestamos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPrestamos.Size = new System.Drawing.Size(183, 132);
            this.dgvPrestamos.TabIndex = 3;
            // 
            // dgvVencidos
            // 
            this.dgvVencidos.AllowUserToAddRows = false;
            this.dgvVencidos.AllowUserToDeleteRows = false;
            this.dgvVencidos.AllowUserToResizeColumns = false;
            this.dgvVencidos.AllowUserToResizeRows = false;
            this.dgvVencidos.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvVencidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVencidos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvVencidos.GridColor = System.Drawing.SystemColors.Info;
            this.dgvVencidos.Location = new System.Drawing.Point(3, 18);
            this.dgvVencidos.Name = "dgvVencidos";
            this.dgvVencidos.ReadOnly = true;
            this.dgvVencidos.RowHeadersVisible = false;
            this.dgvVencidos.RowHeadersWidth = 51;
            this.dgvVencidos.RowTemplate.Height = 24;
            this.dgvVencidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVencidos.Size = new System.Drawing.Size(185, 291);
            this.dgvVencidos.TabIndex = 5;
            // 
            // dgvDevoluciones
            // 
            this.dgvDevoluciones.AllowUserToAddRows = false;
            this.dgvDevoluciones.AllowUserToDeleteRows = false;
            this.dgvDevoluciones.AllowUserToResizeColumns = false;
            this.dgvDevoluciones.AllowUserToResizeRows = false;
            this.dgvDevoluciones.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvDevoluciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDevoluciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDevoluciones.GridColor = System.Drawing.SystemColors.Info;
            this.dgvDevoluciones.Location = new System.Drawing.Point(3, 18);
            this.dgvDevoluciones.Name = "dgvDevoluciones";
            this.dgvDevoluciones.ReadOnly = true;
            this.dgvDevoluciones.RowHeadersVisible = false;
            this.dgvDevoluciones.RowHeadersWidth = 51;
            this.dgvDevoluciones.RowTemplate.Height = 24;
            this.dgvDevoluciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDevoluciones.Size = new System.Drawing.Size(183, 132);
            this.dgvDevoluciones.TabIndex = 6;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.gbDevoluciones, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.gbPrestamos, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 113);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(587, 338);
            this.tableLayoutPanel1.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvActivos);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(198, 3);
            this.groupBox1.Name = "groupBox1";
            this.tableLayoutPanel1.SetRowSpan(this.groupBox1, 2);
            this.groupBox1.Size = new System.Drawing.Size(189, 312);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Préstamos activos";
            // 
            // dgvActivos
            // 
            this.dgvActivos.AllowUserToAddRows = false;
            this.dgvActivos.AllowUserToDeleteRows = false;
            this.dgvActivos.AllowUserToResizeColumns = false;
            this.dgvActivos.AllowUserToResizeRows = false;
            this.dgvActivos.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvActivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvActivos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvActivos.GridColor = System.Drawing.SystemColors.Info;
            this.dgvActivos.Location = new System.Drawing.Point(3, 18);
            this.dgvActivos.Name = "dgvActivos";
            this.dgvActivos.ReadOnly = true;
            this.dgvActivos.RowHeadersVisible = false;
            this.dgvActivos.RowHeadersWidth = 51;
            this.dgvActivos.RowTemplate.Height = 24;
            this.dgvActivos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvActivos.Size = new System.Drawing.Size(183, 291);
            this.dgvActivos.TabIndex = 6;
            // 
            // gbDevoluciones
            // 
            this.gbDevoluciones.Controls.Add(this.dgvDevoluciones);
            this.gbDevoluciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbDevoluciones.Location = new System.Drawing.Point(3, 162);
            this.gbDevoluciones.Name = "gbDevoluciones";
            this.gbDevoluciones.Size = new System.Drawing.Size(189, 153);
            this.gbDevoluciones.TabIndex = 12;
            this.gbDevoluciones.TabStop = false;
            this.gbDevoluciones.Text = "Últimas devoluciones";
            // 
            // gbPrestamos
            // 
            this.gbPrestamos.Controls.Add(this.dgvPrestamos);
            this.gbPrestamos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbPrestamos.Location = new System.Drawing.Point(3, 3);
            this.gbPrestamos.Name = "gbPrestamos";
            this.gbPrestamos.Size = new System.Drawing.Size(189, 153);
            this.gbPrestamos.TabIndex = 0;
            this.gbPrestamos.TabStop = false;
            this.gbPrestamos.Text = "Últimos préstamos";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvVencidos);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(393, 3);
            this.groupBox2.Name = "groupBox2";
            this.tableLayoutPanel1.SetRowSpan(this.groupBox2, 2);
            this.groupBox2.Size = new System.Drawing.Size(191, 312);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Préstamos vencidos";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // UC_Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Name = "UC_Inicio";
            this.Size = new System.Drawing.Size(587, 451);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestamos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVencidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDevoluciones)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvActivos)).EndInit();
            this.gbDevoluciones.ResumeLayout(false);
            this.gbPrestamos.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbBienvenida;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbNVencidos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbNHoy;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbNSala;
        private System.Windows.Forms.DataGridView dgvPrestamos;
        private System.Windows.Forms.DataGridView dgvVencidos;
        private System.Windows.Forms.DataGridView dgvDevoluciones;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox gbDevoluciones;
        private System.Windows.Forms.GroupBox gbPrestamos;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvActivos;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    }
}
