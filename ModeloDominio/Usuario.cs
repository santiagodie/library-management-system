using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloDominio
{
    public class Usuario : Persona
    {
        public EstadoUsuario Estado { get; private set; }

        //PRE: nombre y dni no pueden ser nulos.
        //POST: crea una instancia de Usuario con el nombre y dni indicados, estableciendo su estado inicial como Activo.
        public Usuario(string nombre, string dni) : base(nombre, dni)
        {
            Estado = EstadoUsuario.Activo;
        }

        //PRE: ---
        //POST: actualiza el estado del usuario con el valor proporcionado.
        public void SetEstado(EstadoUsuario estado) { this.Estado = estado; }

        //PRE: ---
        //POST: devuelve el estado actual del usuario.
        public EstadoUsuario GetEstado()
        {
            return this.Estado;
        }

        //PRE: ---
        //POST: devuelve una cadena con la información detallada del usuario (Nombre, Dni y Estado).
        public override string ToString()
        {
            String info = "DATOS DEL USUARIO\n";
            info += $"Nombre: {Nombre}\n";
            info += $"Dni: {Dni}\n";
            info += $"Estado: {Estado}\n";
            return info;
        }

        //PRE: ---
        //POST: cambia el estado del usuario a Sancionado.
        public void Sancionar()
        {
            Estado = EstadoUsuario.Sancionado;
        }

        //PRE: ---
        //POST: cambia el estado del usuario a Activo.
        public void QuitarSancion()
        {
            Estado = EstadoUsuario.Activo;
        }

        //PRE: ---
        //POST: devuelve true si el objeto comparado es un Usuario y tiene el mismo DNI que el actual.
        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (GetType() != obj.GetType()) return false;

            Usuario otro = (Usuario)obj;

            return this.Dni == otro.Dni;
        }

        //PRE: ---
        //POST: devuelve el código hash del objeto basado en el DNI.
        public override int GetHashCode()
        {
            return Dni != null ? Dni.GetHashCode() : 0;
        }

    }
}