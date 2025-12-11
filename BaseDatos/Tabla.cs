using System;
using System.Collections.ObjectModel;

namespace BaseDatos
{
    public class KeyedList<TItem> : KeyedCollection<object, TItem>
    {
        public KeyedList() : base()
        {

        }
        protected override Object GetKeyForItem(TItem item)
        {
            // Este método debe ser sobrescrito en las clases derivadas
            return null;
        }
    }

    public class Tabla : KeyedList<Entidad>
    {
        public Tabla() : base()
        {
        }

        protected override object GetKeyForItem(Entidad item)
        {
            return item.ObtenerClave();
        }

        public bool AñadirFila(Entidad entidad)
        {
            if (!this.Contains(entidad.ObtenerClave()))
            {
                this.Add(entidad); 
                return true;
            }
            return false;
        }

        public Entidad ObtenerDatos(object clave)
        {
            if (this.Dictionary.TryGetValue(clave, out Entidad entidad))
            {
                return entidad;
            }
            return null;
        }

        public bool BorrarFila(object clave)
        {
            return this.Dictionary.Remove(clave);
        }

        public bool ModificarFila(object clave, string columna, Object dato)
        {
            if (this.Dictionary.TryGetValue(clave, out Entidad entidad))
            {
                return entidad.ModificarDato(columna, dato);
            }
            return false;
        }
    }
}
