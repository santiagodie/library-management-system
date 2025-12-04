using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseDatos
{
    public class UsuarioDato:Entidad
    {
        private int id;
        public UsuarioDato(string id)
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
            return this.GetType().GetProperty(nombre).GetValue(this);
        }
    }
}
