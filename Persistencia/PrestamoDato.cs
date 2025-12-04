using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    public class ClavePrestamo
    {
        public int idUsuario { get;private set };
        public DateTime FechaInicio { get; private set; }
        public ClavePrestamo(int id,DateTime fechaInicio)
        {
            this.idUsuario = id;
            this.FechaInicio = fechaInicio;
        }
    }
    public class PrestamoDato:Entidad
    {
        private int idUsuario;
        private DateTime FechaInicio;
        private List<int> EjemplaresPrestados;
        private List<int> EjemplaresDevueltos;
        private DateTime[] FechaFin;
        private int idResponsable;
        public PrestamoDato(int id,DateTime fechainicio,List<int> ejemplares,int responsable)
        {
            idUsuario = id;
            FechaInicio= fechainicio;
            EjemplaresPrestados = ejemplares;
            idResponsable = responsable;
        }
        public override object ObtenerClave()
        {
            return new ClavePrestamo(idUsuario,FechaInicio);
        }
        public override bool ModificarDato(string nombre, Object dato)
        {
            if (nombre != "idUsuario" && nombre != "FechaInicio" && nombre != "idResponsable")
            {
                this.GetType().GetProperty(nombre).SetValue(this, dato);
                return true;
            }
            return false;
        }
        public override Object ObtenerDato(string nombre)
        {
            return this.GetType().GetProperty(nombre).GetValue(this);
        }
    }
}
