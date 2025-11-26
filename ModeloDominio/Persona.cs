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

        public string Id { get; private set; }
        public string Nombre { get; private set; }
        public string Dni { get; private set; }

        //No los construimos con contraseña, se pedirá al dar de alta (logicaNegocio) y se guardará un hash
        public Persona(string id, string nombre, string dni)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Dni = dni;
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
