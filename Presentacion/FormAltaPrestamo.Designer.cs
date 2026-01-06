namespace Presentacion
{
    partial class FormAltaPrestamo
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btAnadir = new System.Windows.Forms.Button();
            this.tbID = new System.Windows.Forms.TextBox();
            this.cbUsuario = new System.Windows.Forms.ComboBox();
            this.btAceptar = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lbEjemplares = new System.Windows.Forms.ListBox();
            this.gbEjemplares = new System.Windows.Forms.GroupBox();
            this.gbEjemplares.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fecha:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(115, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Usuario:";
            // 
            // btAnadir
            // 
            this.btAnadir.Location = new System.Drawing.Point(112, 270);
            this.btAnadir.Name = "btAnadir";
            this.btAnadir.Size = new System.Drawing.Size(207, 30);
            this.btAnadir.TabIndex = 3;
            this.btAnadir.Text = "Añadir ejemplar";
            this.btAnadir.UseVisualStyleBackColor = true;
            this.btAnadir.Click += new System.EventHandler(this.btAnadir_Click);
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(193, 85);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(126, 22);
            this.tbID.TabIndex = 4;
            // 
            // cbUsuario
            // 
            this.cbUsuario.FormattingEnabled = true;
            this.cbUsuario.Location = new System.Drawing.Point(193, 204);
            this.cbUsuario.Name = "cbUsuario";
            this.cbUsuario.Size = new System.Drawing.Size(126, 24);
            this.cbUsuario.TabIndex = 6;
            // 
            // btAceptar
            // 
            this.btAceptar.Location = new System.Drawing.Point(425, 385);
            this.btAceptar.Name = "btAceptar";
            this.btAceptar.Size = new System.Drawing.Size(80, 28);
            this.btAceptar.TabIndex = 9;
            this.btAceptar.Text = "Aceptar";
            this.btAceptar.UseVisualStyleBackColor = true;
            this.btAceptar.Click += new System.EventHandler(this.btAceptar_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(540, 385);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(82, 28);
            this.btCancelar.TabIndex = 10;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(193, 147);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(126, 22);
            this.dtpFecha.TabIndex = 11;
            // 
            // lbEjemplares
            // 
            this.lbEjemplares.FormattingEnabled = true;
            this.lbEjemplares.ItemHeight = 16;
            this.lbEjemplares.Location = new System.Drawing.Point(6, 29);
            this.lbEjemplares.Name = "lbEjemplares";
            this.lbEjemplares.Size = new System.Drawing.Size(318, 276);
            this.lbEjemplares.TabIndex = 0;
            this.lbEjemplares.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.lbEjemplares_Format);
            // 
            // gbEjemplares
            // 
            this.gbEjemplares.Controls.Add(this.lbEjemplares);
            this.gbEjemplares.Location = new System.Drawing.Point(425, 44);
            this.gbEjemplares.Name = "gbEjemplares";
            this.gbEjemplares.Size = new System.Drawing.Size(330, 309);
            this.gbEjemplares.TabIndex = 8;
            this.gbEjemplares.TabStop = false;
            this.gbEjemplares.Text = "Ejemplares añadidos";
            // 
            // FormAltaPrestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btAceptar);
            this.Controls.Add(this.gbEjemplares);
            this.Controls.Add(this.cbUsuario);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.btAnadir);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormAltaPrestamo";
            this.Text = "Alta de un préstamo";
            this.Load += new System.EventHandler(this.FormAltaPrestamo_Load);
            this.gbEjemplares.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btAnadir;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.ComboBox cbUsuario;
        private System.Windows.Forms.Button btAceptar;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.ListBox lbEjemplares;
        private System.Windows.Forms.GroupBox gbEjemplares;
    }
}