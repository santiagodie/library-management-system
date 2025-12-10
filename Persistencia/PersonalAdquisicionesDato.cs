using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseDatos
{
    internal class PersonalAdquisicionesDato : Entidad
    {
        private string id;
        private string nombre;
        private string dni;
        private string usuario;
        private string contraseña;
        public PersonalAdquisicionesDato(string id, string nombre, string dni,
        string usuario, string contraseña)
        {
            this.id = id;
            this.nombre = nombre;
            this.dni = dni;
            this.usuario = usuario;
            this.contraseña = contraseña;
        }
        public string Id { get { return id; } }
        public string Nombre { get { return nombre; } }
        public string Dni { get { return dni; } }
        public string Usuario { get { return usuario; } }
        public string Contraseña { get { return contraseña; } }
        public override object ObtenerClave()
        {
            return id;
        }
        public override bool ModificarDato(string nombre, object dato)
        {
            return false;
        }
        public override object ObtenerDato(string nombre)
        {
            switch (nombre)
            {
                case "Id": return id;
                case "Nombre": return this.nombre;
                case "Dni": return dni;
                case "Usuario": return usuario;
                case "Contraseña": return contraseña;
                default: return null;
            }
        }
    }
}
