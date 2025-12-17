namespace Presentacion
{
    partial class FormPersonal
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
            this.Tab = new System.Windows.Forms.TabControl();
            this.Usuarios = new System.Windows.Forms.TabPage();
            this.Sala = new System.Windows.Forms.TabPage();
            this.Adquisiciones = new System.Windows.Forms.TabPage();
            this.Tab.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tab
            // 
            this.Tab.Controls.Add(this.Usuarios);
            this.Tab.Controls.Add(this.Sala);
            this.Tab.Controls.Add(this.Adquisiciones);
            this.Tab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tab.Location = new System.Drawing.Point(0, 0);
            this.Tab.Name = "Tab";
            this.Tab.SelectedIndex = 0;
            this.Tab.Size = new System.Drawing.Size(849, 474);
            this.Tab.TabIndex = 0;
            // 
            // Usuarios
            // 
            this.Usuarios.Location = new System.Drawing.Point(4, 25);
            this.Usuarios.Name = "Usuarios";
            this.Usuarios.Padding = new System.Windows.Forms.Padding(3);
            this.Usuarios.Size = new System.Drawing.Size(792, 421);
            this.Usuarios.TabIndex = 0;
            this.Usuarios.Text = "Usuarios";
            this.Usuarios.UseVisualStyleBackColor = true;
            // 
            // Sala
            // 
            this.Sala.Location = new System.Drawing.Point(4, 25);
            this.Sala.Name = "Sala";
            this.Sala.Padding = new System.Windows.Forms.Padding(3);
            this.Sala.Size = new System.Drawing.Size(841, 445);
            this.Sala.TabIndex = 1;
            this.Sala.Text = "Sala";
            this.Sala.UseVisualStyleBackColor = true;
            // 
            // Adquisiciones
            // 
            this.Adquisiciones.Location = new System.Drawing.Point(4, 25);
            this.Adquisiciones.Name = "Adquisiciones";
            this.Adquisiciones.Size = new System.Drawing.Size(792, 421);
            this.Adquisiciones.TabIndex = 2;
            this.Adquisiciones.Text = "Adquisiciones";
            this.Adquisiciones.UseVisualStyleBackColor = true;
            // 
            // FormPersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 474);
            this.Controls.Add(this.Tab);
            this.Name = "FormPersonal";
            this.Text = "Gestor de biblioteca";
            this.Tab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Tab;
        private System.Windows.Forms.TabPage Usuarios;
        private System.Windows.Forms.TabPage Sala;
        private System.Windows.Forms.TabPage Adquisiciones;
    }
}