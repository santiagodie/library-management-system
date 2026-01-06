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

        //PRE: 'user' no debe ser nulo.
        //POST: Inicializa el componente, asigna el usuario recibido y muestra sus datos (Nombre, DNI) en los campos correspondientes. Oculta el panel de navegación por defecto.
        public UC_InfoUsuario(Usuario user)
        {
            InitializeComponent();
            this.user = user;
            NameBox.Text = user.Nombre;
            DNIBox.Text = user.Dni;
            if (panelNavegacion != null)  panelNavegacion.Visible = false;
        }

        //PRE: 'totalUsuarios' debe ser mayor que 0.
        //POST: Hace visible el panel de navegación y habilita/deshabilita los botones (primero, anterior, siguiente, último) según la posición del 'indiceActual'.
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

        //PRE: ---
        //POST: Dispara el evento 'IrAlPrimero' para navegar al primer registro de la lista.
        private void btPrimero_Click(object sender, EventArgs e)
        {
            IrAlPrimero?.Invoke();
        }

        //PRE: ---
        //POST: Dispara el evento 'CambiarUsuario' indicando dirección hacia atrás (false) para ir al usuario anterior.
        private void btAnterior_Click(object sender, EventArgs e)
        {
            CambiarUsuario?.Invoke(this.user, false);
        }

        //PRE: ---
        //POST: Dispara el evento 'CambiarUsuario' indicando dirección hacia delante (true) para ir al siguiente usuario.
        private void btSiguiente_Click(object sender, EventArgs e)
        {
            CambiarUsuario?.Invoke(this.user, true);
        }

        //PRE: ---
        //POST: Dispara el evento 'IrAlUltimo' para navegar al último registro de la lista.
        private void btUltimo_Click(object sender, EventArgs e)
        {
            IrAlUltimo?.Invoke();
        }

        //PRE: El objeto 'user' local debe estar asignado.
        //POST: Dispara el evento 'MostrarPrestamos' pasando el usuario actual para ver su historial.
        private void PrestBtn_Click(object sender, EventArgs e)
        {
            if (this.user != null)
            {
                MostrarPrestamos?.Invoke(this.user);
            }
        }

        //PRE: ---
        //POST: Intercepta la tecla Enter. Valida que el texto sea un número dentro del rango válido. Si es correcto, dispara el evento 'IrAIndice'; si no, muestra error y restaura el valor anterior.
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

        //PRE: ---
        //POST: Restablece el valor del TextBox del índice al valor guardado anteriormente ('indiceActualGuardado' + 1) y coloca el cursor al final.
        private void RestaurarValorVisual()
        {
            tbIndice.Text = (indiceActualGuardado + 1).ToString();
            tbIndice.SelectionStart = tbIndice.Text.Length;
        }
    }
}
