using ModeloDominio;
using BaseDatos;

namespace Persistencia
{
    internal class UsuarioDato : Entidad
    {
        private string personaId;
        private EstadoUsuario estado;

        public UsuarioDato(string personaId, EstadoUsuario estado)
        {
            this.personaId = personaId;
            this.estado = estado;
        }

        public string PersonaId { get { return personaId; } }
        public EstadoUsuario Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        public override object ObtenerClave()
        {
            return personaId;
        }

        public override bool ModificarDato(string nombre, object dato)
        {
            if (nombre == "Estado")
            {
                estado = (EstadoUsuario)dato;
                return true;
            }
            return false;
        }

        public override object ObtenerDato(string nombre)
        {
            switch (nombre)
            {
                case "PersonaId": return personaId;
                case "Estado": return estado;
                default: return null;
            }
        }
    }
}
