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
    public partial class UC_DetallePrestamo : UserControl
    {
        public event EventHandler<Ejemplar> OnEjemplarSeleccionado;
        public event Action<Usuario> OnSolicitarInfoUsuario;
        private Prestamo prestamoActual;
        public UC_DetallePrestamo()
        {
            InitializeComponent();
            ConfigurarGrid();
        }

        private void ConfigurarGrid()
        {
            dgvLibros.AutoGenerateColumns = false;
            dgvLibros.Columns.Clear();
            dgvLibros.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Ejemplar",
                DataPropertyName = "Descripcion",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                ReadOnly = true
            });

            dgvLibros.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Estado",
                DataPropertyName = "EstadoStr",
                Width = 100,
                ReadOnly = true
            });

            DataGridViewButtonColumn btnCol = new DataGridViewButtonColumn
            {
                HeaderText = "Seleccionar",
                Text = ">>",
                UseColumnTextForButtonValue = true,
                Name = "colAccion",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells,
                FlatStyle = FlatStyle.Popup,
                Visible = false
            };
            dgvLibros.Columns.Add(btnCol);

            dgvLibros.CellClick += dgvLibros_CellClick;
            dgvLibros.CellFormatting += dgvLibros_CellFormatting_1;
            dgvLibros.BackgroundColor = Color.White;
            dgvLibros.RowHeadersVisible = false;
        }

        public bool ModoSeleccion
        {
            get { return dgvLibros.Columns["colAccion"].Visible; }
            set
            {
                dgvLibros.Columns["colAccion"].Visible = value;
                this.BackColor = value ? Color.AliceBlue : Color.WhiteSmoke;
                if (btUsuario != null)
                {
                    btUsuario.Visible = !value;
                }
            }
        }

        public void CargarDatos(Prestamo p)
        {
            prestamoActual = p;

            if (p == null)
            {
                Limpiar();
                return;
            }

            tbUsuario.Text = $"{p.Usuario.Nombre} ({p.Usuario.Dni})";
            dtpFecha.Value = p.FechaInicio;

            tbEstado.Text = p.Vencido ? "VENCIDO" : "ACTIVO";
            tbEstado.ForeColor = p.Vencido ? Color.Red : Color.Green;

            var listaVisual = new List<dynamic>();

            foreach (Ejemplar ej in p.EjemplaresPrestados)
            {
                listaVisual.Add(new
                {
                    Descripcion = $"{ej.Codigo} - {ej.Documento.Titulo}",
                    ObjetoReal = ej,
                    EstadoStr = "En curso",
                    EsDevuelto = false
                });
            }

            if (p.EjemplaresDevueltos != null)
            {
                foreach (Ejemplar ej in p.EjemplaresDevueltos)
                {
                    listaVisual.Add(new
                    {
                        Descripcion = $"{ej.Codigo} - {ej.Documento.Titulo}",
                        ObjetoReal = ej,
                        EstadoStr = "Devuelto",
                        EsDevuelto = true
                    });
                }

                
            }
            dgvLibros.DataSource = listaVisual;
        }

        private void Limpiar()
        {
            tbUsuario.Text = "";
            dtpFecha.Value = DateTime.MinValue;
            tbEstado.Text = "";
            dgvLibros.DataSource = null;
        }


        private void dgvLibros_CellFormatting_1(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvLibros.Rows[e.RowIndex].DataBoundItem != null)
            {
                dynamic item = dgvLibros.Rows[e.RowIndex].DataBoundItem;

                if (item.EsDevuelto)
                {
                    e.CellStyle.BackColor = Color.LightGray;
                    e.CellStyle.ForeColor = Color.DimGray;
                    e.CellStyle.SelectionBackColor = Color.Gray;
                }
            }
        }

        private void dgvLibros_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 &&
                e.ColumnIndex == dgvLibros.Columns["colAccion"].Index &&
                ModoSeleccion)
            {
                var item = dgvLibros.Rows[e.RowIndex].DataBoundItem as dynamic;
                if (item != null)
                {
                    if (item.EsDevuelto)
                    {
                        MessageBox.Show("Este ejemplar ya ha sido devuelto.");
                        return;
                    }
                    Ejemplar ej = item.ObjetoReal;

                    OnEjemplarSeleccionado?.Invoke(this, ej);
                }
            }
        }

        private void lbDatos_Click(object sender, EventArgs e)
        {

        }

        private void btUsuario_Click(object sender, EventArgs e)
        {
            if (prestamoActual != null && prestamoActual.Usuario != null)
            {
                OnSolicitarInfoUsuario?.Invoke(prestamoActual.Usuario);
            }
            else
            {
                MessageBox.Show("No hay usuario cargado.");
            }
        }
    }
}

