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
                if (rol == Rol.Usuario)
                {
                    Usuario user = persona as Usuario;
                    if (user == null)
                    {
                        GestorUsuarios gestor = new GestorUsuarios();
                        user = gestor.ConsultarUusuario(persona.Dni);
                    }

                    if (user != null) Application.Run(new FormUsuario(user));
                }
                else
                {
                    Application.Run(new FormPersonal(persona as Personal, rol));
                }
                        
                

            }
            else
            {
                Application.Exit();
            }
        }
    }
}
