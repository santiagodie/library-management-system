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
    public partial class FormPrestamo : Form
    {
        public FormPrestamo(Prestamo prestamo)
        {
            InitializeComponent();
            uc_DetallePrestamo1.ModoSeleccion = false;
            uc_DetallePrestamo1.CargarDatos(prestamo);
            uc_DetallePrestamo1.OnSolicitarInfoUsuario += AbrirInfoUsuario;
        }

        private void AbrirInfoUsuario(Usuario usuario)
        {
            UC_InfoUsuario ucInfo = new UC_InfoUsuario(usuario);
            ucInfo.Dock = DockStyle.Fill;

            ucInfo.MostrarPrestamos += (u) =>
            {
                this.Controls.Remove(ucInfo);
                ucInfo.Dispose();
                uc_DetallePrestamo1.Visible = true;
            };

            uc_DetallePrestamo1.Visible = false;
            this.Controls.Add(ucInfo);
            ucInfo.BringToFront();
        }
    }
}

