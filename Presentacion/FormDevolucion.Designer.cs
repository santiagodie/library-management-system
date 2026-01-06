namespace Presentacion
{
    partial class FormDevolucion
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ucDetalle = new Presentacion.UC_DetallePrestamo();
            this.btAceptar = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.gbDevolucion = new System.Windows.Forms.GroupBox();
            this.lbDevolucion = new System.Windows.Forms.ListBox();
            this.btBuscar = new System.Windows.Forms.Button();
            this.cbEjemplar = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.gbDevolucion.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ejemplar:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ucDetalle);
            this.groupBox1.Location = new System.Drawing.Point(53, 154);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(359, 432);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Préstamo asociado";
            // 
            // ucDetalle
            // 
            this.ucDetalle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ucDetalle.Location = new System.Drawing.Point(-10, 21);
            this.ucDetalle.ModoSeleccion = false;
            this.ucDetalle.Name = "ucDetalle";
            this.ucDetalle.Size = new System.Drawing.Size(369, 411);
            this.ucDetalle.TabIndex = 0;
            // 
            // btAceptar
            // 
            this.btAceptar.Location = new System.Drawing.Point(499, 532);
            this.btAceptar.Name = "btAceptar";
            this.btAceptar.Size = new System.Drawing.Size(85, 29);
            this.btAceptar.TabIndex = 4;
            this.btAceptar.Text = "Confirmar";
            this.btAceptar.UseVisualStyleBackColor = true;
            this.btAceptar.Click += new System.EventHandler(this.btAceptar_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(620, 532);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(85, 29);
            this.btCancelar.TabIndex = 5;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // gbDevolucion
            // 
            this.gbDevolucion.Controls.Add(this.lbDevolucion);
            this.gbDevolucion.Location = new System.Drawing.Point(462, 73);
            this.gbDevolucion.Name = "gbDevolucion";
            this.gbDevolucion.Size = new System.Drawing.Size(274, 430);
            this.gbDevolucion.TabIndex = 6;
            this.gbDevolucion.TabStop = false;
            this.gbDevolucion.Text = "Devolución";
            // 
            // lbDevolucion
            // 
            this.lbDevolucion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbDevolucion.FormattingEnabled = true;
            this.lbDevolucion.ItemHeight = 16;
            this.lbDevolucion.Location = new System.Drawing.Point(3, 18);
            this.lbDevolucion.Name = "lbDevolucion";
            this.lbDevolucion.Size = new System.Drawing.Size(268, 409);
            this.lbDevolucion.TabIndex = 0;
            this.lbDevolucion.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.lbDevolucion_Format);
            this.lbDevolucion.DoubleClick += new System.EventHandler(this.lbDevolucion_DoubleClick);
            // 
            // btBuscar
            // 
            this.btBuscar.Image = global::Presentacion.Properties.Resources.ImagenBuscar__1_;
            this.btBuscar.Location = new System.Drawing.Point(310, 73);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(42, 39);
            this.btBuscar.TabIndex = 2;
            this.btBuscar.UseVisualStyleBackColor = true;
            this.btBuscar.Click += new System.EventHandler(this.btBuscar_Click);
            // 
            // cbEjemplar
            // 
            this.cbEjemplar.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbEjemplar.FormattingEnabled = true;
            this.cbEjemplar.Location = new System.Drawing.Point(172, 84);
            this.cbEjemplar.Name = "cbEjemplar";
            this.cbEjemplar.Size = new System.Drawing.Size(121, 24);
            this.cbEjemplar.TabIndex = 7;
            // 
            // FormDevolucion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 711);
            this.Controls.Add(this.cbEjemplar);
            this.Controls.Add(this.gbDevolucion);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btAceptar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btBuscar);
            this.Controls.Add(this.label1);
            this.Name = "FormDevolucion";
            this.Text = "Devolución";
            this.Load += new System.EventHandler(this.FormDevolucion_Load);
            this.groupBox1.ResumeLayout(false);
            this.gbDevolucion.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btAceptar;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.GroupBox gbDevolucion;
        private System.Windows.Forms.ListBox lbDevolucion;
        private UC_DetallePrestamo ucDetalle;
        private System.Windows.Forms.ComboBox cbEjemplar;
    }
}