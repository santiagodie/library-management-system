using System;
using System.Collections.Generic;
using ModeloDominio;


namespace Persistencia
{
    internal class Transformer
    {
        //----------------------------------USUARIO

        public static UsuarioDato ToUsuarioDato(Usuario user)
        {
            return new UsuarioDato(user.Id, user.Estado);
        }

        public static PersonaDato ToPersonaDatoFromUsuario(Usuario user)
        {
            return new PersonaDato(user.Id, user.Nombre, user.Dni, user.HashContraseña);
        }

        public static Usuario ToUsuario(UsuarioDato userData)
        {
            PersonaDato personaData = BaseDatos.BaseDatos.ObtenerDatos("PersonaTabla", userData.PersonaId) as PersonaDato;
            if (personaData == null) return null;

            Usuario user = new Usuario(personaData.Id, personaData.Nombre, personaData.Dni);
            user.SetHashContraseña(personaData.HashContraseña);
            user.SetEstado(userData.Estado);
            return user;
        }

        //--------------------------------------DOCUMENTO

        public static DocumentoDato ToDocumentoDato(Documento document)
        {
            if (document is Audiolibro audio) 
                return new DocumentoDato(document.ISBN, document.Titulo, document.Autor, document.Editorial, document.AñoEdicion, audio.Formato, audio.DuracionSegundos);
            
            else 
                return new DocumentoDato(document.ISBN, document.Titulo, document.Autor, document.Editorial, document.AñoEdicion);
            
        }

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

        public static EjemplarDato ToEjemplarDato(Ejemplar ejemplar)
        {
            return new EjemplarDato( ejemplar.Codigo, ejemplar.Documento.ISBN, !ejemplar.Disponible, ejemplar.Responsable.Id, ejemplar.Activo );
        }

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

            // Localización como vacio de momento
            return new Ejemplar(ejemplarData.Codigo, "", !ejemplarData.Prestado, document, responsable, ejemplarData.Activo);
        }

        //------------------------PRESTAMO 

        public static PrestamoDato ToPrestamoDato(Prestamo prestamo)
        {
            List<string> codigos = new List<string>();
            Dictionary<string, DateTime> fechasPrevistas = new Dictionary<string, DateTime>();

            foreach (Ejemplar ejemplar in prestamo.EjemplaresPrestados)
            {
                codigos.Add(ejemplar.Codigo);
                DateTime fechaPrevista;
                if (ejemplar.Documento is Libro) fechaPrevista = prestamo.FechaInicio.AddDays(15);
                else fechaPrevista = prestamo.FechaInicio.AddDays(10);

                fechasPrevistas[ejemplar.Codigo] = fechaPrevista;
            }
            return new PrestamoDato(prestamo.Usuario.Id,prestamo.FechaInicio,codigos,fechasPrevistas,prestamo.Responsable.Id);
        }

        public static Prestamo ToPrestamo(PrestamoDato prestamoData)
        {

            UsuarioDato userData = BaseDatos.BaseDatos.ObtenerDatos("UsuarioTabla", prestamoData.IdUsuario) as UsuarioDato;
            if (userData == null) return null;
            Usuario usuario = ToUsuario(userData);
            List<Ejemplar> ejemplaresPrestados = new List<Ejemplar>();
            foreach (string codigo in prestamoData.CodigosEjemplaresPrestados)
            {
                EjemplarDato ejemplarData = BaseDatos.BaseDatos.ObtenerDatos("EjemplarTabla", codigo) as EjemplarDato;
                if (ejemplarData == null) return null;
                Ejemplar ejemplar = ToEjemplar(ejemplarData);
                if (ejemplar == null) return null;
                ejemplaresPrestados.Add(ejemplar);
            }

            PersonalSalaDato responsableData = BaseDatos.BaseDatos.ObtenerDatos("PersonalSalaTabla", prestamoData.IdResponsable) as PersonalSalaDato;
            if (responsableData == null) return null;
            PersonalSala responsable = ToPersonalSala(responsableData);

            DateTime[] fechasFin = new DateTime[2];
            foreach (var ejemplar in ejemplaresPrestados)
            {
                if (ejemplar.Documento is Libro) fechasFin[0] = prestamoData.FechaInicio.AddDays(15);
                else fechasFin[1] = prestamoData.FechaInicio.AddDays(10);
            }

            Prestamo prestamo = new Prestamo(fechasFin, usuario, ejemplaresPrestados, responsable);
            prestamo.FechaInicio = prestamoData.FechaInicio;  // Restaurar la fecha original
            foreach (string codigo in prestamoData.CodigosEjemplaresDevueltos)
            {
                EjemplarDato ejemplarData = BaseDatos.BaseDatos.ObtenerDatos("EjemplarTabla", codigo) as EjemplarDato;
                if (ejemplarData == null) continue; 
                Ejemplar ejemplar = ToEjemplar(ejemplarData);
                if (ejemplar == null) continue; 
                prestamo.DevolverEjemplar(ejemplar);
            }

            return prestamo;
        }

        //----------------------PERSONAL

        public static PersonalSalaDato ToPersonalSalaDato(PersonalSala personalSala)
        {
            return new PersonalSalaDato(personalSala.Id, personalSala.NSS.ToString());
        }

        public static PersonaDato ToPersonaDatoFromPersonalSala(PersonalSala personalSala)
        {
            return new PersonaDato(personalSala.Id, personalSala.Nombre, personalSala.Dni, personalSala.HashContraseña);
        }

        public static PersonalSala ToPersonalSala(PersonalSalaDato personalSalaData)
        {
            PersonaDato personaData = BaseDatos.BaseDatos.ObtenerDatos("PersonaTabla", personalSalaData.PersonaId) as PersonaDato;
            if (personaData == null) return null;

            int nss = 0;
            int.TryParse(personalSalaData.Nss, out nss);
            PersonalSala personalSala = new PersonalSala(personaData.Id, personaData.Nombre, personaData.Dni, nss);
            personalSala.SetHashContraseña(personaData.HashContraseña);
            return personalSala;
        }

        public static PersonalAdquisicionesDato ToPersonalAdquisicionesDato(PersonalAdquisiciones personalAdquisiciones)
        {
            return new PersonalAdquisicionesDato(personalAdquisiciones.Id, personalAdquisiciones.NSS.ToString());
        }

        public static PersonaDato ToPersonaDatoFromPersonalAdquisiciones(PersonalAdquisiciones personalAdquisiciones)
        {
            return new PersonaDato(personalAdquisiciones.Id, personalAdquisiciones.Nombre, personalAdquisiciones.Dni, personalAdquisiciones.HashContraseña);
        }

        public static PersonalAdquisiciones ToPersonalAdquisiciones(PersonalAdquisicionesDato personalAdquisicionesData)
        {
            PersonaDato personaData = BaseDatos.BaseDatos.ObtenerDatos("PersonaTabla", personalAdquisicionesData.PersonaId) as PersonaDato;
            if (personaData == null) return null;
            int nss = 0;
            int.TryParse(personalAdquisicionesData.Nss, out nss);
            PersonalAdquisiciones pa = new PersonalAdquisiciones(personaData.Id, personaData.Nombre, personaData.Dni, nss);
            pa.SetHashContraseña(personaData.HashContraseña);
            return pa;
        }
    }
}