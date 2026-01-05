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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(33, 39);
            this.NameBox.Name = "NameBox";
            this.NameBox.ReadOnly = true;
            this.NameBox.Size = new System.Drawing.Size(129, 22);
            this.NameBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "DNI";
            // 
            // DNIBox
            // 
            this.DNIBox.Location = new System.Drawing.Point(33, 93);
            this.DNIBox.Name = "DNIBox";
            this.DNIBox.ReadOnly = true;
            this.DNIBox.Size = new System.Drawing.Size(129, 22);
            this.DNIBox.TabIndex = 3;
            // 
            // PrestBtn
            // 
            this.PrestBtn.Image = global::Presentacion.Properties.Resources.Prestamo;
            this.PrestBtn.Location = new System.Drawing.Point(190, 31);
            this.PrestBtn.Name = "PrestBtn";
            this.PrestBtn.Size = new System.Drawing.Size(95, 84);
            this.PrestBtn.TabIndex = 4;
            this.PrestBtn.Text = "Préstamos";
            this.PrestBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.PrestBtn.UseVisualStyleBackColor = true;
            this.PrestBtn.Click += new System.EventHandler(this.PrestBtn_Click);
            // 
            // UC_InfoUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PrestBtn);
            this.Controls.Add(this.DNIBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.label1);
            this.Name = "UC_InfoUsuario";
            this.Size = new System.Drawing.Size(300, 136);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox DNIBox;
        private System.Windows.Forms.Button PrestBtn;
    }
}
