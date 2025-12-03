using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseDatos
{
    public class PersonalDato:Entidad
    {
        private int id;
        private string NSS;
        public PersonalDato(string id,string NSS)
        {
            this.id = int.Parse(id);
            this.NSS = NSS;
        }
        public override string ObtenerClave()
        {
            return id.ToString();
        }
        public override bool ModificarDato(string nombre, Object dato)
        {
            return false;
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
