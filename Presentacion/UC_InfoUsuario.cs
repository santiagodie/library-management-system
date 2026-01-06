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
    public partial class UC_InfoUsuario : UserControl
    {
        public event Action<Usuario, bool> CambiarUsuario;
        public event Action<Usuario> MostrarPrestamos;
        private Usuario user;
        public UC_InfoUsuario(Usuario user)
        {
            InitializeComponent();
            this.user = user;
            NameBox.Text = user.Nombre;
            DNIBox.Text = user.Dni;
        }

        private void PrestBtn_Click(object sender, EventArgs e)
        {
            MostrarPrestamos.Invoke(user);
        }
    }
}
