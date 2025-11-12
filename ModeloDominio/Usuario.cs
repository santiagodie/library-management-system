using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.Properties
{
    public class Usuario:Persona
    {
        private EstadoUsuario estado;
        public Usuario(string id, string contraseña, string nombre, string dni) : base(id, contraseña, nombre, dni)
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
