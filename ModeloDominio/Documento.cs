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

        public string ISBN { get; private set; }

        public string Estado { get; set; }

        public Documento(string Titulo, string ISBN, string Autor) 
        {
            this.Titulo = Titulo;
            this.Autor = Autor;
            this.ISBN = ISBN;
            Estado = "disponible";
        }
    }
}
