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
    
    public partial class FormUsuario : Form
    {
        public Usuario usuario { get; set; }
        public List<EjemplarPrestado> listaLibros=new List<EjemplarPrestado>();
        public FormUsuario(Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
            Grid.AutoGenerateColumns = false;
            CargarLibros(null, PendientesBox.Checked);
        }

        private void CargarLibros(string titulo,bool pendientes)
        {
            GestorUsuarios gestor = new GestorUsuarios();
            listaLibros = gestor.ObtenerMisPrestamosFiltrados(this.usuario, titulo, pendientes);
            Grid.DataSource = null;
            Grid.DataSource = listaLibros;
            Grid.Columns["FechaPrestamo"].DefaultCellStyle.Format= "dd/MM/yyyy";
            Grid.Columns["FechaFin"].DefaultCellStyle.Format = "dd/MM/yyyy";
        }

        private void Cambio(object sender, EventArgs e)
        {
            CargarLibros(BookBox.Text,PendientesBox.Checked);
        }

        private void FormUsuario_Load(object sender, EventArgs e)
        {

        }
    }
    
}
