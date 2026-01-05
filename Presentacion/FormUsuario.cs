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
        public List<EjemplarPrestado> listaLibros = new List<EjemplarPrestado>();
        public FormUsuario(Usuario usuario)
        {
            InitializeComponent();
            UC_PrestamosUsuario prestamos = new UC_PrestamosUsuario(usuario);
            prestamos.Dock = DockStyle.Fill;
            this.Controls.Add(prestamos);
        }

    }
    
}
