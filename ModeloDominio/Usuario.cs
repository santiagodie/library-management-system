using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloDominio
{
    public class Usuario:Persona
    {
        public EstadoUsuario Estado {  get; private set; }
        public Usuario(string nombre, string dni) : base( nombre, dni)
        {
            Estado = EstadoUsuario.Activo;
        }
        public void SetEstado(EstadoUsuario estado) { this.Estado = estado; }
        public EstadoUsuario GetEstado()
        {
            return this.Estado;
        }

        public override string ToString() 
        {
            String info = "DATOS DEL USUARIO\n";
            info += $"Nombre: {Nombre}\n";
            info += $"Dni: {Dni}\n";
            info += $"Estado: {Estado}\n";
            return info;
        }

        public void Sancionar()
        {
            Estado = EstadoUsuario.Sancionado;
        }

        public void QuitarSancion()
        {
            Estado = EstadoUsuario.Activo;
        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (GetType() != obj.GetType()) return false;

            Usuario otro = (Usuario)obj;

            return this.Dni == otro.Dni;
        }

        public override int GetHashCode()
        {
            return Dni != null ? Dni.GetHashCode() : 0;
        }

    }
}
