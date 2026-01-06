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

        private BindingSource bsEjemplares;

        public FormSeleccionEjemplar()
        {
            InitializeComponent();
            gestor = new GestorSala();
            bsEjemplares = new BindingSource();
        }

        //PRE: 'gestor' debe estar inicializado.
        //POST: Obtiene todos los ejemplares disponibles del sistema, crea una proyección anónima para formatear el texto y la asigna al ComboBox.
        private void CargarEjemplaresDisponibles()
        {
            List<Ejemplar> listaEjemplares = gestor.GetEjemplaresDisponibles();

            var listaParaComboBox = listaEjemplares.Select(ej => new
            {
                ObjetoReal = ej,
                TextoA_Mostrar = $"Codigo: {ej.Codigo} Documento: ISBN: {ej.Documento.ISBN} Titulo: {ej.Documento.Titulo}"
            }).ToList();

            bsEjemplares.DataSource = listaParaComboBox;
            cbEjemplares.DataSource = bsEjemplares;
            cbEjemplares.DisplayMember = "TextoA_Mostrar";
            cbEjemplares.ValueMember = "ObjetoReal";

            cbEjemplares.SelectedIndex = -1;
        }

        //PRE: ---
        //POST: Carga la lista de ejemplares disponibles en el ComboBox al iniciar el formulario.
        private void FormSeleccionEjemplar_Load(object sender, EventArgs e)
        {
            CargarEjemplaresDisponibles();
        }

        //PRE: Debe haber un elemento seleccionado en el ComboBox cbEjemplares.
        //POST: Asigna el objeto seleccionado a la propiedad pública 'EjemplarSeleccionado' y cierra el formulario con resultado OK.
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

        //PRE: ---
        //POST: Establece el resultado del diálogo como Cancel y cierra el formulario sin realizar ninguna selección.
        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
