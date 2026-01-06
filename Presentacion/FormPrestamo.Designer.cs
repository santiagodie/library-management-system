namespace Presentacion
{
    partial class FormPrestamo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.uc_DetallePrestamo1 = new Presentacion.UC_DetallePrestamo();
            this.SuspendLayout();
            // 
            // uc_DetallePrestamo1
            // 
            this.uc_DetallePrestamo1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.uc_DetallePrestamo1.Location = new System.Drawing.Point(12, 12);
            this.uc_DetallePrestamo1.ModoSeleccion = false;
            this.uc_DetallePrestamo1.Name = "uc_DetallePrestamo1";
            this.uc_DetallePrestamo1.Size = new System.Drawing.Size(381, 436);
            this.uc_DetallePrestamo1.TabIndex = 0;
            // 
            // FormPrestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 450);
            this.Controls.Add(this.uc_DetallePrestamo1);
            this.Name = "FormPrestamo";
            this.Text = "FormPrestamo";
            this.Load += new System.EventHandler(this.FormPrestamo_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private UC_DetallePrestamo uc_DetallePrestamo1;
    }
}