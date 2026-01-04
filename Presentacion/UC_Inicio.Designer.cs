namespace Presentacion
{
    partial class UC_Inicio
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
            this.lbBienvenida = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbNSala = new System.Windows.Forms.Label();
            this.lbNHoy = new System.Windows.Forms.Label();
            this.lbNVencidos = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvVencidos = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVencidos)).BeginInit();
            this.SuspendLayout();
            // 
            // lbBienvenida
            // 
            this.lbBienvenida.AutoSize = true;
            this.lbBienvenida.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lbBienvenida.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbBienvenida.Location = new System.Drawing.Point(195, 16);
            this.lbBienvenida.Name = "lbBienvenida";
            this.lbBienvenida.Size = new System.Drawing.Size(185, 16);
            this.lbBienvenida.TabIndex = 0;
            this.lbBienvenida.Text = "Bienvenido al Gestor de Sala.";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.lbBienvenida);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(587, 120);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Info;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.lbNSala);
            this.panel2.Location = new System.Drawing.Point(22, 52);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(169, 44);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.lbNHoy);
            this.panel3.Location = new System.Drawing.Point(211, 52);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(169, 44);
            this.panel3.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.lbNVencidos);
            this.panel4.Location = new System.Drawing.Point(400, 52);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(169, 44);
            this.panel4.TabIndex = 4;
            // 
            // lbNSala
            // 
            this.lbNSala.AutoSize = true;
            this.lbNSala.Location = new System.Drawing.Point(77, 4);
            this.lbNSala.Name = "lbNSala";
            this.lbNSala.Size = new System.Drawing.Size(14, 16);
            this.lbNSala.TabIndex = 2;
            this.lbNSala.Text = "0";
            // 
            // lbNHoy
            // 
            this.lbNHoy.AutoSize = true;
            this.lbNHoy.Location = new System.Drawing.Point(78, 4);
            this.lbNHoy.Name = "lbNHoy";
            this.lbNHoy.Size = new System.Drawing.Size(14, 16);
            this.lbNHoy.TabIndex = 0;
            this.lbNHoy.Text = "0";
            // 
            // lbNVencidos
            // 
            this.lbNVencidos.AutoSize = true;
            this.lbNVencidos.Location = new System.Drawing.Point(83, 4);
            this.lbNVencidos.Name = "lbNVencidos";
            this.lbNVencidos.Size = new System.Drawing.Size(14, 16);
            this.lbNVencidos.TabIndex = 0;
            this.lbNVencidos.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Personas en Sala";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Préstamos realizados hoy";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Prestamos vencidos";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label7.Dock = System.Windows.Forms.DockStyle.Top;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(0, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(206, 25);
            this.label7.TabIndex = 2;
            this.label7.Text = "Préstamos vencidos";
            // 
            // dgvVencidos
            // 
            this.dgvVencidos.AllowUserToAddRows = false;
            this.dgvVencidos.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvVencidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVencidos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvVencidos.GridColor = System.Drawing.SystemColors.Info;
            this.dgvVencidos.Location = new System.Drawing.Point(0, 145);
            this.dgvVencidos.Name = "dgvVencidos";
            this.dgvVencidos.RowHeadersVisible = false;
            this.dgvVencidos.RowHeadersWidth = 51;
            this.dgvVencidos.RowTemplate.Height = 24;
            this.dgvVencidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVencidos.Size = new System.Drawing.Size(587, 306);
            this.dgvVencidos.TabIndex = 3;
            // 
            // UC_Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvVencidos);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel1);
            this.Name = "UC_Inicio";
            this.Size = new System.Drawing.Size(587, 451);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVencidos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbBienvenida;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbNVencidos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbNHoy;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbNSala;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvVencidos;
    }
}
