using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloDominio
{
    public class Libro : Documento
    {
        //PRE: Titulo, Autor, ISBN y Editorial no pueden ser nulos.
        //POST: crea una instancia de Libro inicializando la información detallada a través del constructor de la clase base Documento.
        public Libro(string Titulo, string Autor, string ISBN, string Editorial, int AñoEdicion) : base(Titulo, Autor, ISBN, Editorial, AñoEdicion)
        {
        }
    }
}