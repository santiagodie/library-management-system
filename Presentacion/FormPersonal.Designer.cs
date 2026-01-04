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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPersonal));
            this.Tab = new System.Windows.Forms.TabControl();
            this.Usuarios = new System.Windows.Forms.TabPage();
            this.Sala = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.gbPrestamos = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbNombre = new System.Windows.Forms.Label();
            this.Adquisiciones = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btConsultarPrestUsuario = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbDni = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btPrestamo = new System.Windows.Forms.Button();
            this.btLogOut = new System.Windows.Forms.Button();
            this.pbFotoPerfil = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Tab.SuspendLayout();
            this.Sala.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.gbPrestamos.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFotoPerfil)).BeginInit();
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
            this.Usuarios.Size = new System.Drawing.Size(841, 445);
            this.Usuarios.TabIndex = 0;
            this.Usuarios.Text = "Usuarios";
            this.Usuarios.UseVisualStyleBackColor = true;
            // 
            // Sala
            // 
            this.Sala.Controls.Add(this.panel2);
            this.Sala.Controls.Add(this.flowLayoutPanel1);
            this.Sala.Controls.Add(this.panel1);
            this.Sala.Location = new System.Drawing.Point(4, 25);
            this.Sala.Name = "Sala";
            this.Sala.Padding = new System.Windows.Forms.Padding(3);
            this.Sala.Size = new System.Drawing.Size(841, 445);
            this.Sala.TabIndex = 1;
            this.Sala.Text = "Sala";
            this.Sala.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.AliceBlue;
            this.flowLayoutPanel1.Controls.Add(this.gbPrestamos);
            this.flowLayoutPanel1.Controls.Add(this.groupBox1);
            this.flowLayoutPanel1.Controls.Add(this.groupBox2);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 77);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(835, 112);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // gbPrestamos
            // 
            this.gbPrestamos.Controls.Add(this.button2);
            this.gbPrestamos.Controls.Add(this.btPrestamo);
            this.gbPrestamos.Location = new System.Drawing.Point(3, 3);
            this.gbPrestamos.Name = "gbPrestamos";
            this.gbPrestamos.Size = new System.Drawing.Size(200, 109);
            this.gbPrestamos.TabIndex = 0;
            this.gbPrestamos.TabStop = false;
            this.gbPrestamos.Text = "Préstamos";
            this.gbPrestamos.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel1.Controls.Add(this.btLogOut);
            this.panel1.Controls.Add(this.lbNombre);
            this.panel1.Controls.Add(this.pbFotoPerfil);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(835, 74);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Location = new System.Drawing.Point(16, 53);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(66, 16);
            this.lbNombre.TabIndex = 1;
            this.lbNombre.Text = "tuNombre";
            // 
            // Adquisiciones
            // 
            this.Adquisiciones.Location = new System.Drawing.Point(4, 25);
            this.Adquisiciones.Name = "Adquisiciones";
            this.Adquisiciones.Size = new System.Drawing.Size(841, 445);
            this.Adquisiciones.TabIndex = 2;
            this.Adquisiciones.Text = "Adquisiciones";
            this.Adquisiciones.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbDni);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.btConsultarPrestUsuario);
            this.groupBox1.Location = new System.Drawing.Point(209, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Usuarios";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Location = new System.Drawing.Point(415, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Documentos";
            // 
            // btConsultarPrestUsuario
            // 
            this.btConsultarPrestUsuario.Image = global::Presentacion.Properties.Resources.ImagenBuscar__1_;
            this.btConsultarPrestUsuario.Location = new System.Drawing.Point(115, 31);
            this.btConsultarPrestUsuario.Name = "btConsultarPrestUsuario";
            this.btConsultarPrestUsuario.Size = new System.Drawing.Size(79, 50);
            this.btConsultarPrestUsuario.TabIndex = 0;
            this.btConsultarPrestUsuario.Text = "Consultar";
            this.btConsultarPrestUsuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btConsultarPrestUsuario.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(9, 59);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 189);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(835, 253);
            this.panel2.TabIndex = 3;
            // 
            // lbDni
            // 
            this.lbDni.AutoSize = true;
            this.lbDni.Location = new System.Drawing.Point(9, 40);
            this.lbDni.Name = "lbDni";
            this.lbDni.Size = new System.Drawing.Size(100, 16);
            this.lbDni.TabIndex = 2;
            this.lbDni.Text = "Introduce el dni:";
            // 
            // button2
            // 
            this.button2.Image = global::Presentacion.Properties.Resources.ImagenDevolucion;
            this.button2.Location = new System.Drawing.Point(107, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 84);
            this.button2.TabIndex = 1;
            this.button2.Text = "Devolución";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btPrestamo
            // 
            this.btPrestamo.Image = global::Presentacion.Properties.Resources.ImagenPrestamo;
            this.btPrestamo.Location = new System.Drawing.Point(16, 19);
            this.btPrestamo.Name = "btPrestamo";
            this.btPrestamo.Size = new System.Drawing.Size(85, 84);
            this.btPrestamo.TabIndex = 0;
            this.btPrestamo.Text = "Préstamo";
            this.btPrestamo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btPrestamo.UseVisualStyleBackColor = true;
            // 
            // btLogOut
            // 
            this.btLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLogOut.Image = global::Presentacion.Properties.Resources.logOut3__2_;
            this.btLogOut.Location = new System.Drawing.Point(768, 21);
            this.btLogOut.Name = "btLogOut";
            this.btLogOut.Size = new System.Drawing.Size(43, 38);
            this.btLogOut.TabIndex = 2;
            this.btLogOut.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btLogOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btLogOut.UseVisualStyleBackColor = true;
            // 
            // pbFotoPerfil
            // 
            this.pbFotoPerfil.Image = ((System.Drawing.Image)(resources.GetObject("pbFotoPerfil.Image")));
            this.pbFotoPerfil.Location = new System.Drawing.Point(28, 12);
            this.pbFotoPerfil.Name = "pbFotoPerfil";
            this.pbFotoPerfil.Size = new System.Drawing.Size(41, 38);
            this.pbFotoPerfil.TabIndex = 0;
            this.pbFotoPerfil.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Introduce el ISBN:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(8, 53);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Image = global::Presentacion.Properties.Resources.ImagenBuscar__1_;
            this.button1.Location = new System.Drawing.Point(115, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 50);
            this.button1.TabIndex = 3;
            this.button1.Text = "Consultar";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = true;
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
            this.Sala.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.gbPrestamos.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFotoPerfil)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Tab;
        private System.Windows.Forms.TabPage Usuarios;
        private System.Windows.Forms.TabPage Sala;
        private System.Windows.Forms.TabPage Adquisiciones;
        private System.Windows.Forms.GroupBox gbPrestamos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.PictureBox pbFotoPerfil;
        private System.Windows.Forms.Button btLogOut;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btPrestamo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btConsultarPrestUsuario;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbDni;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
    }
}