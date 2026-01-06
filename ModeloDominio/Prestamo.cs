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

        public DateTime FechaInicio { get; set; }

        public string Id { get; set; }

        //PRE: fechaFin debe tener tamaño 2. usuario, ejemplares y responsable no pueden ser nulos.
        //POST: crea una instancia de préstamo inicializando el usuario, ejemplares, responsable y la fecha de inicio a la actual.
        public Prestamo(DateTime[] fechaFin, Usuario usuario, List<Ejemplar> ejemplares, PersonalSala responsable)
        {
            Usuario = usuario;
            EjemplaresPrestados = ejemplares;
            FechaInicio = DateTime.Now;
            FechaFin = fechaFin;
            EjemplaresDevueltos = new List<Ejemplar>();
            Responsable = responsable;
            Id = "";
        }

        //PRE: ejemplar no debe ser nulo y debe estar en la lista de ejemplares prestados.
        //POST: mueve el ejemplar de la lista de prestados a la de devueltos. Devuelve true si la operación tuvo éxito.
        public bool DevolverEjemplar(Ejemplar ejemplar)
        {
            if (!EjemplaresPrestados.Remove(ejemplar))
            {
                return false;
            }
            EjemplaresDevueltos.Add(ejemplar);
            return true;
        }

        //PRE: ---
        //POST: devuelve true si no quedan ejemplares pendientes de devolver en este préstamo.
        public bool EstaFinalizado()
        {
            return EjemplaresPrestados.Count == 0;
        }

        //PRE: ---
        //POST: devuelve una cadena con la información detallada del préstamo formateada.
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

        //PRE: ---
        //POST: devuelve true si el objeto es un préstamo con el mismo usuario y fecha de inicio.
        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (GetType() != obj.GetType()) return false;

            Prestamo otro = (Prestamo)obj;

            if (this.FechaInicio != otro.FechaInicio) return false;

            return object.Equals(this.Usuario, otro.Usuario);
        }

        //PRE: ---
        //POST: devuelve un código hash basado en el usuario y la fecha de inicio del préstamo.
        public override int GetHashCode()
        {
            int hashUsuario = (Usuario != null) ? Usuario.GetHashCode() : 0;
            int hashFecha = FechaInicio.GetHashCode();

            return (hashUsuario * 397) ^ hashFecha;
        }

        //PRE: ---
        //POST: devuelve un string con la lista de títulos de ejemplares actualmente prestados.
        public string Prestados()
        {
            string info = "";
            foreach (var ej in EjemplaresPrestados)
            {
                info += $"- {ej.Documento.Titulo}\n";
            }
            return info;
        }

        //PRE: ---
        //POST: devuelve un string con la lista de títulos de ejemplares ya devueltos.
        public string Devueltos()
        {
            string info = "";
            foreach (var ej in EjemplaresDevueltos)
            {
                info += $"- {ej.Documento.Titulo}\n";
            }
            return info;
        }

        //PRE: ---
        //POST: devuelve la lista de ejemplares de tipo Libro que aún no han sido devueltos.
        public List<Ejemplar> GetLibrosPendientes()
        {
            return EjemplaresPrestados.Where(e => e.Documento is Libro).ToList();
        }

        //PRE: ---
        //POST: devuelve la lista de ejemplares de tipo Audiolibro que aún no han sido devueltos.
        public List<Ejemplar> GetAudiosPendientes()
        {
            return EjemplaresPrestados.Where(e => e.Documento is Audiolibro).ToList();
        }

        //PRE: ---
        //POST: devuelve true si hay ejemplares de tipo Libro pendientes de devolución.
        public bool QuedanLibros()
        {
            return EjemplaresPrestados.Any(e => e.Documento is Libro);
        }

        //PRE: ---
        //POST: devuelve true si hay ejemplares de tipo Audiolibro pendientes de devolución.
        public bool QuedanAudios()
        {
            return EjemplaresPrestados.Any(e => e.Documento is Audiolibro);
        }

        //PRE: ---
        //POST: devuelve la fecha de vencimiento más próxima según los tipos de documentos pendientes.
        public DateTime FechaVencimiento
        {
            get
            {
                if (EstaFinalizado()) return DateTime.MinValue;

                bool hayLibros = QuedanLibros();
                bool hayAudios = QuedanAudios();

                if (hayLibros && hayAudios)
                {
                    return FechaFin[0] < FechaFin[1] ? FechaFin[0] : FechaFin[1];
                }

                if (hayLibros) return FechaFin[0];

                if (hayAudios) return FechaFin[1];

                return DateTime.MinValue;
            }
        }

        //PRE: ---
        //POST: devuelve true si el préstamo no ha finalizado y la fecha de vencimiento no ha pasado.
        public bool Activo
        {
            get
            {
                return !EstaFinalizado() && FechaVencimiento >= DateTime.Today;
            }
        }

        //PRE: ---
        //POST: devuelve true si el préstamo no ha finalizado y la fecha de vencimiento ya ha pasado.
        public bool Vencido
        {
            get
            {
                return !EstaFinalizado() && FechaVencimiento < DateTime.Today;
            }
        }
    }
}