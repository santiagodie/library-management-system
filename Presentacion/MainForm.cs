using ModeloDominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{

    public partial class Main : Form
    {
        private Rol rol;
        private Persona persona;
        public Main(Rol rol, Persona persona)
        {
            InitializeComponent();
            this.rol = rol;
            this.persona = persona;
            ConfigurarPermisos();


        }
        private void ConfigurarPermisos()
        {
            switch (this.rol)
            {
                case Rol.Usuario:
                case Rol.PersonalSala:
                case Rol.PersonalAdquisiciones: break;
            }

        }
    }
}
