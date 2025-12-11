using ModeloDominio;
using BaseDatos;
using System;
using System.Collections.Generic;

namespace Persistencia
{
    internal class Transformer
    {
        // ==================== USUARIO ====================

        public static UsuarioDato ToUsuarioDato(Usuario u)
        {
            return new UsuarioDato(u.Dni, u.Nombre, u.Estado);
        }

        public static Usuario ToUsuario(UsuarioDato ud)
        {
            Usuario u = new Usuario(ud.Dni, ud.Nombre, ud.Dni);
            u.SetEstado(ud.Estado);
            return u;
        }

        // ==================== DOCUMENTO ====================

        public static DocumentoDato ToDocumentoDato(Documento d)
        {
            if (d is Audiolibro audio)
            {
                // Audiolibro tiene duración en SEGUNDOS
                return new DocumentoDato(d.ISBN, d.Titulo, d.Autor,
                                        d.Editorial, d.AñoEdicion,
                                        audio.Formato, audio.DuracionSegundos);
            }
            else // Libro
            {
                return new DocumentoDato(d.ISBN, d.Titulo, d.Autor,
                                        d.Editorial, d.AñoEdicion);
            }
        }

        public static Documento ToDocumento(DocumentoDato dd)
        {
            if (dd.Tipo == TipoDocumento.Audiolibro)
            {
                Audiolibro audio = new Audiolibro(dd.Titulo, dd.Autor, dd.ISBN,
                                                  dd.Editorial, dd.AñoEdicion);
                audio.Formato = dd.Formato.Value;
                audio.DuracionSegundos = dd.DuracionSegundos.Value;
                return audio;
            }
            else // Libro
            {
                return new Libro(dd.Titulo, dd.Autor, dd.ISBN,
                                dd.Editorial, dd.AñoEdicion);
            }
        }

        // ==================== EJEMPLAR ====================

        public static EjemplarDato ToEjemplarDato(Ejemplar e)
        {
            return new EjemplarDato(
                e.Codigo,
                e.Documento.ISBN,
                e.Prestado,
                e.Responsable.Id,
                e.Activo
            );
        }

        public static Ejemplar ToEjemplar(EjemplarDato ed)
        {
            // Reconstruir documento
            DocumentoDato docDato = BaseDatos.BaseDatos.ObtenerDatos("DocumentoTabla", ed.IsbnDocumento)
                                    as DocumentoDato;
            Documento doc = ToDocumento(docDato);

            // Reconstruir responsable
            PersonalAdquisicionesDato respDato =
                BaseDatos.BaseDatos.ObtenerDatos("PersonalAdquisicionesTabla", ed.IdResponsable)
                as PersonalAdquisicionesDato;
            PersonalAdquisiciones resp = ToPersonalAdquisiciones(respDato);

            Ejemplar ej = new Ejemplar(ed.Codigo, doc, resp);
            ej.Prestado = ed.Prestado;
            ej.Activo = ed.Activo;
            return ej;
        }

        // ==================== PRESTAMO ====================

        public static PrestamoDato ToPrestamoDato(Prestamo p)
        {
            // Extraer códigos
            List<string> codigos = new List<string>();
            Dictionary<string, DateTime> fechasPrevistas = new Dictionary<string, DateTime>();

            foreach (Ejemplar ej in p.EjemplaresPrestados)
            {
                codigos.Add(ej.Codigo);
                // Calcular fecha prevista según tipo de documento
                DateTime fechaPrevista = p.FechaInicio;
                if (ej.Documento is Libro)
                    fechaPrevista = fechaPrevista.AddDays(15);  // 15 días para libros
                else if (ej.Documento is Audiolibro)
                    fechaPrevista = fechaPrevista.AddDays(10);  // 10 días para audiolibros

                fechasPrevistas[ej.Codigo] = fechaPrevista;
            }

            return new PrestamoDato(
                p.Usuario.Dni,
                p.FechaInicio,
                codigos,
                fechasPrevistas,
                p.Responsable.Id
            );
        }

        public static Prestamo ToPrestamo(PrestamoDato pd)
        {
            // Reconstruir usuario
            UsuarioDato usuDato = BaseDatos.BaseDatos.ObtenerDatos("UsuarioTabla", pd.DniUsuario)
                                 as UsuarioDato;
            Usuario usuario = ToUsuario(usuDato);

            // Reconstruir ejemplares prestados
            List<Ejemplar> ejemplaresPrestados = new List<Ejemplar>();
            foreach (string codigo in pd.CodigosEjemplaresPrestados)
            {
                EjemplarDato ejDato = BaseDatos.BaseDatos.ObtenerDatos("EjemplarTabla", codigo)
                                     as EjemplarDato;
                ejemplaresPrestados.Add(ToEjemplar(ejDato));
            }

            // Reconstruir ejemplares devueltos
            List<Ejemplar> ejemplaresDevueltos = new List<Ejemplar>();
            foreach (string codigo in pd.CodigosEjemplaresDevueltos)
            {
                EjemplarDato ejDato = BaseDatos.BaseDatos.ObtenerDatos("EjemplarTabla", codigo)
                                     as EjemplarDato;
                ejemplaresDevueltos.Add(ToEjemplar(ejDato));
            }

            // Reconstruir responsable
            PersonalSalaDato respDato =
                BaseDatos.BaseDatos.ObtenerDatos("PersonalSalaTabla", pd.IdResponsable)
                as PersonalSalaDato;
            PersonalSala responsable = ToPersonalSala(respDato);

            Prestamo prestamo = new Prestamo(usuario, pd.FechaInicio, ejemplaresPrestados,
                                            ejemplaresDevueltos, responsable);
            return prestamo;
        }

        // ==================== PERSONAL ====================

        public static PersonalSalaDato ToPersonalSalaDato(PersonalSala p)
        {
            return new PersonalSalaDato(p.Id, p.Nombre, p.Dni, p.Usuario, p.Contraseña);
        }

        public static PersonalSala ToPersonalSala(PersonalSalaDato pd)
        {
            return new PersonalSala(pd.Id, pd.Nombre, pd.Dni, pd.Usuario, pd.Contraseña);
        }

        public static PersonalAdquisicionesDato ToPersonalAdquisicionesDato(PersonalAdquisiciones p)
        {
            return new PersonalAdquisicionesDato(p.Id, p.Nombre, p.Dni, p.Usuario, p.Contraseña);
        }

        public static PersonalAdquisiciones ToPersonalAdquisiciones(PersonalAdquisicionesDato pd)
        {
            return new PersonalAdquisiciones(pd.Id, pd.Nombre, pd.Dni, pd.Usuario, pd.Contraseña);
        }
    }
}
