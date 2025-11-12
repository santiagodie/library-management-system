using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ModeloDominio
{
    public class Persona
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
    }
}
