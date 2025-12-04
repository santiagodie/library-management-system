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
        public PersonalDato(int id,string NSS)
        {
            this.id = id;
            this.NSS = NSS;
        }
        public override object ObtenerClave()
        {
            return id;
        }
        public override bool ModificarDato(string nombre, Object dato)
        {
            return false;
        }
        public override Object ObtenerDato(string nombre)
        {
            return this.GetType().GetProperty(nombre).GetValue(this);
        }
    }
}
