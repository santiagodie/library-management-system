using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseDatos
{
    public class PersonalDato:Entidad
    {
        private string id;
        private string NSS;
        public PersonalDato(string id,string NSS)
        {
            this.id = id;
            this.NSS = NSS;
        }
        public override string ObtenerClave()
        {
            return id;
        }
        public override bool ModificarDato(string nombre, Object dato)
        {
            switch (nombre)
            {
                default: return false;
            }
        }
        public override Object ObtenerDato(string nombre)
        {
            switch (nombre)
            {
                case "id":
                    return id;
                case "NSS":
                    return NSS;
            }
        }
    }
}
