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

        public FormAltaPrestamo(Personal personalLogueado)
        {
            InitializeComponent();
            gestor = new GestorSala();
            ejemplaresEnElPrestamo = new List<Ejemplar>();
            this.responsable = personalLogueado;
        }

        private void FormAltaPrestamo_Load(object sender, EventArgs e)
        {
            dtpFecha.Value = DateTime.Today;
            dtpFecha.Enabled = false;
            CargarUsuarios();
        }

        private void CargarUsuarios()
        {
            cbUsuario.DataSource = gestor.GetListaUsuarios();

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
            lbEjemplares.DataSource = null;
            lbEjemplares.DataSource = ejemplaresEnElPrestamo;

            lbEjemplares.DisplayMember = "Codigo";
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
    }
}
