using BaseDatos;


namespace Persistencia
{
    internal class EjemplarDato : Entidad
    {
        private string localizacion;
        private string codigo;  
        private string isbnDocumento;
        private bool prestado;
        private bool activo;
        private string idResponsable; 

        //PRE: codigo, isbnDocumento e idResponsable no pueden ser nulos.
        //POST: crea un nuevo EjemplarDato con los datos proporcionados. Por defecto está activo.
        public EjemplarDato(string localizacion,string codigo, string isbnDocumento, bool prestado,string idResponsable, bool activo = true)
        {
            this.localizacion = localizacion;
            this.codigo = codigo;  
            this.isbnDocumento = isbnDocumento;
            this.prestado = prestado;
            this.idResponsable = idResponsable; 
            this.activo = activo;

        }
        public string Codigo {  get { return codigo; } }
        public string IsbnDocumento { get {  return isbnDocumento; } }
        public bool Prestado
        {
            get { return prestado;  }
            set { prestado = value; }
        }
        public bool Activo
        {
            get { return activo; }
            set { activo = value; }
        }
        public string IdResponsable { get { return idResponsable; }  }
        public string Localizacion { get { return localizacion; } }

        //PRE: ---
        //POST: devuelve la clave primaria (codigo) de esta entidad.
        public override object ObtenerClave()
        {
            return codigo;
        }

        //PRE: nombre indica el campo a modificar y dato contiene el nuevo valor.
        //POST: modifica el campo indicado si existe. Devuelve true si se modificó correctamente.
        public override bool ModificarDato(string nombre, object dato)
        {
            switch (nombre)
            {
                case "Prestado":
                    prestado = (bool)dato;
                    return true;
                case "Activo":
                    activo = (bool)dato;
                    return true;
                case "Localizacion":
                    localizacion = (string)dato;
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
                case "Codigo": return codigo;
                case "IsbnDocumento": return isbnDocumento;
                case "Prestado": return prestado;
                case "Activo": return activo;
                case "IdResponsable": return idResponsable;
                case "Localizacion": return localizacion;
                default: return null;
            }
        }
    }

}
