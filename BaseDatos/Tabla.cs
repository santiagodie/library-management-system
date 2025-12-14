using System;
using System.Collections.ObjectModel;

namespace BaseDatos
{
    public class KeyedList<TItem> : KeyedCollection<object, TItem>
    {
        //PRE: ---
        //POST: crea una nueva colección indexada por clave.
        public KeyedList() : base()
        {

        }

        //PRE: item no puede ser nulo.
        //POST: devuelve la clave del item. Las clases derivadas deben sobrescribir este método.
        protected override Object GetKeyForItem(TItem item)
        {
            // Este método debe ser sobrescrito en las clases derivadas
            return null;
        }
    }

    public class Tabla : KeyedList<Entidad>
    {
        //PRE: ---
        //POST: crea una nueva tabla vacía.
        public Tabla() : base()
        {
        }

        //PRE: item no puede ser nulo.
        //POST: devuelve la clave primaria de la entidad.
        protected override object GetKeyForItem(Entidad item)
        {
            return item.ObtenerClave();
        }

        //PRE: entidad no puede ser nula.
        //POST: añade la entidad a la tabla si no existe ya. Devuelve true si se añadió correctamente.
        public bool AñadirFila(Entidad entidad)
        {
            if (!this.Contains(entidad.ObtenerClave()))
            {
                this.Add(entidad);
                return true;
            }
            return false;
        }

        //PRE: clave no puede ser nula.
        //POST: devuelve la entidad con la clave especificada, o null si no existe.
        public Entidad ObtenerDatos(object clave)
        {
            if (this.Dictionary.TryGetValue(clave, out Entidad entidad))
            {
                return entidad;
            }
            return null;
        }

        //PRE: clave no puede ser nula.
        //POST: elimina la entidad con la clave especificada. Devuelve true si se eliminó correctamente.
        public bool BorrarFila(object clave)
        {
            return this.Dictionary.Remove(clave);
        }

        //PRE: clave no puede ser nula. columna indica el campo a modificar.
        //POST: modifica el campo especificado de la entidad con la clave dada. Devuelve true si se modificó correctamente.
        public bool ModificarFila(object clave, string columna, Object dato)
        {
            if (this.Dictionary.TryGetValue(clave, out Entidad entidad))
            {
                return entidad.ModificarDato(columna, dato);
            }
            return false;
        }
        //PRE: clave no puede ser nula.
        //POST: devuelve true si existe una entidad con la clave especificada en la tabla.
        public bool Existe(object clave)
        {
            return this.Contains(clave);
        }
    }
}
