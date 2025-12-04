using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseDatos
{
    public class PersonalAdquisicionesDato:Entidad
    {
        private int id;
        public PersonalAdquisicionesDato(int id)
        {
            this.id = id;
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
