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
    }
}
