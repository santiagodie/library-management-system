using System;
using BaseDatos;

namespace Persistencia
{
    internal class ClavePrestamoEjemplar
    {
        public string IdUsuario { get; private set; }
        public DateTime FechaInicio { get; private set; }
        public string CodigoEjemplar { get; private set; }

        //PRE: idUsuario y codigoEjemplar no pueden ser nulos.
        //POST: crea una nueva ClavePrestamoEjemplar con el id de usuario, fecha de inicio y código de ejemplar proporcionados.
        public ClavePrestamoEjemplar(string idUsuario, DateTime fechaInicio, string codigoEjemplar)
        {
            this.IdUsuario = idUsuario;
            this.FechaInicio = fechaInicio;
            this.CodigoEjemplar = codigoEjemplar;
        }

        //PRE: ---
        //POST: devuelve true si el objeto es una ClavePrestamoEjemplar con el mismo id de usuario, fecha y código de ejemplar.
        public override bool Equals(object obj)
        {
            if (obj is ClavePrestamoEjemplar other)
                return IdUsuario == other.IdUsuario && FechaInicio.Date == other.FechaInicio.Date && CodigoEjemplar == other.CodigoEjemplar;

            return false;
        }

        //PRE: ---
        //POST: devuelve el código hash de esta clave compuesta.
        public override int GetHashCode()
        {
            return (IdUsuario + FechaInicio.Date.ToString() + CodigoEjemplar).GetHashCode();
        }

        //PRE: ---
        //POST: devuelve una representación en string de la clave en formato "IdUsuario_AAAAMMDD_CodigoEjemplar".
        public override string ToString()
        {
            return $"{IdUsuario}_{FechaInicio:yyyyMMdd}_{CodigoEjemplar}";
        }
    }
    internal class PrestamoEjemplarDato : Entidad
    {
        private string idUsuario;
        private DateTime fechaInicio;
        private string codigoEjemplar;
        private DateTime fechaPrevistaDevolucion;
        private DateTime? fechaDevolucion;

        //PRE: idUsuario y codigoEjemplar no pueden ser nulos.
        //POST: crea un nuevo PrestamoEjemplarDato con los datos proporcionados.
        public PrestamoEjemplarDato(string idUsuario, DateTime fechaInicio, string codigoEjemplar,
                                    DateTime fechaPrevistaDevolucion, DateTime? fechaDevolucion)
        {
            this.idUsuario = idUsuario;
            this.fechaInicio = fechaInicio;
            this.codigoEjemplar = codigoEjemplar;
            this.fechaPrevistaDevolucion = fechaPrevistaDevolucion;
            this.fechaDevolucion = fechaDevolucion;
        }

        public string IdUsuario { get { return idUsuario; } }
        public DateTime FechaInicio { get { return fechaInicio; } }
        public string CodigoEjemplar { get { return codigoEjemplar; } }
        public DateTime FechaPrevistaDevolucion { get { return fechaPrevistaDevolucion; } }
        public DateTime? FechaDevolucion { get { return fechaDevolucion; } }

        //PRE: ---
        //POST: devuelve la clave primaria compuesta (idUsuario, fechaInicio, codigoEjemplar) de esta entidad.
        public override object ObtenerClave()
        {
            return new ClavePrestamoEjemplar(idUsuario, fechaInicio, codigoEjemplar);
        }

        //PRE: nombre indica el campo a modificar y dato contiene el nuevo valor.
        //POST: permite modificar FechaDevolucion. Devuelve true si se modificó correctamente.
        public override bool ModificarDato(string nombre, object dato)
        {
            if (nombre == "FechaDevolucion")
            {
                fechaDevolucion = (DateTime?)dato;
                return true;
            }
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
                case "CodigoEjemplar": return codigoEjemplar;
                case "FechaPrevistaDevolucion": return fechaPrevistaDevolucion;
                case "FechaDevolucion": return fechaDevolucion;
                default: return null;
            }
        }
    }
}
