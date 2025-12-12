using System;
using System.Collections.Generic;
using BaseDatos;


namespace Persistencia
{
    internal class ClavePrestamo
    {
        public string DniUsuario { get; private set; }
        public DateTime FechaInicio { get; private set; }

        public ClavePrestamo(string dniUsuario, DateTime fechaInicio)
        {
            this.DniUsuario = dniUsuario;
            this.FechaInicio = fechaInicio;
        }

        public override bool Equals(object obj)
        {
            if (obj is ClavePrestamo other)
                return DniUsuario == other.DniUsuario && FechaInicio.Date == other.FechaInicio.Date;
            return false;
        }

        public override int GetHashCode()
        {
            return (DniUsuario + FechaInicio.Date.ToString()).GetHashCode();
        }

        public override string ToString()
        {
            return $"{DniUsuario}_{FechaInicio:yyyyMMdd}";
        }
    }

    internal class PrestamoDato : Entidad
    {
        private string dniUsuario;
        private DateTime fechaInicio;
        private List<string> codigosEjemplaresPrestados;
        private List<string> codigosEjemplaresDevueltos;
        private Dictionary<string, DateTime> fechasDevolucion; 
        private Dictionary<string, DateTime> fechasPrevistaDevolucion;  
        private string idResponsable;  // PersonalSala que realizó el préstamo

        public PrestamoDato(string dniUsuario, DateTime fechaInicio, List<string> codigosEjemplares, Dictionary<string, DateTime> fechasPrevistas, string idResponsable)
        {
            this.dniUsuario = dniUsuario;
            this.fechaInicio = fechaInicio;
            this.codigosEjemplaresPrestados = new List<string>(codigosEjemplares);
            this.codigosEjemplaresDevueltos = new List<string>();
            this.fechasDevolucion = new Dictionary<string, DateTime>();
            this.fechasPrevistaDevolucion = fechasPrevistas;
            this.idResponsable = idResponsable;
        }

        public string DniUsuario { get { return dniUsuario; } }
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
            return new ClavePrestamo(dniUsuario, fechaInicio);
        }

        public override bool ModificarDato(string nombre, object dato)
        {
            return false;
        }

        public override object ObtenerDato(string nombre)
        {
            switch (nombre)
            {
                case "DniUsuario": return dniUsuario;
                case "FechaInicio": return fechaInicio;
                case "IdResponsable": return idResponsable;
                default: return null;
            }
        }
    }
}



