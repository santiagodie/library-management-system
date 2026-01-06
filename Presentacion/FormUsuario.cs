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

        //PRE: 'usuario' no debe ser nulo.
        //POST: Inicializa el formulario, instancia el control de usuario 'UC_PrestamosUsuario' con los datos del usuario y lo añade al panel principal ocupando todo el espacio.
        public FormUsuario(Usuario usuario)
        {
            InitializeComponent();
            UC_PrestamosUsuario prestamos = new UC_PrestamosUsuario(usuario);
            prestamos.Dock = DockStyle.Fill;
            this.Controls.Add(prestamos);
        }

    }
    
}
