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
                CargarCodigos();
                cbEjemplar.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al procesar devoluciones: " + ex.Message);
            }
        }

        private void FormDevolucion_Load(object sender, EventArgs e)
        {
            ucDetalle.ModoSeleccion = true;
            ucDetalle.OnEjemplarSeleccionado += UcDetalle_OnEjemplarSeleccionado;

            lbDevolucion.FormattingEnabled = true;
            lbDevolucion.Format += lbDevolucion_Format;

            cbEjemplar.DataSource = bsEjemplares;

            cbEjemplar.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbEjemplar.AutoCompleteSource = AutoCompleteSource.ListItems;

            CargarCodigos();
        }

        private void CargarCodigos()
        {
            List<string> codigos = gestor.GetListaCodigosPrestados();

            bsEjemplares.DataSource = codigos;
            bsEjemplares.ResetBindings(false);
            cbEjemplar.SelectedIndex = -1;
        }

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

        private void lbDevolucion_Format(object sender, ListControlConvertEventArgs e)
        {
            var linea = e.ListItem as LineaDevolucion;

            if (linea != null)
            {
                e.Value = $"{linea.Libro.Codigo} - {linea.Libro.Documento.Titulo}";
            }
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


    public class LineaDevolucion
    {
        public Prestamo PrestamoOrigen { get; set; }
        public Ejemplar Libro { get; set; }

    }
}
