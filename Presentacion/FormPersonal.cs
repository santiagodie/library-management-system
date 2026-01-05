using ModeloDominio;
using Presentacion.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FormPersonal : Form
    {
        public Personal personal;

        GestorAdquisiciones gestorAdquisiciones;

        GestorSala gestorSala;

        //PRE: personal y rol no pueden ser nulos.
        //POST: crea un nuevo FormPersonal inicializando los componentes y configurando las pestañas según el rol.
        public FormPersonal(Personal personal, Rol rol)
        {
            InitializeComponent();
            ToolTipInicializar();
            this.personal= personal;
            lbNombre.Text = personal.Nombre;
            if (rol == Rol.PersonalSala)
            {
                Tab.TabPages.Remove(Adquisiciones);
            }
            else
            {
                Tab.TabPages.Remove(Sala);
                gestorAdquisiciones = new GestorAdquisiciones();
            }
            InicializarSala();
        }
        //PRE: ---
        //POST: inicializa todos los tooltips de los controles del formulario.
        private void ToolTipInicializar()
        {

            //-------------------------- ToolTip Adquisiciones ----------------------//
            toolTip_Sala.SetToolTip(button_Altas, "Realizar altas de documentos o ejemplares.");
            toolTip_Sala.SetToolTip(button_Bajas, "Realizar baja de  un ejemplar existente.");

            toolTip_Sala.SetToolTip(button_Consultas, "Realizar consultas sobre documentos o ejemplares.");
            toolTip_Sala.SetToolTip(button_Listar, "Listar usuarios o préstamos retrasados.");

            toolTip_Sala.SetToolTip(button_Volver, "Volver al menú principal.");

            toolTip_Sala.SetToolTip(button_Alta_Documento, "Dar de alta un nuevo documento.");
            toolTip_Sala.SetToolTip(button_Alta_Ejemplar, "Dar de alta un nuevo ejemplar.");

            toolTip_Sala.SetToolTip(button_Validar_Alta_Documento, "Validar el alta del documento.");
            toolTip_Sala.SetToolTip(button_Validar_Alta_Ejemplar, "Validar el alta del ejemplar.");

            toolTip_Sala.SetToolTip(button_Borrar_Baja_Eje, "Validar la baja del ejemplar.");
            toolTip_Sala.SetToolTip(button_Realizar_Consultar_Ejemplar, "Realizar la consulta del ejemplar.");
            toolTip_Sala.SetToolTip(button_Realizar_Consultar_Disp, "Realizar la consulta de disponibilidad.");
            toolTip_Sala.SetToolTip(button_Realizar_Consultar_Fech, "Realizar la consulta de fecha de disponibilidad.");

            toolTip_Sala.SetToolTip(button_Consultar_Ejemplar, "Consultar un ejemplar por su código.");
            toolTip_Sala.SetToolTip(button_Consultar_Disponible, "Consultar si hay ejemplares disponibles de un documento.");
            toolTip_Sala.SetToolTip(button_Consultar_Fecha, "Consultar la fecha de disponibilidad de un documento.");
            toolTip_Sala.SetToolTip(button_Consultar_Mas_Leido, "Consultar el documento más leído.");

            toolTip_Sala.SetToolTip(button_Listar_Documento, "Listar todos los documentos.");
            toolTip_Sala.SetToolTip(button_Listar_Ejemplar, "Listar todos los ejemplares de un documento.");

        }
        //-------------------------- Event Handlers Clicks de Botones ----------------------//

        //PRE: sender debe ser un botón válido (button_Altas, button_Bajas, button_Consultas, o button_Listar).
        //POST: oculta los botones de inicio, muestra el botón volver, y configura la interfaz según el botón presionado.
        private void EventHandler_Click_BotonesInicio(object sender, EventArgs e) {
            
            button_Altas.Visible = false;
            button_Bajas.Visible = false;
            button_Consultas.Visible = false;
            button_Listar.Visible = false;
            button_Volver.Visible = true;

            Button buttonClick = sender as Button;

            switch (buttonClick?.Name)
            {
                case "button_Altas":
                    button_Alta_Documento.Visible = true;
                    button_Alta_Ejemplar.Visible = true;
                    break;
                case "button_Bajas":
                    button_Bajas.Visible = false;
                    panel_Baja_Ejemplar.Visible = true;
                    button_Borrar_Baja_Eje.Visible = true;
                    comboBox_Documento_Baja_Eje.DataSource = gestorAdquisiciones.GetDocumentos();
                    comboBox_Documento_Baja_Eje.DisplayMember = "Titulo";
                    comboBox_Documento_Baja_Eje.SelectedIndex = -1;
                    break;
                case "button_Consultas":
                    button_Consultar_Ejemplar.Visible = true;
                    button_Consultar_Disponible.Visible = true;
                    button_Consultar_Fecha.Visible = true;
                    button_Consultar_Mas_Leido.Visible = true;
                    break;
                    
                case "button_Listar": 
                    button_Listar_Documento.Visible = true;
                    button_Listar_Ejemplar.Visible = true;
                    break;
            }
        }
        //PRE: sender debe ser un botón válido (button_Consultar_Ejemplar, button_Consultar_Disponible, button_Consultar_Fecha, o button_Consultar_Mas_Leido).
        //POST: oculta los botones de consulta y muestra el panel correspondiente según el botón presionado.
        private void EventHandler_Click_BotonesConsulta(object sender, EventArgs e)
        {
            button_Consultar_Ejemplar.Visible = false;
            button_Consultar_Disponible.Visible = false;
            button_Consultar_Fecha.Visible = false;
            button_Consultar_Mas_Leido.Visible = false;

            Button buttonClick = sender as Button;

            switch (buttonClick?.Name)
            {
                case "button_Consultar_Ejemplar":
                    panel_Consultar_Ejemplar.Visible = true;
                    button_Realizar_Consultar_Ejemplar.Visible = true;
                    break;

                case "button_Consultar_Disponible":
                    panel_Consultar_Disponible.Visible = true;
                    button_Realizar_Consultar_Disp.Visible = true;
                    comboBox_Documento_Consultar_Disp.DataSource = gestorAdquisiciones.GetDocumentos();
                    comboBox_Documento_Consultar_Disp.DisplayMember = "Titulo";
                    comboBox_Documento_Consultar_Disp.SelectedIndex = -1;
                    break;

                case "button_Consultar_Fecha":
                    panel_Consultar_Fecha.Visible = true;
                    button_Realizar_Consultar_Fech.Visible = true;
                    comboBox_Documento_Consultar_Fech.DataSource = gestorAdquisiciones.GetDocumentos();
                    comboBox_Documento_Consultar_Fech.DisplayMember = "Titulo";
                    comboBox_Documento_Consultar_Fech.SelectedIndex = -1;
                    break;

                case "button_Consultar_Mas_Leido":
                    Documento masLeido = gestorAdquisiciones.DocumentoMasLeidoMes();
                    if (masLeido == null)
                    {
                        MessageBox.Show("No hay documentos prestados en el mes actual.");
                        break;
                    }
                    panel_Consultar_MasLeido.Visible = true;
                    button_Consultar_Ejemplar.Visible = false;
                    button_Consultar_Fecha.Visible = false;
                    button_Consultar_Disponible.Visible = false;
                    button_Consultar_Mas_Leido.Visible = false;

                    textBox_Titulo_Consultar_MasLeido.Text = masLeido.Titulo;
                    textBox_Autor_Consultar_MasLeido.Text = masLeido.Autor;
                    textBox_ISBN_Consultar_MasLeido.Text = masLeido.ISBN;
                    textBox_Editorial_Consultar_MasLeido.Text = masLeido.Editorial;
                    textBox_Año_Consultar_MasLeido.Text = masLeido.AñoEdicion.ToString();
                    if (masLeido is Audiolibro audio)
                    {
                        checkBox_Audiolibro_Consultar_MasLeido.Checked = true;
                        comboBox_Formato_Consultar_MasLeido.SelectedItem = audio.Formato;
                        textBox_Duracion_Consultar_MasLeido.Text = audio.DuracionSegundos.ToString();

                        label_Formato_Consultar_MasLeido.Visible = true;
                        comboBox_Formato_Consultar_MasLeido.Visible = true;
                        label_Duracion_Consultar_MasLeido.Visible = true;
                        textBox_Duracion_Consultar_MasLeido.Visible = true;
                    }
                    break;
            }
        }
        //PRE: sender debe ser un botón válido (button_Alta_Documento o button_Alta_Ejemplar).
        //POST: oculta los botones de alta y muestra el panel correspondiente según el botón presionado.
        private void EventHandler_Click_BotonesAlta(object sender, EventArgs e)
        {
            button_Alta_Documento.Visible = false;
            button_Alta_Ejemplar.Visible = false;

            Button buttonClick = sender as Button;

            switch (buttonClick?.Name)
            {
                case "button_Alta_Documento":
                    panel_Alta_Documento.Visible = true;
                    button_Validar_Alta_Documento.Visible = true;
                    comboBox_Formato_Alta_Doc.DataSource = Enum.GetValues(typeof(FormatoAudio)).Cast<FormatoAudio>().Where(f => f != FormatoAudio.Desconocido).ToList();
                    break;

                case "button_Alta_Ejemplar":
                    panel_Alta_Ejemplar.Visible = true;
                    button_Validar_Alta_Ejemplar.Visible = true;
                    comboBox_Documento_Alta_Eje.DataSource = gestorAdquisiciones.GetDocumentos();
                    comboBox_Documento_Alta_Eje.DisplayMember = "Titulo";
                    comboBox_Documento_Alta_Eje.SelectedIndex = -1;
                    break;
            }
        }
        //PRE: sender debe ser un botón válido (button_Listar_Documento o button_Listar_Ejemplar).
        //POST: oculta los botones de listar y muestra el panel correspondiente con los datos solicitados.
        private void EventHandler_Click_BotonesListar(object sender, EventArgs e)
        {
            button_Listar_Ejemplar.Visible = false;
            button_Listar_Documento.Visible = false;

            Button buttonClick = sender as Button;

            switch (buttonClick?.Name)
            {
                case "button_Listar_Documento":
                    panel_Listar_Documento.Visible = true;

                    List<Documento> documentos = gestorAdquisiciones.GetDocumentos().ToList();
                    DateTime? fechaDisp;
                    bool hayDisponible;
                    bool esAudiolibro;
                    Audiolibro audiolibro;

                    foreach (Documento doc in documentos)
                    {
                        esAudiolibro = doc is Audiolibro;
                        hayDisponible = gestorAdquisiciones.HayDisponibles(doc);
                        fechaDisp = gestorAdquisiciones.FechaDisponible(doc);
                        audiolibro = doc as Audiolibro;

                        dataGridView_Listar_Documento.Rows.Add
                            (
                                  doc.Titulo
                                , doc.Autor
                                , doc.ISBN
                                , doc.Editorial
                                , doc.AñoEdicion
                                , esAudiolibro
                                , audiolibro != null ? audiolibro.Formato.ToString() : "N/A"
                                , audiolibro != null ? audiolibro.DuracionSegundos.ToString() : "N/A"
                                , fechaDisp.Value.ToString("g")
                                , hayDisponible
                            );
                    }
                    break;

                case "button_Listar_Ejemplar":
                    panel_Listar_Ejemplar.Visible = true;
                    comboBox_Documento_Listar_Ejemplar.DataSource = gestorAdquisiciones.GetDocumentos();
                    comboBox_Documento_Listar_Ejemplar.DisplayMember = "Titulo";
                    comboBox_Documento_Listar_Ejemplar.SelectedIndex = -1;
                    break;
            }
        }
        //PRE: sender debe ser un botón válido (button_Validar_Alta_Documento o button_Validar_Alta_Ejemplar).
        //POST: valida y procesa el alta del documento o ejemplar según los datos ingresados.
        private void EventHandler_Click_ValidarAlta(object sender, EventArgs e)
        {
            Button buttonClick = sender as Button;

            switch (buttonClick?.Name)
            {
                case "button_Validar_Alta_Documento":
                    if (string.IsNullOrEmpty(textBox_Titulo_Alta_Doc.Text) || string.IsNullOrEmpty(textBox_Autor_Alta_Doc.Text) || string.IsNullOrEmpty(textBox_ISBN_Alta_Doc.Text) || string.IsNullOrEmpty(textBox_Editorial_Alta_Doc.Text) || string.IsNullOrEmpty(textBox_Año_Edicion_Alta_Doc.Text))
                    {
                        MessageBox.Show("Por favor, rellene todos los campos obligatorios.");
                        return;
                    }

                    String titulo = textBox_Titulo_Alta_Doc.Text;
                    String autor = textBox_Autor_Alta_Doc.Text;
                    String isbn = textBox_ISBN_Alta_Doc.Text;
                    String editorial = textBox_Editorial_Alta_Doc.Text;
                    int añoEdicion = int.Parse(textBox_Año_Edicion_Alta_Doc.Text);

                    if (checkBox_Audiolibro_Alta_Doc.Checked)
                    {
                        if (string.IsNullOrEmpty(textBox_Duracion_Alta_Doc.Text))
                        {
                            MessageBox.Show("Por favor, rellene la duración del audiolibro.");
                            return;
                        }

                        FormatoAudio formato = (FormatoAudio)comboBox_Formato_Alta_Doc.SelectedItem;
                        int duracion = int.Parse(textBox_Duracion_Alta_Doc.Text);

                        Audiolibro nuevoAudiolibro = new Audiolibro(titulo, autor, isbn, editorial, añoEdicion);
                        nuevoAudiolibro.Formato = formato;
                        nuevoAudiolibro.DuracionSegundos = duracion;

                        if (!gestorAdquisiciones.AltaDocumento(nuevoAudiolibro))
                        {
                            MessageBox.Show("Error al crear el audiolibro.");
                            return;
                        }
                        MessageBox.Show("Audiolibro creado correctamente.");
                    }
                    else
                    {
                        Libro nuevoLibro = new Libro(titulo, autor, isbn, editorial, añoEdicion);

                        if (!gestorAdquisiciones.AltaDocumento(nuevoLibro))
                        {
                            MessageBox.Show("Error al crear el libro.");
                            return;
                        }
                        MessageBox.Show("Libro creado correctamente.");

                    }
                    textBox_Autor_Alta_Doc.Clear();
                    textBox_Titulo_Alta_Doc.Clear();
                    textBox_ISBN_Alta_Doc.Clear();
                    textBox_Editorial_Alta_Doc.Clear();
                    textBox_Año_Edicion_Alta_Doc.Clear();
                    checkBox_Audiolibro_Alta_Doc.Checked = false;
                    comboBox_Formato_Alta_Doc.SelectedIndex = -1;
                    textBox_Duracion_Alta_Doc.Clear();
                    break;

                case "button_Validar_Alta_Ejemplar":
                    if (string.IsNullOrEmpty(textBox_Localizacion_Alta_Eje.Text) || comboBox_Documento_Alta_Eje.SelectedItem == null)
                    {
                        MessageBox.Show("Por favor, rellene todos los campos obligatorios.");
                        return;
                    }

                    String localizacion = textBox_Localizacion_Alta_Eje.Text;
                    Documento documento = (Documento)comboBox_Documento_Alta_Eje.SelectedItem;
                    bool disponible = checkBox_Disponible_Alta_Eje.Checked;

                    if (!gestorAdquisiciones.AltaEjemplar(localizacion, disponible, documento, (PersonalAdquisiciones)this.personal))
                    {
                        MessageBox.Show("Error al crear el ejemplar.");
                        return;
                    }
                    MessageBox.Show("Ejemplar creado correctamente.");
                    textBox_Localizacion_Alta_Eje.Clear();
                    comboBox_Documento_Alta_Eje.SelectedIndex = -1;
                    break;
            }
        }
        //PRE: debe haber un ejemplar seleccionado en el comboBox.
        //POST: da de baja el ejemplar seleccionado y muestra un mensaje de confirmación.
        private void button_Borrar_Baja_Eje_Click(object sender, EventArgs e)
        {
            if (comboBox_Ejemplar_Baja_Eje.SelectedIndex == -1 || comboBox_Ejemplar_Baja_Eje.SelectedItem == null)
            {
                MessageBox.Show("Por favor, seleccione un ejemplar para dar de baja.");
                return;
            }
            Ejemplar ejemplarSeleccionado = (Ejemplar)comboBox_Ejemplar_Baja_Eje.SelectedItem;
            if (!gestorAdquisiciones.BajaEjemplar(ejemplarSeleccionado))
            {
                MessageBox.Show("Error al dar de baja el ejemplar.");
                return;
            }
            comboBox_Documento_Baja_Eje.SelectedIndex = -1;
            MessageBox.Show("Ejemplar dado de baja correctamente.");

        }
        //PRE: sender debe ser un botón válido (button_Realizar_Consultar_Ejemplar, button_Realizar_Consultar_Disp, o button_Realizar_Consultar_Fech).
        //POST: realiza la consulta solicitada y muestra los resultados en la interfaz.
        private void EventHandler_Click_RealizarConsulta(object sender, EventArgs e)
        {
            Button buttonClick = sender as Button;

            switch (buttonClick?.Name)
            {
                case "button_Realizar_Consultar_Ejemplar":
                    if (string.IsNullOrEmpty(textBox_Codigo_Consultar_Eje.Text))
                    {
                        MessageBox.Show("Por favor, introduzca el código del ejemplar a consultar.");
                        return;
                    }
                    string codigoEjemplar = textBox_Codigo_Consultar_Eje.Text;
                    Ejemplar ejemplar = gestorAdquisiciones.ConsultarEjemplar(codigoEjemplar);
                    if (ejemplar == null)
                    {
                        MessageBox.Show("No se ha encontrado ningún ejemplar con el código proporcionado.");
                        return;
                    }
                    if (!ejemplar.Activo)
                    {
                        MessageBox.Show("El ejemplar consultado ha sido dado de baja.");
                        return;
                    }
                    if (label_Informacion_Consultar_Eje.Visible == false)
                    {
                        label_Informacion_Consultar_Eje.Visible = true;
                        label_Localizacion_Consultar_Eje.Visible = true;
                        label_Documento_Consultar_Eje.Visible = true;
                        label_Responsable_Consultar_Eje.Visible = true;
                        textBox_Localizacion_Consultar_Eje.Visible = true;
                        textBox_Documento_Consultar_Eje.Visible = true;
                        textBox_Responsable_Consultar_Eje.Visible = true;
                        checkBox_Disponible_Consultar_Eje.Visible = true;
                    }
                    textBox_Localizacion_Consultar_Eje.Text = ejemplar.Localizacion;
                    textBox_Documento_Consultar_Eje.Text = ejemplar.Documento.Titulo;
                    textBox_Responsable_Consultar_Eje.Text = ejemplar.Responsable.Nombre;
                    checkBox_Disponible_Consultar_Eje.Checked = ejemplar.Disponible;
                    break;

                case "button_Realizar_Consultar_Disp":
                    if (comboBox_Documento_Consultar_Disp.SelectedIndex == -1 || comboBox_Documento_Consultar_Disp.SelectedItem == null)
                    {
                        MessageBox.Show("Por favor, seleccione un documento para consultar su disponibilidad.");
                        return;
                    }
                    if (!checkBox_Disponible_Consultar_Disp.Visible)
                    {
                        checkBox_Disponible_Consultar_Disp.Visible = true;
                    }
                    checkBox_Disponible_Consultar_Disp.Checked = gestorAdquisiciones.HayDisponibles((Documento)comboBox_Documento_Consultar_Disp.SelectedItem);
                    break;

                case "button_Realizar_Consultar_Fech":
                    if (comboBox_Documento_Consultar_Fech.SelectedIndex == -1 || comboBox_Documento_Consultar_Fech.SelectedItem == null)
                    {
                        MessageBox.Show("Por favor, seleccione un documento para consultar su fecha de disponibilidad.");
                        return;
                    }
                    DateTime? fechaDisponible = gestorAdquisiciones.FechaDisponible((Documento)comboBox_Documento_Consultar_Fech.SelectedItem);
                    if (fechaDisponible == null)
                    {
                        MessageBox.Show("El documento seleccionado no tiene ejemplares prestados actualmente.");
                        return;
                    }
                    label_Fecha_Consultar_Fech.Visible = true;
                    textBox_Fecha_Consultar_Fech.Visible = true;
                    textBox_Fecha_Consultar_Fech.Text = fechaDisponible.Value.ToString("g");
                    break;
            }
        }

        //PRE: ---
        //POST: vuelve al menú principal, ocultando todos los paneles y botones secundarios, y mostrando los botones principales.
        private void button_Volver_Click(object sender, EventArgs e)
        {
            button_Altas.Visible = true;
            button_Bajas.Visible = true;
            button_Consultas.Visible = true;
            button_Listar.Visible = true;

            OcultarBotonesSecundarios();

            LimpiarPanel_AltaDocumento();
            LimpiarPanel_AltaEjemplar();
            LimpiarPanel_BajaEjemplar();
            LimpiarPanel_ConsultarEjemplar();
            LimpiarPanel_ConsultarDisponible();
            LimpiarPanel_ConsultarFecha();
            LimpiarPanel_ConsultarMasLeido();
            LimpiarPanel_ListarDocumento();
            LimpiarPanel_ListarEjemplar();

            button_Volver.Visible = false;
        }
        //PRE: ---
        //POST: muestra u oculta los controles de formato y duración según el estado del checkbox de audiolibro.
        private void checkBox_Audiolibro_Alta_Doc_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Audiolibro_Alta_Doc.Checked) {
                label_Formato_Alta_Doc.Visible = true;
                comboBox_Formato_Alta_Doc.Visible = true;
                label_Duracion_Alta_Doc.Visible = true;
                textBox_Duracion_Alta_Doc.Visible = true;
            }
            else
            {
                label_Formato_Alta_Doc.Visible = false;
                comboBox_Formato_Alta_Doc.Visible = false;
                label_Duracion_Alta_Doc.Visible = false;
                textBox_Duracion_Alta_Doc.Visible = false;
            }
        }
        //PRE: ---
        //POST: filtra el input para permitir solo dígitos y teclas de control.
        private void textBox_KeyPress_SoloInt(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) e.Handled = true;   
        }

        //PRE: ---
        //POST: carga los ejemplares del documento seleccionado en el comboBox de ejemplares.
        private void comboBox_Documento_Baja_Eje_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_Documento_Baja_Eje.SelectedIndex != -1 && comboBox_Documento_Baja_Eje.SelectedItem != null)
            {
                comboBox_Ejemplar_Baja_Eje.Enabled = true;
                comboBox_Ejemplar_Baja_Eje.DataSource = gestorAdquisiciones.GetEjemplares((Documento) comboBox_Documento_Baja_Eje.SelectedItem);
                comboBox_Ejemplar_Baja_Eje.DisplayMember = "Codigo";
                comboBox_Ejemplar_Baja_Eje.SelectedIndex = -1;
            }
            else
            {
                comboBox_Ejemplar_Baja_Eje.Enabled = false;
                comboBox_Ejemplar_Baja_Eje.DataSource = null;
            }
        }

        //PRE: ---
        //POST: muestra los datos del ejemplar seleccionado en los controles correspondientes.
        private void comboBox_Ejemplar_Baja_Eje_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_Ejemplar_Baja_Eje.SelectedIndex != -1 && comboBox_Ejemplar_Baja_Eje.SelectedItem != null)
            {
                Ejemplar ejemplarSeleccionado = (Ejemplar)comboBox_Ejemplar_Baja_Eje.SelectedItem;

                textBox_Codigo_Baja_Eje.Text = ejemplarSeleccionado.Codigo;
                textBox_Localizacion_Baja_Eje.Text = ejemplarSeleccionado.Localizacion;
                textBox_Responsable_Baja_Eje.Text = ejemplarSeleccionado.Responsable.Nombre;
                checkBox_Disponible_Baja_Eje.Checked = ejemplarSeleccionado.Disponible;
            }
            else
            {
                textBox_Codigo_Baja_Eje.Text = string.Empty;
                textBox_Localizacion_Baja_Eje.Text = string.Empty;
                textBox_Responsable_Baja_Eje.Text = string.Empty;
                checkBox_Disponible_Baja_Eje.Checked = false;
            }
        }

        //PRE: ---
        //POST: carga y muestra en el dataGridView los ejemplares del documento seleccionado.
        private void comboBox_Documento_Listar_Ejemplar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_Documento_Listar_Ejemplar.SelectedIndex != -1 && comboBox_Documento_Listar_Ejemplar.SelectedItem != null)
            {
                if(!dataGridView_Listar_Ejemplar.Visible) dataGridView_Listar_Ejemplar.Visible = true;
                dataGridView_Listar_Ejemplar.Rows.Clear();
                Documento documentoSeleccionado = (Documento)comboBox_Documento_Listar_Ejemplar.SelectedItem;
                List<Ejemplar> ejemplares = gestorAdquisiciones.GetEjemplares(documentoSeleccionado).ToList();
                foreach (Ejemplar eje in ejemplares)
                {
                    dataGridView_Listar_Ejemplar.Rows.Add
                        (
                              eje.Codigo
                            , eje.Documento.Titulo
                            , eje.Responsable.Nombre
                            , eje.Activo
                            , eje.Disponible
                            , eje.Localizacion
                            
                        );
                }
            }
            else
            {
                dataGridView_Listar_Ejemplar.Rows.Clear();
                dataGridView_Listar_Ejemplar.Visible = false;
            }
        }

        //-------------------------- Métodos auxiliares ----------------------//
        //PRE: ---
        //POST: oculta todos los botones secundarios de las secciones de alta, consulta y listar.
        private void OcultarBotonesSecundarios()
        {
            if (button_Alta_Documento.Visible || button_Alta_Ejemplar.Visible)
            {
                button_Alta_Documento.Visible = false;
                button_Alta_Ejemplar.Visible = false;
            }

            if (button_Consultar_Ejemplar.Visible || button_Consultar_Disponible.Visible ||
                button_Consultar_Fecha.Visible || button_Consultar_Mas_Leido.Visible)
            {
                button_Consultar_Ejemplar.Visible = false;
                button_Consultar_Disponible.Visible = false;
                button_Consultar_Fecha.Visible = false;
                button_Consultar_Mas_Leido.Visible = false;
            }

            if (button_Listar_Ejemplar.Visible || button_Listar_Documento.Visible)
            {
                button_Listar_Ejemplar.Visible = false;
                button_Listar_Documento.Visible = false;
            }
        }

        //PRE: ---
        //POST: limpia y oculta todos los controles del panel de alta de documentos.
        private void LimpiarPanel_AltaDocumento()
        {
            if (!panel_Alta_Documento.Visible) return;

            panel_Alta_Documento.Visible = false;
            label_Formato_Alta_Doc.Visible = false;
            comboBox_Formato_Alta_Doc.Visible = false;
            label_Duracion_Alta_Doc.Visible = false;
            textBox_Duracion_Alta_Doc.Visible = false;
            button_Validar_Alta_Documento.Visible = false;

            textBox_Autor_Alta_Doc.Clear();
            textBox_Titulo_Alta_Doc.Clear();
            textBox_ISBN_Alta_Doc.Clear();
            textBox_Editorial_Alta_Doc.Clear();
            textBox_Año_Edicion_Alta_Doc.Clear();
            textBox_Duracion_Alta_Doc.Clear();
        }

        //PRE: ---
        //POST: limpia y oculta todos los controles del panel de alta de ejemplares.
        private void LimpiarPanel_AltaEjemplar()
        {
            if (!panel_Alta_Ejemplar.Visible) return;

            panel_Alta_Ejemplar.Visible = false;
            button_Validar_Alta_Ejemplar.Visible = false;
            textBox_Localizacion_Alta_Eje.Clear();
        }

        //PRE: ---
        //POST: limpia y oculta todos los controles del panel de baja de ejemplares.
        private void LimpiarPanel_BajaEjemplar()
        {
            if (!panel_Baja_Ejemplar.Visible) return;

            panel_Baja_Ejemplar.Visible = false;
            button_Borrar_Baja_Eje.Visible = false;
            comboBox_Documento_Baja_Eje.SelectedIndex = -1;
            comboBox_Ejemplar_Baja_Eje.DataSource = null;
            textBox_Codigo_Baja_Eje.Clear();
            textBox_Localizacion_Baja_Eje.Clear();
            textBox_Responsable_Baja_Eje.Clear();
            checkBox_Disponible_Baja_Eje.Checked = false;
        }

        //PRE: ---
        //POST: limpia y oculta todos los controles del panel de consultar ejemplares.
        private void LimpiarPanel_ConsultarEjemplar()
        {
            if (!panel_Consultar_Ejemplar.Visible) return;

            panel_Consultar_Ejemplar.Visible = false;
            button_Realizar_Consultar_Ejemplar.Visible = false;

            label_Informacion_Consultar_Eje.Visible = false;
            label_Localizacion_Consultar_Eje.Visible = false;
            label_Documento_Consultar_Eje.Visible = false;
            label_Responsable_Consultar_Eje.Visible = false;

            textBox_Localizacion_Consultar_Eje.Visible = false;
            textBox_Documento_Consultar_Eje.Visible = false;
            textBox_Responsable_Consultar_Eje.Visible = false;

            checkBox_Disponible_Consultar_Eje.Visible = false;

            textBox_Localizacion_Consultar_Eje.Clear();
            textBox_Codigo_Consultar_Eje.Clear();
            textBox_Documento_Consultar_Eje.Clear();
            textBox_Responsable_Consultar_Eje.Clear();
        }

        //PRE: ---
        //POST: limpia y oculta todos los controles del panel de consultar disponibilidad.
        private void LimpiarPanel_ConsultarDisponible()
        {
            if (!panel_Consultar_Disponible.Visible) return;

            panel_Consultar_Disponible.Visible = false;
            button_Realizar_Consultar_Disp.Visible = false;
            checkBox_Disponible_Consultar_Disp.Visible = false;
        }

        //PRE: ---
        //POST: limpia y oculta todos los controles del panel de consultar fecha de disponibilidad.
        private void LimpiarPanel_ConsultarFecha()
        {
            if (!panel_Consultar_Fecha.Visible) return;

            panel_Consultar_Fecha.Visible = false;
            button_Realizar_Consultar_Fech.Visible = false;
            label_Fecha_Consultar_Fech.Visible = false;
            textBox_Fecha_Consultar_Fech.Visible = false;
            textBox_Fecha_Consultar_Fech.Clear();
        }

        //PRE: ---
        //POST: limpia y oculta todos los controles del panel de consultar documento más leído.
        private void LimpiarPanel_ConsultarMasLeido()
        {
            if (!panel_Consultar_MasLeido.Visible) return;

            panel_Consultar_MasLeido.Visible = false;
            textBox_Titulo_Consultar_MasLeido.Clear();
            textBox_Autor_Consultar_MasLeido.Clear();
            textBox_ISBN_Consultar_MasLeido.Clear();
            textBox_Editorial_Consultar_MasLeido.Clear();
            textBox_Año_Consultar_MasLeido.Clear();
            checkBox_Audiolibro_Consultar_MasLeido.Checked = false;
            comboBox_Formato_Consultar_MasLeido.SelectedIndex = -1;
            textBox_Duracion_Consultar_MasLeido.Clear();
            label_Formato_Consultar_MasLeido.Visible = false;
            comboBox_Formato_Consultar_MasLeido.Visible = false;
            label_Duracion_Consultar_MasLeido.Visible = false;
            textBox_Duracion_Consultar_MasLeido.Visible = false;
        }

        //PRE: ---
        //POST: limpia y oculta todos los controles del panel de listar documentos.
        private void LimpiarPanel_ListarDocumento()
        {
            if (!panel_Listar_Documento.Visible) return;

            panel_Listar_Documento.Visible = false;
            dataGridView_Listar_Documento.Rows.Clear();
        }

        //PRE: ---
        //POST: limpia y oculta todos los controles del panel de listar ejemplares.
        private void LimpiarPanel_ListarEjemplar()
        {
            if (!panel_Listar_Ejemplar.Visible) return;

            panel_Listar_Ejemplar.Visible = false;
            comboBox_Documento_Listar_Ejemplar.SelectedIndex = -1;
            dataGridView_Listar_Ejemplar.Rows.Clear();
            dataGridView_Listar_Ejemplar.Visible = false;
        }
        

        private void InicializarSala()
        {
            UC_Inicio inicio = new UC_Inicio();
            MostrarPantalla(inicio);
        }

        //PRE: ---
        //POST: muestra cualquier usercontrol dentro del panel
        private void MostrarPantalla(UserControl pantalla)
        {
            panelContenedor.Controls.Clear();
            pantalla.Dock = DockStyle.Fill;
            panelContenedor.Controls.Add(pantalla);
            pantalla.BringToFront();
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btBusqueda_Click(object sender, EventArgs e)
        {
            UC_Busqueda busqueda = new UC_Busqueda();
            MostrarPantalla(busqueda);
        }

        private void btLogOut_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show(
                "¿Seguro que desea cerrar sesión?",
                "Cerrar Sesión",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (respuesta == DialogResult.Yes)
            {
                Application.Restart();
                Environment.Exit(0);
            }
        }

        private void btInicio_Click(object sender, EventArgs e)
        {
            UC_Inicio inicio = new UC_Inicio();
            MostrarPantalla(inicio);
        }

        private void AltaBtn_Click(object sender, EventArgs e)
        {
            PanelFunciones.Controls.Clear();
            UC_AltaUsuario alta=new UC_AltaUsuario();
            alta.Dock= DockStyle.Fill;
            PanelFunciones.Controls.Add(alta);
        }

        private void BajaBtn_Click(object sender, EventArgs e)
        {
            PanelFunciones.Controls.Clear();
            UC_BajaUsuario baja = new UC_BajaUsuario();
            baja.Dock = DockStyle.Fill;
            PanelFunciones.Controls.Add(baja);
        }

        private void ListarBtn_Click(object sender, EventArgs e)
        {
            PanelFunciones.Controls.Clear();
            UC_ListadoUsuarios lista=new UC_ListadoUsuarios();
            lista.MostrarUsuario += mostrarUsuario;
            lista.Dock= DockStyle.Fill;
            PanelFunciones.Controls.Add(lista);

        }

        private void ConsultarBtn_Click(object sender, EventArgs e)
        {
            GestorUsuarios gestor= new GestorUsuarios();
            string dni = DNIBox.Text;
            if(!string.IsNullOrEmpty(dni) && gestor.EsDniValido(dni))
            {
                if (gestor.ExisteUsuario(dni))
                {
                    mostrarUsuario(gestor.ConsultarUusuario(dni));
                }
                else
                {
                    MessageBox.Show("No existe ningún usuario con DNI " + dni);
                }
            }
            else
            {
                MessageBox.Show("El DNI introducido no es válido.");
            }
        }
        private void mostrarUsuario(Usuario usuario)
        {
            DNIBox.Text = usuario.Dni;
            PanelFunciones.Controls.Clear();
            UC_InfoUsuario user=new UC_InfoUsuario(usuario);
            user.MostrarPrestamos += mostrarPrestamosUsuario;
            user.Dock= DockStyle.Fill;
            PanelFunciones.Controls.Add(user);
        }
        private void mostrarPrestamosUsuario(Usuario usuario)
        {
            PanelFunciones.Controls.Clear();
            UC_PrestamosUsuario prestamos = new UC_PrestamosUsuario(usuario);
            prestamos.Dock = DockStyle.Fill;
            PanelFunciones.Controls.Add(prestamos);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("¿Cerrar sesión y salir?", "Cerrar Sesión", MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
