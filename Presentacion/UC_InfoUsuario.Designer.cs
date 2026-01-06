namespace Presentacion
{
    partial class UC_InfoUsuario
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
            this.label1 = new System.Windows.Forms.Label();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DNIBox = new System.Windows.Forms.TextBox();
            this.PrestBtn = new System.Windows.Forms.Button();
            this.panelNavegacion = new System.Windows.Forms.Panel();
            this.tbIndice = new System.Windows.Forms.TextBox();
            this.tbTotal = new System.Windows.Forms.TextBox();
            this.btAnterior = new System.Windows.Forms.Button();
            this.btPrimero = new System.Windows.Forms.Button();
            this.btSiguiente = new System.Windows.Forms.Button();
            this.btUltimo = new System.Windows.Forms.Button();
            this.panelNavegacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(68, 96);
            this.NameBox.Name = "NameBox";
            this.NameBox.ReadOnly = true;
            this.NameBox.Size = new System.Drawing.Size(129, 22);
            this.NameBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "DNI";
            // 
            // DNIBox
            // 
            this.DNIBox.Location = new System.Drawing.Point(68, 150);
            this.DNIBox.Name = "DNIBox";
            this.DNIBox.ReadOnly = true;
            this.DNIBox.Size = new System.Drawing.Size(129, 22);
            this.DNIBox.TabIndex = 3;
            // 
            // PrestBtn
            // 
            this.PrestBtn.Image = global::Presentacion.Properties.Resources.Prestamo;
            this.PrestBtn.Location = new System.Drawing.Point(225, 88);
            this.PrestBtn.Name = "PrestBtn";
            this.PrestBtn.Size = new System.Drawing.Size(130, 97);
            this.PrestBtn.TabIndex = 4;
            this.PrestBtn.Text = "Préstamos";
            this.PrestBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.PrestBtn.UseVisualStyleBackColor = true;
            this.PrestBtn.Click += new System.EventHandler(this.PrestBtn_Click);
            // 
            // panelNavegacion
            // 
            this.panelNavegacion.Controls.Add(this.btUltimo);
            this.panelNavegacion.Controls.Add(this.btSiguiente);
            this.panelNavegacion.Controls.Add(this.btPrimero);
            this.panelNavegacion.Controls.Add(this.btAnterior);
            this.panelNavegacion.Controls.Add(this.tbTotal);
            this.panelNavegacion.Controls.Add(this.tbIndice);
            this.panelNavegacion.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelNavegacion.Location = new System.Drawing.Point(0, 0);
            this.panelNavegacion.Name = "panelNavegacion";
            this.panelNavegacion.Size = new System.Drawing.Size(438, 37);
            this.panelNavegacion.TabIndex = 5;
            // 
            // tbIndice
            // 
            this.tbIndice.Location = new System.Drawing.Point(142, 12);
            this.tbIndice.Name = "tbIndice";
            this.tbIndice.Size = new System.Drawing.Size(55, 22);
            this.tbIndice.TabIndex = 0;
            this.tbIndice.Text = "0";
            this.tbIndice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbIndice_KeyPress);
            // 
            // tbTotal
            // 
            this.tbTotal.Location = new System.Drawing.Point(203, 12);
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.ReadOnly = true;
            this.tbTotal.Size = new System.Drawing.Size(35, 22);
            this.tbTotal.TabIndex = 1;
            this.tbTotal.Text = "de 0";
            // 
            // btAnterior
            // 
            this.btAnterior.Location = new System.Drawing.Point(86, 11);
            this.btAnterior.Name = "btAnterior";
            this.btAnterior.Size = new System.Drawing.Size(34, 23);
            this.btAnterior.TabIndex = 2;
            this.btAnterior.Text = "<";
            this.btAnterior.UseVisualStyleBackColor = true;
            this.btAnterior.Click += new System.EventHandler(this.btAnterior_Click);
            // 
            // btPrimero
            // 
            this.btPrimero.Location = new System.Drawing.Point(32, 11);
            this.btPrimero.Name = "btPrimero";
            this.btPrimero.Size = new System.Drawing.Size(29, 23);
            this.btPrimero.TabIndex = 3;
            this.btPrimero.Text = "<<";
            this.btPrimero.UseVisualStyleBackColor = true;
            this.btPrimero.Click += new System.EventHandler(this.btPrimero_Click);
            // 
            // btSiguiente
            // 
            this.btSiguiente.Location = new System.Drawing.Point(259, 11);
            this.btSiguiente.Name = "btSiguiente";
            this.btSiguiente.Size = new System.Drawing.Size(37, 23);
            this.btSiguiente.TabIndex = 4;
            this.btSiguiente.Text = ">";
            this.btSiguiente.UseVisualStyleBackColor = true;
            this.btSiguiente.Click += new System.EventHandler(this.btSiguiente_Click);
            // 
            // btUltimo
            // 
            this.btUltimo.Location = new System.Drawing.Point(315, 11);
            this.btUltimo.Name = "btUltimo";
            this.btUltimo.Size = new System.Drawing.Size(40, 23);
            this.btUltimo.TabIndex = 5;
            this.btUltimo.Text = ">>";
            this.btUltimo.UseVisualStyleBackColor = true;
            this.btUltimo.Click += new System.EventHandler(this.btUltimo_Click);
            // 
            // UC_InfoUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelNavegacion);
            this.Controls.Add(this.PrestBtn);
            this.Controls.Add(this.DNIBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.label1);
            this.Name = "UC_InfoUsuario";
            this.Size = new System.Drawing.Size(438, 204);
            this.panelNavegacion.ResumeLayout(false);
            this.panelNavegacion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox DNIBox;
        private System.Windows.Forms.Button PrestBtn;
        private System.Windows.Forms.Panel panelNavegacion;
        private System.Windows.Forms.TextBox tbTotal;
        private System.Windows.Forms.TextBox tbIndice;
        private System.Windows.Forms.Button btUltimo;
        private System.Windows.Forms.Button btSiguiente;
        private System.Windows.Forms.Button btPrimero;
        private System.Windows.Forms.Button btAnterior;
    }
}
