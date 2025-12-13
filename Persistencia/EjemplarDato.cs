using BaseDatos;


namespace Persistencia
{
    internal class EjemplarDato : Entidad
    {
        private string codigo;
        private string isbnDocumento;
        private bool prestado;
        private bool activo;
        private string idResponsable;
        public EjemplarDato(string codigo, string isbnDocumento, bool prestado,
        string idResponsable, bool activo = true)
        {
            this.codigo = codigo;
            this.isbnDocumento = isbnDocumento;
            this.prestado = prestado;
            this.idResponsable = idResponsable;
            this.activo = activo;
        }
        public string Codigo { get { return codigo; } }
        public string IsbnDocumento { get { return isbnDocumento; } }
        public bool Prestado
        {
            get { return prestado; }
            set { prestado = value; }
        }
        public bool Activo
        {
            get { return activo; }
            set { activo = value; }
        }
        public string IdResponsable { get { return idResponsable; } }
        public override object ObtenerClave()
        {
            return codigo;
        }
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
                default:
                    return false;
            }
        }
        public override object ObtenerDato(string nombre)
        {
            switch (nombre)
            {
                case "Codigo": return codigo;
                case "IsbnDocumento": return isbnDocumento;
                case "Prestado": return prestado;
                case "Activo": return activo;
                case "IdResponsable": return idResponsable;
                default: return null;
            }
        }
    }
}
