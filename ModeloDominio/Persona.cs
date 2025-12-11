using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ModeloDominio
{
    public abstract class Persona : Entidad
    {

        public string Id { get; private set; }
        public string Nombre { get; private set; }
        public string Dni { get; private set; }

        public string HashContraseña { get; private set; }

        //No los construimos con contraseña, se pedirá al dar de alta (logicaNegocio) y se guardará un hash
        public Persona(string id, string nombre, string dni)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Dni = dni;
            this.HashContraseña = "";
        }

        //Añadi esto para poder setear el hash al recrarlo con el Transformer
        public void SetHashContraseña(string hash)
        {
            this.HashContraseña = hash;
        }

        public override object ObtenerClave()
        {
            return this.Id;
        }

        public override bool ModificarDato(string nombre, object dato)
        {
            switch (nombre.ToLower())
            {
                case "nombre":
                    this.Nombre = dato.ToString();
                    return true;
                default:
                    return false;
            }
        }

        public override object ObtenerDato(string nombre)
        {
            switch (nombre.ToLower())
            {
                case "id": return this.Id;
                case "nombre": return this.Nombre;
                case "dni": return this.Dni;
                default: return null;
            }
        }
    }
}
