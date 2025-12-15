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

        private void CargarLibros()
        {
            
        }
    }
}
