using BaseDatos;

namespace Persistencia
{
    internal class PersonaDato : Entidad
    {
        private string id;
        private string nombre;
        private string dni;
        private string hashContraseña;

        public PersonaDato(string id, string nombre, string dni, string hashContraseña)
        {
            this.id = id;
            this.nombre = nombre;
            this.dni = dni;
            this.hashContraseña = hashContraseña;
        }

        public string Id { get { return id; } }
        public string Nombre { get { return nombre; } }
        public string Dni { get { return dni; } }
        public string HashContraseña
        {
            get { return hashContraseña; }
            set { hashContraseña = value; }
        }

        public override object ObtenerClave()
        {
            return id;
        }

        public override bool ModificarDato(string nombre, object dato)
        {
            switch (nombre)
            {
                case "HashContraseña":
                    hashContraseña = (string)dato;
                    return true;
                default:
                    return false;
            }
        }

        public override object ObtenerDato(string nombre)
        {
            switch (nombre)
            {
                case "Id": return id;
                case "Nombre": return this.nombre;
                case "Dni": return dni;
                case "HashContraseña": return hashContraseña;
                default: return null;
            }
        }
    }
}