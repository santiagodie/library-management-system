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
    public partial class UC_AltaUsuario : UserControl
    {
        public UC_AltaUsuario()
        {
            InitializeComponent();
        }

        //PRE: Los campos NameBox y DNIBox deben contener datos.
        //POST: Valida el DNI y crea un nuevo objeto Usuario. Si el alta en el gestor es exitosa, limpia los campos; si no, informa del error (ej. usuario duplicado).
        private void AltaBtn_Click(object sender, EventArgs e)
        {
            string name=NameBox.Text;
            string dni=DNIBox.Text;
            GestorUsuarios gestor = new GestorUsuarios();
            if (!String.IsNullOrEmpty(name) && !String.IsNullOrEmpty(dni)&&gestor.EsDniValido(dni))
            {
                Usuario user = new Usuario(name, dni);
                user.SetHashContraseña(Hash.GetHash(Hash.CrearPassword(10)));
                if (gestor.AltaUsuario(user))
                {
                    NameBox.Clear();
                    DNIBox.Clear();
                }
                else
                {
                    MessageBox.Show("Ya existe un usuario con DNI " + dni);
                }
            }
            else
            {
                MessageBox.Show("Los datos introducidos no son válidos.");
            }
        }
    }
}
