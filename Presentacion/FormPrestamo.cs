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
        //PRE: 'prestamo' no debe ser nulo.
        //POST: Inicializa los componentes, configura el modo de selección del control de usuario y carga los datos del préstamo proporcionado.
        public FormPrestamo(Prestamo prestamo)
        {
            InitializeComponent();
            uc_DetallePrestamo1.ModoSeleccion = false;
            uc_DetallePrestamo1.CargarDatos(prestamo);
            uc_DetallePrestamo1.OnSolicitarInfoUsuario += AbrirInfoUsuario;
        }

        //PRE: 'usuario' no debe ser nulo.
        //POST: Oculta el detalle del préstamo y superpone el control UC_InfoUsuario. Configura el evento de retorno para restaurar la vista original.
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

        private void FormPrestamo_Load(object sender, EventArgs e)
        {

        }
    }
}

