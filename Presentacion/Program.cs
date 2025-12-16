using ModeloDominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Persistencia;

namespace Presentacion
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            PoblarBaseDatos.Inicializar();// poblamos aqui con algunos datos de prueba.

            Login login = new Login();

            if (login.ShowDialog() == DialogResult.OK)
            {
                Rol rol = login.RolLogueado;
                Persona persona = login.PersonaLogueada;

                switch (rol)
                {
                    case Rol.Usuario:
                        Application.Run(new FormUsuario(persona as Usuario));
                        break;
                }

            }
            else
            {
                Application.Exit();
            }
        }
    }
}
