using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloDominio
{
    public class Prestamo
    {
        public Usuario Usuario { get; private set; }

        public List<Ejemplar> EjemplaresPrestados { get; set; }

        public List<Ejemplar> EjemplaresDevueltos { get; set; }

        public DateTime FechaFinPrevista { get; private set; }

        public DateTime? FechaFin { get; set; }

        public DateTime FechaInicio { get; private set; }
        public Prestamo(DateTime fechaFinPrevista, Usuario usuario, List<Ejemplar> ejemplares) 
        {
            Usuario = usuario;
            EjemplaresPrestados = ejemplares;
            FechaInicio = DateTime.Today;
            FechaFinPrevista = fechaFinPrevista;
            EjemplaresDevueltos = null;
            FechaFin = null;
        }

        public bool DevolverEjemplar(Ejemplar ejemplar)
        {
            if (!EjemplaresPrestados.Remove(ejemplar))
            {
                return false;
            }
            EjemplaresDevueltos.Add(ejemplar);
            return true;
        }
    }
}
