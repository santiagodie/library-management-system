using System;
using System.Windows.Forms;
using ModeloDominio;
namespace Presentacion
{
    public partial class Login : Form
    {
        public Rol RolLogueado { get; private set; }
        public Persona PersonaLogueada { get; private set; }

        public Login()
        {
            InitializeComponent();
        }

        private void AcceptBtn_Click(object sender, EventArgs e)
        {
            string dni = DNIBox.Text;
            string contraseña = PasswordBox.Text;

            try
            {
                GestorUsuarios gestor = new GestorUsuarios();
                var resultado = gestor.ValidarLogin(dni, contraseña);

                if (resultado.Exito)
                {
                    this.RolLogueado = resultado.Rol;
                    this.PersonaLogueada = rehsultado.Persona;
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show(resultado.MensajeError, "Error de acceso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error del sistema: " + ex.Message);
            }
        }

    }
}
