using BaseDatos;

namespace Persistencia
{
    internal class PersonalSalaDato : Entidad
    {
        private string personaId;
        private string nss;

        public PersonalSalaDato(string personaId, string nss)
        {
            this.personaId = personaId;
            this.nss = nss;
        }

        public string PersonaId { get { return personaId; } }
        public string Nss { get { return nss; } }

        public override object ObtenerClave()
        {
            return personaId;
        }

        public override bool ModificarDato(string nombre, object dato)
        {
            if (nombre == "Nss")
            {
                nss = (string)dato;
                return true;
            }
            return false;
        }

        public override object ObtenerDato(string nombre)
        {
            switch (nombre)
            {
                case "PersonaId": return personaId;
                case "Nss": return nss;
                default: return null;
            }
        }
    }
}