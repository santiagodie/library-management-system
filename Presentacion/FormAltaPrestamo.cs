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

        public FormAltaPrestamo(Personal personalLogueado)
        {
            InitializeComponent();
            gestor = new GestorSala();
            ejemplaresEnElPrestamo = new List<Ejemplar>();
            this.responsable = personalLogueado;
            bsUsuarios = new BindingSource();
            bsEjemplares = new BindingSource();
        }

        private void FormAltaPrestamo_Load(object sender, EventArgs e)
        {
            dtpFecha.Value = DateTime.Today;
            dtpFecha.Enabled = false;
            CargarUsuarios();
        }

        private void CargarUsuarios()
        {
            bsUsuarios.DataSource = gestor.GetListaUsuarios();
            cbUsuario.DataSource = bsUsuarios;

            cbUsuario.DisplayMember = "Dni";

            cbUsuario.SelectedIndex = -1;
        }

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

        private void ActualizarListaVisual()
        {
            bsEjemplares.DataSource = ejemplaresEnElPrestamo;
            lbEjemplares.DataSource = bsEjemplares;

            lbEjemplares.FormattingEnabled = true; 
            lbEjemplares.Format += lbEjemplares_Format;
        }

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

        private void lbEjemplares_Format(object sender, ListControlConvertEventArgs e)
        {
            Ejemplar ej = (Ejemplar)e.ListItem;
            e.Value = $"COD ejemplar:   {ej.Codigo}";
        }

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
