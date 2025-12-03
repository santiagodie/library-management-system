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
        public PersonalAdquisicionesDato(string id)
        {
            this.id = int.Parse(id);
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
            }
        }
    }
}
