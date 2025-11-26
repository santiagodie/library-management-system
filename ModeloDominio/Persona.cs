using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ModeloDominio
{
    public class Persona : Entidad
    {
        private string id;
        private string Contraseña;
        private string Nombre;
        private string dni;
        public Persona(string id, string contraseña, string nombre, string dni)
        {
            this.id = id;
            Contraseña = contraseña;
            Nombre = nombre;
            this.dni = dni;
        }
        public string getId()
        {
            return id;
        }
        public string getName()
        {
            return Nombre;
        }
        public string getContraseña()
        {
            return Contraseña;
        }
        public string getDNI()
        {
            return dni;
        }

        public override string ObtenerClave()
        {
            return this.getId();
        }

        public override bool ModificarDato(string nombre, object dato)
        {
            switch (nombre.ToLower())
            {
                case "nombre":
                    this.Nombre = dato.ToString();
                    return true;
                case "contraseña":
                    this.Contraseña = dato.ToString();
                    return true;
                default:
                    return false;
            }
        }

        public override object ObtenerDato(string nombre)
        {
            switch (nombre.ToLower())
            {
                case "id": return this.getId();
                case "nombre": return this.getName();
                case "dni": return this.getDNI();
                case "contraseña": return this.getContraseña();
                default: return null;
            }
        }
    }
}
