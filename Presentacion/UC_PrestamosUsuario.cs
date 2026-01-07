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

        //PRE: 'usuario' no debe ser nulo.
        //POST: Inicializa el control, configura el formato de columnas del DataGridView y carga los préstamos asociados al usuario recibido.
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

        //PRE: La propiedad 'usuario' debe estar asignada y no ser nula.
        //POST: Obtiene la lista de préstamos filtrada por título y estado (pendientes o todos) usando el gestor y actualiza el DataSource del Grid.
        private void CargarLibros(string titulo, bool pendientes)
        {
            GestorUsuarios gestor = new GestorUsuarios();
            List<EjemplarPrestado> lista = gestor.ObtenerMisPrestamosFiltrados(this.usuario, titulo, pendientes);
            source.DataSource=lista;
        }

        //PRE: ---
        //POST: Recoge los valores actuales de los filtros (texto y checkbox) y recarga la lista de libros mostrada.
        private void Cambio(object sender, EventArgs e)
        {
            CargarLibros(BookBox.Text,PendientesBox.Checked);
        }

        
    }
    
}
