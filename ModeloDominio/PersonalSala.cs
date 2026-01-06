using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloDominio
{
    public class PersonalSala : Personal
    {
        //PRE: nombre y dni no pueden ser nulos.
        //POST: crea una instancia de PersonalSala inicializando los datos de nombre, dni y NSS heredados de Personal.
        public PersonalSala(string nombre, string dni, int NSS) : base(nombre, dni, NSS)
        {
        }
    }
}