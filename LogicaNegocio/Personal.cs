using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.Properties
{
    public class Personal:Persona
    {
        private int NSS;
        public Personal(string id, string contraseña, string nombre, string dni,int NSS): base(id, contraseña, nombre, dni)
        {
            this.NSS = NSS;
        }
    }
}
