using ModeloDominio;
using System;
using System.Collections.Generic;

namespace Persistencia
{
    /// <summary>
    /// Interfaz pública de la capa de persistencia.
    /// Define todas las operaciones de acceso a datos disponibles.
    /// </summary>
    public interface IPersistencia
    {
        // ------------- GESTIÓN DE PERSONAS

        /// <summary>
        /// PRE: dni no puede ser nulo.
        /// POST: devuelve true si existe una persona con ese dni en la BD.
        /// </summary>
        bool ExistePersona(string dni);

        // ------------- GESTIÓN DE USUARIOS

        /// <summary>
        /// PRE: dni no puede ser nulo.
        /// POST: devuelve true si existe un usuario con ese dni en la BD.
        /// </summary>
        bool ExisteUsuario(string dni);

        /// <summary>
        /// PRE: usuario no puede ser nulo y no debe existir previamente en la BD.
        /// POST: da de alta al usuario. Si falla, revierte los cambios en PersonaTabla.
        /// </summary>
        bool AltaUsuario(Usuario usuario);

        /// <summary>
        /// PRE: usuario no puede ser nulo y debe existir en la BD.
        /// POST: marca el usuario como Inactivo (baja lógica). Devuelve true si tuvo éxito.
        /// </summary>
        bool BajaUsuario(Usuario usuario);

        /// <summary>
        /// PRE: usuario no puede ser nulo y debe existir en la BD.
        /// POST: actualiza los datos del usuario en PersonaTabla y UsuarioTabla. Devuelve true si tuvo éxito.
        /// </summary>
        bool ActualizarUsuario(Usuario usuario);

        /// <summary>
        /// PRE: dni no puede ser nulo.
        /// POST: devuelve el usuario con ese dni. Si no existe, devuelve null.
        /// </summary>
        Usuario GetUsuario(string dni);

        /// <summary>
        /// PRE: ---
        /// POST: devuelve una lista con todos los usuarios de la BD.
        /// </summary>
        List<Usuario> GetListaUsuarios();

        // ------------- GESTIÓN DE PRÉSTAMOS

        /// <summary>
        /// PRE: prestamo no puede ser nulo y no debe existir previamente en la BD.
        /// POST: da de alta el préstamo en PrestamoTabla y PrestamoEjemplarTabla. Devuelve true si tuvo éxito. Si falla, revierte los cambios.
        /// </summary>
        bool AltaPrestamo(Prestamo prestamo);

        /// <summary>
        /// PRE: prestamo no puede ser nulo y debe existir en la BD.
        /// POST: actualiza la disponibilidad de los ejemplares y marca FechaDevolucion en PrestamoEjemplarTabla. Devuelve true si tuvo éxito.
        /// </summary>
        bool ActualizarPrestamo(Prestamo prestamo);

        /// <summary>
        /// PRE: ejemplar no puede ser nulo.
        /// POST: devuelve el préstamo activo que contiene ese ejemplar. Si no existe, devuelve null.
        /// </summary>
        Prestamo GetPrestamoActivo(Ejemplar ejemplar);

        /// <summary>
        /// PRE: ---
        /// POST: devuelve una lista con todos los préstamos de la BD.
        /// </summary>
        List<Prestamo> GetPrestamos();

        /// <summary>
        /// PRE: usuario no puede ser nulo.
        /// POST: devuelve una lista con todos los préstamos del usuario.
        /// </summary>
        List<Prestamo> GetPrestamos(Usuario usuario);

        /// <summary>
        /// PRE: documento no puede ser nulo.
        /// POST: devuelve una lista con todos los préstamos que contienen ejemplares de ese documento.
        /// </summary>
        List<Prestamo> GetPrestamos(Documento documento);

        /// <summary>
        /// PRE: usuario no puede ser nulo y fecha debe ser válida.
        /// POST: devuelve una lista con todos los préstamos del usuario en esa fecha.
        /// </summary>
        List<Prestamo> GetPrestamos(Usuario usuario, DateTime fecha);

        /// <summary>
        /// PRE: usuario y documento no pueden ser nulos.
        /// POST: devuelve una lista con todos los préstamos del usuario que contienen ejemplares de ese documento.
        /// </summary>
        List<Prestamo> GetPrestamos(Usuario usuario, Documento documento);

        // ------------- GESTION DE DOCUMENTOS Y EJEMPLARES

        /// <summary>
        /// PRE: documento no puede ser nulo y no debe existir previamente en la BD.
        /// POST: da de alta el documento. Devuelve true si tuvo éxito.
        /// </summary>
        bool AltaDocumento(Documento documento);

        /// <summary>
        /// PRE: ISBN no puede ser nulo.
        /// POST: devuelve true si existe un documento con ese ISBN en la BD.
        /// </summary>
        bool ExisteDocumento(string ISBN);

        /// <summary>
        /// PRE: isbn no puede ser nulo.
        /// POST: devuelve el documento con ese ISBN. Si no existe, devuelve null.
        /// </summary>
        Documento GetDocumento(string isbn);

        /// <summary>
        /// PRE: ---
        /// POST: devuelve una lista con todos los documentos de la BD.
        /// </summary>
        List<Documento> GetDocumentos();

        /// <summary>
        /// PRE: documento no puede ser nulo y debe existir en la BD.
        /// POST: actualiza los datos del documento. Devuelve true si tuvo éxito.
        /// </summary>
        bool ActualizarDocumento(Documento documento);

        /// <summary>
        /// PRE: ejemplar no puede ser nulo y no debe existir previamente en la BD.
        /// POST: da de alta el ejemplar. Devuelve true si tuvo éxito.
        /// </summary>
        bool AltaEjemplar(Ejemplar ejemplar);

        /// <summary>
        /// PRE: ejemplar no puede ser nulo y debe existir en la BD.
        /// POST: marca el ejemplar como inactivo (baja lógica). Devuelve true si tuvo éxito.
        /// </summary>
        bool BajaEjemplar(Ejemplar ejemplar);

        /// <summary>
        /// PRE: codigo no puede ser nulo.
        /// POST: devuelve true si existe un ejemplar con ese código en la BD.
        /// </summary>
        bool ExisteEjemplar(string codigo);

        /// <summary>
        /// PRE: codigo no puede ser nulo.
        /// POST: devuelve el ejemplar con ese código. Si no existe, devuelve null.
        /// </summary>
        Ejemplar GetEjemplar(string codigo);

        /// <summary>
        /// PRE: documento no puede ser nulo.
        /// POST: devuelve una lista con todos los ejemplares activos de ese documento.
        /// </summary>
        List<Ejemplar> GetEjemplares(Documento documento);

        /// <summary>
        /// PRE: ejemplar no puede ser nulo y debe existir en la BD.
        /// POST: actualiza los datos del ejemplar. Devuelve true si tuvo éxito.
        /// </summary>
        bool ActualizarEjemplar(Ejemplar ejemplar);

        /// <summary>
        /// PRE: ejemplares no puede ser nulo ni vacío.
        /// POST: actualiza la disponibilidad de todos los ejemplares. Devuelve true si todos se actualizaron correctamente.
        /// </summary>
        bool ActualizarDisponibilidad(List<Ejemplar> ejemplares);

        /// <summary>
        /// PRE: isbn no puede ser nulo.
        /// POST: devuelve true si hay al menos un ejemplar disponible de ese documento.
        /// </summary>
        bool HayEjemplaresDisponibles(string isbn);

        // ------------- GESTIÓN DE PERSONAL

        /// <summary>
        /// PRE: dni no puede ser nulo.
        /// POST: devuelve true si existe un personal sala con ese dni en la BD.
        /// </summary>
        bool ExistePersonalSala(string dni);

        /// <summary>
        /// PRE: dni no puede ser nulo.
        /// POST: devuelve true si existe un personal de adquisiciones con ese dni en la BD.
        /// </summary>
        bool ExistePersonalAdquisiciones(string dni);

        /// <summary>
        /// PRE: personalSala no puede ser nulo y no debe existir previamente en la BD.
        /// POST: da de alta el personal de sala en PersonaTabla(si es necesario) y PersonalSalaTabla. Devuelve true si tuvo éxito.
        /// </summary>
        bool AltaPersonalSala(PersonalSala personalSala);

        /// <summary>
        /// PRE: personalAdquisiciones no puede ser nulo y no debe existir previamente en la BD.
        /// POST: da de alta el personal de adquisiciones en PersonaTabla(si necesario) y PersonalAdquisicionesTabla. Devuelve true si tuvo éxito.
        /// </summary>
        bool AltaPersonalAdquisiciones(PersonalAdquisiciones personalAdquisiciones);

        /// <summary>
        /// PRE: personalSala no puede ser nulo y debe existir en la BD.
        /// POST: actualiza los datos del personal de sala en PersonaTabla y PersonalSalaTabla. Devuelve true si tuvo éxito.
        /// </summary>
        bool ActualizarPersonalSala(PersonalSala personalSala);

        /// <summary>
        /// PRE: personalAdquisiciones no puede ser nulo y debe existir en la BD.
        /// POST: actualiza los datos del personal de adquisiciones en PersonaTabla y PersonalAdquisicionesTabla. Devuelve true si tuvo éxito.
        /// </summary>
        bool ActualizarPersonalAdquisiciones(PersonalAdquisiciones personalAdquisiciones);

        /// <summary>
        /// PRE: dni no puede ser nulo.
        /// POST: devuelve el personal de sala con ese dni. Si no existe, devuelve null.
        /// </summary>
        PersonalSala GetPersonalSala(string dni);

        /// <summary>
        /// PRE: dni no puede ser nulo.
        /// POST: devuelve el personal de adquisiciones con ese dni. Si no existe, devuelve null.
        /// </summary>
        PersonalAdquisiciones GetPersonalAdquisiciones(string dni);
    }
}
