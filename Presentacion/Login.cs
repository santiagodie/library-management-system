using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ModeloDominio;
using Persistencia;
namespace Presentacion
{
    public partial class Login : UserControl
    {
        public Login()
        {
            InitializeComponent();
        }
        public delegate void LoginExitosoEventHandler(object sender, Rol rol,Persona persona);

        public event LoginExitosoEventHandler LoginExitoso;

        private void OnLoginExitoso(Rol rol,Persona persona)
        {
            // Verifica si hay algún suscriptor antes de disparar
            LoginExitoso?.Invoke(this, rol,persona);
        }

        private void AcceptBtn_Click(object sender, EventArgs e)
        {
            string dni=DNIBox.Text;
            string contraseña=PasswordBox.Text;
            if (Persistencia.Persistencia.ExistePersona(dni))
            {
                if(Persistencia.Persistencia.ExisteUsuario(dni))
                {
                    Usuario usuario = Persistencia.Persistencia.GetUsuario(dni);
                    if (usuario.HashContraseña == Hash.GetHash(contraseña))
                    {
                       OnLoginExitoso(Rol.Usuario, usuario);
                    }
                    else
                    {
                        MessageBox.Show("Contraseña incorrecta para la cuenta con DNI: " + dni);
                    }
                }
                else
                {
                    if (Persistencia.Persistencia.ExistePersonalSala(dni))
                    {
                        PersonalSala personal=Persistencia.Persistencia.GetPersonalSala(dni);
                        if (personal.HashContraseña == Hash.GetHash(contraseña))
                        {
                            OnLoginExitoso(Rol.PersonalSala, personal); 
                        }
                        else
                        {
                            MessageBox.Show("Contraseña incorrecta para la cuenta con DNI: " + dni);
                        }
                    }
                    else
                    {
                        if (Persistencia.Persistencia.ExistePersonalAdquisiciones(dni))
                        {
                            PersonalAdquisiciones personal = Persistencia.Persistencia.GetPersonalAdquisiciones(dni);
                            if (personal.HashContraseña == Hash.GetHash(contraseña))
                            {
                                OnLoginExitoso(Rol.PersonalAdquisiciones, personal);
                            }
                            else
                            {
                                MessageBox.Show("Contraseña incorrecta para la cuenta con DNI: " + dni);
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No existe ninguna cuenta para el DNI: " + dni);
            }
        }
        
    }
}
