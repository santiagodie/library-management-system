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
    public partial class RolLog : Form
    {
        public Rol rolLogin { get;set }
        private Rol Roles;
        public RolLog(Rol rol)
        {
            InitializeComponent();
            Roles=rol;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            rolLogin = Rol.Usuario;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Roles == Rol.UsuarioYAdquisiciones)
            {
                rolLogin = Rol.PersonalAdquisiciones;
            }
            else
            {
                rolLogin = Rol.PersonalSala;
            }
            this.DialogResult=DialogResult.OK;
            this.Close();
        }
    }
}
