using BaseDatos;
using ModeloDominio;


namespace Persistencia
{

    public class DocumentoDato : Entidad
    {
        //Atributos de todos los documentos

        private string isbn; 
        private string titulo;
        private string autor;
        private string editorial;
        private int añoEdicion;
        private TipoDocumento tipo;  

        //Atributos adicionales de audiolibros, los pongo nullable porque no todos los documentos los usan

        private FormatoAudio? formato;
        private int? duracionSegundos;
          

        //PRE: isbn, titulo, autor y editorial no pueden ser nulos. año debe ser válido.
        //POST: crea un nuevo DocumentoDato de tipo Libro con los datos proporcionados.
        public DocumentoDato(string isbn, string titulo, string autor, string editorial, int año)
        {
            this.isbn = isbn;
            this.titulo = titulo; 
            this.autor = autor;
            this.editorial = editorial;
            this.añoEdicion = año;
            this.tipo = TipoDocumento.Libro;  

        }
        //PRE: isbn, titulo, autor y editorial no pueden ser nulos. añoEdicion y duracionSegundos deben ser válidos.
        //POST: crea un nuevo DocumentoDato de tipo Audiolibro con los datos proporcionados.
        public DocumentoDato(string isbn, string titulo, string autor, string editorial, int añoEdicion, FormatoAudio formato, int duracionSegundos)
        {
            this.isbn = isbn;
            this.titulo = titulo;
            this.autor = autor;
            this.editorial = editorial;
            this.añoEdicion = añoEdicion;
            this.tipo = TipoDocumento.Audiolibro;
            this.formato = formato;
            this.duracionSegundos = duracionSegundos;
        }
        public string ISBN { get { return isbn; }  }
        public string Titulo { get { return titulo; } }
        public string Autor { get { return  autor; } }
        public string Editorial { get { return editorial;  } }
        public int AñoEdicion {  get { return añoEdicion; } }
        public TipoDocumento Tipo { get { return tipo; } }
        public FormatoAudio? Formato { get { return formato; }  }
        public int? DuracionSegundos { get { return duracionSegundos; } }

        //PRE: ---
        //POST: devuelve la clave primaria (isbn) de esta entidad.
        public override object ObtenerClave()
        {
            return isbn;
        }

        //PRE: nombre indica el campo a modificar y dato contiene el nuevo valor.
        //POST: los datos de documento son inmutables. Devuelve false siempre.
        public override bool ModificarDato(string nombre, object dato)
        {
            return false;
        }

        //PRE: nombre indica el campo a obtener.
        //POST: devuelve el valor del campo indicado, o null si no existe.
        public override object ObtenerDato(string nombre)
        {
            switch (nombre)
            {
                case "ISBN":  return isbn;
                case "Titulo": return titulo;
                case "Autor": return autor;
                case "Editorial": return editorial;
                case "AñoEdicion": return añoEdicion;  
                case "Tipo": return tipo;
                case "Formato": return formato;
                case "DuracionSegundos": return duracionSegundos;
                default: return null; 
            }

        }
    }
}
