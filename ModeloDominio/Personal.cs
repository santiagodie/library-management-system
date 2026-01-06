using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloDominio
{
    public abstract class Personal:Persona
    {
        public int NSS { get; private set; }
        //PRE: nombre y dni no pueden ser nulos.
        //POST: crea una instancia de Personal inicializando el nombre, dni y número de seguridad social (NSS).
        public Personal(string nombre, string dni,int NSS): base( nombre, dni)
        {
            this.NSS = NSS;
        }
        
    }
}
