using System;
using System.Collections.Generic;
using BaseDatos;


namespace Persistencia
{
    internal class ClavePrestamo
    {
        public string IdUsuario { get; private set; }
        public DateTime FechaInicio { get; private set; }

        public ClavePrestamo(string idUsuario, DateTime fechaInicio)
        {
            this.IdUsuario = idUsuario;
            this.FechaInicio = fechaInicio;
        }

        public override bool Equals(object obj)
        {
            if (obj is ClavePrestamo other)
                return IdUsuario == other.IdUsuario && FechaInicio.Date == other.FechaInicio.Date;
            return false;
        }

        public override int GetHashCode()
        {
            return (IdUsuario + FechaInicio.Date.ToString()).GetHashCode();
        }

        public override string ToString()
        {
            return $"{IdUsuario}_{FechaInicio:yyyyMMdd}";
        }
    }

    internal class PrestamoDato : Entidad
    {
        private string idUsuario;
        private DateTime fechaInicio;
        private List<string> codigosEjemplaresPrestados;
        private List<string> codigosEjemplaresDevueltos;
        private Dictionary<string, DateTime> fechasDevolucion;
        private Dictionary<string, DateTime> fechasPrevistaDevolucion;
        private string idResponsable;  // PersonalSala que realizó el préstamo

        public PrestamoDato(string idUsuario, DateTime fechaInicio, List<string> codigosEjemplares, Dictionary<string, DateTime> fechasPrevistas, string idResponsable)
        {
            this.idUsuario = idUsuario;
            this.fechaInicio = fechaInicio;
            this.codigosEjemplaresPrestados = new List<string>(codigosEjemplares);
            this.codigosEjemplaresDevueltos = new List<string>();
            this.fechasDevolucion = new Dictionary<string, DateTime>();
            this.fechasPrevistaDevolucion = fechasPrevistas;
            this.idResponsable = idResponsable;
        }

        public string IdUsuario { get { return idUsuario; } }
        public DateTime FechaInicio { get { return fechaInicio; } }
        public List<string> CodigosEjemplaresPrestados { get { return codigosEjemplaresPrestados; } }
        public List<string> CodigosEjemplaresDevueltos { get { return codigosEjemplaresDevueltos; } }
        public Dictionary<string, DateTime> FechasDevolucion { get { return fechasDevolucion; } }
        public Dictionary<string, DateTime> FechasPrevistaDevolucion { get { return fechasPrevistaDevolucion; } }
        public string IdResponsable { get { return idResponsable; } }

        public bool EstaFinalizado()
        {
            return codigosEjemplaresPrestados.Count == 0;
        }

        public bool EstaVencido()
        {
            foreach (var codigo in codigosEjemplaresPrestados)
            {
                if (fechasPrevistaDevolucion.ContainsKey(codigo))
                {
                    if (DateTime.Now.Date > fechasPrevistaDevolucion[codigo].Date)
                        return true;
                }
            }
            return false;
        }

        public override object ObtenerClave()
        {
            return new ClavePrestamo(idUsuario, fechaInicio);
        }

        public override bool ModificarDato(string nombre, object dato)
        {
            return false;
        }

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



