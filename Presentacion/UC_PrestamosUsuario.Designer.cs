namespace Presentacion
{
    partial class UC_PrestamosUsuario
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Tabla = new System.Windows.Forms.TableLayoutPanel();
            this.Grid = new System.Windows.Forms.DataGridView();
            this.Panel = new System.Windows.Forms.Panel();
            this.PendientesBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BookBox = new System.Windows.Forms.TextBox();
            this.formUsuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Título = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Autor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ISBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaPrestamo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pendiente = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Tabla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            this.Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.formUsuarioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Tabla
            // 
            this.Tabla.ColumnCount = 1;
            this.Tabla.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Tabla.Controls.Add(this.Grid, 0, 1);
            this.Tabla.Controls.Add(this.Panel, 0, 0);
            this.Tabla.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tabla.Location = new System.Drawing.Point(0, 0);
            this.Tabla.Name = "Tabla";
            this.Tabla.RowCount = 2;
            this.Tabla.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.Tabla.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 326F));
            this.Tabla.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.Tabla.Size = new System.Drawing.Size(753, 473);
            this.Tabla.TabIndex = 0;
            // 
            // Grid
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Grid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Grid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Título,
            this.Autor,
            this.ISBN,
            this.FechaPrestamo,
            this.FechaFin,
            this.Pendiente});
            this.Grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Grid.GridColor = System.Drawing.SystemColors.Control;
            this.Grid.Location = new System.Drawing.Point(3, 63);
            this.Grid.Name = "Grid";
            this.Grid.ReadOnly = true;
            this.Grid.RowHeadersVisible = false;
            this.Grid.RowHeadersWidth = 51;
            this.Grid.RowTemplate.Height = 24;
            this.Grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Grid.Size = new System.Drawing.Size(747, 407);
            this.Grid.TabIndex = 0;
            // 
            // Panel
            // 
            this.Panel.Controls.Add(this.PendientesBox);
            this.Panel.Controls.Add(this.label1);
            this.Panel.Controls.Add(this.BookBox);
            this.Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel.Location = new System.Drawing.Point(3, 3);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(747, 54);
            this.Panel.TabIndex = 1;
            // 
            // PendientesBox
            // 
            this.PendientesBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PendientesBox.AutoSize = true;
            this.PendientesBox.Location = new System.Drawing.Point(361, 16);
            this.PendientesBox.Name = "PendientesBox";
            this.PendientesBox.Size = new System.Drawing.Size(261, 20);
            this.PendientesBox.TabIndex = 2;
            this.PendientesBox.Text = "Mostrar solo pendientes de devolución";
            this.PendientesBox.UseVisualStyleBackColor = true;
            this.PendientesBox.CheckedChanged += new System.EventHandler(this.Cambio);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre del documento";
            // 
            // BookBox
            // 
            this.BookBox.Location = new System.Drawing.Point(204, 13);
            this.BookBox.Name = "BookBox";
            this.BookBox.Size = new System.Drawing.Size(126, 22);
            this.BookBox.TabIndex = 0;
            this.BookBox.TextChanged += new System.EventHandler(this.Cambio);
            // 
            // formUsuarioBindingSource
            // 
            this.formUsuarioBindingSource.DataSource = typeof(Presentacion.FormUsuario);
            // 
            // Título
            //
            this.Título.DataPropertyName = "Título";
            this.Título.HeaderText = "Título";
            this.Título.MinimumWidth = 6;
            this.Título.Name = "Título";
            this.Título.ReadOnly = true;
            // 
            // Autor
            //
            this.Autor.DataPropertyName = "Autor";
            this.Autor.HeaderText = "Autor";
            this.Autor.MinimumWidth = 6;
            this.Autor.Name = "Autor";
            this.Autor.ReadOnly = true;
            // 
            // ISBN
            //
            this.ISBN.DataPropertyName = "ISBN";
            this.ISBN.HeaderText = "ISBN";
            this.ISBN.MinimumWidth = 6;
            this.ISBN.Name = "ISBN";
            this.ISBN.ReadOnly = true;
            // 
            // FechaPrestamo
            //
            this.FechaPrestamo.DataPropertyName = "FechaPrestamo";
            this.FechaPrestamo.HeaderText = "Fecha de préstamo";
            this.FechaPrestamo.MinimumWidth = 6;
            this.FechaPrestamo.Name = "FechaPrestamo";
            this.FechaPrestamo.ReadOnly = true;
            // 
            // FechaFin
            //
            this.FechaFin.DataPropertyName = "FechaFin";
            this.FechaFin.HeaderText = "Fecha fin de préstamo";
            this.FechaFin.MinimumWidth = 6;
            this.FechaFin.Name = "FechaFin";
            this.FechaFin.ReadOnly = true;
            // 
            // Pendiente
            //
            this.Pendiente.DataPropertyName = "Pendiente";
            this.Pendiente.HeaderText = "Pendiente de devolución";
            this.Pendiente.MinimumWidth = 6;
            this.Pendiente.Name = "Pendiente";
            this.Pendiente.ReadOnly = true;
            // 
            // FormUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 473);
            this.Controls.Add(this.Tabla);
            this.Name = "FormUsuario";
            this.Text = "Documentos prestados";
            this.Tabla.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            this.Panel.ResumeLayout(false);
            this.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.formUsuarioBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel Tabla;
        private System.Windows.Forms.DataGridView Grid;
        private System.Windows.Forms.Panel Panel;
        private System.Windows.Forms.CheckBox PendientesBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox BookBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn Título;
        private System.Windows.Forms.DataGridViewTextBoxColumn Autor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ISBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaPrestamo;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaFin;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Pendiente;
        private System.Windows.Forms.BindingSource formUsuarioBindingSource;
    }
}
