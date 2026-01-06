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
        public event Action IrAlPrimero;
        public event Action IrAlUltimo;
        public event Action<Usuario> MostrarPrestamos;
        private Usuario user;

        public UC_InfoUsuario(Usuario user)
        {
            InitializeComponent();
            this.user = user;
            NameBox.Text = user.Nombre;
            DNIBox.Text = user.Dni;
            if (panelNavegacion != null)  panelNavegacion.Visible = false;
        }

        public void ActivarNavegacion(int indiceActual, int totalUsuarios)
        {
            if (panelNavegacion != null)
            {
                panelNavegacion.Visible = true;

                tbIndice.Text = (indiceActual + 1).ToString();
                tbTotal.Text = "de " + totalUsuarios.ToString();

                btPrimero.Enabled = indiceActual > 0;
                btAnterior.Enabled = indiceActual > 0;
                btSiguiente.Enabled = indiceActual < (totalUsuarios - 1);
                btUltimo.Enabled = indiceActual < (totalUsuarios - 1);
            }
        }

        private void btPrimero_Click(object sender, EventArgs e)
        {
            IrAlPrimero?.Invoke();
        }

        private void btAnterior_Click(object sender, EventArgs e)
        {
            CambiarUsuario?.Invoke(this.user, false);
        }

        private void btSiguiente_Click(object sender, EventArgs e)
        {
            CambiarUsuario?.Invoke(this.user, true);
        }

        private void btUltimo_Click(object sender, EventArgs e)
        {
            IrAlUltimo?.Invoke();
        }

        private void PrestBtn_Click(object sender, EventArgs e)
        {
            if (this.user != null)
            {
                MostrarPrestamos?.Invoke(this.user);
            }
        }
    }
}
