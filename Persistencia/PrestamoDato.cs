using System;
using System.Collections.Generic;
using BaseDatos;


namespace Persistencia
{
    internal class ClavePrestamo
    {
        public string IdUsuario { get; private set; }
        public DateTime FechaInicio { get; private set; }

        //PRE: idUsuario no puede ser nulo.
        //POST: crea una nueva ClavePrestamo con el id de usuario y fecha de inicio proporcionados.
        public ClavePrestamo(string idUsuario, DateTime fechaInicio)
        {
            this.IdUsuario = idUsuario;
            this.FechaInicio = fechaInicio;
        }

        //PRE: ---
        //POST: devuelve true si el objeto es una ClavePrestamo con el mismo id de usuario y fecha.
        public override bool Equals(object obj)
        {
            if (obj is ClavePrestamo other )
                 return IdUsuario == other.IdUsuario && FechaInicio.Date == other.FechaInicio.Date;
            return false;
        }

        //PRE: ---
        //POST: devuelve el código hash de esta clave compuesta.
        public override int GetHashCode()
        {
            return (IdUsuario + FechaInicio.Date.ToString()).GetHashCode();
        }

        //PRE: ---
        //POST: devuelve una representación en string de la clave en formato "IdUsuario_AAAAMMDD".
        public override string ToString()
        {
            return $"{IdUsuario}_{FechaInicio:yyyyMMdd}";
        }
    }

    internal class PrestamoDato : Entidad
    {
        private string idUsuario;
        private DateTime fechaInicio;
        private string idResponsable;  // PersonalSala que realizó el préstamo

        //PRE: idUsuario e idResponsable no pueden ser nulos.
        //POST: crea un nuevo PrestamoDato con los datos proporcionados.
        public PrestamoDato(string idUsuario, DateTime fechaInicio, string idResponsable)
        {
            this.idUsuario = idUsuario;
            this.fechaInicio = fechaInicio;
            this.idResponsable = idResponsable;
        }

        public string IdUsuario { get { return idUsuario; } }
        public DateTime FechaInicio { get { return fechaInicio; } }
        public string IdResponsable { get { return idResponsable; } }

        //PRE: ---
        //POST: devuelve la clave primaria compuesta (idUsuario, fechaInicio) de esta entidad.
        public override object ObtenerClave()
        {
            return new ClavePrestamo(idUsuario, fechaInicio);
        }

        //PRE: nombre indica el campo a modificar y dato contiene el nuevo valor.
        //POST: los datos de préstamo son inmutables. Devuelve false siempre.
        public override bool ModificarDato(string nombre, object dato)
        {
            return false;
        }

        //PRE: nombre indica el campo a obtener.
        //POST: devuelve el valor del campo indicado, o null si no existe.
        public override object ObtenerDato(string nombre)
        {
            switch (nombre)
            {
                case "IdUsuario": return idUsuario;
                case "FechaInicio": return fechaInicio;
                case "IdResponsable": return idResponsable;
                default: return null;
            }
        }
    }
}



