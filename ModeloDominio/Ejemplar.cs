using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloDominio
{
    public class Ejemplar
    {
        public string Localizacion {  get; set; }

        public bool Estado { get; set; }

        public Documento Documento { get; private set; }

//No guardamos ahora el personalAdquisiciones responsable de darlo de alta, se guardá, al dar de alta, al guardarlo en la base de datos
        public Ejemplar(string Localizacion, bool Estado, Documento Documento) 
        {
            this.Localizacion = Localizacion;
            this.Estado = Estado;
            this.Documento = Documento;
        }
    }
}
