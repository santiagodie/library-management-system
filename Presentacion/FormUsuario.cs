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
        public FormUsuario(Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
        }

        private void CargarLibros(string titulo,bool pendientes)
        {
            GestorUsuarios gestor = new GestorUsuarios();
            List<Prestamo> prestamos = gestor.ObtenerMisPrestamosFiltrados(usuario, titulo, pendientes);
            List<Ejemplar> ejemplares= new List<Ejemplar>();
            foreach(Prestamo p in prestamos)
            {
                foreach(Ejemplar e in p.EjemplaresPrestados)
                {
                    ejemplares.Add(e);
                }
            }

        }
    }
}
