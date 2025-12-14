using BaseDatos;

namespace Persistencia
{
    internal class PersonaDato : Entidad
    {
        private string id;
        private string nombre;
        private string dni;
        private string hashContraseña;

        //PRE: id, nombre, dni y hashContraseña no pueden ser nulos.
        //POST: crea un nuevo PersonaDato con los datos proporcionados.
        public PersonaDato(string id, string nombre, string dni, string hashContraseña)
        {
            this.id = id; 
            this.nombre = nombre;
            this.dni = dni;
            this.hashContraseña = hashContraseña;  
        }

        public string Id { get { return id; } }
        public string Nombre { get { return nombre; }}
        public string Dni { get { return dni; } }
        public string HashContraseña 
        { 
            get { return hashContraseña;  } 
            set { hashContraseña = value; } 
        }

        //PRE: ---
        //POST: devuelve la clave primaria (id) de esta entidad.
        public override object ObtenerClave()
        {
            return this.id;
        }

        //PRE: nombre indica el campo a modificar y dato contiene el nuevo valor.
        //POST: modifica el campo indicado si existe. Devuelve true si se modificó correctamente.
        public override bool ModificarDato(string nombre, object dato)
        {
            switch (nombre)
            {
                case "Nombre":
                    this.nombre = (string)dato;
                    return true;
                case "HashContraseña":
                    this.hashContraseña = (string)dato;
                    return true;
                default:
                    return false;  
                    
            }
        }

        //PRE: nombre indica el campo a obtener.
        //POST: devuelve el valor del campo indicado, o null si no existe.
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