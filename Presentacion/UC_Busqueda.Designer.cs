namespace Presentacion.Properties
{
    partial class UC_Busqueda
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.gbFiltros = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbUsuario = new System.Windows.Forms.Label();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.lbAutor = new System.Windows.Forms.Label();
            this.lbTipo = new System.Windows.Forms.Label();
            this.cbTipo = new System.Windows.Forms.ComboBox();
            this.lbISBN = new System.Windows.Forms.Label();
            this.lbEjemplar = new System.Windows.Forms.Label();
            this.lbFecha = new System.Windows.Forms.Label();
            this.lbEstado = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.btLimpiar = new System.Windows.Forms.Button();
            this.btBuscar = new System.Windows.Forms.Button();
            this.cbUsuario = new System.Windows.Forms.ComboBox();
            this.cbTitulo = new System.Windows.Forms.ComboBox();
            this.cbAutor = new System.Windows.Forms.ComboBox();
            this.cbISBN = new System.Windows.Forms.ComboBox();
            this.cbEjemplar = new System.Windows.Forms.ComboBox();
            this.dgvResultados = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.gbFiltros.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gbFiltros);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(656, 120);
            this.panel1.TabIndex = 0;
            // 
            // gbFiltros
            // 
            this.gbFiltros.Controls.Add(this.tableLayoutPanel1);
            this.gbFiltros.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbFiltros.Location = new System.Drawing.Point(0, 0);
            this.gbFiltros.Name = "gbFiltros";
            this.gbFiltros.Size = new System.Drawing.Size(656, 120);
            this.gbFiltros.TabIndex = 0;
            this.gbFiltros.TabStop = false;
            this.gbFiltros.Text = "Filtros de búsqueda";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.lbUsuario, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbTitulo, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbAutor, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbTipo, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.cbTipo, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbISBN, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbEjemplar, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbFecha, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbEstado, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.dtpFecha, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.cbEstado, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.btLimpiar, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.btBuscar, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.cbUsuario, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.cbTitulo, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.cbAutor, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.cbISBN, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.cbEjemplar, 1, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 18);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(650, 99);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lbUsuario
            // 
            this.lbUsuario.AutoSize = true;
            this.lbUsuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbUsuario.Location = new System.Drawing.Point(3, 0);
            this.lbUsuario.Name = "lbUsuario";
            this.lbUsuario.Size = new System.Drawing.Size(136, 16);
            this.lbUsuario.TabIndex = 0;
            this.lbUsuario.Text = "Usuario";
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Location = new System.Drawing.Point(145, 0);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(40, 16);
            this.lbTitulo.TabIndex = 1;
            this.lbTitulo.Text = "Titulo";
            // 
            // lbAutor
            // 
            this.lbAutor.AutoSize = true;
            this.lbAutor.Location = new System.Drawing.Point(287, 0);
            this.lbAutor.Name = "lbAutor";
            this.lbAutor.Size = new System.Drawing.Size(38, 16);
            this.lbAutor.TabIndex = 2;
            this.lbAutor.Text = "Autor";
            // 
            // lbTipo
            // 
            this.lbTipo.AutoSize = true;
            this.lbTipo.Location = new System.Drawing.Point(429, 0);
            this.lbTipo.Name = "lbTipo";
            this.lbTipo.Size = new System.Drawing.Size(35, 16);
            this.lbTipo.TabIndex = 3;
            this.lbTipo.Text = "Tipo";
            // 
            // cbTipo
            // 
            this.cbTipo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbTipo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.Location = new System.Drawing.Point(429, 19);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(121, 24);
            this.cbTipo.TabIndex = 7;
            this.cbTipo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UC_Busqueda_KeyPress);
            // 
            // lbISBN
            // 
            this.lbISBN.AutoSize = true;
            this.lbISBN.Location = new System.Drawing.Point(3, 46);
            this.lbISBN.Name = "lbISBN";
            this.lbISBN.Size = new System.Drawing.Size(38, 16);
            this.lbISBN.TabIndex = 8;
            this.lbISBN.Text = "ISBN";
            // 
            // lbEjemplar
            // 
            this.lbEjemplar.AutoSize = true;
            this.lbEjemplar.Location = new System.Drawing.Point(145, 46);
            this.lbEjemplar.Name = "lbEjemplar";
            this.lbEjemplar.Size = new System.Drawing.Size(108, 16);
            this.lbEjemplar.TabIndex = 9;
            this.lbEjemplar.Text = "Código Ejemplar";
            // 
            // lbFecha
            // 
            this.lbFecha.AutoSize = true;
            this.lbFecha.Location = new System.Drawing.Point(287, 46);
            this.lbFecha.Name = "lbFecha";
            this.lbFecha.Size = new System.Drawing.Size(98, 16);
            this.lbFecha.TabIndex = 10;
            this.lbFecha.Text = "Fecha de inicio";
            // 
            // lbEstado
            // 
            this.lbEstado.AutoSize = true;
            this.lbEstado.Location = new System.Drawing.Point(429, 46);
            this.lbEstado.Name = "lbEstado";
            this.lbEstado.Size = new System.Drawing.Size(50, 16);
            this.lbEstado.TabIndex = 11;
            this.lbEstado.Text = "Estado";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(287, 65);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(136, 22);
            this.dtpFecha.TabIndex = 14;
            this.dtpFecha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UC_Busqueda_KeyPress);
            // 
            // cbEstado
            // 
            this.cbEstado.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbEstado.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Location = new System.Drawing.Point(429, 65);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(121, 24);
            this.cbEstado.TabIndex = 15;
            this.cbEstado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UC_Busqueda_KeyPress);
            // 
            // btLimpiar
            // 
            this.btLimpiar.Location = new System.Drawing.Point(571, 3);
            this.btLimpiar.Name = "btLimpiar";
            this.tableLayoutPanel1.SetRowSpan(this.btLimpiar, 2);
            this.btLimpiar.Size = new System.Drawing.Size(75, 28);
            this.btLimpiar.TabIndex = 16;
            this.btLimpiar.Text = "Ver todos";
            this.btLimpiar.UseVisualStyleBackColor = true;
            this.btLimpiar.Click += new System.EventHandler(this.btLimpiar_Click);
            // 
            // btBuscar
            // 
            this.btBuscar.Image = global::Presentacion.Properties.Resources.ImagenBuscar__1_;
            this.btBuscar.Location = new System.Drawing.Point(571, 65);
            this.btBuscar.Name = "btBuscar";
            this.tableLayoutPanel1.SetRowSpan(this.btBuscar, 2);
            this.btBuscar.Size = new System.Drawing.Size(56, 35);
            this.btBuscar.TabIndex = 17;
            this.btBuscar.UseVisualStyleBackColor = true;
            this.btBuscar.Click += new System.EventHandler(this.btBuscar_Click);
            // 
            // cbUsuario
            // 
            this.cbUsuario.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbUsuario.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbUsuario.FormattingEnabled = true;
            this.cbUsuario.Location = new System.Drawing.Point(3, 19);
            this.cbUsuario.Name = "cbUsuario";
            this.cbUsuario.Size = new System.Drawing.Size(121, 24);
            this.cbUsuario.TabIndex = 18;
            // 
            // cbTitulo
            // 
            this.cbTitulo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbTitulo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbTitulo.FormattingEnabled = true;
            this.cbTitulo.Location = new System.Drawing.Point(145, 19);
            this.cbTitulo.Name = "cbTitulo";
            this.cbTitulo.Size = new System.Drawing.Size(121, 24);
            this.cbTitulo.TabIndex = 19;
            // 
            // cbAutor
            // 
            this.cbAutor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbAutor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbAutor.FormattingEnabled = true;
            this.cbAutor.Location = new System.Drawing.Point(287, 19);
            this.cbAutor.Name = "cbAutor";
            this.cbAutor.Size = new System.Drawing.Size(121, 24);
            this.cbAutor.TabIndex = 20;
            // 
            // cbISBN
            // 
            this.cbISBN.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbISBN.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbISBN.FormattingEnabled = true;
            this.cbISBN.Location = new System.Drawing.Point(3, 65);
            this.cbISBN.Name = "cbISBN";
            this.cbISBN.Size = new System.Drawing.Size(121, 24);
            this.cbISBN.TabIndex = 21;
            // 
            // cbEjemplar
            // 
            this.cbEjemplar.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbEjemplar.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbEjemplar.FormattingEnabled = true;
            this.cbEjemplar.Location = new System.Drawing.Point(145, 65);
            this.cbEjemplar.Name = "cbEjemplar";
            this.cbEjemplar.Size = new System.Drawing.Size(121, 24);
            this.cbEjemplar.TabIndex = 22;
            // 
            // dgvResultados
            // 
            this.dgvResultados.AllowUserToAddRows = false;
            this.dgvResultados.AllowUserToDeleteRows = false;
            this.dgvResultados.AllowUserToResizeColumns = false;
            this.dgvResultados.AllowUserToResizeRows = false;
            this.dgvResultados.ColumnHeadersHeight = 29;
            this.dgvResultados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvResultados.Location = new System.Drawing.Point(0, 120);
            this.dgvResultados.Name = "dgvResultados";
            this.dgvResultados.RowHeadersVisible = false;
            this.dgvResultados.RowHeadersWidth = 51;
            this.dgvResultados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvResultados.Size = new System.Drawing.Size(656, 419);
            this.dgvResultados.TabIndex = 0;
            this.dgvResultados.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvResultados_CellDoubleClick);
            // 
            // UC_Busqueda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvResultados);
            this.Controls.Add(this.panel1);
            this.Name = "UC_Busqueda";
            this.Size = new System.Drawing.Size(656, 539);
            this.Load += new System.EventHandler(this.UC_Busqueda_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UC_Busqueda_KeyPress);
            this.panel1.ResumeLayout(false);
            this.gbFiltros.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gbFiltros;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lbUsuario;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.Label lbAutor;
        private System.Windows.Forms.Label lbTipo;
        private System.Windows.Forms.DataGridView dgvResultados;
        private System.Windows.Forms.ComboBox cbTipo;
        private System.Windows.Forms.Label lbISBN;
        private System.Windows.Forms.Label lbEjemplar;
        private System.Windows.Forms.Label lbFecha;
        private System.Windows.Forms.Label lbEstado;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.Button btLimpiar;
        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.ComboBox cbUsuario;
        private System.Windows.Forms.ComboBox cbTitulo;
        private System.Windows.Forms.ComboBox cbAutor;
        private System.Windows.Forms.ComboBox cbISBN;
        private System.Windows.Forms.ComboBox cbEjemplar;
    }
}
