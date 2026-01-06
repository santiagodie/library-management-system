using System.Windows.Forms;

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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPersonal));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Tab = new System.Windows.Forms.TabControl();
            this.Usuarios = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.DNIBox = new System.Windows.Forms.TextBox();
            this.ConsultarBtn = new System.Windows.Forms.Button();
            this.ListarBtn = new System.Windows.Forms.Button();
            this.BajaBtn = new System.Windows.Forms.Button();
            this.AltaBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.PanelFunciones = new System.Windows.Forms.Panel();
            this.Sala = new System.Windows.Forms.TabPage();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btInicio = new System.Windows.Forms.Button();
            this.gbPrestamos = new System.Windows.Forms.GroupBox();
            this.btBuscar = new System.Windows.Forms.Button();
            this.btBusqueda = new System.Windows.Forms.Button();
            this.btDevolucion = new System.Windows.Forms.Button();
            this.btPrestamo = new System.Windows.Forms.Button();
            this.Adquisiciones = new System.Windows.Forms.TabPage();
            this.panel_Listar_Ejemplar = new System.Windows.Forms.Panel();
            this.comboBox_Documento_Listar_Ejemplar = new System.Windows.Forms.ComboBox();
            this.label_Documento_Listar_Ejemplar = new System.Windows.Forms.Label();
            this.dataGridView_Listar_Ejemplar = new System.Windows.Forms.DataGridView();
            this.label_Listar_Ejemplar = new System.Windows.Forms.Label();
            this.panel_Listar_Documento = new System.Windows.Forms.Panel();
            this.dataGridView_Listar_Documento = new System.Windows.Forms.DataGridView();
            this.column_Titulo_List_Documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_Autor_List_Documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_ISBN_List_Documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_Editorial_List_Documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_Año_List_Documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_AudioLibro_List_Documento = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.column_Formato_List_Documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_Duracion_List_Documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_Fecha_List_Documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_Disponible_List_Documento = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label_Listar_Documento = new System.Windows.Forms.Label();
            this.panel_Consultar_MasLeido = new System.Windows.Forms.Panel();
            this.label_Consultar_MasLeido = new System.Windows.Forms.Label();
            this.textBox_Duracion_Consultar_MasLeido = new System.Windows.Forms.TextBox();
            this.comboBox_Formato_Consultar_MasLeido = new System.Windows.Forms.ComboBox();
            this.label_Duracion_Consultar_MasLeido = new System.Windows.Forms.Label();
            this.label_Formato_Consultar_MasLeido = new System.Windows.Forms.Label();
            this.label_Año_Consultar_MasLeido = new System.Windows.Forms.Label();
            this.textBox_Año_Consultar_MasLeido = new System.Windows.Forms.TextBox();
            this.label_Editorial_Consultar_MasLeido = new System.Windows.Forms.Label();
            this.label_ISBN_Consultar_MasLeido = new System.Windows.Forms.Label();
            this.label_Autor_Consultar_MasLeido = new System.Windows.Forms.Label();
            this.label_Titulo_Consultar_MasLeido = new System.Windows.Forms.Label();
            this.textBox_Editorial_Consultar_MasLeido = new System.Windows.Forms.TextBox();
            this.textBox_ISBN_Consultar_MasLeido = new System.Windows.Forms.TextBox();
            this.textBox_Autor_Consultar_MasLeido = new System.Windows.Forms.TextBox();
            this.textBox_Titulo_Consultar_MasLeido = new System.Windows.Forms.TextBox();
            this.checkBox_Audiolibro_Consultar_MasLeido = new System.Windows.Forms.CheckBox();
            this.button_Realizar_Consultar_Fech = new System.Windows.Forms.Button();
            this.panel_Consultar_Fecha = new System.Windows.Forms.Panel();
            this.textBox_Fecha_Consultar_Fech = new System.Windows.Forms.TextBox();
            this.label_Fecha_Consultar_Fech = new System.Windows.Forms.Label();
            this.comboBox_Documento_Consultar_Fech = new System.Windows.Forms.ComboBox();
            this.label_Documento_Consultar_Fech = new System.Windows.Forms.Label();
            this.label_Consultar_Fecha = new System.Windows.Forms.Label();
            this.button_Realizar_Consultar_Disp = new System.Windows.Forms.Button();
            this.panel_Consultar_Disponible = new System.Windows.Forms.Panel();
            this.comboBox_Documento_Consultar_Disp = new System.Windows.Forms.ComboBox();
            this.label_Documento_Consultar_Disp = new System.Windows.Forms.Label();
            this.label_Consultar_Disponible = new System.Windows.Forms.Label();
            this.checkBox_Disponible_Consultar_Disp = new System.Windows.Forms.CheckBox();
            this.button_Realizar_Consultar_Ejemplar = new System.Windows.Forms.Button();
            this.panel_Consultar_Ejemplar = new System.Windows.Forms.Panel();
            this.textBox_Documento_Consultar_Eje = new System.Windows.Forms.TextBox();
            this.textBox_Codigo_Consultar_Eje = new System.Windows.Forms.TextBox();
            this.label_Documento_Consultar_Eje = new System.Windows.Forms.Label();
            this.textBox_Responsable_Consultar_Eje = new System.Windows.Forms.TextBox();
            this.label_Informacion_Consultar_Eje = new System.Windows.Forms.Label();
            this.label_Codigo_Consultar_Eje = new System.Windows.Forms.Label();
            this.label_Responsable_Consultar_Eje = new System.Windows.Forms.Label();
            this.label_Consultar_Ejemplar = new System.Windows.Forms.Label();
            this.label_Localizacion_Consultar_Eje = new System.Windows.Forms.Label();
            this.textBox_Localizacion_Consultar_Eje = new System.Windows.Forms.TextBox();
            this.checkBox_Disponible_Consultar_Eje = new System.Windows.Forms.CheckBox();
            this.button_Listar_Ejemplar = new System.Windows.Forms.Button();
            this.button_Listar_Documento = new System.Windows.Forms.Button();
            this.button_Consultar_Mas_Leido = new System.Windows.Forms.Button();
            this.button_Consultar_Disponible = new System.Windows.Forms.Button();
            this.button_Consultar_Fecha = new System.Windows.Forms.Button();
            this.button_Consultar_Ejemplar = new System.Windows.Forms.Button();
            this.button_Borrar_Baja_Eje = new System.Windows.Forms.Button();
            this.panel_Baja_Ejemplar = new System.Windows.Forms.Panel();
            this.textBox_Codigo_Baja_Eje = new System.Windows.Forms.TextBox();
            this.label_Codigo_Baja_Eje = new System.Windows.Forms.Label();
            this.textBox_Responsable_Baja_Eje = new System.Windows.Forms.TextBox();
            this.label_Info_Baja_Eje = new System.Windows.Forms.Label();
            this.comboBox_Ejemplar_Baja_Eje = new System.Windows.Forms.ComboBox();
            this.label_Ejemplar_Baja_Eje = new System.Windows.Forms.Label();
            this.label_Responsable_Baja_Eje = new System.Windows.Forms.Label();
            this.label_Baja_Ejemplares = new System.Windows.Forms.Label();
            this.comboBox_Documento_Baja_Eje = new System.Windows.Forms.ComboBox();
            this.label_Documento_Baja_Eje = new System.Windows.Forms.Label();
            this.label_Localizacion_Baja_Eje = new System.Windows.Forms.Label();
            this.textBox_Localizacion_Baja_Eje = new System.Windows.Forms.TextBox();
            this.checkBox_Disponible_Baja_Eje = new System.Windows.Forms.CheckBox();
            this.panel_Alta_Ejemplar = new System.Windows.Forms.Panel();
            this.label_Alta_Ejemplar = new System.Windows.Forms.Label();
            this.comboBox_Documento_Alta_Eje = new System.Windows.Forms.ComboBox();
            this.label_Documento_Alta_Eje = new System.Windows.Forms.Label();
            this.label_Localizacion_Alta_Eje = new System.Windows.Forms.Label();
            this.textBox_Localizacion_Alta_Eje = new System.Windows.Forms.TextBox();
            this.checkBox_Disponible_Alta_Eje = new System.Windows.Forms.CheckBox();
            this.button_Validar_Alta_Ejemplar = new System.Windows.Forms.Button();
            this.button_Validar_Alta_Documento = new System.Windows.Forms.Button();
            this.panel_Alta_Documento = new System.Windows.Forms.Panel();
            this.label_Alta_Doc = new System.Windows.Forms.Label();
            this.textBox_Duracion_Alta_Doc = new System.Windows.Forms.TextBox();
            this.comboBox_Formato_Alta_Doc = new System.Windows.Forms.ComboBox();
            this.label_Duracion_Alta_Doc = new System.Windows.Forms.Label();
            this.label_Formato_Alta_Doc = new System.Windows.Forms.Label();
            this.label_Año_Edicion_Alta_Doc = new System.Windows.Forms.Label();
            this.textBox_Año_Edicion_Alta_Doc = new System.Windows.Forms.TextBox();
            this.label_Editorial_Alta_Doc = new System.Windows.Forms.Label();
            this.label_ISBN_Alta_Doc = new System.Windows.Forms.Label();
            this.label_Autor_Alta_Doc = new System.Windows.Forms.Label();
            this.label_Titulo_Alta_Doc = new System.Windows.Forms.Label();
            this.textBox_Editorial_Alta_Doc = new System.Windows.Forms.TextBox();
            this.textBox_ISBN_Alta_Doc = new System.Windows.Forms.TextBox();
            this.textBox_Autor_Alta_Doc = new System.Windows.Forms.TextBox();
            this.textBox_Titulo_Alta_Doc = new System.Windows.Forms.TextBox();
            this.checkBox_Audiolibro_Alta_Doc = new System.Windows.Forms.CheckBox();
            this.button_Volver = new System.Windows.Forms.Button();
            this.button_Alta_Ejemplar = new System.Windows.Forms.Button();
            this.button_Alta_Documento = new System.Windows.Forms.Button();
            this.button_Listar = new System.Windows.Forms.Button();
            this.button_Consultas = new System.Windows.Forms.Button();
            this.button_Bajas = new System.Windows.Forms.Button();
            this.button_Altas = new System.Windows.Forms.Button();
            this.label_Main_Adquisiciones = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btLogOut = new System.Windows.Forms.Button();
            this.lbNombre = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.toolTip_Sala = new System.Windows.Forms.ToolTip(this.components);
            this.bindingSource_Ejemplar_Listar_Ejemplar = new System.Windows.Forms.BindingSource(this.components);
            this.Column_Codigo_Listar_Ejemplar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Documento_Listar_Ejemplar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Responsable_Listar_Ejemplar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Activo_Listar_Ejemplar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column_Disponible_Listar_Ejemplar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ColumnLocalizacion_Listar_Ejemplar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.Tab.SuspendLayout();
            this.Usuarios.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.Sala.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbPrestamos.SuspendLayout();
            this.Adquisiciones.SuspendLayout();
            this.panel_Listar_Ejemplar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Listar_Ejemplar)).BeginInit();
            this.panel_Listar_Documento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Listar_Documento)).BeginInit();
            this.panel_Consultar_MasLeido.SuspendLayout();
            this.panel_Consultar_Fecha.SuspendLayout();
            this.panel_Consultar_Disponible.SuspendLayout();
            this.panel_Consultar_Ejemplar.SuspendLayout();
            this.panel_Baja_Ejemplar.SuspendLayout();
            this.panel_Alta_Ejemplar.SuspendLayout();
            this.panel_Alta_Documento.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_Ejemplar_Listar_Ejemplar)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1054, 507);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.AutoSize = true;
            this.panel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel3.Controls.Add(this.Tab);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 92);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1048, 413);
            this.panel3.TabIndex = 0;
            // 
            // Tab
            // 
            this.Tab.Controls.Add(this.Usuarios);
            this.Tab.Controls.Add(this.Sala);
            this.Tab.Controls.Add(this.Adquisiciones);
            this.Tab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tab.Location = new System.Drawing.Point(0, 0);
            this.Tab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Tab.Name = "Tab";
            this.Tab.SelectedIndex = 0;
            this.Tab.Size = new System.Drawing.Size(1048, 413);
            this.Tab.TabIndex = 1;
            // 
            // Usuarios
            // 
            this.Usuarios.Controls.Add(this.tableLayoutPanel2);
            this.Usuarios.Location = new System.Drawing.Point(4, 22);
            this.Usuarios.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Usuarios.Name = "Usuarios";
            this.Usuarios.Padding = new System.Windows.Forms.Padding(4);
            this.Usuarios.Size = new System.Drawing.Size(1040, 387);
            this.Usuarios.TabIndex = 0;
            this.Usuarios.Text = "Usuarios";
            this.Usuarios.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.PanelFunciones, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 164F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1032, 379);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.AliceBlue;
            this.flowLayoutPanel2.Controls.Add(this.groupBox4);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(4, 4);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(1024, 156);
            this.flowLayoutPanel2.TabIndex = 4;
            // 
            // groupBox4
            // 
            this.groupBox4.AutoSize = true;
            this.groupBox4.Controls.Add(this.DNIBox);
            this.groupBox4.Controls.Add(this.ConsultarBtn);
            this.groupBox4.Controls.Add(this.ListarBtn);
            this.groupBox4.Controls.Add(this.BajaBtn);
            this.groupBox4.Controls.Add(this.AltaBtn);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Location = new System.Drawing.Point(3, 2);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Size = new System.Drawing.Size(658, 146);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Usuarios";
            // 
            // DNIBox
            // 
            this.DNIBox.Location = new System.Drawing.Point(440, 76);
            this.DNIBox.Name = "DNIBox";
            this.DNIBox.Size = new System.Drawing.Size(119, 20);
            this.DNIBox.TabIndex = 6;
            // 
            // ConsultarBtn
            // 
            this.ConsultarBtn.Image = global::Presentacion.Properties.Resources.ImagenBuscar__1_;
            this.ConsultarBtn.Location = new System.Drawing.Point(565, 51);
            this.ConsultarBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ConsultarBtn.Name = "ConsultarBtn";
            this.ConsultarBtn.Size = new System.Drawing.Size(87, 60);
            this.ConsultarBtn.TabIndex = 7;
            this.ConsultarBtn.Text = "Consultar";
            this.ConsultarBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ConsultarBtn.UseVisualStyleBackColor = true;
            this.ConsultarBtn.Click += new System.EventHandler(this.ConsultarBtn_Click);
            // 
            // ListarBtn
            // 
            this.ListarBtn.Image = global::Presentacion.Properties.Resources.Lista;
            this.ListarBtn.Location = new System.Drawing.Point(277, 26);
            this.ListarBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ListarBtn.Name = "ListarBtn";
            this.ListarBtn.Size = new System.Drawing.Size(127, 103);
            this.ListarBtn.TabIndex = 5;
            this.ListarBtn.Text = "Listado";
            this.ListarBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ListarBtn.UseVisualStyleBackColor = true;
            this.ListarBtn.Click += new System.EventHandler(this.ListarBtn_Click);
            // 
            // BajaBtn
            // 
            this.BajaBtn.Image = global::Presentacion.Properties.Resources.Baja;
            this.BajaBtn.Location = new System.Drawing.Point(143, 26);
            this.BajaBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BajaBtn.Name = "BajaBtn";
            this.BajaBtn.Size = new System.Drawing.Size(127, 103);
            this.BajaBtn.TabIndex = 4;
            this.BajaBtn.Text = "Baja";
            this.BajaBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BajaBtn.UseVisualStyleBackColor = true;
            this.BajaBtn.Click += new System.EventHandler(this.BajaBtn_Click);
            // 
            // AltaBtn
            // 
            this.AltaBtn.Image = global::Presentacion.Properties.Resources.Alta;
            this.AltaBtn.Location = new System.Drawing.Point(8, 26);
            this.AltaBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AltaBtn.Name = "AltaBtn";
            this.AltaBtn.Size = new System.Drawing.Size(127, 103);
            this.AltaBtn.TabIndex = 3;
            this.AltaBtn.Text = "Alta";
            this.AltaBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.AltaBtn.UseVisualStyleBackColor = true;
            this.AltaBtn.Click += new System.EventHandler(this.AltaBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(437, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Introduce el dni:";
            // 
            // PanelFunciones
            // 
            this.PanelFunciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelFunciones.Location = new System.Drawing.Point(3, 167);
            this.PanelFunciones.Name = "PanelFunciones";
            this.PanelFunciones.Size = new System.Drawing.Size(1026, 209);
            this.PanelFunciones.TabIndex = 5;
            // 
            // Sala
            // 
            this.Sala.Controls.Add(this.panelContenedor);
            this.Sala.Controls.Add(this.flowLayoutPanel1);
            this.Sala.Location = new System.Drawing.Point(4, 22);
            this.Sala.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Sala.Name = "Sala";
            this.Sala.Padding = new System.Windows.Forms.Padding(4);
            this.Sala.Size = new System.Drawing.Size(1040, 387);
            this.Sala.TabIndex = 1;
            this.Sala.Text = "Sala";
            this.Sala.UseVisualStyleBackColor = true;
            // 
            // panelContenedor
            // 
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(4, 118);
            this.panelContenedor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(1032, 265);
            this.panelContenedor.TabIndex = 3;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.AliceBlue;
            this.flowLayoutPanel1.Controls.Add(this.groupBox1);
            this.flowLayoutPanel1.Controls.Add(this.gbPrestamos);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(4, 4);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1032, 114);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btInicio);
            this.groupBox1.Location = new System.Drawing.Point(3, 2);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(136, 108);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Inicio";
            // 
            // btInicio
            // 
            this.btInicio.Location = new System.Drawing.Point(36, 23);
            this.btInicio.Margin = new System.Windows.Forms.Padding(4);
            this.btInicio.Name = "btInicio";
            this.btInicio.Size = new System.Drawing.Size(69, 68);
            this.btInicio.TabIndex = 1;
            this.btInicio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btInicio.UseVisualStyleBackColor = true;
            this.btInicio.Click += new System.EventHandler(this.btInicio_Click);
            // 
            // gbPrestamos
            // 
            this.gbPrestamos.Controls.Add(this.btBuscar);
            this.gbPrestamos.Controls.Add(this.btBusqueda);
            this.gbPrestamos.Controls.Add(this.btDevolucion);
            this.gbPrestamos.Controls.Add(this.btPrestamo);
            this.gbPrestamos.Location = new System.Drawing.Point(145, 2);
            this.gbPrestamos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbPrestamos.Name = "gbPrestamos";
            this.gbPrestamos.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbPrestamos.Size = new System.Drawing.Size(352, 110);
            this.gbPrestamos.TabIndex = 0;
            this.gbPrestamos.TabStop = false;
            this.gbPrestamos.Text = "Préstamos";
            // 
            // btBuscar
            // 
            this.btBuscar.Image = global::Presentacion.Properties.Resources.ImagenBuscar__1_;
            this.btBuscar.Location = new System.Drawing.Point(251, 23);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(81, 68);
            this.btBuscar.TabIndex = 18;
            this.btBuscar.Text = "Consultar";
            this.btBuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btBuscar.UseVisualStyleBackColor = true;
            this.btBuscar.Click += new System.EventHandler(this.btBuscar_Click);
            // 
            // btBusqueda
            // 
            this.btBusqueda.AutoSize = true;
            this.btBusqueda.Image = global::Presentacion.Properties.Resources.ImagenBuscar__1_;
            this.btBusqueda.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btBusqueda.Location = new System.Drawing.Point(476, 4);
            this.btBusqueda.Margin = new System.Windows.Forms.Padding(4);
            this.btBusqueda.Name = "btBusqueda";
            this.btBusqueda.Size = new System.Drawing.Size(127, 103);
            this.btBusqueda.TabIndex = 4;
            this.btBusqueda.Text = "Consultar";
            this.btBusqueda.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btBusqueda.UseVisualStyleBackColor = true;
            this.btBusqueda.Click += new System.EventHandler(this.btBusqueda_Click);
            // 
            // btDevolucion
            // 
            this.btDevolucion.Image = global::Presentacion.Properties.Resources.ImagenDevolucion;
            this.btDevolucion.Location = new System.Drawing.Point(133, 21);
            this.btDevolucion.Margin = new System.Windows.Forms.Padding(4);
            this.btDevolucion.Name = "btDevolucion";
            this.btDevolucion.Size = new System.Drawing.Size(93, 70);
            this.btDevolucion.TabIndex = 1;
            this.btDevolucion.Text = "Devolución";
            this.btDevolucion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btDevolucion.UseVisualStyleBackColor = true;
            // 
            // btPrestamo
            // 
            this.btPrestamo.Image = global::Presentacion.Properties.Resources.ImagenPrestamo;
            this.btPrestamo.Location = new System.Drawing.Point(19, 20);
            this.btPrestamo.Margin = new System.Windows.Forms.Padding(4);
            this.btPrestamo.Name = "btPrestamo";
            this.btPrestamo.Size = new System.Drawing.Size(96, 71);
            this.btPrestamo.TabIndex = 0;
            this.btPrestamo.Text = "Préstamo";
            this.btPrestamo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btPrestamo.UseVisualStyleBackColor = true;
            this.btPrestamo.Click += new System.EventHandler(this.btPrestamo_Click);
            // 
            // Adquisiciones
            // 
            this.Adquisiciones.Controls.Add(this.panel_Listar_Ejemplar);
            this.Adquisiciones.Controls.Add(this.panel_Listar_Documento);
            this.Adquisiciones.Controls.Add(this.panel_Consultar_MasLeido);
            this.Adquisiciones.Controls.Add(this.button_Realizar_Consultar_Fech);
            this.Adquisiciones.Controls.Add(this.panel_Consultar_Fecha);
            this.Adquisiciones.Controls.Add(this.button_Realizar_Consultar_Disp);
            this.Adquisiciones.Controls.Add(this.panel_Consultar_Disponible);
            this.Adquisiciones.Controls.Add(this.button_Realizar_Consultar_Ejemplar);
            this.Adquisiciones.Controls.Add(this.panel_Consultar_Ejemplar);
            this.Adquisiciones.Controls.Add(this.button_Listar_Ejemplar);
            this.Adquisiciones.Controls.Add(this.button_Listar_Documento);
            this.Adquisiciones.Controls.Add(this.button_Consultar_Mas_Leido);
            this.Adquisiciones.Controls.Add(this.button_Consultar_Disponible);
            this.Adquisiciones.Controls.Add(this.button_Consultar_Fecha);
            this.Adquisiciones.Controls.Add(this.button_Consultar_Ejemplar);
            this.Adquisiciones.Controls.Add(this.button_Borrar_Baja_Eje);
            this.Adquisiciones.Controls.Add(this.panel_Baja_Ejemplar);
            this.Adquisiciones.Controls.Add(this.panel_Alta_Ejemplar);
            this.Adquisiciones.Controls.Add(this.button_Validar_Alta_Ejemplar);
            this.Adquisiciones.Controls.Add(this.button_Validar_Alta_Documento);
            this.Adquisiciones.Controls.Add(this.panel_Alta_Documento);
            this.Adquisiciones.Controls.Add(this.button_Volver);
            this.Adquisiciones.Controls.Add(this.button_Alta_Ejemplar);
            this.Adquisiciones.Controls.Add(this.button_Alta_Documento);
            this.Adquisiciones.Controls.Add(this.button_Listar);
            this.Adquisiciones.Controls.Add(this.button_Consultas);
            this.Adquisiciones.Controls.Add(this.button_Bajas);
            this.Adquisiciones.Controls.Add(this.button_Altas);
            this.Adquisiciones.Controls.Add(this.label_Main_Adquisiciones);
            this.Adquisiciones.Location = new System.Drawing.Point(4, 22);
            this.Adquisiciones.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Adquisiciones.Name = "Adquisiciones";
            this.Adquisiciones.Size = new System.Drawing.Size(1040, 387);
            this.Adquisiciones.TabIndex = 2;
            this.Adquisiciones.Text = "Adquisiciones";
            this.Adquisiciones.UseVisualStyleBackColor = true;
            // 
            // panel_Listar_Ejemplar
            // 
            this.panel_Listar_Ejemplar.Controls.Add(this.comboBox_Documento_Listar_Ejemplar);
            this.panel_Listar_Ejemplar.Controls.Add(this.label_Documento_Listar_Ejemplar);
            this.panel_Listar_Ejemplar.Controls.Add(this.dataGridView_Listar_Ejemplar);
            this.panel_Listar_Ejemplar.Controls.Add(this.label_Listar_Ejemplar);
            this.panel_Listar_Ejemplar.Location = new System.Drawing.Point(19, 52);
            this.panel_Listar_Ejemplar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_Listar_Ejemplar.Name = "panel_Listar_Ejemplar";
            this.panel_Listar_Ejemplar.Size = new System.Drawing.Size(813, 318);
            this.panel_Listar_Ejemplar.TabIndex = 30;
            this.panel_Listar_Ejemplar.Visible = false;
            // 
            // comboBox_Documento_Listar_Ejemplar
            // 
            this.comboBox_Documento_Listar_Ejemplar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Documento_Listar_Ejemplar.FormattingEnabled = true;
            this.comboBox_Documento_Listar_Ejemplar.Location = new System.Drawing.Point(293, 39);
            this.comboBox_Documento_Listar_Ejemplar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox_Documento_Listar_Ejemplar.Name = "comboBox_Documento_Listar_Ejemplar";
            this.comboBox_Documento_Listar_Ejemplar.Size = new System.Drawing.Size(225, 21);
            this.comboBox_Documento_Listar_Ejemplar.TabIndex = 3;
            this.comboBox_Documento_Listar_Ejemplar.SelectedIndexChanged += new System.EventHandler(this.comboBox_Documento_Listar_Ejemplar_SelectedIndexChanged);
            // 
            // label_Documento_Listar_Ejemplar
            // 
            this.label_Documento_Listar_Ejemplar.AutoSize = true;
            this.label_Documento_Listar_Ejemplar.Location = new System.Drawing.Point(209, 44);
            this.label_Documento_Listar_Ejemplar.Name = "label_Documento_Listar_Ejemplar";
            this.label_Documento_Listar_Ejemplar.Size = new System.Drawing.Size(62, 13);
            this.label_Documento_Listar_Ejemplar.TabIndex = 2;
            this.label_Documento_Listar_Ejemplar.Text = "Documento";
            // 
            // dataGridView_Listar_Ejemplar
            // 
            this.dataGridView_Listar_Ejemplar.AllowUserToAddRows = false;
            this.dataGridView_Listar_Ejemplar.AllowUserToDeleteRows = false;
            this.dataGridView_Listar_Ejemplar.AutoGenerateColumns = false;
            this.dataGridView_Listar_Ejemplar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Listar_Ejemplar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_Codigo_Listar_Ejemplar,
            this.Column_Documento_Listar_Ejemplar,
            this.Column_Responsable_Listar_Ejemplar,
            this.Column_Activo_Listar_Ejemplar,
            this.Column_Disponible_Listar_Ejemplar,
            this.ColumnLocalizacion_Listar_Ejemplar});
            this.dataGridView_Listar_Ejemplar.DataSource = this.bindingSource_Ejemplar_Listar_Ejemplar;
            this.dataGridView_Listar_Ejemplar.Location = new System.Drawing.Point(35, 84);
            this.dataGridView_Listar_Ejemplar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView_Listar_Ejemplar.Name = "dataGridView_Listar_Ejemplar";
            this.dataGridView_Listar_Ejemplar.ReadOnly = true;
            this.dataGridView_Listar_Ejemplar.RowHeadersWidth = 51;
            this.dataGridView_Listar_Ejemplar.RowTemplate.Height = 24;
            this.dataGridView_Listar_Ejemplar.Size = new System.Drawing.Size(744, 226);
            this.dataGridView_Listar_Ejemplar.TabIndex = 1;
            this.dataGridView_Listar_Ejemplar.Visible = false;
            this.dataGridView_Listar_Ejemplar.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView_Listar_Ejemplar_CellFormatting);
            // 
            // label_Listar_Ejemplar
            // 
            this.label_Listar_Ejemplar.AutoSize = true;
            this.label_Listar_Ejemplar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label_Listar_Ejemplar.Location = new System.Drawing.Point(340, 17);
            this.label_Listar_Ejemplar.Name = "label_Listar_Ejemplar";
            this.label_Listar_Ejemplar.Size = new System.Drawing.Size(132, 17);
            this.label_Listar_Ejemplar.TabIndex = 0;
            this.label_Listar_Ejemplar.Text = "Lista de Ejemplares";
            // 
            // panel_Listar_Documento
            // 
            this.panel_Listar_Documento.Controls.Add(this.dataGridView_Listar_Documento);
            this.panel_Listar_Documento.Controls.Add(this.label_Listar_Documento);
            this.panel_Listar_Documento.Location = new System.Drawing.Point(19, 50);
            this.panel_Listar_Documento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_Listar_Documento.Name = "panel_Listar_Documento";
            this.panel_Listar_Documento.Size = new System.Drawing.Size(813, 318);
            this.panel_Listar_Documento.TabIndex = 29;
            this.panel_Listar_Documento.Visible = false;
            // 
            // dataGridView_Listar_Documento
            // 
            this.dataGridView_Listar_Documento.AllowUserToAddRows = false;
            this.dataGridView_Listar_Documento.AllowUserToDeleteRows = false;
            this.dataGridView_Listar_Documento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Listar_Documento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.column_Titulo_List_Documento,
            this.column_Autor_List_Documento,
            this.column_ISBN_List_Documento,
            this.column_Editorial_List_Documento,
            this.column_Año_List_Documento,
            this.column_AudioLibro_List_Documento,
            this.column_Formato_List_Documento,
            this.column_Duracion_List_Documento,
            this.column_Fecha_List_Documento,
            this.column_Disponible_List_Documento});
            this.dataGridView_Listar_Documento.Location = new System.Drawing.Point(3, 49);
            this.dataGridView_Listar_Documento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView_Listar_Documento.Name = "dataGridView_Listar_Documento";
            this.dataGridView_Listar_Documento.ReadOnly = true;
            this.dataGridView_Listar_Documento.RowHeadersWidth = 51;
            this.dataGridView_Listar_Documento.RowTemplate.Height = 24;
            this.dataGridView_Listar_Documento.Size = new System.Drawing.Size(807, 262);
            this.dataGridView_Listar_Documento.TabIndex = 1;
            // 
            // column_Titulo_List_Documento
            // 
            this.column_Titulo_List_Documento.HeaderText = "Titulo";
            this.column_Titulo_List_Documento.MinimumWidth = 6;
            this.column_Titulo_List_Documento.Name = "column_Titulo_List_Documento";
            this.column_Titulo_List_Documento.ReadOnly = true;
            this.column_Titulo_List_Documento.Width = 125;
            // 
            // column_Autor_List_Documento
            // 
            this.column_Autor_List_Documento.HeaderText = "Autor";
            this.column_Autor_List_Documento.MinimumWidth = 6;
            this.column_Autor_List_Documento.Name = "column_Autor_List_Documento";
            this.column_Autor_List_Documento.ReadOnly = true;
            this.column_Autor_List_Documento.Width = 125;
            // 
            // column_ISBN_List_Documento
            // 
            this.column_ISBN_List_Documento.HeaderText = "ISBN";
            this.column_ISBN_List_Documento.MinimumWidth = 6;
            this.column_ISBN_List_Documento.Name = "column_ISBN_List_Documento";
            this.column_ISBN_List_Documento.ReadOnly = true;
            this.column_ISBN_List_Documento.Width = 125;
            // 
            // column_Editorial_List_Documento
            // 
            this.column_Editorial_List_Documento.HeaderText = "Editorial";
            this.column_Editorial_List_Documento.MinimumWidth = 6;
            this.column_Editorial_List_Documento.Name = "column_Editorial_List_Documento";
            this.column_Editorial_List_Documento.ReadOnly = true;
            this.column_Editorial_List_Documento.Width = 125;
            // 
            // column_Año_List_Documento
            // 
            this.column_Año_List_Documento.HeaderText = "AñoEdicion";
            this.column_Año_List_Documento.MinimumWidth = 6;
            this.column_Año_List_Documento.Name = "column_Año_List_Documento";
            this.column_Año_List_Documento.ReadOnly = true;
            this.column_Año_List_Documento.Width = 125;
            // 
            // column_AudioLibro_List_Documento
            // 
            this.column_AudioLibro_List_Documento.HeaderText = "Audiolibro";
            this.column_AudioLibro_List_Documento.MinimumWidth = 6;
            this.column_AudioLibro_List_Documento.Name = "column_AudioLibro_List_Documento";
            this.column_AudioLibro_List_Documento.ReadOnly = true;
            this.column_AudioLibro_List_Documento.Width = 70;
            // 
            // column_Formato_List_Documento
            // 
            this.column_Formato_List_Documento.HeaderText = "Formato";
            this.column_Formato_List_Documento.MinimumWidth = 6;
            this.column_Formato_List_Documento.Name = "column_Formato_List_Documento";
            this.column_Formato_List_Documento.ReadOnly = true;
            this.column_Formato_List_Documento.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.column_Formato_List_Documento.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.column_Formato_List_Documento.Width = 125;
            // 
            // column_Duracion_List_Documento
            // 
            this.column_Duracion_List_Documento.HeaderText = "Duracion";
            this.column_Duracion_List_Documento.MinimumWidth = 6;
            this.column_Duracion_List_Documento.Name = "column_Duracion_List_Documento";
            this.column_Duracion_List_Documento.ReadOnly = true;
            this.column_Duracion_List_Documento.Width = 125;
            // 
            // column_Fecha_List_Documento
            // 
            this.column_Fecha_List_Documento.HeaderText = "Fecha Disponible";
            this.column_Fecha_List_Documento.MinimumWidth = 6;
            this.column_Fecha_List_Documento.Name = "column_Fecha_List_Documento";
            this.column_Fecha_List_Documento.ReadOnly = true;
            this.column_Fecha_List_Documento.Width = 125;
            // 
            // column_Disponible_List_Documento
            // 
            this.column_Disponible_List_Documento.HeaderText = "Disponible";
            this.column_Disponible_List_Documento.MinimumWidth = 6;
            this.column_Disponible_List_Documento.Name = "column_Disponible_List_Documento";
            this.column_Disponible_List_Documento.ReadOnly = true;
            this.column_Disponible_List_Documento.Width = 125;
            // 
            // label_Listar_Documento
            // 
            this.label_Listar_Documento.AutoSize = true;
            this.label_Listar_Documento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label_Listar_Documento.Location = new System.Drawing.Point(347, 17);
            this.label_Listar_Documento.Name = "label_Listar_Documento";
            this.label_Listar_Documento.Size = new System.Drawing.Size(141, 17);
            this.label_Listar_Documento.TabIndex = 0;
            this.label_Listar_Documento.Text = "Lista de Documentos";
            // 
            // panel_Consultar_MasLeido
            // 
            this.panel_Consultar_MasLeido.Controls.Add(this.label_Consultar_MasLeido);
            this.panel_Consultar_MasLeido.Controls.Add(this.textBox_Duracion_Consultar_MasLeido);
            this.panel_Consultar_MasLeido.Controls.Add(this.comboBox_Formato_Consultar_MasLeido);
            this.panel_Consultar_MasLeido.Controls.Add(this.label_Duracion_Consultar_MasLeido);
            this.panel_Consultar_MasLeido.Controls.Add(this.label_Formato_Consultar_MasLeido);
            this.panel_Consultar_MasLeido.Controls.Add(this.label_Año_Consultar_MasLeido);
            this.panel_Consultar_MasLeido.Controls.Add(this.textBox_Año_Consultar_MasLeido);
            this.panel_Consultar_MasLeido.Controls.Add(this.label_Editorial_Consultar_MasLeido);
            this.panel_Consultar_MasLeido.Controls.Add(this.label_ISBN_Consultar_MasLeido);
            this.panel_Consultar_MasLeido.Controls.Add(this.label_Autor_Consultar_MasLeido);
            this.panel_Consultar_MasLeido.Controls.Add(this.label_Titulo_Consultar_MasLeido);
            this.panel_Consultar_MasLeido.Controls.Add(this.textBox_Editorial_Consultar_MasLeido);
            this.panel_Consultar_MasLeido.Controls.Add(this.textBox_ISBN_Consultar_MasLeido);
            this.panel_Consultar_MasLeido.Controls.Add(this.textBox_Autor_Consultar_MasLeido);
            this.panel_Consultar_MasLeido.Controls.Add(this.textBox_Titulo_Consultar_MasLeido);
            this.panel_Consultar_MasLeido.Controls.Add(this.checkBox_Audiolibro_Consultar_MasLeido);
            this.panel_Consultar_MasLeido.Location = new System.Drawing.Point(247, 74);
            this.panel_Consultar_MasLeido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_Consultar_MasLeido.Name = "panel_Consultar_MasLeido";
            this.panel_Consultar_MasLeido.Size = new System.Drawing.Size(355, 357);
            this.panel_Consultar_MasLeido.TabIndex = 17;
            this.panel_Consultar_MasLeido.Visible = false;
            // 
            // label_Consultar_MasLeido
            // 
            this.label_Consultar_MasLeido.AutoSize = true;
            this.label_Consultar_MasLeido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Consultar_MasLeido.Location = new System.Drawing.Point(108, 10);
            this.label_Consultar_MasLeido.Name = "label_Consultar_MasLeido";
            this.label_Consultar_MasLeido.Size = new System.Drawing.Size(128, 17);
            this.label_Consultar_MasLeido.TabIndex = 15;
            this.label_Consultar_MasLeido.Text = "Alta de Documento";
            // 
            // textBox_Duracion_Consultar_MasLeido
            // 
            this.textBox_Duracion_Consultar_MasLeido.Enabled = false;
            this.textBox_Duracion_Consultar_MasLeido.Location = new System.Drawing.Point(127, 268);
            this.textBox_Duracion_Consultar_MasLeido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_Duracion_Consultar_MasLeido.Name = "textBox_Duracion_Consultar_MasLeido";
            this.textBox_Duracion_Consultar_MasLeido.Size = new System.Drawing.Size(121, 20);
            this.textBox_Duracion_Consultar_MasLeido.TabIndex = 14;
            this.textBox_Duracion_Consultar_MasLeido.Visible = false;
            // 
            // comboBox_Formato_Consultar_MasLeido
            // 
            this.comboBox_Formato_Consultar_MasLeido.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Formato_Consultar_MasLeido.Enabled = false;
            this.comboBox_Formato_Consultar_MasLeido.FormattingEnabled = true;
            this.comboBox_Formato_Consultar_MasLeido.Location = new System.Drawing.Point(127, 230);
            this.comboBox_Formato_Consultar_MasLeido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox_Formato_Consultar_MasLeido.Name = "comboBox_Formato_Consultar_MasLeido";
            this.comboBox_Formato_Consultar_MasLeido.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Formato_Consultar_MasLeido.TabIndex = 13;
            this.comboBox_Formato_Consultar_MasLeido.Visible = false;
            // 
            // label_Duracion_Consultar_MasLeido
            // 
            this.label_Duracion_Consultar_MasLeido.AutoSize = true;
            this.label_Duracion_Consultar_MasLeido.Location = new System.Drawing.Point(23, 268);
            this.label_Duracion_Consultar_MasLeido.Name = "label_Duracion_Consultar_MasLeido";
            this.label_Duracion_Consultar_MasLeido.Size = new System.Drawing.Size(50, 13);
            this.label_Duracion_Consultar_MasLeido.TabIndex = 12;
            this.label_Duracion_Consultar_MasLeido.Text = "Duración";
            this.label_Duracion_Consultar_MasLeido.Visible = false;
            // 
            // label_Formato_Consultar_MasLeido
            // 
            this.label_Formato_Consultar_MasLeido.AutoSize = true;
            this.label_Formato_Consultar_MasLeido.Location = new System.Drawing.Point(23, 233);
            this.label_Formato_Consultar_MasLeido.Name = "label_Formato_Consultar_MasLeido";
            this.label_Formato_Consultar_MasLeido.Size = new System.Drawing.Size(45, 13);
            this.label_Formato_Consultar_MasLeido.TabIndex = 11;
            this.label_Formato_Consultar_MasLeido.Text = "Formato";
            this.label_Formato_Consultar_MasLeido.Visible = false;
            // 
            // label_Año_Consultar_MasLeido
            // 
            this.label_Año_Consultar_MasLeido.AutoSize = true;
            this.label_Año_Consultar_MasLeido.Location = new System.Drawing.Point(23, 159);
            this.label_Año_Consultar_MasLeido.Name = "label_Año_Consultar_MasLeido";
            this.label_Año_Consultar_MasLeido.Size = new System.Drawing.Size(64, 13);
            this.label_Año_Consultar_MasLeido.TabIndex = 10;
            this.label_Año_Consultar_MasLeido.Text = "Año Edición";
            // 
            // textBox_Año_Consultar_MasLeido
            // 
            this.textBox_Año_Consultar_MasLeido.Enabled = false;
            this.textBox_Año_Consultar_MasLeido.Location = new System.Drawing.Point(127, 154);
            this.textBox_Año_Consultar_MasLeido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_Año_Consultar_MasLeido.MaxLength = 4;
            this.textBox_Año_Consultar_MasLeido.Name = "textBox_Año_Consultar_MasLeido";
            this.textBox_Año_Consultar_MasLeido.Size = new System.Drawing.Size(121, 20);
            this.textBox_Año_Consultar_MasLeido.TabIndex = 9;
            // 
            // label_Editorial_Consultar_MasLeido
            // 
            this.label_Editorial_Consultar_MasLeido.AutoSize = true;
            this.label_Editorial_Consultar_MasLeido.Location = new System.Drawing.Point(23, 132);
            this.label_Editorial_Consultar_MasLeido.Name = "label_Editorial_Consultar_MasLeido";
            this.label_Editorial_Consultar_MasLeido.Size = new System.Drawing.Size(44, 13);
            this.label_Editorial_Consultar_MasLeido.TabIndex = 8;
            this.label_Editorial_Consultar_MasLeido.Text = "Editorial";
            // 
            // label_ISBN_Consultar_MasLeido
            // 
            this.label_ISBN_Consultar_MasLeido.AutoSize = true;
            this.label_ISBN_Consultar_MasLeido.Location = new System.Drawing.Point(23, 101);
            this.label_ISBN_Consultar_MasLeido.Name = "label_ISBN_Consultar_MasLeido";
            this.label_ISBN_Consultar_MasLeido.Size = new System.Drawing.Size(32, 13);
            this.label_ISBN_Consultar_MasLeido.TabIndex = 7;
            this.label_ISBN_Consultar_MasLeido.Text = "ISBN";
            // 
            // label_Autor_Consultar_MasLeido
            // 
            this.label_Autor_Consultar_MasLeido.AutoSize = true;
            this.label_Autor_Consultar_MasLeido.Location = new System.Drawing.Point(23, 73);
            this.label_Autor_Consultar_MasLeido.Name = "label_Autor_Consultar_MasLeido";
            this.label_Autor_Consultar_MasLeido.Size = new System.Drawing.Size(32, 13);
            this.label_Autor_Consultar_MasLeido.TabIndex = 6;
            this.label_Autor_Consultar_MasLeido.Text = "Autor";
            // 
            // label_Titulo_Consultar_MasLeido
            // 
            this.label_Titulo_Consultar_MasLeido.AutoSize = true;
            this.label_Titulo_Consultar_MasLeido.Location = new System.Drawing.Point(23, 46);
            this.label_Titulo_Consultar_MasLeido.Name = "label_Titulo_Consultar_MasLeido";
            this.label_Titulo_Consultar_MasLeido.Size = new System.Drawing.Size(33, 13);
            this.label_Titulo_Consultar_MasLeido.TabIndex = 5;
            this.label_Titulo_Consultar_MasLeido.Text = "Titulo";
            // 
            // textBox_Editorial_Consultar_MasLeido
            // 
            this.textBox_Editorial_Consultar_MasLeido.Enabled = false;
            this.textBox_Editorial_Consultar_MasLeido.Location = new System.Drawing.Point(127, 126);
            this.textBox_Editorial_Consultar_MasLeido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_Editorial_Consultar_MasLeido.Name = "textBox_Editorial_Consultar_MasLeido";
            this.textBox_Editorial_Consultar_MasLeido.Size = new System.Drawing.Size(121, 20);
            this.textBox_Editorial_Consultar_MasLeido.TabIndex = 4;
            // 
            // textBox_ISBN_Consultar_MasLeido
            // 
            this.textBox_ISBN_Consultar_MasLeido.Enabled = false;
            this.textBox_ISBN_Consultar_MasLeido.Location = new System.Drawing.Point(127, 98);
            this.textBox_ISBN_Consultar_MasLeido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_ISBN_Consultar_MasLeido.Name = "textBox_ISBN_Consultar_MasLeido";
            this.textBox_ISBN_Consultar_MasLeido.Size = new System.Drawing.Size(121, 20);
            this.textBox_ISBN_Consultar_MasLeido.TabIndex = 3;
            // 
            // textBox_Autor_Consultar_MasLeido
            // 
            this.textBox_Autor_Consultar_MasLeido.Enabled = false;
            this.textBox_Autor_Consultar_MasLeido.Location = new System.Drawing.Point(127, 70);
            this.textBox_Autor_Consultar_MasLeido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_Autor_Consultar_MasLeido.Name = "textBox_Autor_Consultar_MasLeido";
            this.textBox_Autor_Consultar_MasLeido.Size = new System.Drawing.Size(121, 20);
            this.textBox_Autor_Consultar_MasLeido.TabIndex = 2;
            // 
            // textBox_Titulo_Consultar_MasLeido
            // 
            this.textBox_Titulo_Consultar_MasLeido.Enabled = false;
            this.textBox_Titulo_Consultar_MasLeido.Location = new System.Drawing.Point(127, 42);
            this.textBox_Titulo_Consultar_MasLeido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_Titulo_Consultar_MasLeido.Name = "textBox_Titulo_Consultar_MasLeido";
            this.textBox_Titulo_Consultar_MasLeido.Size = new System.Drawing.Size(121, 20);
            this.textBox_Titulo_Consultar_MasLeido.TabIndex = 1;
            // 
            // checkBox_Audiolibro_Consultar_MasLeido
            // 
            this.checkBox_Audiolibro_Consultar_MasLeido.AutoSize = true;
            this.checkBox_Audiolibro_Consultar_MasLeido.Enabled = false;
            this.checkBox_Audiolibro_Consultar_MasLeido.Location = new System.Drawing.Point(140, 191);
            this.checkBox_Audiolibro_Consultar_MasLeido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox_Audiolibro_Consultar_MasLeido.Name = "checkBox_Audiolibro_Consultar_MasLeido";
            this.checkBox_Audiolibro_Consultar_MasLeido.Size = new System.Drawing.Size(76, 17);
            this.checkBox_Audiolibro_Consultar_MasLeido.TabIndex = 0;
            this.checkBox_Audiolibro_Consultar_MasLeido.Text = "AudioLibro";
            this.checkBox_Audiolibro_Consultar_MasLeido.UseVisualStyleBackColor = true;
            // 
            // button_Realizar_Consultar_Fech
            // 
            this.button_Realizar_Consultar_Fech.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.button_Realizar_Consultar_Fech.Location = new System.Drawing.Point(640, 382);
            this.button_Realizar_Consultar_Fech.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_Realizar_Consultar_Fech.Name = "button_Realizar_Consultar_Fech";
            this.button_Realizar_Consultar_Fech.Size = new System.Drawing.Size(107, 42);
            this.button_Realizar_Consultar_Fech.TabIndex = 28;
            this.button_Realizar_Consultar_Fech.Text = "Consultar";
            this.button_Realizar_Consultar_Fech.UseVisualStyleBackColor = true;
            this.button_Realizar_Consultar_Fech.Visible = false;
            this.button_Realizar_Consultar_Fech.Click += new System.EventHandler(this.EventHandler_Click_RealizarConsulta);
            // 
            // panel_Consultar_Fecha
            // 
            this.panel_Consultar_Fecha.Controls.Add(this.textBox_Fecha_Consultar_Fech);
            this.panel_Consultar_Fecha.Controls.Add(this.label_Fecha_Consultar_Fech);
            this.panel_Consultar_Fecha.Controls.Add(this.comboBox_Documento_Consultar_Fech);
            this.panel_Consultar_Fecha.Controls.Add(this.label_Documento_Consultar_Fech);
            this.panel_Consultar_Fecha.Controls.Add(this.label_Consultar_Fecha);
            this.panel_Consultar_Fecha.Location = new System.Drawing.Point(243, 182);
            this.panel_Consultar_Fecha.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_Consultar_Fecha.Name = "panel_Consultar_Fecha";
            this.panel_Consultar_Fecha.Size = new System.Drawing.Size(355, 114);
            this.panel_Consultar_Fecha.TabIndex = 26;
            this.panel_Consultar_Fecha.Visible = false;
            // 
            // textBox_Fecha_Consultar_Fech
            // 
            this.textBox_Fecha_Consultar_Fech.Enabled = false;
            this.textBox_Fecha_Consultar_Fech.Location = new System.Drawing.Point(127, 68);
            this.textBox_Fecha_Consultar_Fech.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_Fecha_Consultar_Fech.Name = "textBox_Fecha_Consultar_Fech";
            this.textBox_Fecha_Consultar_Fech.Size = new System.Drawing.Size(208, 20);
            this.textBox_Fecha_Consultar_Fech.TabIndex = 20;
            this.textBox_Fecha_Consultar_Fech.Visible = false;
            // 
            // label_Fecha_Consultar_Fech
            // 
            this.label_Fecha_Consultar_Fech.AutoSize = true;
            this.label_Fecha_Consultar_Fech.Location = new System.Drawing.Point(23, 71);
            this.label_Fecha_Consultar_Fech.Name = "label_Fecha_Consultar_Fech";
            this.label_Fecha_Consultar_Fech.Size = new System.Drawing.Size(37, 13);
            this.label_Fecha_Consultar_Fech.TabIndex = 19;
            this.label_Fecha_Consultar_Fech.Text = "Fecha";
            this.label_Fecha_Consultar_Fech.Visible = false;
            // 
            // comboBox_Documento_Consultar_Fech
            // 
            this.comboBox_Documento_Consultar_Fech.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Documento_Consultar_Fech.FormattingEnabled = true;
            this.comboBox_Documento_Consultar_Fech.Location = new System.Drawing.Point(128, 34);
            this.comboBox_Documento_Consultar_Fech.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox_Documento_Consultar_Fech.Name = "comboBox_Documento_Consultar_Fech";
            this.comboBox_Documento_Consultar_Fech.Size = new System.Drawing.Size(207, 21);
            this.comboBox_Documento_Consultar_Fech.TabIndex = 18;
            // 
            // label_Documento_Consultar_Fech
            // 
            this.label_Documento_Consultar_Fech.AutoSize = true;
            this.label_Documento_Consultar_Fech.Location = new System.Drawing.Point(23, 39);
            this.label_Documento_Consultar_Fech.Name = "label_Documento_Consultar_Fech";
            this.label_Documento_Consultar_Fech.Size = new System.Drawing.Size(62, 13);
            this.label_Documento_Consultar_Fech.TabIndex = 17;
            this.label_Documento_Consultar_Fech.Text = "Documento";
            // 
            // label_Consultar_Fecha
            // 
            this.label_Consultar_Fecha.AutoSize = true;
            this.label_Consultar_Fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Consultar_Fecha.Location = new System.Drawing.Point(53, 9);
            this.label_Consultar_Fecha.Name = "label_Consultar_Fecha";
            this.label_Consultar_Fecha.Size = new System.Drawing.Size(257, 17);
            this.label_Consultar_Fecha.TabIndex = 15;
            this.label_Consultar_Fecha.Text = "Consultar Fecha Disponible Documento";
            // 
            // button_Realizar_Consultar_Disp
            // 
            this.button_Realizar_Consultar_Disp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.button_Realizar_Consultar_Disp.Location = new System.Drawing.Point(640, 382);
            this.button_Realizar_Consultar_Disp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_Realizar_Consultar_Disp.Name = "button_Realizar_Consultar_Disp";
            this.button_Realizar_Consultar_Disp.Size = new System.Drawing.Size(107, 42);
            this.button_Realizar_Consultar_Disp.TabIndex = 27;
            this.button_Realizar_Consultar_Disp.Text = "Consultar";
            this.button_Realizar_Consultar_Disp.UseVisualStyleBackColor = true;
            this.button_Realizar_Consultar_Disp.Visible = false;
            this.button_Realizar_Consultar_Disp.Click += new System.EventHandler(this.EventHandler_Click_RealizarConsulta);
            // 
            // panel_Consultar_Disponible
            // 
            this.panel_Consultar_Disponible.Controls.Add(this.comboBox_Documento_Consultar_Disp);
            this.panel_Consultar_Disponible.Controls.Add(this.label_Documento_Consultar_Disp);
            this.panel_Consultar_Disponible.Controls.Add(this.label_Consultar_Disponible);
            this.panel_Consultar_Disponible.Controls.Add(this.checkBox_Disponible_Consultar_Disp);
            this.panel_Consultar_Disponible.Location = new System.Drawing.Point(243, 182);
            this.panel_Consultar_Disponible.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_Consultar_Disponible.Name = "panel_Consultar_Disponible";
            this.panel_Consultar_Disponible.Size = new System.Drawing.Size(355, 114);
            this.panel_Consultar_Disponible.TabIndex = 25;
            this.panel_Consultar_Disponible.Visible = false;
            // 
            // comboBox_Documento_Consultar_Disp
            // 
            this.comboBox_Documento_Consultar_Disp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Documento_Consultar_Disp.FormattingEnabled = true;
            this.comboBox_Documento_Consultar_Disp.Location = new System.Drawing.Point(128, 34);
            this.comboBox_Documento_Consultar_Disp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox_Documento_Consultar_Disp.Name = "comboBox_Documento_Consultar_Disp";
            this.comboBox_Documento_Consultar_Disp.Size = new System.Drawing.Size(207, 21);
            this.comboBox_Documento_Consultar_Disp.TabIndex = 18;
            // 
            // label_Documento_Consultar_Disp
            // 
            this.label_Documento_Consultar_Disp.AutoSize = true;
            this.label_Documento_Consultar_Disp.Location = new System.Drawing.Point(23, 39);
            this.label_Documento_Consultar_Disp.Name = "label_Documento_Consultar_Disp";
            this.label_Documento_Consultar_Disp.Size = new System.Drawing.Size(62, 13);
            this.label_Documento_Consultar_Disp.TabIndex = 17;
            this.label_Documento_Consultar_Disp.Text = "Documento";
            // 
            // label_Consultar_Disponible
            // 
            this.label_Consultar_Disponible.AutoSize = true;
            this.label_Consultar_Disponible.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Consultar_Disponible.Location = new System.Drawing.Point(53, 9);
            this.label_Consultar_Disponible.Name = "label_Consultar_Disponible";
            this.label_Consultar_Disponible.Size = new System.Drawing.Size(236, 17);
            this.label_Consultar_Disponible.TabIndex = 15;
            this.label_Consultar_Disponible.Text = "Consultar Disponibilidad Documento";
            // 
            // checkBox_Disponible_Consultar_Disp
            // 
            this.checkBox_Disponible_Consultar_Disp.AutoSize = true;
            this.checkBox_Disponible_Consultar_Disp.Checked = true;
            this.checkBox_Disponible_Consultar_Disp.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_Disponible_Consultar_Disp.Enabled = false;
            this.checkBox_Disponible_Consultar_Disp.Location = new System.Drawing.Point(127, 78);
            this.checkBox_Disponible_Consultar_Disp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox_Disponible_Consultar_Disp.Name = "checkBox_Disponible_Consultar_Disp";
            this.checkBox_Disponible_Consultar_Disp.Size = new System.Drawing.Size(97, 17);
            this.checkBox_Disponible_Consultar_Disp.TabIndex = 0;
            this.checkBox_Disponible_Consultar_Disp.Text = "Hay Disponible";
            this.checkBox_Disponible_Consultar_Disp.UseVisualStyleBackColor = true;
            this.checkBox_Disponible_Consultar_Disp.Visible = false;
            // 
            // button_Realizar_Consultar_Ejemplar
            // 
            this.button_Realizar_Consultar_Ejemplar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.button_Realizar_Consultar_Ejemplar.Location = new System.Drawing.Point(640, 382);
            this.button_Realizar_Consultar_Ejemplar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_Realizar_Consultar_Ejemplar.Name = "button_Realizar_Consultar_Ejemplar";
            this.button_Realizar_Consultar_Ejemplar.Size = new System.Drawing.Size(107, 42);
            this.button_Realizar_Consultar_Ejemplar.TabIndex = 26;
            this.button_Realizar_Consultar_Ejemplar.Text = "Consultar";
            this.button_Realizar_Consultar_Ejemplar.UseVisualStyleBackColor = true;
            this.button_Realizar_Consultar_Ejemplar.Visible = false;
            this.button_Realizar_Consultar_Ejemplar.Click += new System.EventHandler(this.EventHandler_Click_RealizarConsulta);
            // 
            // panel_Consultar_Ejemplar
            // 
            this.panel_Consultar_Ejemplar.Controls.Add(this.textBox_Documento_Consultar_Eje);
            this.panel_Consultar_Ejemplar.Controls.Add(this.textBox_Codigo_Consultar_Eje);
            this.panel_Consultar_Ejemplar.Controls.Add(this.label_Documento_Consultar_Eje);
            this.panel_Consultar_Ejemplar.Controls.Add(this.textBox_Responsable_Consultar_Eje);
            this.panel_Consultar_Ejemplar.Controls.Add(this.label_Informacion_Consultar_Eje);
            this.panel_Consultar_Ejemplar.Controls.Add(this.label_Codigo_Consultar_Eje);
            this.panel_Consultar_Ejemplar.Controls.Add(this.label_Responsable_Consultar_Eje);
            this.panel_Consultar_Ejemplar.Controls.Add(this.label_Consultar_Ejemplar);
            this.panel_Consultar_Ejemplar.Controls.Add(this.label_Localizacion_Consultar_Eje);
            this.panel_Consultar_Ejemplar.Controls.Add(this.textBox_Localizacion_Consultar_Eje);
            this.panel_Consultar_Ejemplar.Controls.Add(this.checkBox_Disponible_Consultar_Eje);
            this.panel_Consultar_Ejemplar.Location = new System.Drawing.Point(243, 119);
            this.panel_Consultar_Ejemplar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_Consultar_Ejemplar.Name = "panel_Consultar_Ejemplar";
            this.panel_Consultar_Ejemplar.Size = new System.Drawing.Size(355, 246);
            this.panel_Consultar_Ejemplar.TabIndex = 23;
            this.panel_Consultar_Ejemplar.Visible = false;
            // 
            // textBox_Documento_Consultar_Eje
            // 
            this.textBox_Documento_Consultar_Eje.Enabled = false;
            this.textBox_Documento_Consultar_Eje.Location = new System.Drawing.Point(127, 110);
            this.textBox_Documento_Consultar_Eje.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_Documento_Consultar_Eje.Name = "textBox_Documento_Consultar_Eje";
            this.textBox_Documento_Consultar_Eje.Size = new System.Drawing.Size(208, 20);
            this.textBox_Documento_Consultar_Eje.TabIndex = 23;
            this.textBox_Documento_Consultar_Eje.Visible = false;
            // 
            // textBox_Codigo_Consultar_Eje
            // 
            this.textBox_Codigo_Consultar_Eje.Location = new System.Drawing.Point(127, 36);
            this.textBox_Codigo_Consultar_Eje.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_Codigo_Consultar_Eje.Name = "textBox_Codigo_Consultar_Eje";
            this.textBox_Codigo_Consultar_Eje.Size = new System.Drawing.Size(208, 20);
            this.textBox_Codigo_Consultar_Eje.TabIndex = 22;
            // 
            // label_Documento_Consultar_Eje
            // 
            this.label_Documento_Consultar_Eje.AutoSize = true;
            this.label_Documento_Consultar_Eje.Location = new System.Drawing.Point(23, 113);
            this.label_Documento_Consultar_Eje.Name = "label_Documento_Consultar_Eje";
            this.label_Documento_Consultar_Eje.Size = new System.Drawing.Size(62, 13);
            this.label_Documento_Consultar_Eje.TabIndex = 21;
            this.label_Documento_Consultar_Eje.Text = "Documento";
            this.label_Documento_Consultar_Eje.Visible = false;
            // 
            // textBox_Responsable_Consultar_Eje
            // 
            this.textBox_Responsable_Consultar_Eje.Enabled = false;
            this.textBox_Responsable_Consultar_Eje.Location = new System.Drawing.Point(127, 180);
            this.textBox_Responsable_Consultar_Eje.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_Responsable_Consultar_Eje.Name = "textBox_Responsable_Consultar_Eje";
            this.textBox_Responsable_Consultar_Eje.Size = new System.Drawing.Size(208, 20);
            this.textBox_Responsable_Consultar_Eje.TabIndex = 20;
            this.textBox_Responsable_Consultar_Eje.Visible = false;
            // 
            // label_Informacion_Consultar_Eje
            // 
            this.label_Informacion_Consultar_Eje.AutoSize = true;
            this.label_Informacion_Consultar_Eje.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label_Informacion_Consultar_Eje.Location = new System.Drawing.Point(105, 75);
            this.label_Informacion_Consultar_Eje.Name = "label_Informacion_Consultar_Eje";
            this.label_Informacion_Consultar_Eje.Size = new System.Drawing.Size(140, 17);
            this.label_Informacion_Consultar_Eje.TabIndex = 19;
            this.label_Informacion_Consultar_Eje.Text = "Informacion Ejemplar";
            this.label_Informacion_Consultar_Eje.Visible = false;
            // 
            // label_Codigo_Consultar_Eje
            // 
            this.label_Codigo_Consultar_Eje.AutoSize = true;
            this.label_Codigo_Consultar_Eje.Location = new System.Drawing.Point(23, 39);
            this.label_Codigo_Consultar_Eje.Name = "label_Codigo_Consultar_Eje";
            this.label_Codigo_Consultar_Eje.Size = new System.Drawing.Size(40, 13);
            this.label_Codigo_Consultar_Eje.TabIndex = 17;
            this.label_Codigo_Consultar_Eje.Text = "Codigo";
            // 
            // label_Responsable_Consultar_Eje
            // 
            this.label_Responsable_Consultar_Eje.AutoSize = true;
            this.label_Responsable_Consultar_Eje.Location = new System.Drawing.Point(23, 183);
            this.label_Responsable_Consultar_Eje.Name = "label_Responsable_Consultar_Eje";
            this.label_Responsable_Consultar_Eje.Size = new System.Drawing.Size(69, 13);
            this.label_Responsable_Consultar_Eje.TabIndex = 16;
            this.label_Responsable_Consultar_Eje.Text = "Responsable";
            this.label_Responsable_Consultar_Eje.Visible = false;
            // 
            // label_Consultar_Ejemplar
            // 
            this.label_Consultar_Ejemplar.AutoSize = true;
            this.label_Consultar_Ejemplar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Consultar_Ejemplar.Location = new System.Drawing.Point(99, 5);
            this.label_Consultar_Ejemplar.Name = "label_Consultar_Ejemplar";
            this.label_Consultar_Ejemplar.Size = new System.Drawing.Size(151, 17);
            this.label_Consultar_Ejemplar.TabIndex = 15;
            this.label_Consultar_Ejemplar.Text = "Consultar un  Ejemplar";
            // 
            // label_Localizacion_Consultar_Eje
            // 
            this.label_Localizacion_Consultar_Eje.AutoSize = true;
            this.label_Localizacion_Consultar_Eje.Location = new System.Drawing.Point(23, 148);
            this.label_Localizacion_Consultar_Eje.Name = "label_Localizacion_Consultar_Eje";
            this.label_Localizacion_Consultar_Eje.Size = new System.Drawing.Size(66, 13);
            this.label_Localizacion_Consultar_Eje.TabIndex = 5;
            this.label_Localizacion_Consultar_Eje.Text = "Localizacion";
            this.label_Localizacion_Consultar_Eje.Visible = false;
            // 
            // textBox_Localizacion_Consultar_Eje
            // 
            this.textBox_Localizacion_Consultar_Eje.Enabled = false;
            this.textBox_Localizacion_Consultar_Eje.Location = new System.Drawing.Point(127, 145);
            this.textBox_Localizacion_Consultar_Eje.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_Localizacion_Consultar_Eje.Name = "textBox_Localizacion_Consultar_Eje";
            this.textBox_Localizacion_Consultar_Eje.Size = new System.Drawing.Size(208, 20);
            this.textBox_Localizacion_Consultar_Eje.TabIndex = 1;
            this.textBox_Localizacion_Consultar_Eje.Visible = false;
            // 
            // checkBox_Disponible_Consultar_Eje
            // 
            this.checkBox_Disponible_Consultar_Eje.AutoSize = true;
            this.checkBox_Disponible_Consultar_Eje.Checked = true;
            this.checkBox_Disponible_Consultar_Eje.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_Disponible_Consultar_Eje.Enabled = false;
            this.checkBox_Disponible_Consultar_Eje.Location = new System.Drawing.Point(155, 215);
            this.checkBox_Disponible_Consultar_Eje.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox_Disponible_Consultar_Eje.Name = "checkBox_Disponible_Consultar_Eje";
            this.checkBox_Disponible_Consultar_Eje.Size = new System.Drawing.Size(75, 17);
            this.checkBox_Disponible_Consultar_Eje.TabIndex = 0;
            this.checkBox_Disponible_Consultar_Eje.Text = "Disponible";
            this.checkBox_Disponible_Consultar_Eje.UseVisualStyleBackColor = true;
            this.checkBox_Disponible_Consultar_Eje.Visible = false;
            // 
            // button_Listar_Ejemplar
            // 
            this.button_Listar_Ejemplar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Listar_Ejemplar.Location = new System.Drawing.Point(455, 212);
            this.button_Listar_Ejemplar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_Listar_Ejemplar.Name = "button_Listar_Ejemplar";
            this.button_Listar_Ejemplar.Size = new System.Drawing.Size(123, 42);
            this.button_Listar_Ejemplar.TabIndex = 25;
            this.button_Listar_Ejemplar.Text = "Ejemplar";
            this.button_Listar_Ejemplar.UseVisualStyleBackColor = true;
            this.button_Listar_Ejemplar.Visible = false;
            this.button_Listar_Ejemplar.Click += new System.EventHandler(this.EventHandler_Click_BotonesListar);
            // 
            // button_Listar_Documento
            // 
            this.button_Listar_Documento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Listar_Documento.Location = new System.Drawing.Point(221, 212);
            this.button_Listar_Documento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_Listar_Documento.Name = "button_Listar_Documento";
            this.button_Listar_Documento.Size = new System.Drawing.Size(123, 42);
            this.button_Listar_Documento.TabIndex = 24;
            this.button_Listar_Documento.Text = "Documento";
            this.button_Listar_Documento.UseVisualStyleBackColor = true;
            this.button_Listar_Documento.Visible = false;
            this.button_Listar_Documento.Click += new System.EventHandler(this.EventHandler_Click_BotonesListar);
            // 
            // button_Consultar_Mas_Leido
            // 
            this.button_Consultar_Mas_Leido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Consultar_Mas_Leido.Location = new System.Drawing.Point(535, 213);
            this.button_Consultar_Mas_Leido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_Consultar_Mas_Leido.Name = "button_Consultar_Mas_Leido";
            this.button_Consultar_Mas_Leido.Size = new System.Drawing.Size(123, 42);
            this.button_Consultar_Mas_Leido.TabIndex = 23;
            this.button_Consultar_Mas_Leido.Text = "Mas Leido";
            this.button_Consultar_Mas_Leido.UseVisualStyleBackColor = true;
            this.button_Consultar_Mas_Leido.Visible = false;
            this.button_Consultar_Mas_Leido.Click += new System.EventHandler(this.EventHandler_Click_BotonesConsulta);
            // 
            // button_Consultar_Disponible
            // 
            this.button_Consultar_Disponible.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Consultar_Disponible.Location = new System.Drawing.Point(279, 213);
            this.button_Consultar_Disponible.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_Consultar_Disponible.Name = "button_Consultar_Disponible";
            this.button_Consultar_Disponible.Size = new System.Drawing.Size(123, 42);
            this.button_Consultar_Disponible.TabIndex = 22;
            this.button_Consultar_Disponible.Text = "Disponible";
            this.button_Consultar_Disponible.UseVisualStyleBackColor = true;
            this.button_Consultar_Disponible.Visible = false;
            this.button_Consultar_Disponible.Click += new System.EventHandler(this.EventHandler_Click_BotonesConsulta);
            // 
            // button_Consultar_Fecha
            // 
            this.button_Consultar_Fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Consultar_Fecha.Location = new System.Drawing.Point(407, 213);
            this.button_Consultar_Fecha.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_Consultar_Fecha.Name = "button_Consultar_Fecha";
            this.button_Consultar_Fecha.Size = new System.Drawing.Size(123, 42);
            this.button_Consultar_Fecha.TabIndex = 21;
            this.button_Consultar_Fecha.Text = "Fecha";
            this.button_Consultar_Fecha.UseVisualStyleBackColor = true;
            this.button_Consultar_Fecha.Visible = false;
            this.button_Consultar_Fecha.Click += new System.EventHandler(this.EventHandler_Click_BotonesConsulta);
            // 
            // button_Consultar_Ejemplar
            // 
            this.button_Consultar_Ejemplar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Consultar_Ejemplar.Location = new System.Drawing.Point(151, 213);
            this.button_Consultar_Ejemplar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_Consultar_Ejemplar.Name = "button_Consultar_Ejemplar";
            this.button_Consultar_Ejemplar.Size = new System.Drawing.Size(123, 42);
            this.button_Consultar_Ejemplar.TabIndex = 20;
            this.button_Consultar_Ejemplar.Text = "Ejemplar";
            this.button_Consultar_Ejemplar.UseVisualStyleBackColor = true;
            this.button_Consultar_Ejemplar.Visible = false;
            this.button_Consultar_Ejemplar.Click += new System.EventHandler(this.EventHandler_Click_BotonesConsulta);
            // 
            // button_Borrar_Baja_Eje
            // 
            this.button_Borrar_Baja_Eje.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.button_Borrar_Baja_Eje.Location = new System.Drawing.Point(640, 382);
            this.button_Borrar_Baja_Eje.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_Borrar_Baja_Eje.Name = "button_Borrar_Baja_Eje";
            this.button_Borrar_Baja_Eje.Size = new System.Drawing.Size(91, 42);
            this.button_Borrar_Baja_Eje.TabIndex = 19;
            this.button_Borrar_Baja_Eje.Text = "Borrar";
            this.button_Borrar_Baja_Eje.UseVisualStyleBackColor = true;
            this.button_Borrar_Baja_Eje.Visible = false;
            this.button_Borrar_Baja_Eje.Click += new System.EventHandler(this.button_Borrar_Baja_Eje_Click);
            // 
            // panel_Baja_Ejemplar
            // 
            this.panel_Baja_Ejemplar.Controls.Add(this.textBox_Codigo_Baja_Eje);
            this.panel_Baja_Ejemplar.Controls.Add(this.label_Codigo_Baja_Eje);
            this.panel_Baja_Ejemplar.Controls.Add(this.textBox_Responsable_Baja_Eje);
            this.panel_Baja_Ejemplar.Controls.Add(this.label_Info_Baja_Eje);
            this.panel_Baja_Ejemplar.Controls.Add(this.comboBox_Ejemplar_Baja_Eje);
            this.panel_Baja_Ejemplar.Controls.Add(this.label_Ejemplar_Baja_Eje);
            this.panel_Baja_Ejemplar.Controls.Add(this.label_Responsable_Baja_Eje);
            this.panel_Baja_Ejemplar.Controls.Add(this.label_Baja_Ejemplares);
            this.panel_Baja_Ejemplar.Controls.Add(this.comboBox_Documento_Baja_Eje);
            this.panel_Baja_Ejemplar.Controls.Add(this.label_Documento_Baja_Eje);
            this.panel_Baja_Ejemplar.Controls.Add(this.label_Localizacion_Baja_Eje);
            this.panel_Baja_Ejemplar.Controls.Add(this.textBox_Localizacion_Baja_Eje);
            this.panel_Baja_Ejemplar.Controls.Add(this.checkBox_Disponible_Baja_Eje);
            this.panel_Baja_Ejemplar.Location = new System.Drawing.Point(247, 119);
            this.panel_Baja_Ejemplar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_Baja_Ejemplar.Name = "panel_Baja_Ejemplar";
            this.panel_Baja_Ejemplar.Size = new System.Drawing.Size(355, 283);
            this.panel_Baja_Ejemplar.TabIndex = 18;
            this.panel_Baja_Ejemplar.Visible = false;
            // 
            // textBox_Codigo_Baja_Eje
            // 
            this.textBox_Codigo_Baja_Eje.Enabled = false;
            this.textBox_Codigo_Baja_Eje.Location = new System.Drawing.Point(127, 151);
            this.textBox_Codigo_Baja_Eje.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_Codigo_Baja_Eje.Name = "textBox_Codigo_Baja_Eje";
            this.textBox_Codigo_Baja_Eje.Size = new System.Drawing.Size(208, 20);
            this.textBox_Codigo_Baja_Eje.TabIndex = 22;
            // 
            // label_Codigo_Baja_Eje
            // 
            this.label_Codigo_Baja_Eje.AutoSize = true;
            this.label_Codigo_Baja_Eje.Location = new System.Drawing.Point(23, 154);
            this.label_Codigo_Baja_Eje.Name = "label_Codigo_Baja_Eje";
            this.label_Codigo_Baja_Eje.Size = new System.Drawing.Size(40, 13);
            this.label_Codigo_Baja_Eje.TabIndex = 21;
            this.label_Codigo_Baja_Eje.Text = "Codigo";
            // 
            // textBox_Responsable_Baja_Eje
            // 
            this.textBox_Responsable_Baja_Eje.Enabled = false;
            this.textBox_Responsable_Baja_Eje.Location = new System.Drawing.Point(127, 222);
            this.textBox_Responsable_Baja_Eje.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_Responsable_Baja_Eje.Name = "textBox_Responsable_Baja_Eje";
            this.textBox_Responsable_Baja_Eje.Size = new System.Drawing.Size(208, 20);
            this.textBox_Responsable_Baja_Eje.TabIndex = 20;
            // 
            // label_Info_Baja_Eje
            // 
            this.label_Info_Baja_Eje.AutoSize = true;
            this.label_Info_Baja_Eje.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label_Info_Baja_Eje.Location = new System.Drawing.Point(105, 116);
            this.label_Info_Baja_Eje.Name = "label_Info_Baja_Eje";
            this.label_Info_Baja_Eje.Size = new System.Drawing.Size(140, 17);
            this.label_Info_Baja_Eje.TabIndex = 19;
            this.label_Info_Baja_Eje.Text = "Informacion Ejemplar";
            // 
            // comboBox_Ejemplar_Baja_Eje
            // 
            this.comboBox_Ejemplar_Baja_Eje.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Ejemplar_Baja_Eje.Enabled = false;
            this.comboBox_Ejemplar_Baja_Eje.FormattingEnabled = true;
            this.comboBox_Ejemplar_Baja_Eje.Location = new System.Drawing.Point(127, 78);
            this.comboBox_Ejemplar_Baja_Eje.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox_Ejemplar_Baja_Eje.Name = "comboBox_Ejemplar_Baja_Eje";
            this.comboBox_Ejemplar_Baja_Eje.Size = new System.Drawing.Size(208, 21);
            this.comboBox_Ejemplar_Baja_Eje.TabIndex = 18;
            this.comboBox_Ejemplar_Baja_Eje.SelectedIndexChanged += new System.EventHandler(this.comboBox_Ejemplar_Baja_Eje_SelectedIndexChanged);
            // 
            // label_Ejemplar_Baja_Eje
            // 
            this.label_Ejemplar_Baja_Eje.AutoSize = true;
            this.label_Ejemplar_Baja_Eje.Location = new System.Drawing.Point(23, 81);
            this.label_Ejemplar_Baja_Eje.Name = "label_Ejemplar_Baja_Eje";
            this.label_Ejemplar_Baja_Eje.Size = new System.Drawing.Size(47, 13);
            this.label_Ejemplar_Baja_Eje.TabIndex = 17;
            this.label_Ejemplar_Baja_Eje.Text = "Ejemplar";
            // 
            // label_Responsable_Baja_Eje
            // 
            this.label_Responsable_Baja_Eje.AutoSize = true;
            this.label_Responsable_Baja_Eje.Location = new System.Drawing.Point(23, 224);
            this.label_Responsable_Baja_Eje.Name = "label_Responsable_Baja_Eje";
            this.label_Responsable_Baja_Eje.Size = new System.Drawing.Size(69, 13);
            this.label_Responsable_Baja_Eje.TabIndex = 16;
            this.label_Responsable_Baja_Eje.Text = "Responsable";
            // 
            // label_Baja_Ejemplares
            // 
            this.label_Baja_Ejemplares.AutoSize = true;
            this.label_Baja_Ejemplares.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Baja_Ejemplares.Location = new System.Drawing.Point(120, 7);
            this.label_Baja_Ejemplares.Name = "label_Baja_Ejemplares";
            this.label_Baja_Ejemplares.Size = new System.Drawing.Size(115, 17);
            this.label_Baja_Ejemplares.TabIndex = 15;
            this.label_Baja_Ejemplares.Text = "Baja de Ejemplar";
            // 
            // comboBox_Documento_Baja_Eje
            // 
            this.comboBox_Documento_Baja_Eje.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Documento_Baja_Eje.FormattingEnabled = true;
            this.comboBox_Documento_Baja_Eje.Location = new System.Drawing.Point(127, 42);
            this.comboBox_Documento_Baja_Eje.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox_Documento_Baja_Eje.Name = "comboBox_Documento_Baja_Eje";
            this.comboBox_Documento_Baja_Eje.Size = new System.Drawing.Size(208, 21);
            this.comboBox_Documento_Baja_Eje.TabIndex = 13;
            this.comboBox_Documento_Baja_Eje.SelectedIndexChanged += new System.EventHandler(this.comboBox_Documento_Baja_Eje_SelectedIndexChanged);
            // 
            // label_Documento_Baja_Eje
            // 
            this.label_Documento_Baja_Eje.AutoSize = true;
            this.label_Documento_Baja_Eje.Location = new System.Drawing.Point(23, 46);
            this.label_Documento_Baja_Eje.Name = "label_Documento_Baja_Eje";
            this.label_Documento_Baja_Eje.Size = new System.Drawing.Size(62, 13);
            this.label_Documento_Baja_Eje.TabIndex = 6;
            this.label_Documento_Baja_Eje.Text = "Documento";
            // 
            // label_Localizacion_Baja_Eje
            // 
            this.label_Localizacion_Baja_Eje.AutoSize = true;
            this.label_Localizacion_Baja_Eje.Location = new System.Drawing.Point(23, 190);
            this.label_Localizacion_Baja_Eje.Name = "label_Localizacion_Baja_Eje";
            this.label_Localizacion_Baja_Eje.Size = new System.Drawing.Size(66, 13);
            this.label_Localizacion_Baja_Eje.TabIndex = 5;
            this.label_Localizacion_Baja_Eje.Text = "Localizacion";
            // 
            // textBox_Localizacion_Baja_Eje
            // 
            this.textBox_Localizacion_Baja_Eje.Enabled = false;
            this.textBox_Localizacion_Baja_Eje.Location = new System.Drawing.Point(127, 186);
            this.textBox_Localizacion_Baja_Eje.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_Localizacion_Baja_Eje.Name = "textBox_Localizacion_Baja_Eje";
            this.textBox_Localizacion_Baja_Eje.Size = new System.Drawing.Size(208, 20);
            this.textBox_Localizacion_Baja_Eje.TabIndex = 1;
            // 
            // checkBox_Disponible_Baja_Eje
            // 
            this.checkBox_Disponible_Baja_Eje.AutoSize = true;
            this.checkBox_Disponible_Baja_Eje.Checked = true;
            this.checkBox_Disponible_Baja_Eje.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_Disponible_Baja_Eje.Enabled = false;
            this.checkBox_Disponible_Baja_Eje.Location = new System.Drawing.Point(155, 256);
            this.checkBox_Disponible_Baja_Eje.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox_Disponible_Baja_Eje.Name = "checkBox_Disponible_Baja_Eje";
            this.checkBox_Disponible_Baja_Eje.Size = new System.Drawing.Size(75, 17);
            this.checkBox_Disponible_Baja_Eje.TabIndex = 0;
            this.checkBox_Disponible_Baja_Eje.Text = "Disponible";
            this.checkBox_Disponible_Baja_Eje.UseVisualStyleBackColor = true;
            // 
            // panel_Alta_Ejemplar
            // 
            this.panel_Alta_Ejemplar.Controls.Add(this.label_Alta_Ejemplar);
            this.panel_Alta_Ejemplar.Controls.Add(this.comboBox_Documento_Alta_Eje);
            this.panel_Alta_Ejemplar.Controls.Add(this.label_Documento_Alta_Eje);
            this.panel_Alta_Ejemplar.Controls.Add(this.label_Localizacion_Alta_Eje);
            this.panel_Alta_Ejemplar.Controls.Add(this.textBox_Localizacion_Alta_Eje);
            this.panel_Alta_Ejemplar.Controls.Add(this.checkBox_Disponible_Alta_Eje);
            this.panel_Alta_Ejemplar.Location = new System.Drawing.Point(243, 164);
            this.panel_Alta_Ejemplar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_Alta_Ejemplar.Name = "panel_Alta_Ejemplar";
            this.panel_Alta_Ejemplar.Size = new System.Drawing.Size(355, 156);
            this.panel_Alta_Ejemplar.TabIndex = 17;
            this.panel_Alta_Ejemplar.Visible = false;
            // 
            // label_Alta_Ejemplar
            // 
            this.label_Alta_Ejemplar.AutoSize = true;
            this.label_Alta_Ejemplar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Alta_Ejemplar.Location = new System.Drawing.Point(108, 10);
            this.label_Alta_Ejemplar.Name = "label_Alta_Ejemplar";
            this.label_Alta_Ejemplar.Size = new System.Drawing.Size(111, 17);
            this.label_Alta_Ejemplar.TabIndex = 15;
            this.label_Alta_Ejemplar.Text = "Alta de Ejemplar";
            // 
            // comboBox_Documento_Alta_Eje
            // 
            this.comboBox_Documento_Alta_Eje.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Documento_Alta_Eje.FormattingEnabled = true;
            this.comboBox_Documento_Alta_Eje.Location = new System.Drawing.Point(127, 73);
            this.comboBox_Documento_Alta_Eje.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox_Documento_Alta_Eje.Name = "comboBox_Documento_Alta_Eje";
            this.comboBox_Documento_Alta_Eje.Size = new System.Drawing.Size(208, 21);
            this.comboBox_Documento_Alta_Eje.TabIndex = 13;
            // 
            // label_Documento_Alta_Eje
            // 
            this.label_Documento_Alta_Eje.AutoSize = true;
            this.label_Documento_Alta_Eje.Location = new System.Drawing.Point(23, 73);
            this.label_Documento_Alta_Eje.Name = "label_Documento_Alta_Eje";
            this.label_Documento_Alta_Eje.Size = new System.Drawing.Size(62, 13);
            this.label_Documento_Alta_Eje.TabIndex = 6;
            this.label_Documento_Alta_Eje.Text = "Documento";
            // 
            // label_Localizacion_Alta_Eje
            // 
            this.label_Localizacion_Alta_Eje.AutoSize = true;
            this.label_Localizacion_Alta_Eje.Location = new System.Drawing.Point(23, 46);
            this.label_Localizacion_Alta_Eje.Name = "label_Localizacion_Alta_Eje";
            this.label_Localizacion_Alta_Eje.Size = new System.Drawing.Size(66, 13);
            this.label_Localizacion_Alta_Eje.TabIndex = 5;
            this.label_Localizacion_Alta_Eje.Text = "Localizacion";
            // 
            // textBox_Localizacion_Alta_Eje
            // 
            this.textBox_Localizacion_Alta_Eje.Location = new System.Drawing.Point(127, 42);
            this.textBox_Localizacion_Alta_Eje.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_Localizacion_Alta_Eje.Name = "textBox_Localizacion_Alta_Eje";
            this.textBox_Localizacion_Alta_Eje.Size = new System.Drawing.Size(208, 20);
            this.textBox_Localizacion_Alta_Eje.TabIndex = 1;
            // 
            // checkBox_Disponible_Alta_Eje
            // 
            this.checkBox_Disponible_Alta_Eje.AutoSize = true;
            this.checkBox_Disponible_Alta_Eje.Checked = true;
            this.checkBox_Disponible_Alta_Eje.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_Disponible_Alta_Eje.Location = new System.Drawing.Point(140, 106);
            this.checkBox_Disponible_Alta_Eje.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox_Disponible_Alta_Eje.Name = "checkBox_Disponible_Alta_Eje";
            this.checkBox_Disponible_Alta_Eje.Size = new System.Drawing.Size(75, 17);
            this.checkBox_Disponible_Alta_Eje.TabIndex = 0;
            this.checkBox_Disponible_Alta_Eje.Text = "Disponible";
            this.checkBox_Disponible_Alta_Eje.UseVisualStyleBackColor = true;
            // 
            // button_Validar_Alta_Ejemplar
            // 
            this.button_Validar_Alta_Ejemplar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.button_Validar_Alta_Ejemplar.Location = new System.Drawing.Point(640, 382);
            this.button_Validar_Alta_Ejemplar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_Validar_Alta_Ejemplar.Name = "button_Validar_Alta_Ejemplar";
            this.button_Validar_Alta_Ejemplar.Size = new System.Drawing.Size(91, 42);
            this.button_Validar_Alta_Ejemplar.TabIndex = 18;
            this.button_Validar_Alta_Ejemplar.Text = "Validar";
            this.button_Validar_Alta_Ejemplar.UseVisualStyleBackColor = true;
            this.button_Validar_Alta_Ejemplar.Visible = false;
            this.button_Validar_Alta_Ejemplar.Click += new System.EventHandler(this.EventHandler_Click_ValidarAlta);
            // 
            // button_Validar_Alta_Documento
            // 
            this.button_Validar_Alta_Documento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.button_Validar_Alta_Documento.Location = new System.Drawing.Point(640, 382);
            this.button_Validar_Alta_Documento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_Validar_Alta_Documento.Name = "button_Validar_Alta_Documento";
            this.button_Validar_Alta_Documento.Size = new System.Drawing.Size(91, 42);
            this.button_Validar_Alta_Documento.TabIndex = 17;
            this.button_Validar_Alta_Documento.Text = "Validar";
            this.button_Validar_Alta_Documento.UseVisualStyleBackColor = true;
            this.button_Validar_Alta_Documento.Visible = false;
            this.button_Validar_Alta_Documento.Click += new System.EventHandler(this.EventHandler_Click_ValidarAlta);
            // 
            // panel_Alta_Documento
            // 
            this.panel_Alta_Documento.Controls.Add(this.label_Alta_Doc);
            this.panel_Alta_Documento.Controls.Add(this.textBox_Duracion_Alta_Doc);
            this.panel_Alta_Documento.Controls.Add(this.comboBox_Formato_Alta_Doc);
            this.panel_Alta_Documento.Controls.Add(this.label_Duracion_Alta_Doc);
            this.panel_Alta_Documento.Controls.Add(this.label_Formato_Alta_Doc);
            this.panel_Alta_Documento.Controls.Add(this.label_Año_Edicion_Alta_Doc);
            this.panel_Alta_Documento.Controls.Add(this.textBox_Año_Edicion_Alta_Doc);
            this.panel_Alta_Documento.Controls.Add(this.label_Editorial_Alta_Doc);
            this.panel_Alta_Documento.Controls.Add(this.label_ISBN_Alta_Doc);
            this.panel_Alta_Documento.Controls.Add(this.label_Autor_Alta_Doc);
            this.panel_Alta_Documento.Controls.Add(this.label_Titulo_Alta_Doc);
            this.panel_Alta_Documento.Controls.Add(this.textBox_Editorial_Alta_Doc);
            this.panel_Alta_Documento.Controls.Add(this.textBox_ISBN_Alta_Doc);
            this.panel_Alta_Documento.Controls.Add(this.textBox_Autor_Alta_Doc);
            this.panel_Alta_Documento.Controls.Add(this.textBox_Titulo_Alta_Doc);
            this.panel_Alta_Documento.Controls.Add(this.checkBox_Audiolibro_Alta_Doc);
            this.panel_Alta_Documento.Location = new System.Drawing.Point(247, 74);
            this.panel_Alta_Documento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_Alta_Documento.Name = "panel_Alta_Documento";
            this.panel_Alta_Documento.Size = new System.Drawing.Size(355, 357);
            this.panel_Alta_Documento.TabIndex = 16;
            this.panel_Alta_Documento.Visible = false;
            // 
            // label_Alta_Doc
            // 
            this.label_Alta_Doc.AutoSize = true;
            this.label_Alta_Doc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Alta_Doc.Location = new System.Drawing.Point(108, 10);
            this.label_Alta_Doc.Name = "label_Alta_Doc";
            this.label_Alta_Doc.Size = new System.Drawing.Size(128, 17);
            this.label_Alta_Doc.TabIndex = 15;
            this.label_Alta_Doc.Text = "Alta de Documento";
            // 
            // textBox_Duracion_Alta_Doc
            // 
            this.textBox_Duracion_Alta_Doc.Location = new System.Drawing.Point(127, 268);
            this.textBox_Duracion_Alta_Doc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_Duracion_Alta_Doc.Name = "textBox_Duracion_Alta_Doc";
            this.textBox_Duracion_Alta_Doc.Size = new System.Drawing.Size(121, 20);
            this.textBox_Duracion_Alta_Doc.TabIndex = 14;
            this.textBox_Duracion_Alta_Doc.Visible = false;
            this.textBox_Duracion_Alta_Doc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress_SoloInt);
            // 
            // comboBox_Formato_Alta_Doc
            // 
            this.comboBox_Formato_Alta_Doc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Formato_Alta_Doc.FormattingEnabled = true;
            this.comboBox_Formato_Alta_Doc.Location = new System.Drawing.Point(127, 230);
            this.comboBox_Formato_Alta_Doc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox_Formato_Alta_Doc.Name = "comboBox_Formato_Alta_Doc";
            this.comboBox_Formato_Alta_Doc.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Formato_Alta_Doc.TabIndex = 13;
            this.comboBox_Formato_Alta_Doc.Visible = false;
            // 
            // label_Duracion_Alta_Doc
            // 
            this.label_Duracion_Alta_Doc.AutoSize = true;
            this.label_Duracion_Alta_Doc.Location = new System.Drawing.Point(23, 268);
            this.label_Duracion_Alta_Doc.Name = "label_Duracion_Alta_Doc";
            this.label_Duracion_Alta_Doc.Size = new System.Drawing.Size(50, 13);
            this.label_Duracion_Alta_Doc.TabIndex = 12;
            this.label_Duracion_Alta_Doc.Text = "Duración";
            this.label_Duracion_Alta_Doc.Visible = false;
            // 
            // label_Formato_Alta_Doc
            // 
            this.label_Formato_Alta_Doc.AutoSize = true;
            this.label_Formato_Alta_Doc.Location = new System.Drawing.Point(23, 233);
            this.label_Formato_Alta_Doc.Name = "label_Formato_Alta_Doc";
            this.label_Formato_Alta_Doc.Size = new System.Drawing.Size(45, 13);
            this.label_Formato_Alta_Doc.TabIndex = 11;
            this.label_Formato_Alta_Doc.Text = "Formato";
            this.label_Formato_Alta_Doc.Visible = false;
            // 
            // label_Año_Edicion_Alta_Doc
            // 
            this.label_Año_Edicion_Alta_Doc.AutoSize = true;
            this.label_Año_Edicion_Alta_Doc.Location = new System.Drawing.Point(23, 159);
            this.label_Año_Edicion_Alta_Doc.Name = "label_Año_Edicion_Alta_Doc";
            this.label_Año_Edicion_Alta_Doc.Size = new System.Drawing.Size(64, 13);
            this.label_Año_Edicion_Alta_Doc.TabIndex = 10;
            this.label_Año_Edicion_Alta_Doc.Text = "Año Edición";
            // 
            // textBox_Año_Edicion_Alta_Doc
            // 
            this.textBox_Año_Edicion_Alta_Doc.Location = new System.Drawing.Point(127, 154);
            this.textBox_Año_Edicion_Alta_Doc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_Año_Edicion_Alta_Doc.MaxLength = 4;
            this.textBox_Año_Edicion_Alta_Doc.Name = "textBox_Año_Edicion_Alta_Doc";
            this.textBox_Año_Edicion_Alta_Doc.Size = new System.Drawing.Size(121, 20);
            this.textBox_Año_Edicion_Alta_Doc.TabIndex = 9;
            this.textBox_Año_Edicion_Alta_Doc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress_SoloInt);
            // 
            // label_Editorial_Alta_Doc
            // 
            this.label_Editorial_Alta_Doc.AutoSize = true;
            this.label_Editorial_Alta_Doc.Location = new System.Drawing.Point(23, 132);
            this.label_Editorial_Alta_Doc.Name = "label_Editorial_Alta_Doc";
            this.label_Editorial_Alta_Doc.Size = new System.Drawing.Size(44, 13);
            this.label_Editorial_Alta_Doc.TabIndex = 8;
            this.label_Editorial_Alta_Doc.Text = "Editorial";
            // 
            // label_ISBN_Alta_Doc
            // 
            this.label_ISBN_Alta_Doc.AutoSize = true;
            this.label_ISBN_Alta_Doc.Location = new System.Drawing.Point(23, 101);
            this.label_ISBN_Alta_Doc.Name = "label_ISBN_Alta_Doc";
            this.label_ISBN_Alta_Doc.Size = new System.Drawing.Size(32, 13);
            this.label_ISBN_Alta_Doc.TabIndex = 7;
            this.label_ISBN_Alta_Doc.Text = "ISBN";
            // 
            // label_Autor_Alta_Doc
            // 
            this.label_Autor_Alta_Doc.AutoSize = true;
            this.label_Autor_Alta_Doc.Location = new System.Drawing.Point(23, 73);
            this.label_Autor_Alta_Doc.Name = "label_Autor_Alta_Doc";
            this.label_Autor_Alta_Doc.Size = new System.Drawing.Size(32, 13);
            this.label_Autor_Alta_Doc.TabIndex = 6;
            this.label_Autor_Alta_Doc.Text = "Autor";
            // 
            // label_Titulo_Alta_Doc
            // 
            this.label_Titulo_Alta_Doc.AutoSize = true;
            this.label_Titulo_Alta_Doc.Location = new System.Drawing.Point(23, 46);
            this.label_Titulo_Alta_Doc.Name = "label_Titulo_Alta_Doc";
            this.label_Titulo_Alta_Doc.Size = new System.Drawing.Size(33, 13);
            this.label_Titulo_Alta_Doc.TabIndex = 5;
            this.label_Titulo_Alta_Doc.Text = "Titulo";
            // 
            // textBox_Editorial_Alta_Doc
            // 
            this.textBox_Editorial_Alta_Doc.Location = new System.Drawing.Point(127, 126);
            this.textBox_Editorial_Alta_Doc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_Editorial_Alta_Doc.Name = "textBox_Editorial_Alta_Doc";
            this.textBox_Editorial_Alta_Doc.Size = new System.Drawing.Size(121, 20);
            this.textBox_Editorial_Alta_Doc.TabIndex = 4;
            // 
            // textBox_ISBN_Alta_Doc
            // 
            this.textBox_ISBN_Alta_Doc.Location = new System.Drawing.Point(127, 98);
            this.textBox_ISBN_Alta_Doc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_ISBN_Alta_Doc.Name = "textBox_ISBN_Alta_Doc";
            this.textBox_ISBN_Alta_Doc.Size = new System.Drawing.Size(121, 20);
            this.textBox_ISBN_Alta_Doc.TabIndex = 3;
            // 
            // textBox_Autor_Alta_Doc
            // 
            this.textBox_Autor_Alta_Doc.Location = new System.Drawing.Point(127, 70);
            this.textBox_Autor_Alta_Doc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_Autor_Alta_Doc.Name = "textBox_Autor_Alta_Doc";
            this.textBox_Autor_Alta_Doc.Size = new System.Drawing.Size(121, 20);
            this.textBox_Autor_Alta_Doc.TabIndex = 2;
            // 
            // textBox_Titulo_Alta_Doc
            // 
            this.textBox_Titulo_Alta_Doc.Location = new System.Drawing.Point(127, 42);
            this.textBox_Titulo_Alta_Doc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_Titulo_Alta_Doc.Name = "textBox_Titulo_Alta_Doc";
            this.textBox_Titulo_Alta_Doc.Size = new System.Drawing.Size(121, 20);
            this.textBox_Titulo_Alta_Doc.TabIndex = 1;
            // 
            // checkBox_Audiolibro_Alta_Doc
            // 
            this.checkBox_Audiolibro_Alta_Doc.AutoSize = true;
            this.checkBox_Audiolibro_Alta_Doc.Location = new System.Drawing.Point(140, 191);
            this.checkBox_Audiolibro_Alta_Doc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox_Audiolibro_Alta_Doc.Name = "checkBox_Audiolibro_Alta_Doc";
            this.checkBox_Audiolibro_Alta_Doc.Size = new System.Drawing.Size(76, 17);
            this.checkBox_Audiolibro_Alta_Doc.TabIndex = 0;
            this.checkBox_Audiolibro_Alta_Doc.Text = "AudioLibro";
            this.checkBox_Audiolibro_Alta_Doc.UseVisualStyleBackColor = true;
            this.checkBox_Audiolibro_Alta_Doc.CheckedChanged += new System.EventHandler(this.checkBox_Audiolibro_Alta_Doc_CheckedChanged);
            // 
            // button_Volver
            // 
            this.button_Volver.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Volver.Location = new System.Drawing.Point(20, 382);
            this.button_Volver.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_Volver.Name = "button_Volver";
            this.button_Volver.Size = new System.Drawing.Size(91, 42);
            this.button_Volver.TabIndex = 15;
            this.button_Volver.Text = "Volver";
            this.button_Volver.UseVisualStyleBackColor = true;
            this.button_Volver.Visible = false;
            this.button_Volver.Click += new System.EventHandler(this.button_Volver_Click);
            // 
            // button_Alta_Ejemplar
            // 
            this.button_Alta_Ejemplar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Alta_Ejemplar.Location = new System.Drawing.Point(476, 212);
            this.button_Alta_Ejemplar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_Alta_Ejemplar.Name = "button_Alta_Ejemplar";
            this.button_Alta_Ejemplar.Size = new System.Drawing.Size(123, 42);
            this.button_Alta_Ejemplar.TabIndex = 12;
            this.button_Alta_Ejemplar.Text = "Ejemplar";
            this.button_Alta_Ejemplar.UseVisualStyleBackColor = true;
            this.button_Alta_Ejemplar.Visible = false;
            this.button_Alta_Ejemplar.Click += new System.EventHandler(this.EventHandler_Click_BotonesAlta);
            // 
            // button_Alta_Documento
            // 
            this.button_Alta_Documento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Alta_Documento.Location = new System.Drawing.Point(243, 212);
            this.button_Alta_Documento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_Alta_Documento.Name = "button_Alta_Documento";
            this.button_Alta_Documento.Size = new System.Drawing.Size(123, 42);
            this.button_Alta_Documento.TabIndex = 11;
            this.button_Alta_Documento.Text = "Documento";
            this.button_Alta_Documento.UseVisualStyleBackColor = true;
            this.button_Alta_Documento.Visible = false;
            this.button_Alta_Documento.Click += new System.EventHandler(this.EventHandler_Click_BotonesAlta);
            // 
            // button_Listar
            // 
            this.button_Listar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Listar.Location = new System.Drawing.Point(629, 281);
            this.button_Listar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_Listar.Name = "button_Listar";
            this.button_Listar.Size = new System.Drawing.Size(91, 42);
            this.button_Listar.TabIndex = 10;
            this.button_Listar.Text = "Listar";
            this.button_Listar.UseVisualStyleBackColor = true;
            this.button_Listar.Click += new System.EventHandler(this.EventHandler_Click_BotonesInicio);
            // 
            // button_Consultas
            // 
            this.button_Consultas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Consultas.Location = new System.Drawing.Point(619, 146);
            this.button_Consultas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_Consultas.Name = "button_Consultas";
            this.button_Consultas.Size = new System.Drawing.Size(112, 42);
            this.button_Consultas.TabIndex = 9;
            this.button_Consultas.Text = "Consultas";
            this.button_Consultas.UseVisualStyleBackColor = true;
            this.button_Consultas.Click += new System.EventHandler(this.EventHandler_Click_BotonesInicio);
            // 
            // button_Bajas
            // 
            this.button_Bajas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Bajas.Location = new System.Drawing.Point(83, 281);
            this.button_Bajas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_Bajas.Name = "button_Bajas";
            this.button_Bajas.Size = new System.Drawing.Size(91, 42);
            this.button_Bajas.TabIndex = 8;
            this.button_Bajas.Text = "Bajas";
            this.button_Bajas.UseVisualStyleBackColor = true;
            this.button_Bajas.Click += new System.EventHandler(this.EventHandler_Click_BotonesInicio);
            // 
            // button_Altas
            // 
            this.button_Altas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Altas.Location = new System.Drawing.Point(83, 146);
            this.button_Altas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_Altas.Name = "button_Altas";
            this.button_Altas.Size = new System.Drawing.Size(91, 42);
            this.button_Altas.TabIndex = 7;
            this.button_Altas.Text = "Altas";
            this.button_Altas.UseVisualStyleBackColor = true;
            this.button_Altas.Click += new System.EventHandler(this.EventHandler_Click_BotonesInicio);
            // 
            // label_Main_Adquisiciones
            // 
            this.label_Main_Adquisiciones.AutoSize = true;
            this.label_Main_Adquisiciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Main_Adquisiciones.Location = new System.Drawing.Point(283, 22);
            this.label_Main_Adquisiciones.Name = "label_Main_Adquisiciones";
            this.label_Main_Adquisiciones.Size = new System.Drawing.Size(282, 26);
            this.label_Main_Adquisiciones.TabIndex = 6;
            this.label_Main_Adquisiciones.Text = "Gestion de Adquisiciones";
            // 
            // panel4
            // 
            this.panel4.AutoSize = true;
            this.panel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel4.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel4.Controls.Add(this.btLogOut);
            this.panel4.Controls.Add(this.lbNombre);
            this.panel4.Controls.Add(this.pictureBox2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 2);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1048, 86);
            this.panel4.TabIndex = 3;
            // 
            // btLogOut
            // 
            this.btLogOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLogOut.Image = global::Presentacion.Properties.Resources.logOut3__2_;
            this.btLogOut.Location = new System.Drawing.Point(1239, 26);
            this.btLogOut.Margin = new System.Windows.Forms.Padding(4);
            this.btLogOut.Name = "btLogOut";
            this.btLogOut.Size = new System.Drawing.Size(57, 47);
            this.btLogOut.TabIndex = 2;
            this.btLogOut.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btLogOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btLogOut.UseVisualStyleBackColor = true;
            this.btLogOut.Click += new System.EventHandler(this.btLogOut_Click);
            // 
            // lbNombre
            // 
            this.lbNombre.Location = new System.Drawing.Point(34, 58);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(66, 16);
            this.lbNombre.TabIndex = 1;
            this.lbNombre.Text = "tuNombre";
            this.lbNombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(37, 9);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(55, 47);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // Column_Codigo_Listar_Ejemplar
            // 
            this.Column_Codigo_Listar_Ejemplar.DataPropertyName = "Codigo";
            this.Column_Codigo_Listar_Ejemplar.HeaderText = "Codigo";
            this.Column_Codigo_Listar_Ejemplar.MinimumWidth = 6;
            this.Column_Codigo_Listar_Ejemplar.Name = "Column_Codigo_Listar_Ejemplar";
            this.Column_Codigo_Listar_Ejemplar.ReadOnly = true;
            this.Column_Codigo_Listar_Ejemplar.ToolTipText = "Codigo del Ejemplar";
            this.Column_Codigo_Listar_Ejemplar.Width = 125;
            // 
            // Column_Documento_Listar_Ejemplar
            // 
            this.Column_Documento_Listar_Ejemplar.DataPropertyName = "Documento";
            this.Column_Documento_Listar_Ejemplar.HeaderText = "Documento";
            this.Column_Documento_Listar_Ejemplar.MinimumWidth = 6;
            this.Column_Documento_Listar_Ejemplar.Name = "Column_Documento_Listar_Ejemplar";
            this.Column_Documento_Listar_Ejemplar.ReadOnly = true;
            this.Column_Documento_Listar_Ejemplar.ToolTipText = "Documento del Ejemplar";
            this.Column_Documento_Listar_Ejemplar.Width = 125;
            // 
            // Column_Responsable_Listar_Ejemplar
            // 
            this.Column_Responsable_Listar_Ejemplar.DataPropertyName = "Responsable";
            this.Column_Responsable_Listar_Ejemplar.HeaderText = "Responsable";
            this.Column_Responsable_Listar_Ejemplar.MinimumWidth = 6;
            this.Column_Responsable_Listar_Ejemplar.Name = "Column_Responsable_Listar_Ejemplar";
            this.Column_Responsable_Listar_Ejemplar.ReadOnly = true;
            this.Column_Responsable_Listar_Ejemplar.ToolTipText = "Responsable del Ejemplar";
            this.Column_Responsable_Listar_Ejemplar.Width = 125;
            // 
            // Column_Activo_Listar_Ejemplar
            // 
            this.Column_Activo_Listar_Ejemplar.DataPropertyName = "Activo";
            this.Column_Activo_Listar_Ejemplar.HeaderText = "Activo";
            this.Column_Activo_Listar_Ejemplar.MinimumWidth = 6;
            this.Column_Activo_Listar_Ejemplar.Name = "Column_Activo_Listar_Ejemplar";
            this.Column_Activo_Listar_Ejemplar.ReadOnly = true;
            this.Column_Activo_Listar_Ejemplar.ToolTipText = "Ejemplar Activo";
            this.Column_Activo_Listar_Ejemplar.Width = 125;
            // 
            // Column_Disponible_Listar_Ejemplar
            // 
            this.Column_Disponible_Listar_Ejemplar.DataPropertyName = "Disponible";
            this.Column_Disponible_Listar_Ejemplar.HeaderText = "Disponible";
            this.Column_Disponible_Listar_Ejemplar.MinimumWidth = 6;
            this.Column_Disponible_Listar_Ejemplar.Name = "Column_Disponible_Listar_Ejemplar";
            this.Column_Disponible_Listar_Ejemplar.ReadOnly = true;
            this.Column_Disponible_Listar_Ejemplar.ToolTipText = "Ejemplar Disponible";
            this.Column_Disponible_Listar_Ejemplar.Width = 125;
            // 
            // ColumnLocalizacion_Listar_Ejemplar
            // 
            this.ColumnLocalizacion_Listar_Ejemplar.DataPropertyName = "Localizacion";
            this.ColumnLocalizacion_Listar_Ejemplar.HeaderText = "Localizacion";
            this.ColumnLocalizacion_Listar_Ejemplar.MinimumWidth = 6;
            this.ColumnLocalizacion_Listar_Ejemplar.Name = "ColumnLocalizacion_Listar_Ejemplar";
            this.ColumnLocalizacion_Listar_Ejemplar.ReadOnly = true;
            this.ColumnLocalizacion_Listar_Ejemplar.ToolTipText = "Localizacion del Ejemplar";
            this.ColumnLocalizacion_Listar_Ejemplar.Width = 200;
            // 
            // FormPersonal
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1054, 507);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormPersonal";
            this.Text = "Gestor de biblioteca";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.Tab.ResumeLayout(false);
            this.Usuarios.ResumeLayout(false);
            this.Usuarios.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.Sala.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.gbPrestamos.ResumeLayout(false);
            this.gbPrestamos.PerformLayout();
            this.Adquisiciones.ResumeLayout(false);
            this.Adquisiciones.PerformLayout();
            this.panel_Listar_Ejemplar.ResumeLayout(false);
            this.panel_Listar_Ejemplar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Listar_Ejemplar)).EndInit();
            this.panel_Listar_Documento.ResumeLayout(false);
            this.panel_Listar_Documento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Listar_Documento)).EndInit();
            this.panel_Consultar_MasLeido.ResumeLayout(false);
            this.panel_Consultar_MasLeido.PerformLayout();
            this.panel_Consultar_Fecha.ResumeLayout(false);
            this.panel_Consultar_Fecha.PerformLayout();
            this.panel_Consultar_Disponible.ResumeLayout(false);
            this.panel_Consultar_Disponible.PerformLayout();
            this.panel_Consultar_Ejemplar.ResumeLayout(false);
            this.panel_Consultar_Ejemplar.PerformLayout();
            this.panel_Baja_Ejemplar.ResumeLayout(false);
            this.panel_Baja_Ejemplar.PerformLayout();
            this.panel_Alta_Ejemplar.ResumeLayout(false);
            this.panel_Alta_Ejemplar.PerformLayout();
            this.panel_Alta_Documento.ResumeLayout(false);
            this.panel_Alta_Documento.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_Ejemplar_Listar_Ejemplar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolTip toolTip_Sala;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btLogOut;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TabControl Tab;
        private System.Windows.Forms.TabPage Usuarios;
        private System.Windows.Forms.TabPage Sala;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.GroupBox gbPrestamos;
        private System.Windows.Forms.Button btBusqueda;
        private System.Windows.Forms.Button btDevolucion;
        private System.Windows.Forms.Button btPrestamo;
        private System.Windows.Forms.TabPage Adquisiciones;
        private System.Windows.Forms.Panel panel_Listar_Ejemplar;
        private System.Windows.Forms.ComboBox comboBox_Documento_Listar_Ejemplar;
        private System.Windows.Forms.Label label_Documento_Listar_Ejemplar;
        private System.Windows.Forms.DataGridView dataGridView_Listar_Ejemplar;
        private System.Windows.Forms.Label label_Listar_Ejemplar;
        private System.Windows.Forms.Panel panel_Listar_Documento;
        private System.Windows.Forms.DataGridView dataGridView_Listar_Documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_Titulo_List_Documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_Autor_List_Documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_ISBN_List_Documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_Editorial_List_Documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_Año_List_Documento;
        private System.Windows.Forms.DataGridViewCheckBoxColumn column_AudioLibro_List_Documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_Formato_List_Documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_Duracion_List_Documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_Fecha_List_Documento;
        private System.Windows.Forms.DataGridViewCheckBoxColumn column_Disponible_List_Documento;
        private System.Windows.Forms.Label label_Listar_Documento;
        private System.Windows.Forms.Panel panel_Consultar_MasLeido;
        private System.Windows.Forms.Label label_Consultar_MasLeido;
        private System.Windows.Forms.TextBox textBox_Duracion_Consultar_MasLeido;
        private System.Windows.Forms.ComboBox comboBox_Formato_Consultar_MasLeido;
        private System.Windows.Forms.Label label_Duracion_Consultar_MasLeido;
        private System.Windows.Forms.Label label_Formato_Consultar_MasLeido;
        private System.Windows.Forms.Label label_Año_Consultar_MasLeido;
        private System.Windows.Forms.TextBox textBox_Año_Consultar_MasLeido;
        private System.Windows.Forms.Label label_Editorial_Consultar_MasLeido;
        private System.Windows.Forms.Label label_ISBN_Consultar_MasLeido;
        private System.Windows.Forms.Label label_Autor_Consultar_MasLeido;
        private System.Windows.Forms.Label label_Titulo_Consultar_MasLeido;
        private System.Windows.Forms.TextBox textBox_Editorial_Consultar_MasLeido;
        private System.Windows.Forms.TextBox textBox_ISBN_Consultar_MasLeido;
        private System.Windows.Forms.TextBox textBox_Autor_Consultar_MasLeido;
        private System.Windows.Forms.TextBox textBox_Titulo_Consultar_MasLeido;
        private System.Windows.Forms.CheckBox checkBox_Audiolibro_Consultar_MasLeido;
        private System.Windows.Forms.Button button_Realizar_Consultar_Fech;
        private System.Windows.Forms.Panel panel_Consultar_Fecha;
        private System.Windows.Forms.TextBox textBox_Fecha_Consultar_Fech;
        private System.Windows.Forms.Label label_Fecha_Consultar_Fech;
        private System.Windows.Forms.ComboBox comboBox_Documento_Consultar_Fech;
        private System.Windows.Forms.Label label_Documento_Consultar_Fech;
        private System.Windows.Forms.Label label_Consultar_Fecha;
        private System.Windows.Forms.Button button_Realizar_Consultar_Disp;
        private System.Windows.Forms.Panel panel_Consultar_Disponible;
        private System.Windows.Forms.ComboBox comboBox_Documento_Consultar_Disp;
        private System.Windows.Forms.Label label_Documento_Consultar_Disp;
        private System.Windows.Forms.Label label_Consultar_Disponible;
        private System.Windows.Forms.CheckBox checkBox_Disponible_Consultar_Disp;
        private System.Windows.Forms.Button button_Realizar_Consultar_Ejemplar;
        private System.Windows.Forms.Panel panel_Consultar_Ejemplar;
        private System.Windows.Forms.TextBox textBox_Documento_Consultar_Eje;
        private System.Windows.Forms.TextBox textBox_Codigo_Consultar_Eje;
        private System.Windows.Forms.Label label_Documento_Consultar_Eje;
        private System.Windows.Forms.TextBox textBox_Responsable_Consultar_Eje;
        private System.Windows.Forms.Label label_Informacion_Consultar_Eje;
        private System.Windows.Forms.Label label_Codigo_Consultar_Eje;
        private System.Windows.Forms.Label label_Responsable_Consultar_Eje;
        private System.Windows.Forms.Label label_Consultar_Ejemplar;
        private System.Windows.Forms.Label label_Localizacion_Consultar_Eje;
        private System.Windows.Forms.TextBox textBox_Localizacion_Consultar_Eje;
        private System.Windows.Forms.CheckBox checkBox_Disponible_Consultar_Eje;
        private System.Windows.Forms.Button button_Listar_Ejemplar;
        private System.Windows.Forms.Button button_Listar_Documento;
        private System.Windows.Forms.Button button_Consultar_Mas_Leido;
        private System.Windows.Forms.Button button_Consultar_Disponible;
        private System.Windows.Forms.Button button_Consultar_Fecha;
        private System.Windows.Forms.Button button_Consultar_Ejemplar;
        private System.Windows.Forms.Button button_Borrar_Baja_Eje;
        private System.Windows.Forms.Panel panel_Baja_Ejemplar;
        private System.Windows.Forms.TextBox textBox_Codigo_Baja_Eje;
        private System.Windows.Forms.Label label_Codigo_Baja_Eje;
        private System.Windows.Forms.TextBox textBox_Responsable_Baja_Eje;
        private System.Windows.Forms.Label label_Info_Baja_Eje;
        private System.Windows.Forms.ComboBox comboBox_Ejemplar_Baja_Eje;
        private System.Windows.Forms.Label label_Ejemplar_Baja_Eje;
        private System.Windows.Forms.Label label_Responsable_Baja_Eje;
        private System.Windows.Forms.Label label_Baja_Ejemplares;
        private System.Windows.Forms.ComboBox comboBox_Documento_Baja_Eje;
        private System.Windows.Forms.Label label_Documento_Baja_Eje;
        private System.Windows.Forms.Label label_Localizacion_Baja_Eje;
        private System.Windows.Forms.TextBox textBox_Localizacion_Baja_Eje;
        private System.Windows.Forms.CheckBox checkBox_Disponible_Baja_Eje;
        private System.Windows.Forms.Panel panel_Alta_Ejemplar;
        private System.Windows.Forms.Label label_Alta_Ejemplar;
        private System.Windows.Forms.ComboBox comboBox_Documento_Alta_Eje;
        private System.Windows.Forms.Label label_Documento_Alta_Eje;
        private System.Windows.Forms.Label label_Localizacion_Alta_Eje;
        private System.Windows.Forms.TextBox textBox_Localizacion_Alta_Eje;
        private System.Windows.Forms.CheckBox checkBox_Disponible_Alta_Eje;
        private System.Windows.Forms.Button button_Validar_Alta_Ejemplar;
        private System.Windows.Forms.Button button_Validar_Alta_Documento;
        private System.Windows.Forms.Panel panel_Alta_Documento;
        private System.Windows.Forms.Label label_Alta_Doc;
        private System.Windows.Forms.TextBox textBox_Duracion_Alta_Doc;
        private System.Windows.Forms.ComboBox comboBox_Formato_Alta_Doc;
        private System.Windows.Forms.Label label_Duracion_Alta_Doc;
        private System.Windows.Forms.Label label_Formato_Alta_Doc;
        private System.Windows.Forms.Label label_Año_Edicion_Alta_Doc;
        private System.Windows.Forms.TextBox textBox_Año_Edicion_Alta_Doc;
        private System.Windows.Forms.Label label_Editorial_Alta_Doc;
        private System.Windows.Forms.Label label_ISBN_Alta_Doc;
        private System.Windows.Forms.Label label_Autor_Alta_Doc;
        private System.Windows.Forms.Label label_Titulo_Alta_Doc;
        private System.Windows.Forms.TextBox textBox_Editorial_Alta_Doc;
        private System.Windows.Forms.TextBox textBox_ISBN_Alta_Doc;
        private System.Windows.Forms.TextBox textBox_Autor_Alta_Doc;
        private System.Windows.Forms.TextBox textBox_Titulo_Alta_Doc;
        private System.Windows.Forms.CheckBox checkBox_Audiolibro_Alta_Doc;
        private System.Windows.Forms.Button button_Volver;
        private System.Windows.Forms.Button button_Alta_Ejemplar;
        private System.Windows.Forms.Button button_Alta_Documento;
        private System.Windows.Forms.Button button_Listar;
        private System.Windows.Forms.Button button_Consultas;
        private System.Windows.Forms.Button button_Bajas;
        private System.Windows.Forms.Button button_Altas;
        private System.Windows.Forms.Label label_Main_Adquisiciones;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btInicio;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button ListarBtn;
        private System.Windows.Forms.Button BajaBtn;
        private System.Windows.Forms.Button AltaBtn;
        private System.Windows.Forms.Label label3;
        private TextBox DNIBox;
        private Button ConsultarBtn;
        private Panel PanelFunciones;
        private Button btBuscar;
        private BindingSource bindingSource_Ejemplar_Listar_Ejemplar;
        private DataGridViewTextBoxColumn Column_Codigo_Listar_Ejemplar;
        private DataGridViewTextBoxColumn Column_Documento_Listar_Ejemplar;
        private DataGridViewTextBoxColumn Column_Responsable_Listar_Ejemplar;
        private DataGridViewCheckBoxColumn Column_Activo_Listar_Ejemplar;
        private DataGridViewCheckBoxColumn Column_Disponible_Listar_Ejemplar;
        private DataGridViewTextBoxColumn ColumnLocalizacion_Listar_Ejemplar;
    }
}