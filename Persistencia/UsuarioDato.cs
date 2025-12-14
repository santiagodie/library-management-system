using ModeloDominio;
using BaseDatos;

namespace Persistencia
{
    internal class UsuarioDato : Entidad
    {
        private string personaId;
        private EstadoUsuario estado;

        //PRE: personaId no puede ser nulo.
        //POST: crea un nuevo UsuarioDato con el id de persona y estado proporcionados.
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

        //PRE: ---
        //POST: devuelve la clave primaria (personaId) de esta entidad.
        public override object ObtenerClave()
        {
            return personaId;
        }

        //PRE: nombre indica el campo a modificar y dato contiene el nuevo valor.
        //POST: modifica el campo indicado si existe. Devuelve true si se modificó correctamente.
        public override bool ModificarDato(string nombre, object dato)
        {
            if (nombre == "Estado")
            {
                estado = (EstadoUsuario)dato;
                return true;
            }
            return false;
        }

        //PRE: nombre indica el campo a obtener.
        //POST: devuelve el valor del campo indicado, o null si no existe.
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
