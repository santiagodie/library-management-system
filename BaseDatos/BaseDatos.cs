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
        public static Tabla PrestamoEjemplarTabla { get; private set; }

        //PRE: ---
        //POST: inicializa todas las tablas de la base de datos vacías.
        static BaseDatos()
        {
            PersonaTabla = new Tabla();
            UsuarioTabla = new Tabla();
            PersonalAdquisicionesTabla = new Tabla();
            PersonalSalaTabla = new Tabla();
            DocumentoTabla = new Tabla();
            EjemplarTabla = new Tabla();
            PrestamoTabla = new Tabla();
            PrestamoEjemplarTabla = new Tabla();
        }

        //PRE: Tabla debe ser el nombre de una tabla válida. Dato no puede ser nulo.
        //POST: añade la entidad a la tabla especificada. Devuelve true si se añadió correctamente.
        public static bool AñadirFila(string Tabla, Entidad Dato)
        {
            Tabla tabla = typeof(BaseDatos).GetProperty(Tabla).GetValue(null) as Tabla;
            return tabla.AñadirFila(Dato);
        }

        //PRE: Tabla debe ser el nombre de una tabla válida. clave no puede ser nula.
        //POST: devuelve la entidad con la clave especificada de la tabla, o null si no existe.
        public static Entidad ObtenerDatos(string Tabla, object clave)
        {
            Tabla tabla = typeof(BaseDatos).GetProperty(Tabla).GetValue(null) as Tabla;
            return tabla.ObtenerDatos(clave);
        }

        //PRE: Tabla debe ser el nombre de una tabla válida. clave no puede ser nula.
        //POST: elimina la entidad con la clave especificada de la tabla. Devuelve true si se eliminó correctamente.
        public static bool BorrarFila(string Tabla, object clave)
        {
            Tabla tabla = typeof(BaseDatos).GetProperty(Tabla).GetValue(null) as Tabla;
            return tabla.BorrarFila(clave);
        }

        //PRE: Tabla debe ser el nombre de una tabla válida. clave no puede ser nula. columna indica el campo a modificar.
        //POST: modifica el campo especificado de la entidad con la clave dada en la tabla. Devuelve true si se modificó correctamente.
        public static bool ModificarFila(string Tabla, object clave, string columna, Object dato)
        {
            Tabla tabla = typeof(BaseDatos).GetProperty(Tabla).GetValue(null) as Tabla;
            return tabla.ModificarFila(clave, columna, dato);
        }
        //PRE: Tabla debe ser el nombre de una tabla válida.
        //POST: devuelve una lista con todas las entidades de la tabla especificada.
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
        //PRE: Tabla debe ser el nombre de una tabla válida. clave no puede ser nula.
        //POST: devuelve true si existe una entidad con la clave especificada en la tabla.
        public static bool Existe(string Tabla,object clave)
        {
            Tabla tabla = typeof(BaseDatos).GetProperty(Tabla).GetValue(null) as Tabla;
            return tabla.Existe(clave);
        }
    }
}