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

        public List<Ejemplar> EjemplaresPrestados { get; private set; }

        public List<Ejemplar> EjemplaresDevueltos { get; private set; }

        public DateTime[] FechaFin { get; private set; } = new DateTime[2]; // 0: fecha para libros; 1: fecha para audiolibros

        public PersonalSala Responsable { get; private set; }

        public DateTime FechaInicio { get; set; }//Puse public el seter, porque cuando se reconstruye con el transformer necesitamos poner la fecha original

        //Pre: fechaFinPrevista debe tener tamaño 2
        public Prestamo(DateTime[] fechaFin, Usuario usuario, List<Ejemplar> ejemplares, PersonalSala responsable)
        {
            Usuario = usuario;
            EjemplaresPrestados = ejemplares;
            FechaInicio = DateTime.Today;
            FechaFin = fechaFin;
            EjemplaresDevueltos = new List<Ejemplar>();
            Responsable = responsable;
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

        public bool EstaFinalizado()
        {
            return EjemplaresPrestados.Count == 0;
        }

        public override string ToString()
        {
            string info = "DATOS DEL PRÉSTAMO\n";
            info += $"Usuario: {Usuario.Nombre} (DNI: {Usuario.Dni})\n";
            info += $"Fecha Inicio: {FechaInicio.ToShortDateString()}\n";

            if (FechaFin[0] != DateTime.MinValue) info += $"Fecha Fin (Libros): {FechaFin[0].ToShortDateString()}\n";
            if (FechaFin[1] != DateTime.MinValue) info += $"Fecha Fin (Audiolibros): {FechaFin[1].ToShortDateString()}\n";

            info += $"Realizado por: {Responsable.Nombre}\n";

            info += $"Estado: ";
            if (EstaFinalizado()) info += "Finalizado\n";
            else info += "En Proceso";


            info += "\nDocumentos Prestados:\n" + Prestados() + Devueltos();


            if (!EstaFinalizado())
            {
                info += "\nDocumentos por devolver:\n" + Prestados();
            }

            return info;
        }

        public string Prestados()
        {
            string info = "";
            foreach (var ej in EjemplaresPrestados)
            {
                info += $"- {ej.Documento.Titulo}\n";
            }
            return info;
        }

        public string Devueltos()
        {
            string info = "";
            foreach (var ej in EjemplaresDevueltos)
            {
                info += $"- {ej.Documento.Titulo}\n";
            }
            return info;
        }

        public List<Ejemplar> GetLibrosPendientes()
        {
            return EjemplaresPrestados.Where(e => e.Documento is Libro).ToList();
        }

        public List<Ejemplar> GetAudiosPendientes()
        {
            return EjemplaresPrestados.Where(e => e.Documento is Audiolibro).ToList();
        }

        public bool QuedanLibros()
        {
            return EjemplaresPrestados.Any(e => e.Documento is Libro);
        }

        public bool QuedanAudios()
        {
            return EjemplaresPrestados.Any(e => e.Documento is Audiolibro);
        }
    }
}
