using ModeloDominio;
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
    public partial class FormAltaPrestamo : Form
    {
        private GestorSala gestor;
        private List<Ejemplar> ejemplaresEnElPrestamo;

        private Personal responsable;

        private BindingSource bsUsuarios;
        private BindingSource bsEjemplares;

        //PRE: 'personalLogueado' no debe ser nulo.
        //POST: Inicializa los componentes del formulario, instancia el gestor de sala y prepara las listas de binding para usuarios y ejemplares.
        public FormAltaPrestamo(Personal personalLogueado)
        {
            InitializeComponent();
            gestor = new GestorSala();
            ejemplaresEnElPrestamo = new List<Ejemplar>();
            this.responsable = personalLogueado;
            bsUsuarios = new BindingSource();
            bsEjemplares = new BindingSource();
        }

        //PRE: ---
        //POST: Establece la fecha actual en el selector de fecha (deshabilitado) y carga la lista de usuarios disponibles.
        private void FormAltaPrestamo_Load(object sender, EventArgs e)
        {
            dtpFecha.Value = DateTime.Today;
            dtpFecha.Enabled = false;
            CargarUsuarios();
        }

        //PRE: La instancia de 'gestor' debe estar correctamente inicializada.
        //POST: Obtiene la lista de usuarios del sistema y la vincula al ComboBox cbUsuario.
        private void CargarUsuarios()
        {
            bsUsuarios.DataSource = gestor.GetListaUsuarios();
            cbUsuario.DataSource = bsUsuarios;

            cbUsuario.DisplayMember = "Dni";

            cbUsuario.SelectedIndex = -1;
        }

        //PRE: ---
        //POST: Abre el formulario de selección de ejemplar. Si se selecciona uno válido y no está repetido, lo añade a la lista 'ejemplaresEnElPrestamo' y actualiza la vista.
        private void btAnadir_Click(object sender, EventArgs e)
        {
            FormSeleccionEjemplar frmSeleccion = new FormSeleccionEjemplar();

            if (frmSeleccion.ShowDialog() == DialogResult.OK)
            {
                Ejemplar nuevoEjemplar = frmSeleccion.EjemplarSeleccionado;

                if (nuevoEjemplar != null)
                {
                    if (ejemplaresEnElPrestamo.Exists(x => x.Codigo == nuevoEjemplar.Codigo))
                    {
                        MessageBox.Show("Este ejemplar ya está añadido a la lista.");
                        return;
                    }

                    ejemplaresEnElPrestamo.Add(nuevoEjemplar);
                    ActualizarListaVisual();
                }
            }
        }

        //PRE: La lista 'ejemplaresEnElPrestamo' debe estar inicializada.
        //POST: Actualiza el DataSource del ListBox 'lbEjemplares' para reflejar los cambios en la lista de objetos.
        private void ActualizarListaVisual()
        {
            bsEjemplares.DataSource = ejemplaresEnElPrestamo;
            lbEjemplares.DataSource = bsEjemplares;

            lbEjemplares.FormattingEnabled = true; 
            lbEjemplares.Format += lbEjemplares_Format;
        }

        //PRE: Se debe haber seleccionado un usuario, ingresado un ID y añadido al menos un ejemplar a la lista.
        //POST: Intenta registrar el préstamo en el sistema. Si tiene éxito, muestra confirmación y cierra el formulario. Si falla, captura la excepción y muestra el error.
        private void btAceptar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbID.Text))
            {
                MessageBox.Show("Debes introducir un ID para el préstamo.");
                return;
            }
            if (cbUsuario.SelectedItem == null)
            {
                MessageBox.Show("Selecciona un usuario.");
                return;
            }
            if (ejemplaresEnElPrestamo.Count == 0)
            {
                MessageBox.Show("Debes añadir al menos un ejemplar.");
                return;
            }

            try
            {
                Usuario usuario = (Usuario)cbUsuario.SelectedItem;
                DateTime fechaInicio = dtpFecha.Value;

                DateTime[] fechasFin = new DateTime[ejemplaresEnElPrestamo.Count];
                for (int i = 0; i < ejemplaresEnElPrestamo.Count; i++)
                {
                    fechasFin[i] = fechaInicio.AddDays(15);
                }

                gestor.AltaPrestamo(usuario, ejemplaresEnElPrestamo, (PersonalSala)responsable);

                MessageBox.Show("Préstamo registrado correctamente");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el préstamo: " + ex.Message);
            }
        }

        //PRE: El objeto 'e.ListItem' debe ser de tipo Ejemplar.
        //POST: Formatea la visualización del elemento en el ListBox para mostrar el texto "COD ejemplar:" seguido del código del ejemplar.
        private void lbEjemplares_Format(object sender, ListControlConvertEventArgs e)
        {
            Ejemplar ej = (Ejemplar)e.ListItem;
            e.Value = $"COD ejemplar:   {ej.Codigo}";
        }

        //PRE: ---
        //POST: Solicita confirmación al usuario mediante un cuadro de diálogo. Si confirma, cierra el formulario con resultado Cancel; de lo contrario, no realiza ninguna acción.
        private void btCancelar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show(
                "¿Estás seguro de que deseas cancelar? Se perderán los datos no guardados.",
                "Confirmar cancelación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
            this.DialogResult = DialogResult.Cancel; 

            this.Close();
            }
        }
    }
}
