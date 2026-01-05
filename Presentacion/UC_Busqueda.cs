using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Properties
{
    public partial class UC_Busqueda : UserControl
    {
        GestorSala gestorSala;
        public UC_Busqueda()
        {
            InitializeComponent();
            gestorSala = new GestorSala();
        }

        private void UC_Busqueda_Load(object sender, EventArgs e)
        {
            if (cbEstado.Items.Count == 0)
            {
                cbEstado.Items.AddRange(new string[] { "Todos", "Activos", "Vencidos", "Devueltos" });
                cbEstado.SelectedIndex = 0;
            }
            if (cbTipo.Items.Count == 0)
            {
                cbTipo.Items.AddRange(new string[] { "Todos", "Libro", "Audiolibro" });
                cbTipo.SelectedIndex = 0;
            }

            CargarDatosCombos();

            dgvResultados.ReadOnly = true;
            dgvResultados.MultiSelect = false;

            dtpFecha.Checked = false;
            Buscar();
        }

        private void CargarDatosCombos()
        {
            cbTitulo.DataSource = gestorSala.GetListaTitulos();
            cbTitulo.SelectedIndex = -1;

            cbAutor.DataSource = gestorSala.GetListaAutores();
            cbAutor.SelectedIndex = -1;

            cbUsuario.DataSource = gestorSala.GetListaUsuariosBusqueda();
            cbUsuario.SelectedIndex = -1;

            cbISBN.DataSource = gestorSala.GetListaISBNs();
            cbISBN.SelectedIndex = -1;
        }


        private void Buscar()
        {
            string usuario = cbUsuario.Text;
            string titulo = cbTitulo.Text;
            string autor = cbAutor.Text;
            string isbn = cbISBN.Text;
            string ejemplar = cbEjemplar.Text;
            string tipo = cbTipo.SelectedItem?.ToString() ?? "Todos";
            string estado = cbEstado.SelectedItem?.ToString() ?? "Todos";

            DateTime? fecha = null;
            if (dtpFecha.Checked) fecha = dtpFecha.Value;

            List<ItemBusquedaPrestamo> resultados = gestorSala.BuscarPrestamos(usuario, titulo, autor, isbn, ejemplar, tipo, fecha, estado);

            dgvResultados.DataSource = null;
            dgvResultados.DataSource = resultados;

            if (dgvResultados.Columns.Count > 0)
            {
                dgvResultados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            Buscar();
        }

        private void btLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCb(cbUsuario);
            LimpiarCb(cbTitulo);
            LimpiarCb(cbAutor);
            LimpiarCb(cbISBN);
            LimpiarCb(cbEjemplar);

            cbTipo.SelectedIndex = 0;
            cbEstado.SelectedIndex = 0;

            dtpFecha.Checked = false;
            dtpFecha.Value = DateTime.Today;

            Buscar();
        }

        private void UC_Busqueda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                btBuscar.PerformClick();
            }
        }

        private void LimpiarCb(ComboBox cb)
        {
            cb.SelectedIndex = -1; 
            cb.Text = "";
        }
    }
}
