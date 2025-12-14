using System;

namespace BaseDatos {
    public abstract class Entidad
    {
        //PRE: ---
        //POST: devuelve la clave primaria de la entidad.
        public abstract object ObtenerClave();

        //PRE: nombre indica el campo a modificar y dato contiene el nuevo valor.
        //POST: modifica el campo indicado si es posible. Devuelve true si se modificó correctamente.
        public abstract bool ModificarDato(string nombre, Object dato);

        //PRE: nombre indica el campo a obtener.
        //POST: devuelve el valor del campo indicado, o null si no existe.
        public abstract Object ObtenerDato(string nombre);
    }
}

