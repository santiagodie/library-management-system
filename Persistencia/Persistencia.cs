using ModeloDominio;
using BaseDatos;
using System;
using System.Collections.Generic;
using System.Linq;


namespace Persistencia
{
    public static class Persistencia
    {
        // ------------- GESTIÓN DE PERSONAS

        //PRE: dni no puede ser nulo.
        //POST: devuelve true si existe una persona con ese dni en la BD.
        public static bool ExistePersona(string dni)
        {
            return BaseDatos.BaseDatos.Existe("PersonaTabla", dni);
        }

        // ------------- GESTIÓN DE USUARIOS

        //PRE: dni no puede ser nulo.
        //POST: devuelve true si existe un usuario con ese dni en la BD.
        public static bool ExisteUsuario(string dni)
        {
            return BaseDatos.BaseDatos.Existe("PersonaTabla", dni) && BaseDatos.BaseDatos.Existe("UsuarioTabla", dni);
        }

        //PRE: usuario no puede ser nulo y no debe existir previamente en la BD.
        //POST: da de alta al usuario en PersonaTabla y UsuarioTabla. Devuelve true si tuvo éxito.
        public static bool AltaUsuario(Usuario usuario)
        {
            PersonaDato personaData = Transformer.ToPersonaDatoFromUsuario(usuario);
            if (!BaseDatos.BaseDatos.AñadirFila("PersonaTabla", personaData)) return false;
            return BaseDatos.BaseDatos.AñadirFila("UsuarioTabla", Transformer.ToUsuarioDato(usuario));
        }


        //PRE: usuario no puede ser nulo y debe existir en la BD.
        //POST: marca el usuario como Inactivo (baja lógica). Devuelve true si tuvo éxito.
        public static bool BajaUsuario(Usuario usuario)
        {
            return BaseDatos.BaseDatos.ModificarFila("UsuarioTabla", usuario.Dni, "Estado", EstadoUsuario.Inactivo);
        }

        //PRE: usuario no puede ser nulo y debe existir en la BD.
        //POST: actualiza los datos del usuario en PersonaTabla y UsuarioTabla. Devuelve true si tuvo éxito.
        public static bool ActualizarUsuario(Usuario usuario)
        {
            // Actualizar PersonaTabla
            BaseDatos.BaseDatos.BorrarFila("PersonaTabla", usuario.Dni);
            PersonaDato personaData = Transformer.ToPersonaDatoFromUsuario(usuario);
            if (!BaseDatos.BaseDatos.AñadirFila("PersonaTabla", personaData)) return false;

            // Actualizar UsuarioTabla (PersonaId = Dni porque UsuarioDato.PersonaId apunta a PersonaDato cuya clave es Dni)
            BaseDatos.BaseDatos.BorrarFila("UsuarioTabla", usuario.Dni);
            return BaseDatos.BaseDatos.AñadirFila("UsuarioTabla", Transformer.ToUsuarioDato(usuario));
        }

        //PRE: dni no puede ser nulo.
        //POST: devuelve el usuario con ese dni. Si no existe, devuelve null.
        public static Usuario GetUsuario(string dni)
        {
            // UsuarioDato.PersonaId apunta a PersonaDato cuya clave es Dni
            UsuarioDato userData = BaseDatos.BaseDatos.ObtenerDatos("UsuarioTabla", dni) as UsuarioDato;
            if (userData == null) return null;
            return Transformer.ToUsuario(userData);
        }

        //PRE: ---
        //POST: devuelve una lista con todos los usuarios de la BD.
        public static List<Usuario> GetListaUsuarios()
        {
            return BaseDatos.BaseDatos.ObtenerTodos("UsuarioTabla")
                .OfType<UsuarioDato>()
                .Select(userData => Transformer.ToUsuario(userData))
                .ToList();
        }

        // ------------- GESTIÓN DE PRÉSTAMOS

        //PRE: prestamo no puede ser nulo y no debe existir previamente en la BD.
        //POST: da de alta el préstamo. Devuelve true si tuvo éxito.
        public static bool AltaPrestamo(Prestamo prestamo)
        {
            return BaseDatos.BaseDatos.AñadirFila("PrestamoTabla", Transformer.ToPrestamoDato(prestamo));
        }

        //PRE: prestamo no puede ser nulo y debe existir en la BD.
        //POST: actualiza el préstamo y la disponibilidad de los ejemplares. Devuelve true si tuvo éxito.
        public static bool ActualizarPrestamo(Prestamo prestamo)
        {
            // PrestamoDato.IdUsuario es el dni del usuario
            ClavePrestamo clave = new ClavePrestamo(prestamo.Usuario.Dni, prestamo.FechaInicio);
            BaseDatos.BaseDatos.BorrarFila("PrestamoTabla", clave); 

            PrestamoDato prestamoData = Transformer.ToPrestamoDato(prestamo); 

            foreach (Ejemplar ejemplar in prestamo.EjemplaresPrestados)
            {
                BaseDatos.BaseDatos.ModificarFila("EjemplarTabla", ejemplar.Codigo, "Prestado", true); 
            }

            foreach (Ejemplar ejemplar in prestamo.EjemplaresDevueltos)
            {
                 BaseDatos.BaseDatos.ModificarFila("EjemplarTabla", ejemplar.Codigo, "Prestado", false); 
            }

            return BaseDatos.BaseDatos.AñadirFila("PrestamoTabla", prestamoData);
        }

        //PRE: ejemplar no puede ser nulo.
        //POST: devuelve el préstamo activo que contiene ese ejemplar. Si no existe, devuelve null.
        public static Prestamo GetPrestamoActivo(Ejemplar ejemplar)
        {
            PrestamoDato prestamoData = BaseDatos.BaseDatos.ObtenerTodos("PrestamoTabla")
                .OfType<PrestamoDato>()
                .FirstOrDefault(pd => !pd.EstaFinalizado() && pd.CodigosEjemplaresPrestados.Contains(ejemplar.Codigo));

            return prestamoData != null ? Transformer.ToPrestamo(prestamoData) :  null;
        }

        //PRE: ---
        //POST: devuelve una lista con todos los préstamos de la BD.
        public static List<Prestamo> GetPrestamos()
        {
            return BaseDatos.BaseDatos.ObtenerTodos("PrestamoTabla")
                .OfType<PrestamoDato>()
                .Select(prestamoData => Transformer.ToPrestamo(prestamoData) )
                .ToList();
        }

        //PRE: usuario no puede ser nulo.
        //POST: devuelve una lista con todos los préstamos del usuario.
        public static List<Prestamo> GetPrestamos(Usuario usuario)
        {
            return BaseDatos.BaseDatos.ObtenerTodos("PrestamoTabla")
                .OfType<PrestamoDato>()
                .Where(prestamoData => prestamoData.IdUsuario == usuario.Dni)
                .Select(prestamoData => Transformer.ToPrestamo(prestamoData))
                .ToList();
        }

        //PRE: documento no puede ser nulo.
        //POST: devuelve una lista con todos los préstamos que contienen ejemplares de ese documento.
        public static List<Prestamo> GetPrestamos(Documento documento)
        {
            return BaseDatos.BaseDatos.ObtenerTodos("PrestamoTabla")
                .OfType<PrestamoDato>()
                .Select(prestamoData => Transformer.ToPrestamo(prestamoData))
                .Where(prestamo =>
                    prestamo.EjemplaresPrestados.Any(ejemplar => ejemplar.Documento.ISBN == documento.ISBN) ||
                    prestamo.EjemplaresDevueltos.Any(ejemplar => ejemplar.Documento.ISBN == documento.ISBN))
                .ToList();
        }

        //PRE: usuario no puede ser nulo y fecha debe ser válida.
        //POST: devuelve una lista con todos los préstamos del usuario en esa fecha.
        public static List<Prestamo> GetPrestamos(Usuario usuario, DateTime fecha)
        {
            return BaseDatos.BaseDatos.ObtenerTodos("PrestamoTabla")
                .OfType<PrestamoDato>()
                .Where(prestamoData => prestamoData.IdUsuario == usuario.Dni && prestamoData.FechaInicio.Date == fecha.Date)
                .Select(prestamoData => Transformer.ToPrestamo(prestamoData))
                .ToList();
        }

        //PRE: usuario y documento no pueden ser nulos.
        //POST: devuelve una lista con todos los préstamos del usuario que contienen ejemplares de ese documento.
        public static List<Prestamo> GetPrestamos(Usuario usuario, Documento documento)
        {
            return BaseDatos.BaseDatos.ObtenerTodos( "PrestamoTabla")
                .OfType<PrestamoDato>()
                .Where(prestamoData => prestamoData.IdUsuario == usuario.Dni)
                .Select(prestamoData => Transformer.ToPrestamo(prestamoData))
                .Where(prestamo =>
                    prestamo.EjemplaresPrestados.Any(ejemplar => ejemplar.Documento.ISBN == documento.ISBN) ||
                    prestamo.EjemplaresDevueltos.Any(ejemplar => ejemplar.Documento.ISBN == documento.ISBN))
                .ToList();
        }

        // ------------- GESTION DE DOCUMENTOS Y EJEMPLARES

        //PRE: documento no puede ser nulo y no debe existir previamente en la BD.
        //POST: da de alta el documento. Devuelve true si tuvo éxito.
        public static bool AltaDocumento(Documento documento)
        {
            return BaseDatos.BaseDatos.AñadirFila("DocumentoTabla", Transformer.ToDocumentoDato(documento));
        }

        //PRE: ISBN no puede ser nulo.
        //POST: devuelve true si existe un documento con ese ISBN en la BD.
        public static bool ExisteDocumento(string ISBN)
        {
            return BaseDatos.BaseDatos.ObtenerDatos("DocumentoTabla", ISBN) != null;
        }

        //PRE: isbn no puede ser nulo.
        //POST: devuelve el documento con ese ISBN. Si no existe, devuelve null.
        public static Documento GetDocumento(string isbn)
        {
            DocumentoDato documentData = BaseDatos.BaseDatos.ObtenerDatos("DocumentoTabla", isbn) as DocumentoDato;
             if (documentData == null) return null;
            return Transformer.ToDocumento(documentData);
        }

        //PRE: ---
        //POST: devuelve una lista con todos los documentos de la BD.
        public static List<Documento> GetDocumentos() 
        {
            return BaseDatos.BaseDatos.ObtenerTodos("DocumentoTabla")
                .OfType<DocumentoDato>()
                .Select(documentData => Transformer.ToDocumento(documentData))
                .ToList()
                ; 
        }

        //PRE: documento no puede ser nulo y debe existir en la BD.
        //POST: actualiza los datos del documento. Devuelve true si tuvo éxito.
        public static bool ActualizarDocumento(Documento documento)
        {
            BaseDatos.BaseDatos.BorrarFila("DocumentoTabla", documento.ISBN);
             return BaseDatos.BaseDatos.AñadirFila("DocumentoTabla", Transformer.ToDocumentoDato(documento));
        }

        //PRE: ejemplar no puede ser nulo y no debe existir previamente en la BD.
        //POST: da de alta el ejemplar. Devuelve true si tuvo éxito.
        public static bool AltaEjemplar(Ejemplar ejemplar)
        {
            return BaseDatos.BaseDatos.AñadirFila("EjemplarTabla", Transformer.ToEjemplarDato(ejemplar));
        }

        //PRE: ejemplar no puede ser nulo y debe existir en la BD.
        //POST: marca el ejemplar como inactivo (baja lógica). Devuelve true si tuvo éxito.
        public static bool BajaEjemplar(Ejemplar ejemplar)
        {
            // Baja lógica: marcar como inactivo en lugar de borrar
            return BaseDatos.BaseDatos.ModificarFila("EjemplarTabla", ejemplar.Codigo, "Activo", false );
        }

        //PRE: codigo no puede ser nulo.
        //POST: devuelve true si existe un ejemplar con ese código en la BD.
        public static bool ExisteEjemplar(string codigo)
        {
            return BaseDatos.BaseDatos.ObtenerDatos("EjemplarTabla", codigo) !=  null;
        }

        //PRE: codigo no puede ser nulo.
        //POST: devuelve el ejemplar con ese código. Si no existe, devuelve null.
        public static Ejemplar GetEjemplar(string codigo)
        {
            EjemplarDato ejemplarData = BaseDatos.BaseDatos.ObtenerDatos("EjemplarTabla", codigo) as EjemplarDato;
            if (ejemplarData == null) return null;
            return Transformer.ToEjemplar(ejemplarData);

        }

        //PRE: documento no puede ser nulo.
        //POST: devuelve una lista con todos los ejemplares activos de ese documento.
        public static List<Ejemplar> GetEjemplares(Documento documento)
        {
            return BaseDatos.BaseDatos.ObtenerTodos("EjemplarTabla")
                .OfType<EjemplarDato>()
                .Where(ejemplarData => ejemplarData.IsbnDocumento == documento.ISBN &&  ejemplarData.Activo)
                .Select(ejemplarData => Transformer.ToEjemplar(ejemplarData))
                .ToList();
        }

        //PRE: ejemplar no puede ser nulo y debe existir en la BD.
        //POST: actualiza los datos del ejemplar. Devuelve true si tuvo éxito.
        public static bool ActualizarEjemplar(Ejemplar ejemplar)
        {
            BaseDatos.BaseDatos.BorrarFila("EjemplarTabla", ejemplar.Codigo);
            return BaseDatos.BaseDatos.AñadirFila("EjemplarTabla", Transformer.ToEjemplarDato(ejemplar)) ;
        }

        //PRE: ejemplares no puede ser nulo ni vacío.
        //POST: actualiza la disponibilidad de todos los ejemplares. Devuelve true si todos se actualizaron correctamente.
        public static bool ActualizarDisponibilidad(List<Ejemplar> ejemplares)
        {
            return ejemplares.All(ejemplar =>
                 BaseDatos.BaseDatos.ModificarFila("EjemplarTabla", ejemplar.Codigo, "Prestado", !ejemplar.Disponible));
        }

        //PRE: isbn no puede ser nulo.
        //POST: devuelve true si hay al menos un ejemplar disponible de ese documento.
        public static bool HayEjemplaresDisponibles(string isbn)
        {
            return BaseDatos.BaseDatos.ObtenerTodos("EjemplarTabla")
                .OfType<EjemplarDato>()
                .Any(ejemplarData => ejemplarData.IsbnDocumento  == isbn && ejemplarData.Activo  && !ejemplarData.Prestado);
        }

        // ------------- GESTIÓN DE PERSONAL

        //PRE: dni no puede ser nulo.
        //POST: devuelve true si existe un personal sala con ese dni en la BD.
        public static bool ExistePersonalSala(string dni)
        {
            return BaseDatos.BaseDatos.Existe("PersonaTabla", dni) && BaseDatos.BaseDatos.Existe("PersonalSalaTabla", dni);
        }
        
        //PRE: dni no puede ser nulo.
        //POST: devuelve true si existe un personal de adquisiciones con ese dni en la BD.
        public static bool ExistePersonalAdquisiciones(string dni)
        {
            return BaseDatos.BaseDatos.Existe("PersonaTabla", dni) && BaseDatos.BaseDatos.Existe("PersonalAdquisicionesTabla", dni);
        }
        
        //PRE: personalSala no puede ser nulo y no debe existir previamente en la BD.
        //POST: da de alta el personal de sala en PersonaTabla y PersonalSalaTabla. Devuelve true si tuvo éxito.
        public static bool AltaPersonalSala(PersonalSala personalSala)
        {

            PersonaDato personaData = Transformer.ToPersonaDatoFromPersonalSala(personalSala);
            if (!BaseDatos.BaseDatos.AñadirFila("PersonaTabla", personaData)) return false;
            return BaseDatos.BaseDatos.AñadirFila("PersonalSalaTabla", Transformer.ToPersonalSalaDato(personalSala));
        }

        //PRE: personalAdquisiciones no puede ser nulo y no debe existir previamente en la BD.
        //POST: da de alta el personal de adquisiciones en PersonaTabla y PersonalAdquisicionesTabla. Devuelve true si tuvo éxito.
        public static bool AltaPersonalAdquisiciones(PersonalAdquisiciones personalAdquisiciones)
        {
            PersonaDato personaData = Transformer.ToPersonaDatoFromPersonalAdquisiciones(personalAdquisiciones);
            if (!BaseDatos.BaseDatos.AñadirFila("PersonaTabla", personaData)) return  false ;
            return BaseDatos.BaseDatos.AñadirFila("PersonalAdquisicionesTabla", Transformer.ToPersonalAdquisicionesDato(personalAdquisiciones));
        }

        //PRE: personalSala no puede ser nulo y debe existir en la BD.
        //POST: actualiza los datos del personal de sala en PersonaTabla y PersonalSalaTabla. Devuelve true si tuvo éxito.
        public static bool ActualizarPersonalSala(PersonalSala personalSala)
        {
            // Actualizar PersonaTabla
            BaseDatos.BaseDatos.BorrarFila("PersonaTabla", personalSala.Dni);
            PersonaDato personaData = Transformer.ToPersonaDatoFromPersonalSala(personalSala);
            if (!BaseDatos.BaseDatos.AñadirFila("PersonaTabla", personaData)) return false;

            // Actualizar PersonalSalaTabla
            BaseDatos.BaseDatos.BorrarFila("PersonalSalaTabla", personalSala.Dni);
            return BaseDatos.BaseDatos.AñadirFila("PersonalSalaTabla", Transformer.ToPersonalSalaDato(personalSala));
        }

        //PRE: personalAdquisiciones no puede ser nulo y debe existir en la BD.
        //POST: actualiza los datos del personal de adquisiciones en PersonaTabla y PersonalAdquisicionesTabla. Devuelve true si tuvo éxito.
        public static bool ActualizarPersonalAdquisiciones(PersonalAdquisiciones personalAdquisiciones)
        {
            // Actualizar PersonaTabla
            BaseDatos.BaseDatos.BorrarFila("PersonaTabla", personalAdquisiciones.Dni);
            PersonaDato personaData = Transformer.ToPersonaDatoFromPersonalAdquisiciones(personalAdquisiciones);
            if (!BaseDatos.BaseDatos.AñadirFila("PersonaTabla", personaData)) return false;

            // Actualizar PersonalAdquisicionesTabla
            BaseDatos.BaseDatos.BorrarFila("PersonalAdquisicionesTabla", personalAdquisiciones.Dni);
            return BaseDatos.BaseDatos.AñadirFila("PersonalAdquisicionesTabla", Transformer.ToPersonalAdquisicionesDato(personalAdquisiciones));
        }

        //PRE: dni no puede ser nulo.
        //POST: devuelve el personal de sala con ese dni. Si no existe, devuelve null.
        public static PersonalSala GetPersonalSala(string dni)
        {
            PersonalSalaDato personalSalaData = BaseDatos.BaseDatos.ObtenerDatos("PersonalSalaTabla", dni) as PersonalSalaDato;
            if (personalSalaData == null) return null;
            return Transformer.ToPersonalSala(personalSalaData);
        }

        //PRE: dni no puede ser nulo.
        //POST: devuelve el personal de adquisiciones con ese dni. Si no existe, devuelve null.
        public static PersonalAdquisiciones GetPersonalAdquisiciones(string dni)
        {
            PersonalAdquisicionesDato personalAdquisicionesData = BaseDatos.BaseDatos.ObtenerDatos("PersonalAdquisicionesTabla", dni) as PersonalAdquisicionesDato;
            if (personalAdquisicionesData == null) return null;
            return Transformer.ToPersonalAdquisiciones(personalAdquisicionesData);
        }
    }
}