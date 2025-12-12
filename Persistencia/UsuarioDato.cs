using ModeloDominio;
using BaseDatos;

namespace Persistencia
{
    public class UsuarioDato:Entidad
    {
        private string dni;
        private string nombre;
        private EstadoUsuario estado;
        public UsuarioDato(string dni, string nombre, EstadoUsuario estado)
        {
            this.dni = dni;
            this.nombre = nombre;
            this.estado = estado;
        }
        public string Dni { get { return dni; } }
        public string Nombre { get { return nombre; } }
        public EstadoUsuario Estado
        {
            get { return estado; }
            set { estado = value; }
        }
        public override object ObtenerClave()
        {
            return dni; // DNI es la clave primaria
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
                case "Dni": return dni;
                case "Nombre": return this.nombre;
                case "Estado": return estado;
                default: return null;
            }
        }
    }
}
