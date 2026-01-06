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
        public Rol rolLogin { get; set; }
        private Rol Roles;
        public RolLog(Rol rol)
        {
            InitializeComponent();
            Roles=rol;
        }

        //PRE: ---
        //POST: Establece el 'rolLogin' como 'Usuario', fija el resultado del diálogo a OK y cierra el formulario.
        private void button1_Click(object sender, EventArgs e)
        {
            rolLogin = Rol.Usuario;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        //PRE: La propiedad 'Roles' debe estar inicializada con el rol compuesto (ej. UsuarioYSala).
        //POST: Determina el rol específico de personal (Adquisiciones o Sala) basado en 'Roles', lo asigna a 'rolLogin' y cierra el formulario con OK.
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

        private void RolLog_Load(object sender, EventArgs e)
        {

        }
    }
}
