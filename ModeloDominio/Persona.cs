using BaseDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ModeloDominio
{
    public enum Rol
    {
        Usuario,
        PersonalAdquisiciones,
        PersonalSala,
        UsuarioYSala,
        UsuarioYAdquisiciones
    }
    public abstract class Persona
    {
        public string Nombre { get; private set; }
        public string Dni { get; private set; }

        public string HashContraseña { get; private set; }

        //No los construimos con contraseña, se pedirá al dar de alta (logicaNegocio) y se guardará un hash
        public Persona(string nombre, string dni)
        {
            this.Nombre = nombre;
            this.Dni = dni;
            this.HashContraseña = "";
        }

        //Añadi esto para poder setear el hash al recrarlo con el Transformer
        public void SetHashContraseña(string hash)
        {
            this.HashContraseña = hash;
        }

        
    }
}
