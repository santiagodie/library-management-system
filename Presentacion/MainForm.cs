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
        public Main()
        {
            InitializeComponent();
            loginForm.LoginExitoso += InicioSesion;


        }
        private void InicioSesion(object sender, Rol rol,Persona persona)
        {
            this.rol = rol;
            this.persona = persona;
            loginForm.Visible = false;
            switch (rol)
            {
                
            }
        }

        
    }
}
