using BaseDatos;

namespace Persistencia
{
    internal class PersonalSalaDato : Entidad
    {
        private string id;
        private string nombre;
        private string dni;
        private string contraseña;  
        private string nss;        
        public PersonalSalaDato(string id, string nombre, string dni, string contraseña, string nss)
        {
            this.id = id;
            this.nombre = nombre;
            this.dni = dni;
            this.contraseña = contraseña;
            this.nss = nss;
        }

        public string Id { get { return id; } }
        public string Nombre { get { return nombre; } }
        public string Dni { get { return dni; } }
        public string Contraseña { get { return contraseña; } }
        public string Nss { get { return nss; } }

        public override object ObtenerClave()
        {
            return id;
        }

        public override bool ModificarDato(string nombre, object dato)
        {
            switch (nombre)
            {
                case "Contraseña":
                    this.contraseña = dato as string;
                    return true;
                case "Nombre":
                    this.nombre = dato as string;
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
                case "Contraseña": return contraseña;
                case "Nss": return nss;
                default: return null;
            }
        }
    }
}