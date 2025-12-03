using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseDatos
{
    public static class BaseDatos
    {
        private static Tabla PersonalTabla;
        private static Tabla Personatabla;
        private static Tabla UsuarioTabla;
        private static Tabla PersonalAdquisicionesTabla;
        private static Tabla PersonalSalaTabla;
        private static Tabla DocumentoTabla;
        static BaseDatos()
        {
            PersonalTabla = new Tabla();
            Personatabla = new Tabla();
            UsuarioTabla = new Tabla();
            PersonalAdquisicionesTabla = new Tabla();
            PersonalSalaTabla = new Tabla();
            DocumentoTabla = new Tabla();
        }
        public static bool AñadirFila(string Tabla,Entidad Dato)
        {
            Tabla tabla = typeof(BaseDatos).GetProperty(Tabla).GetValue(null) as Tabla;
            return tabla.AñadirFila(Dato);
        }
        public static Entidad ObtenerDatos(string Tabla,string clave)
        {
            Tabla tabla = this.GetType().GetProperty(Tabla);
            return tabla.ObtenerDatos(clave);
        }
        public static bool BorrarFila(string Tabla,string clave)
        {
            Tabla tabla = typeof(BaseDatos).GetProperty(Tabla).GetValue(null) as Tabla;
            return tabla.BorrarFila(clave);
        }
        public static bool ModificarFila(string Tabla,string clave,string columna,Object dato)
        {
            Tabla tabla = typeof(BaseDatos).GetProperty(Tabla).GetValue(null) as Tabla;
            return tabla.ModificarFila(clave,columna,dato);    
        }
    }
}
