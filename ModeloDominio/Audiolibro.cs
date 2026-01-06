using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloDominio
{
    public class Audiolibro : Documento
    {
        public FormatoAudio Formato { get; set; }
        public int DuracionSegundos { get; set; }

        //PRE: Titulo, Autor, ISBN y Editorial no pueden ser nulos.
        //POST: crea una instancia de Audiolibro heredando los atributos base de Documento con los datos proporcionados.
        public Audiolibro(string Titulo, string Autor, string ISBN, string Editorial, int AñoEdicion) : base(Titulo, Autor, ISBN, Editorial, AñoEdicion)
        {
        }
    }
}