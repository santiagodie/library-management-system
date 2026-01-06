using ModeloDominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class UC_InfoUsuario : UserControl
    {
        public event Action<int> IrAIndice;
        public event Action<Usuario, bool> CambiarUsuario;
        public event Action IrAlPrimero;
        public event Action IrAlUltimo;
        public event Action<Usuario> MostrarPrestamos;
        private Usuario user;
        private int indiceActualGuardado;
        private int totalGuardado;

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
            indiceActualGuardado = indiceActual;
            totalGuardado = totalUsuarios;
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

        private void tbIndice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;

                if (int.TryParse(tbIndice.Text.Trim(), out int numeroIngresado))
                {
                    int indiceSolicitado = numeroIngresado - 1;
                    if (indiceSolicitado >= 0 && indiceSolicitado < totalGuardado)
                    {
                        IrAIndice?.Invoke(indiceSolicitado);
                    }
                    else
                    {
                        MessageBox.Show($"Por favor, introduce un número entre 1 y {totalGuardado}.");
                        RestaurarValorVisual();
                    }
                }
                else
                {
                    MessageBox.Show("Solo se admiten números.");
                    RestaurarValorVisual();
                }
            }
        }

        private void RestaurarValorVisual()
        {
            tbIndice.Text = (indiceActualGuardado + 1).ToString();
            tbIndice.SelectionStart = tbIndice.Text.Length;
        }
    }
}
