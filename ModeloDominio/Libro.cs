using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloDominio
{
    public class Libro : Documento
    {
        public Libro(string Titulo, string Autor, string ISBN, string Editorial, int AñoEdicion) : base(Titulo, Autor, ISBN, Editorial, AñoEdicion)
        {
        }
    }
}
