using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseDatos
{
    public static class BaseDatos
    {
        //  Pongo publicas las tablas por que GetProperty() solo puede acceder a propiedades públicas, no a campos privados
        // Los seter se mantienen privados
        public static Tabla PersonaTabla { get; private set; }
        public static Tabla UsuarioTabla { get; private set; }
        public static Tabla PersonalAdquisicionesTabla { get; private set; }
        public static Tabla PersonalSalaTabla { get; private set; }
        public static Tabla DocumentoTabla { get; private set; }
        public static Tabla EjemplarTabla { get; private set; }
        public static Tabla PrestamoTabla { get; private set; }

        static BaseDatos()
        {
            PersonaTabla = new Tabla();
            UsuarioTabla = new Tabla();
            PersonalAdquisicionesTabla = new Tabla();
            PersonalSalaTabla = new Tabla();
            DocumentoTabla = new Tabla();
            EjemplarTabla = new Tabla();
            PrestamoTabla = new Tabla();
        }

        public static bool AñadirFila(string Tabla, Entidad Dato)
        {
            Tabla tabla = typeof(BaseDatos).GetProperty(Tabla).GetValue(null) as Tabla;
            return tabla.AñadirFila(Dato);
        }

        public static Entidad ObtenerDatos(string Tabla, object clave)
        {
            Tabla tabla = typeof(BaseDatos).GetProperty(Tabla).GetValue(null) as Tabla;
            return tabla.ObtenerDatos(clave);
        }

        public static bool BorrarFila(string Tabla, object clave)
        {
            Tabla tabla = typeof(BaseDatos).GetProperty(Tabla).GetValue(null) as Tabla;
            return tabla.BorrarFila(clave);
        }

        public static bool ModificarFila(string Tabla, object clave, string columna, Object dato)
        {
            Tabla tabla = typeof(BaseDatos).GetProperty(Tabla).GetValue(null) as Tabla;
            return tabla.ModificarFila(clave, columna, dato);
        }
        public static List<Entidad> ObtenerTodos(string Tabla)
        {
            Tabla tabla = typeof(BaseDatos).GetProperty(Tabla).GetValue(null) as Tabla;
            List<Entidad> resultado = new List<Entidad>();
            foreach (Entidad e in tabla)
            {
                resultado.Add(e);
            }
            return resultado;
        }
        public static bool Existe(string Tabla,object clave)
        {
            Tabla tabla = typeof(BaseDatos).GetProperty(Tabla).GetValue(null) as Tabla;
            return tabla.Existe(clave);
        }
    }
}