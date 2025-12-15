namespace Presentacion
{
    partial class Main
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
            this.loginForm = new Presentacion.Login();
            this.SuspendLayout();
            // 
            // loginForm
            // 
            this.loginForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loginForm.Location = new System.Drawing.Point(0, 0);
            this.loginForm.Name = "loginForm";
            this.loginForm.Size = new System.Drawing.Size(618, 233);
            this.loginForm.TabIndex = 0;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 233);
            this.Controls.Add(this.loginForm);
            this.Name = "Main";
            this.Text = "GestionBiblioteca";
            this.ResumeLayout(false);

        }

        #endregion

        private Login loginForm;
    }
}

