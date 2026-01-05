namespace Presentacion
{
    partial class UC_BajaUsuario
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
            this.DNIBox = new System.Windows.Forms.TextBox();
            this.BajaBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "DNI:";
            // 
            // DNIBox
            // 
            this.DNIBox.Location = new System.Drawing.Point(27, 40);
            this.DNIBox.Name = "DNIBox";
            this.DNIBox.Size = new System.Drawing.Size(109, 22);
            this.DNIBox.TabIndex = 1;
            // 
            // BajaBtn
            // 
            this.BajaBtn.Location = new System.Drawing.Point(174, 40);
            this.BajaBtn.Name = "BajaBtn";
            this.BajaBtn.Size = new System.Drawing.Size(77, 25);
            this.BajaBtn.TabIndex = 2;
            this.BajaBtn.Text = "Baja";
            this.BajaBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BajaBtn.UseVisualStyleBackColor = true;
            this.BajaBtn.Click += new System.EventHandler(this.BajaBtn_Click);
            // 
            // UC_BajaUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BajaBtn);
            this.Controls.Add(this.DNIBox);
            this.Controls.Add(this.label1);
            this.Name = "UC_BajaUsuario";
            this.Size = new System.Drawing.Size(275, 95);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox DNIBox;
        private System.Windows.Forms.Button BajaBtn;
    }
}
