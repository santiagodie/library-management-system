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
    public partial class UC_BajaUsuario : UserControl
    {
        public UC_BajaUsuario()
        {
            InitializeComponent();
        }

        //PRE: El control DNIBox debe contener texto.
        //POST: Valida el formato del DNI. Si es válido, pide confirmación al usuario y solicita la baja al gestor. Muestra un mensaje con el resultado (éxito o error si el usuario no existe).
        private void BajaBtn_Click(object sender, EventArgs e)
        {
            string dni=DNIBox.Text;
            GestorUsuarios gestor=new GestorUsuarios();
            if (!String.IsNullOrEmpty(dni) && gestor.EsDniValido(dni))
            {
                if (MessageBox.Show("¿Está seguro de que quiere dar de baja al usuario con DNI " + dni, "Confirmar baja", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (gestor.BajaUsuario(gestor.ConsultarUusuario(dni)))
                    {
                        DNIBox.Clear();
                    }
                    else
                    {
                        MessageBox.Show("No existe un usuario activo con DNI " + dni);
                    }
                }
            }
            else
            {
                MessageBox.Show("El DNI introducido no es válido.");
            }
        }
    }
}
