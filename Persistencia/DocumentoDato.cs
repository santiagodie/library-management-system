using ModeloDominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BaseDatos
{
    public class DocumentoDato:Entidad
    {
        private string ISBN;
        private string Título;
        private string Autor;
        private string Editorial;
        private string Año;
        private TipoDocumento Tipo;
        private string Formato;
        private int Duración;
        public DocumentoDato(string iSBN, string título, string autor, string editorial, string año, string formato, int duración)
        {
            ISBN = iSBN;
            Título = título;
            Autor = autor;
            Editorial = editorial;
            Año = año;
            Tipo = TipoDocumento.Audiolibro;
            Formato = formato;
            Duración = duración;   
        }
        public DocumentoDato(string iSBN, string título, string autor, string editorial, string año)
        {
            ISBN = iSBN;
            Título = título;
            Autor = autor;
            Editorial = editorial;
            Año = año;
            Tipo = TipoDocumento.Libro;
        }
        public override object ObtenerClave()
        {
            return ISBN;
        }
        public override bool ModificarDato(string nombre, Object dato)
        {
            switch (nombre)
            {
                default: return false;
            }
        }
        public override Object ObtenerDato(string nombre)
        {
            return this.GetType().GetProperty(nombre).GetValue(this);
        }
    }
}
