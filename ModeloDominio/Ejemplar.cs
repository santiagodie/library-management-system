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

        public bool Disponible { get; set; }

        public Documento Documento { get; private set; }

        public PersonalAdquisiciones Responsable { get; set; }

        public Ejemplar(string Localizacion, bool Disponible, Documento Documento, PersonalAdquisiciones Responsable) 
        {
            this.Localizacion = Localizacion;
            this.Disponible = Disponible;
            this.Documento = Documento;
            this.Responsable = Responsable;
        }
    }
}
