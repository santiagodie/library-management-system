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
    public partial class FormSeleccionEjemplar : Form
    {
        private GestorSala gestor;

        public Ejemplar EjemplarSeleccionado { get; private set; }

        public FormSeleccionEjemplar()
        {
            InitializeComponent();
            gestor = new GestorSala();
        }

        private void CargarEjemplaresDisponibles()
        {
            List<Ejemplar> listaEjemplares = gestor.GetEjemplaresDisponibles();

            var listaParaComboBox = listaEjemplares.Select(ej => new
            {
                ObjetoReal = ej,
                TextoA_Mostrar = $"Codigo: {ej.Codigo} Documento: ISBN: {ej.Documento.ISBN} Titulo: {ej.Documento.Titulo}"
            }).ToList();

            cbEjemplares.DataSource = listaParaComboBox;
            cbEjemplares.DisplayMember = "TextoA_Mostrar";
            cbEjemplares.ValueMember = "ObjetoReal";

            cbEjemplares.SelectedIndex = -1;
        }

        private void FormSeleccionEjemplar_Load(object sender, EventArgs e)
        {
            CargarEjemplaresDisponibles();
        }

        private void btAceptar_Click(object sender, EventArgs e)
        {
            if (cbEjemplares.SelectedItem != null)
            {
                EjemplarSeleccionado = (Ejemplar)cbEjemplares.SelectedValue;

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un ejemplar de la lista.");
            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
