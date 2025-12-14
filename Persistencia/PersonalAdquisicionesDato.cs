using BaseDatos;

namespace Persistencia
{
    internal class PersonalAdquisicionesDato : Entidad
    {
        private string personaId;
        private string nss;

        //PRE: personaId y nss no pueden ser nulos.
        //POST: crea un nuevo PersonalAdquisicionesDato con el id de persona y NSS proporcionados.
        public PersonalAdquisicionesDato(string personaId, string nss)
        {
            this.personaId = personaId;
            this.nss = nss;
        }

        public string PersonaId { get { return personaId; } }
        public string Nss { get {  return nss; } }

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
            if (nombre == "Nss" )
            {
                nss = (string)dato;
                return true;
            }
            return false; 
        }

        //PRE: nombre indica el campo a obtener.
        //POST: devuelve el valor del campo indicado, o null si no existe.
        public override object ObtenerDato(string nombre)
        {
            switch ( nombre )
            {
                case "PersonaId":  return personaId; 
                case "Nss": return nss;
                default: return null;
            }
        }
    }
}