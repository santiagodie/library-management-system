using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ModeloDominio
{
    public class Ejemplar
    {
        public string Localizacion {  get; set; }

        public bool Disponible { get; set; }

        public Documento Documento { get; private set; }

        public PersonalAdquisiciones Responsable { get; set; }

        public string Codigo { get; private set; }

        public Ejemplar(string Localizacion, bool Disponible, Documento Documento, PersonalAdquisiciones Responsable) 
        {
            this.Localizacion = Localizacion;
            this.Disponible = Disponible;
            this.Documento = Documento;
            this.Responsable = Responsable;
            Codigo = GenerarCodigo();
        }

        public string GenerarCodigo()
        {
            string prefijo = "DOC";
            if (Documento is Libro) prefijo = "LIB";
            else if (Documento is Audiolibro) prefijo = "AUD";

            string idDoc = "DESC";

            if (!string.IsNullOrWhiteSpace(Documento.Titulo))
            {
                string tituloLimpio = Regex.Replace(Documento.Titulo, "[^a-zA-Z0-9]", "").ToUpper();

                if (tituloLimpio.Length >= 4)
                {
                    idDoc = tituloLimpio.Substring(0, 4);
                }
                else
                {
                    idDoc = tituloLimpio.PadRight(4, 'X');
                }
            }

            string idEjemplar = Guid.NewGuid().ToString("N").Substring(0, 4).ToUpper();

            return $"{prefijo}-{idDoc}-{idEjemplar}";
        }
    }
}
