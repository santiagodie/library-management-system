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

        //PRE: ---
        //POST: Inicializa los ComboBoxes de estado y tipo si están vacíos, carga las listas de datos (títulos, autores, usuarios, ISBNs) y realiza una búsqueda inicial.
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

        //PRE: La instancia 'gestorSala' debe estar inicializada.
        //POST: Carga los datos de títulos, autores, usuarios e ISBNs obtenidos del gestor en sus respectivos ComboBoxes y resetea su selección.
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


        //PRE: Los controles de filtrado (ComboBoxes, DatePicker) deben estar inicializados.
        //POST: Recoge los filtros seleccionados, consulta a la capa de negocio (gestorSala) y actualiza el DataGridView 'dgvResultados' con los préstamos encontrados.
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

            BindingSource bs = new BindingSource();
            bs.DataSource = resultados;
            dgvResultados.DataSource = bs;

            if (dgvResultados.Columns.Count > 0)
            {
                dgvResultados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }

        //PRE: ---
        //POST: Llama al método 'Buscar' para filtrar y mostrar los préstamos según los criterios seleccionados.
        private void btBuscar_Click(object sender, EventArgs e)
        {
            Buscar();
        }

        //PRE: ---
        //POST: Resetea todos los controles de filtro a sus valores por defecto (vacíos o "Todos") y realiza una nueva búsqueda sin filtros.
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

        //PRE: ---
        //POST: Detecta si se ha pulsado la tecla Enter. En caso afirmativo, anula el evento predeterminado y ejecuta la búsqueda.
        private void UC_Busqueda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                btBuscar.PerformClick();
            }
        }

        //PRE: 'cb' no debe ser nulo.
        //POST: Establece el índice seleccionado a -1 y borra el texto del ComboBox recibido.
        private void LimpiarCb(ComboBox cb)
        {
            cb.SelectedIndex = -1; 
            cb.Text = "";
        }

        //PRE: El índice de fila (e.RowIndex) debe ser válido (>= 0).
        //POST: Abre el formulario 'FormPrestamo' con los detalles del préstamo seleccionado. Al cerrar el formulario, refresca la búsqueda.
        private void dgvResultados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var item = dgvResultados.Rows[e.RowIndex].DataBoundItem as ItemBusquedaPrestamo;

                if (item != null && item.PrestamoCompleto != null)
                {
                    FormPrestamo frm = new FormPrestamo(item.PrestamoCompleto);
                    frm.ShowDialog();

                    Buscar();
                }
            }
        }
    }
}

