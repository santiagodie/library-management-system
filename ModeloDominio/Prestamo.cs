using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloDominio
{
    public class Prestamo
    {
        public DateTime FechaFinPrevista { get; private set; }

        public DateTime? FechaFin { get; set; }

        public DateTime FechaInicio { get; private set; }
        public Prestamo(DateTime FechaFinPrevista) 
        {
            FechaInicio = DateTime.Today;
            this.FechaFinPrevista = FechaFinPrevista;
            FechaFin = null;
        }
    }
}
