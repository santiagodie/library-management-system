using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseDatos
{
    public class PersonalSalaDato:Entidad
    {
        private string id;
        public PersonalSalaDato(string id)
        {
            this.id = id;
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
            }
        }
    }
}
