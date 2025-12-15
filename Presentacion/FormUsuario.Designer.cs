namespace Presentacion
{
    partial class FormUsuario
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
            this.Tabla = new System.Windows.Forms.TableLayoutPanel();
            this.Grid = new System.Windows.Forms.DataGridView();
            this.Panel = new System.Windows.Forms.Panel();
            this.checkBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Book = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Tabla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            this.Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tabla
            // 
            this.Tabla.ColumnCount = 1;
            this.Tabla.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Tabla.Controls.Add(this.Grid, 0, 2);
            this.Tabla.Controls.Add(this.Panel, 0, 1);
            this.Tabla.Controls.Add(this.label2, 0, 0);
            this.Tabla.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tabla.Location = new System.Drawing.Point(0, 0);
            this.Tabla.Name = "Tabla";
            this.Tabla.RowCount = 3;
            this.Tabla.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.Tabla.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.Tabla.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 326F));
            this.Tabla.Size = new System.Drawing.Size(771, 520);
            this.Tabla.TabIndex = 0;
            // 
            // Grid
            // 
            this.Grid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Grid.GridColor = System.Drawing.SystemColors.Control;
            this.Grid.Location = new System.Drawing.Point(3, 95);
            this.Grid.Name = "Grid";
            this.Grid.RowHeadersWidth = 51;
            this.Grid.RowTemplate.Height = 24;
            this.Grid.Size = new System.Drawing.Size(765, 422);
            this.Grid.TabIndex = 0;
            // 
            // Panel
            // 
            this.Panel.Controls.Add(this.checkBox);
            this.Panel.Controls.Add(this.label1);
            this.Panel.Controls.Add(this.Book);
            this.Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel.Location = new System.Drawing.Point(3, 35);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(765, 54);
            this.Panel.TabIndex = 1;
            // 
            // checkBox
            // 
            this.checkBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox.AutoSize = true;
            this.checkBox.Location = new System.Drawing.Point(361, 16);
            this.checkBox.Name = "checkBox";
            this.checkBox.Size = new System.Drawing.Size(261, 20);
            this.checkBox.TabIndex = 2;
            this.checkBox.Text = "Mostrar solo pendientes de devolución";
            this.checkBox.UseVisualStyleBackColor = true;
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
            // Book
            // 
            this.Book.Location = new System.Drawing.Point(204, 13);
            this.Book.Name = "Book";
            this.Book.Size = new System.Drawing.Size(126, 22);
            this.Book.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(765, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Documentos prestados";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FormUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Tabla);
            this.Name = "FormUsuario";
            this.Size = new System.Drawing.Size(771, 520);
            this.VisibleChanged += new System.EventHandler(this.FormUsuario_VisibleChanged);
            this.Tabla.ResumeLayout(false);
            this.Tabla.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            this.Panel.ResumeLayout(false);
            this.Panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel Tabla;
        private System.Windows.Forms.DataGridView Grid;
        private System.Windows.Forms.Panel Panel;
        private System.Windows.Forms.CheckBox checkBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Book;
        private System.Windows.Forms.Label label2;
    }
}
