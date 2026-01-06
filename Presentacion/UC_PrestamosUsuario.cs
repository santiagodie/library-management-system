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
    
    public partial class UC_PrestamosUsuario : UserControl
    {
        public Usuario usuario { get; set; }
        public List<EjemplarPrestado> listaLibros=new List<EjemplarPrestado>();
        private BindingSource source;
        public UC_PrestamosUsuario(Usuario usuario)
        {
            InitializeComponent();
            source=new BindingSource();
            source.DataSource = listaLibros;
            Grid.DataSource = source;
            this.usuario = usuario;
            Grid.AutoGenerateColumns = false;
            Grid.Columns["FechaPrestamo"].DefaultCellStyle.Format = "dd/MM/yyyy";
            Grid.Columns["FechaFin"].DefaultCellStyle.Format = "dd/MM/yyyy";
            CargarLibros(null, PendientesBox.Checked);
        }

        private void CargarLibros(string titulo,bool pendientes)
        {
            GestorUsuarios gestor = new GestorUsuarios();
            List<EjemplarPrestado> lista = gestor.ObtenerMisPrestamosFiltrados(this.usuario, titulo, pendientes);
            source.DataSource=lista;
        }

        private void Cambio(object sender, EventArgs e)
        {
            CargarLibros(BookBox.Text,PendientesBox.Checked);
        }

        
    }
    
}
