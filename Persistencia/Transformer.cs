using System;
using System.Collections.Generic;
using System.Linq;
using ModeloDominio;


namespace Persistencia
{
    internal class Transformer
    {
        //----------------------------------USUARIO

        //PRE: user no puede ser nulo.
        //POST: devuelve un UsuarioDato creado a partir del Usuario.
        public static UsuarioDato ToUsuarioDato(Usuario user)
        {
            return new UsuarioDato(user.Dni, user.Estado);
        }

        //PRE: user no puede ser nulo.
        //POST: devuelve un PersonaDato creado a partir del Usuario.
        public static PersonaDato ToPersonaDatoFromUsuario(Usuario user)
        {
            return new PersonaDato(user.Nombre, user.Dni, user.HashContraseña);
        }

        //PRE: userData no puede ser nulo.
        //POST: reconstruye un Usuario a partir de UsuarioDato y PersonaDato de la BD. Devuelve null si no existe PersonaDato.
        public static Usuario ToUsuario(UsuarioDato userData)
        {
            PersonaDato personaData = BaseDatos.BaseDatos.ObtenerDatos("PersonaTabla", userData.PersonaId) as PersonaDato;
            if (personaData == null) return null;

            Usuario user = new Usuario(personaData.Nombre, personaData.Dni);
            user.SetHashContraseña(personaData.HashContraseña);
            user.SetEstado(userData.Estado);
            return user;
        }

        //--------------------------------------DOCUMENTO

        //PRE: document no puede ser nulo.
        //POST: devuelve un DocumentoDato creado a partir del Documento (Libro o Audiolibro).
        public static DocumentoDato ToDocumentoDato(Documento document)
        {
            if (document is Audiolibro audio)
                return new DocumentoDato(document.ISBN, document.Titulo, document.Autor, document.Editorial, document.AñoEdicion, audio.Formato, audio.DuracionSegundos);

            else
                return new DocumentoDato(document.ISBN, document.Titulo, document.Autor, document.Editorial, document.AñoEdicion);

        }

        //PRE: documentData no puede ser nulo.
        //POST: reconstruye un Documento (Libro o Audiolibro) a partir de DocumentoDato.
        public static Documento ToDocumento(DocumentoDato documentData)
        {
            if (documentData.Tipo == TipoDocumento.Audiolibro)
            {
                Audiolibro audio = new Audiolibro(documentData.Titulo, documentData.Autor, documentData.ISBN, documentData.Editorial, documentData.AñoEdicion);
                audio.Formato = documentData.Formato.Value;
                audio.DuracionSegundos = documentData.DuracionSegundos.Value;
                return audio;
            }
            else return new Libro(documentData.Titulo, documentData.Autor, documentData.ISBN, documentData.Editorial, documentData.AñoEdicion);

        }

        //-------------------------------EJEMPLAR

        //PRE: ejemplar no puede ser nulo.
        //POST: devuelve un EjemplarDato creado a partir del Ejemplar.
        public static EjemplarDato ToEjemplarDato(Ejemplar ejemplar)
        {
            return new EjemplarDato(ejemplar.Localizacion, ejemplar.Codigo, ejemplar.Documento.ISBN, !ejemplar.Disponible, ejemplar.Responsable.Dni, ejemplar.Activo );
        }

        //PRE: ejemplarData no puede ser nulo.
        //POST: reconstruye un Ejemplar a partir de EjemplarDato, DocumentoDato y PersonalAdquisicionesDato de la BD. Devuelve null si faltan datos.
        public static Ejemplar ToEjemplar(EjemplarDato ejemplarData)
        {
            // Reconstruir documento
            DocumentoDato documentData = BaseDatos.BaseDatos.ObtenerDatos("DocumentoTabla", ejemplarData.IsbnDocumento) as DocumentoDato;
            if (documentData == null) return null;
            Documento document = ToDocumento(documentData);

            // Reconstruir responsable
            PersonalAdquisicionesDato responsableData = BaseDatos.BaseDatos.ObtenerDatos("PersonalAdquisicionesTabla", ejemplarData.IdResponsable) as PersonalAdquisicionesDato;
            if (responsableData == null) return null;
            PersonalAdquisiciones responsable = ToPersonalAdquisiciones(responsableData);

            return new Ejemplar(ejemplarData.Codigo, ejemplarData.Localizacion, !ejemplarData.Prestado, document, responsable, ejemplarData.Activo);
        }

        //------------------------PRESTAMO

        //PRE: prestamo no puede ser nulo.
        //POST: devuelve un PrestamoDato creado a partir del Prestamo.
        public static PrestamoDato ToPrestamoDato(Prestamo prestamo)
        {
            return new PrestamoDato(prestamo.Usuario.Dni, prestamo.FechaInicio, prestamo.Responsable.Dni);
        }

        //PRE: prestamoData no puede ser nulo.
        //POST: reconstruye un Prestamo a partir de PrestamoDato y datos relacionados de la BD. Devuelve null si faltan datos críticos.
        public static Prestamo ToPrestamo(PrestamoDato prestamoData)
        {
            //Obtener usuario
            UsuarioDato userData = BaseDatos.BaseDatos.ObtenerDatos("UsuarioTabla", prestamoData.IdUsuario) as UsuarioDato;
            if (userData == null) return null;
            Usuario usuario = ToUsuario(userData);

            //Obtener responsable
            PersonalSalaDato responsableData = BaseDatos.BaseDatos.ObtenerDatos("PersonalSalaTabla", prestamoData.IdResponsable) as PersonalSalaDato;
            if (responsableData == null) return null;
            PersonalSala responsable = ToPersonalSala(responsableData);

            //Obtener todos los PrestamoEjemplar de préstamo
            List<PrestamoEjemplarDato> prestamoEjemplares = BaseDatos.BaseDatos.ObtenerTodos("PrestamoEjemplarTabla")
                .OfType<PrestamoEjemplarDato>()
                .Where(pe => pe.IdUsuario == prestamoData.IdUsuario && pe.FechaInicio.Date == prestamoData.FechaInicio.Date).ToList();

            if (prestamoEjemplares.Count == 0) return null; 


            //Reconstruir TODOS los ejemplares
            List<Ejemplar> todosLosEjemplares = new List<Ejemplar>();
            List<Ejemplar> ejemplaresYaDevueltos = new List<Ejemplar>();

            foreach (var pe in prestamoEjemplares)
            {
                EjemplarDato ejemplarData = BaseDatos.BaseDatos.ObtenerDatos("EjemplarTabla", pe.CodigoEjemplar) as EjemplarDato;
                if (ejemplarData == null) continue;
                Ejemplar ejemplar = ToEjemplar(ejemplarData);
                if (ejemplar == null) continue;
                todosLosEjemplares.Add(ejemplar);
                if (pe.FechaDevolucion != null) ejemplaresYaDevueltos.Add(ejemplar);
            }

            // Obtener fechas desde la BD (FechaPrevistaDevolucion almacenada en PrestamoEjemplarTabla)
            DateTime[] fechasFin = new DateTime[2];
            var librosPE = prestamoEjemplares.Where(pe => {
                var ej = todosLosEjemplares.FirstOrDefault(e => e.Codigo == pe.CodigoEjemplar);
                return ej?.Documento is Libro;
            });
            var audiosPE = prestamoEjemplares.Where(pe => {
                var ej = todosLosEjemplares.FirstOrDefault(e => e.Codigo == pe.CodigoEjemplar);
                return ej?.Documento is Audiolibro;
            });

            if (librosPE.Any()) fechasFin[0] = librosPE.First().FechaPrevistaDevolucion;
            if (audiosPE.Any()) fechasFin[1] = audiosPE.First().FechaPrevistaDevolucion;

            Prestamo prestamo = new Prestamo(fechasFin, usuario, todosLosEjemplares, responsable);
            prestamo.FechaInicio = prestamoData.FechaInicio;  // Restaurar la fecha original
            foreach (var ejemplar in ejemplaresYaDevueltos)
            {
                prestamo.DevolverEjemplar(ejemplar);
            }
            return prestamo;
        }
        //----------------------PRESTAMO EJEMPLAR

        //PRE: idUsuario, ejemplar y fechaPrevista no pueden ser nulos.
        //POST: devuelve un PrestamoEjemplarDato creado a partir de los datos proporcionados.
        public static PrestamoEjemplarDato ToPrestamoEjemplarDato(string idUsuario, DateTime fechaInicio, Ejemplar ejemplar, DateTime fechaPrevista, DateTime? fechaDevolucion)
        {
            return new PrestamoEjemplarDato(idUsuario, fechaInicio, ejemplar.Codigo, fechaPrevista, fechaDevolucion);
        }

        //PRE: peData no puede ser nulo.
        //POST: reconstruye un Ejemplar a partir de PrestamoEjemplarDato. Devuelve null si no existe el ejemplar en la BD.
        public static Ejemplar ToEjemplarFromPrestamoEjemplar(PrestamoEjemplarDato peData)
        {
            EjemplarDato ejemplarData = BaseDatos.BaseDatos.ObtenerDatos("EjemplarTabla", peData.CodigoEjemplar) as EjemplarDato;
            if (ejemplarData == null) return null;
            return ToEjemplar(ejemplarData);
        }

        //----------------------PERSONAL

        //PRE: personalSala no puede ser nulo.
        //POST: devuelve un PersonalSalaDato creado a partir del PersonalSala.
        public static PersonalSalaDato ToPersonalSalaDato(PersonalSala personalSala)
        {
            return new PersonalSalaDato(personalSala.Dni, personalSala.NSS.ToString());
        }

        //PRE: personalSala no puede ser nulo.
        //POST: devuelve un PersonaDato creado a partir del PersonalSala.
        public static PersonaDato ToPersonaDatoFromPersonalSala(PersonalSala personalSala)
        {
            return new PersonaDato(personalSala.Nombre, personalSala.Dni, personalSala.HashContraseña);
        }

        //PRE: personalSalaData no puede ser nulo.
        //POST: reconstruye un PersonalSala a partir de PersonalSalaDato y PersonaDato de la BD. Devuelve null si no existe PersonaDato.
        public static PersonalSala ToPersonalSala(PersonalSalaDato personalSalaData)
        {
            PersonaDato personaData = BaseDatos.BaseDatos.ObtenerDatos("PersonaTabla", personalSalaData.PersonaId) as PersonaDato;
            if (personaData == null) return null;

            int nss = 0;
            int.TryParse(personalSalaData.Nss, out nss);
            PersonalSala personalSala = new PersonalSala(personaData.Nombre, personaData.Dni, nss);
            personalSala.SetHashContraseña(personaData.HashContraseña);
            return personalSala;
        }

        //PRE: personalAdquisiciones no puede ser nulo.
        //POST: devuelve un PersonalAdquisicionesDato creado a partir del PersonalAdquisiciones.
        public static PersonalAdquisicionesDato ToPersonalAdquisicionesDato(PersonalAdquisiciones personalAdquisiciones)
        {
            return new PersonalAdquisicionesDato(personalAdquisiciones.Dni, personalAdquisiciones.NSS.ToString());
        }

        //PRE: personalAdquisiciones no puede ser nulo.
        //POST: devuelve un PersonaDato creado a partir del PersonalAdquisiciones.
        public static PersonaDato ToPersonaDatoFromPersonalAdquisiciones(PersonalAdquisiciones personalAdquisiciones)
        {
            return new PersonaDato(personalAdquisiciones.Nombre, personalAdquisiciones.Dni, personalAdquisiciones.HashContraseña);
        }

        //PRE: personalAdquisicionesData no puede ser nulo.
        //POST: reconstruye un PersonalAdquisiciones a partir de PersonalAdquisicionesDato y PersonaDato de la BD. Devuelve null si no existe PersonaDato.
        public static PersonalAdquisiciones ToPersonalAdquisiciones(PersonalAdquisicionesDato personalAdquisicionesData)
        {
            PersonaDato personaData = BaseDatos.BaseDatos.ObtenerDatos("PersonaTabla", personalAdquisicionesData.PersonaId) as PersonaDato;
            if (personaData == null) return null;
            int nss = 0;
            int.TryParse(personalAdquisicionesData.Nss, out nss);
            PersonalAdquisiciones pa = new PersonalAdquisiciones(personaData.Nombre, personaData.Dni, nss);
            pa.SetHashContraseña(personaData.HashContraseña);
            return pa;
        }

       
    }
}