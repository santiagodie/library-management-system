using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloDominio
{
    public class Usuario:Persona
    {
        private EstadoUsuario estado;
        public Usuario(string id, string nombre, string dni) : base(id, nombre, dni)
        {
            estado = EstadoUsuario.Activo;
        }
        public void SetEstado(EstadoUsuario estado) { this.estado = estado; }
        public EstadoUsuario GetEstado()
        {
            return this.estado;
        }
    }
}
