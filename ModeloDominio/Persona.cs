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

        //PRE: nombre y dni no pueden ser nulos.
        //POST: crea una instancia de Persona con el nombre y DNI indicados, inicializando el hash de la contraseña como una cadena vacía.
        public Persona(string nombre, string dni)
        {
            this.Nombre = nombre;
            this.Dni = dni;
            this.HashContraseña = "";
        }

        //PRE: hash no puede ser nulo.
        //POST: actualiza el campo HashContraseña con el valor del hash proporcionado.
        public void SetHashContraseña(string hash)
        {
            this.HashContraseña = hash;
        }
    }
}