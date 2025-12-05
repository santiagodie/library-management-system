using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloDominio
{
    public class Documento
    {
        public string Titulo { get; private set; }

        public string Autor { get; private set; }

        public string Editorial { get; private set; }

        public int AñoEdicion {  get; private set; }

        public string ISBN { get; private set; }

        public Documento(string Titulo, string Autor, string ISBN, string Editorial, int AñoEdicion) 
        {
            this.Titulo = Titulo;
            this.Autor = Autor;
            this.ISBN = ISBN;
            this.Editorial = Editorial;
            this.AñoEdicion = AñoEdicion;
        }

        public Documento(string titulo, string iSBN, string autor)
        {
            Titulo = titulo;
            ISBN = iSBN;
            Autor = autor;
        }
    }
}
