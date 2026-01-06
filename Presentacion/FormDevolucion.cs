using ModeloDominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FormDevolucion : Form
    {
        private GestorSala gestor;
        private Prestamo prestamoActivo;
        private BindingSource bsEjemplares;

        public FormDevolucion()
        {
            InitializeComponent();
            gestor = new GestorSala();
            bsEjemplares = new BindingSource();
            this.AcceptButton = btBuscar;
        }

        //PRE: El campo cbEjemplar no debe estar vacío.
        //POST: Busca el ejemplar y su préstamo activo asociado. Si se encuentra, carga los datos en el control de detalle 'ucDetalle'. Si no, notifica al usuario.
        private void btBuscar_Click(object sender, EventArgs e)
        {
            string codigo = cbEjemplar.Text.Trim();
            if (string.IsNullOrEmpty(codigo)) return;

            Ejemplar ej = gestor.ConsultarEjemplar(codigo);
            if (ej == null) { MessageBox.Show("Ejemplar no encontrado"); return; }

            Prestamo p = gestor.GetPrestamoActivo(ej);
            if (p == null) { MessageBox.Show("Este ejemplar no está prestado."); return; }

            prestamoActivo = p;
            ucDetalle.CargarDatos(p);

        }

        //PRE: La lista de devoluciones (lbDevolucion) debe contener al menos un elemento.
        //POST: Agrupa las devoluciones por préstamo y procesa la devolución en la capa de negocio. Muestra el número total de ejemplares devueltos al finalizar.
        private void btAceptar_Click(object sender, EventArgs e)
        {
            if (lbDevolucion.Items.Count == 0) return;
            try
            {
                List<LineaDevolucion> cesta = new List<LineaDevolucion>();
                foreach (LineaDevolucion item in lbDevolucion.Items) cesta.Add(item);

                var gruposDeDevolucion = cesta.GroupBy(x => x.PrestamoOrigen);

                int totalProcesados = 0;

                foreach (var grupo in gruposDeDevolucion)
                {
                    Prestamo prestamo = grupo.Key;
                    List<Ejemplar> librosDelGrupo = grupo.Select(x => x.Libro).ToList();
                    if (gestor.DevolverEjemplares(prestamo, librosDelGrupo))
                    {
                        totalProcesados += librosDelGrupo.Count;
                    }
                    else
                    {
                        MessageBox.Show($"Error al guardar la devolución del usuario {prestamo.Usuario.Nombre}");
                    }
                }
                MessageBox.Show($"Operación finalizada. {totalProcesados} ejemplares devueltos.");
                LimpiarPantalla();
                CargarCodigos();
                cbEjemplar.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al procesar devoluciones: " + ex.Message);
            }
        }

        //PRE: ---
        //POST: Resetea la interfaz: vacía la lista de devoluciones, limpia el control de detalle y pone el foco en la búsqueda.
        private void LimpiarPantalla()
        {
            lbDevolucion.Items.Clear();
            ucDetalle.CargarDatos(null);
            prestamoActivo = null;
            cbEjemplar.Text = "";
            cbEjemplar.Focus();
        }

        //PRE: ---
        //POST: Configura los eventos de los controles, inicializa el modo de selección y carga la lista de códigos para el autocompletado.
        private void FormDevolucion_Load(object sender, EventArgs e)
        {
            ucDetalle.ModoSeleccion = true;
            ucDetalle.OnEjemplarSeleccionado += UcDetalle_OnEjemplarSeleccionado;

            lbDevolucion.FormattingEnabled = true;
            lbDevolucion.Format += lbDevolucion_Format;

            lbDevolucion.DoubleClick += lbDevolucion_DoubleClick;

            cbEjemplar.DataSource = bsEjemplares;
            cbEjemplar.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbEjemplar.AutoCompleteSource = AutoCompleteSource.ListItems;

            CargarCodigos();
        }

        //PRE: 'gestor' debe estar inicializado.
        //POST: Obtiene la lista de códigos de ejemplares prestados y recarga el autocompletado del buscador.
        private void CargarCodigos()
        {
            List<string> codigos = gestor.GetListaCodigosPrestados();

            bsEjemplares.DataSource = codigos;
            bsEjemplares.ResetBindings(false);
            cbEjemplar.SelectedIndex = -1;
        }

        //PRE: 'ejemplarElegido' no debe ser nulo. 'prestamoActivo' debe estar establecido.
        //POST: Añade el ejemplar a la lista visual de devoluciones (lbDevolucion) si no se encuentra ya en ella.
        private void UcDetalle_OnEjemplarSeleccionado(object sender, Ejemplar ejemplarElegido)
        {

            foreach (LineaDevolucion item in lbDevolucion.Items)
            {
                if (item.Libro.Codigo == ejemplarElegido.Codigo) return;
            }

            lbDevolucion.Items.Add(new LineaDevolucion
            {
                Libro = ejemplarElegido,
                PrestamoOrigen = this.prestamoActivo
            });
        }

        //PRE: El objeto e.ListItem debe ser de tipo LineaDevolucion.
        //POST: Formatea la visualización del elemento en la lista mostrando el código del ejemplar y el título del documento.
        private void lbDevolucion_Format(object sender, ListControlConvertEventArgs e)
        {
            var linea = e.ListItem as LineaDevolucion;

            if (linea != null)
            {
                e.Value = $"{linea.Libro.Codigo} - {linea.Libro.Documento.Titulo}";
            }
        }

        //PRE: ---
        //POST: Solicita confirmación al usuario. Si acepta, cierra el formulario devolviendo DialogResult.Cancel.
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

        //PRE: Debe haber un elemento seleccionado en lbDevolucion.
        //POST: Elimina el elemento seleccionado de la lista de devoluciones pendientes.
        private void lbDevolucion_DoubleClick(object sender, EventArgs e)
        {
            if (lbDevolucion.SelectedItem != null)
            {
                lbDevolucion.Items.Remove(lbDevolucion.SelectedItem);
            }
        }
    }


    public class LineaDevolucion
    {
        public Prestamo PrestamoOrigen { get; set; }
        public Ejemplar Libro { get; set; }

    }
}
