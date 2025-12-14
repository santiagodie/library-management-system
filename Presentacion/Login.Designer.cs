namespace Presentacion
{
    partial class Login
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
            this.DNILabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.DNIBox = new System.Windows.Forms.TextBox();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.AcceptBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DNILabel
            // 
            this.DNILabel.AutoSize = true;
            this.DNILabel.Location = new System.Drawing.Point(150, 48);
            this.DNILabel.Name = "DNILabel";
            this.DNILabel.Size = new System.Drawing.Size(102, 16);
            this.DNILabel.TabIndex = 0;
            this.DNILabel.Text = "Introduce el DNI";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(150, 109);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(146, 16);
            this.PasswordLabel.TabIndex = 1;
            this.PasswordLabel.Text = "Introduce la contraseña";
            // 
            // DNIBox
            // 
            this.DNIBox.Location = new System.Drawing.Point(153, 67);
            this.DNIBox.Name = "DNIBox";
            this.DNIBox.Size = new System.Drawing.Size(143, 22);
            this.DNIBox.TabIndex = 2;
            // 
            // PasswordBox
            // 
            this.PasswordBox.Location = new System.Drawing.Point(153, 128);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.PasswordChar = '*';
            this.PasswordBox.Size = new System.Drawing.Size(143, 22);
            this.PasswordBox.TabIndex = 3;
            this.PasswordBox.UseSystemPasswordChar = true;
            // 
            // AcceptBtn
            // 
            this.AcceptBtn.Location = new System.Drawing.Point(360, 172);
            this.AcceptBtn.Name = "AcceptBtn";
            this.AcceptBtn.Size = new System.Drawing.Size(75, 23);
            this.AcceptBtn.TabIndex = 4;
            this.AcceptBtn.Text = "Aceptar";
            this.AcceptBtn.UseVisualStyleBackColor = true;
            this.AcceptBtn.Click += new System.EventHandler(this.AcceptBtn_Click);
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.AcceptBtn);
            this.Controls.Add(this.PasswordBox);
            this.Controls.Add(this.DNIBox);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.DNILabel);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(483, 224);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DNILabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.TextBox DNIBox;
        private System.Windows.Forms.TextBox PasswordBox;
        private System.Windows.Forms.Button AcceptBtn;
    }
}
