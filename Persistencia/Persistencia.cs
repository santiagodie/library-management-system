using ModeloDominio;
using BaseDatos;
using System;
using System.Collections.Generic;


namespace Persistencia
{
    public static class Persistencia
    {
        // ------------- GESTIÓN DE USUARIOS 

        public static bool ExisteUsuario(string dni)
        {
            return BaseDatos.BaseDatos.ObtenerDatos("UsuarioTabla", dni) != null;
        }

        public static bool AltaUsuario(Usuario usuario)
        {
            PersonaDato personaData = new PersonaDato(usuario.Id, usuario.Nombre, usuario.Dni,usuario.HashContraseña);
            if (!BaseDatos.BaseDatos.AñadirFila("PersonaTabla", personaData)) return false;
            return BaseDatos.BaseDatos.AñadirFila("UsuarioTabla", new UsuarioDato(usuario.Id, usuario.Estado));
        }

        public static bool BajaUsuario(Usuario usuario)
        {
            return BaseDatos.BaseDatos.BorrarFila("UsuarioTabla", usuario.Dni);
        }

        public static Usuario GetUsuario(string dni)
        {
            UsuarioDato userData = BaseDatos.BaseDatos.ObtenerDatos("UsuarioTabla", dni) as UsuarioDato;
            if (userData == null) return null;
            return Transformer.ToUsuario(userData);
        }

        public static List<Usuario> GetListaUsuarios()
        {
            List<Usuario> usuarios = new List<Usuario>();
            List<Entidad> datos = BaseDatos.BaseDatos.ObtenerTodos("UsuarioTabla");

            foreach (Entidad entidad in datos)
            {
                UsuarioDato userData = entidad as UsuarioDato;
                if (userData != null) usuarios.Add(Transformer.ToUsuario(userData));
                
            }
            return usuarios;
        }
        // ------------- GESTIÓN DE PRÉSTAMOS 

        public static bool AltaPrestamo(Prestamo prestamo)
        {
            return BaseDatos.BaseDatos.AñadirFila("PrestamoTabla", Transformer.ToPrestamoDato(prestamo));
        }

        public static bool ActualizarPrestamo(Prestamo prestamo)
        {
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

        public static Prestamo GetPrestamoActivo(Ejemplar ejemplar)
        {
            List<Entidad> prestamos = BaseDatos.BaseDatos.ObtenerTodos("PrestamoTabla");

            foreach (Entidad entidad in prestamos)
            {
                PrestamoDato prestamoData = entidad as PrestamoDato;
                if (prestamoData != null && !prestamoData.EstaFinalizado() && prestamoData.CodigosEjemplaresPrestados.Contains(ejemplar.Codigo))
                return Transformer.ToPrestamo(prestamoData);
                
            }

            return null;
        }

        public static List<Prestamo> GetPrestamos()
        {
            List<Prestamo> prestamos = new List<Prestamo>();
            List<Entidad> datos = BaseDatos.BaseDatos.ObtenerTodos("PrestamoTabla");

            foreach (Entidad entidad in datos)
            {
                PrestamoDato prestamoData = entidad as PrestamoDato;
                if (prestamoData != null) prestamos.Add(Transformer.ToPrestamo(prestamoData));  
            }
            return prestamos;
        }

        public static List<Prestamo> GetPrestamos(Usuario usuario)
        {
            List<Prestamo> prestamos = new List<Prestamo>();
            List<Entidad> datos = BaseDatos.BaseDatos.ObtenerTodos("PrestamoTabla");

            foreach (Entidad entidad in datos)
            {
                PrestamoDato prestamoData = entidad as PrestamoDato;
                if (prestamoData != null && prestamoData.DniUsuario == usuario.Dni) prestamos.Add(Transformer.ToPrestamo(prestamoData));
            }

            return prestamos;
        }

        public static List<Prestamo> GetPrestamos(Documento documento)
        {
            List<Prestamo> prestamos = new List<Prestamo>();
            List<Entidad> datos = BaseDatos.BaseDatos.ObtenerTodos("PrestamoTabla");

            foreach (Entidad entidad in datos)
            {
                PrestamoDato prestamoData = entidad as PrestamoDato;
                if (prestamoData != null)
                {
                    Prestamo prestamo = Transformer.ToPrestamo(prestamoData);

                    bool contieneDocumento = false;
                    foreach (Ejemplar ejemplar in prestamo.EjemplaresPrestados)
                    {
                        if (ejemplar.Documento.ISBN == documento.ISBN)
                        {
                            contieneDocumento = true;
                            break;
                        }
                    }

                    foreach (Ejemplar ejemplar in prestamo.EjemplaresDevueltos)
                    {
                        if (ejemplar.Documento.ISBN == documento.ISBN)
                        {
                            contieneDocumento = true;
                            break;
                        }
                    }

                    if (contieneDocumento) prestamos.Add(prestamo);
                    
                }
            }

            return prestamos;
        }

        public static List<Prestamo> GetPrestamos(Usuario usuario, DateTime fecha)
        {
            List<Prestamo> prestamos = new List<Prestamo>();
            List<Entidad> datos = BaseDatos.BaseDatos.ObtenerTodos("PrestamoTabla");

            foreach (Entidad entidad in datos)
            {
                PrestamoDato prestamoData = entidad as PrestamoDato;
                if (prestamoData != null && prestamoData.DniUsuario == usuario.Dni && prestamoData.FechaInicio.Date == fecha.Date) 
                    prestamos.Add(Transformer.ToPrestamo(prestamoData));
                
            }

            return prestamos;
        }
        public static List<Prestamo> GetPrestamos(Usuario usuario, Documento documento)
        {
            List<Prestamo> prestamos = new List<Prestamo>();
            List<Entidad> datos = BaseDatos.BaseDatos.ObtenerTodos("PrestamoTabla");

            foreach (Entidad entidad in datos)
            {
                PrestamoDato prestamoData = entidad as PrestamoDato;
                if (prestamoData != null && prestamoData.DniUsuario == usuario.Dni)
                {
                    Prestamo prestamo = Transformer.ToPrestamo(prestamoData);

                    // Verificar si alguno de los ejemplares pertenece al documento
                    bool contieneDocumento = false;
                    foreach (Ejemplar ejemplar in prestamo.EjemplaresPrestados)
                    {
                        if (ejemplar.Documento.ISBN == documento.ISBN)
                        {
                            contieneDocumento = true;
                            break;
                        }
                    }

                    foreach (Ejemplar ejemplar in prestamo.EjemplaresDevueltos)
                    {
                        if (ejemplar.Documento.ISBN == documento.ISBN)
                        {
                            contieneDocumento = true;
                            break;
                        }
                    }

                    if (contieneDocumento) prestamos.Add(prestamo);
                    
                }
            }

            return prestamos;
        }

        // ------------- C. GESTIÓN DE DOCUMENTOS Y EJEMPLARES 

        public static bool AltaDocumento(Documento documento)
        {
            return BaseDatos.BaseDatos.AñadirFila("DocumentoTabla", Transformer.ToDocumentoDato(documento));
        }

        public static bool ExisteDocumento(string ISBN)
        {
            return BaseDatos.BaseDatos.ObtenerDatos("DocumentoTabla", ISBN) != null;
        }

        public static Documento GetDocumento(string isbn)
        {
            DocumentoDato dd = BaseDatos.BaseDatos.ObtenerDatos("DocumentoTabla", isbn) as DocumentoDato;
            if (dd == null) return null;
            return Transformer.ToDocumento(dd);
        }

        public static List<Documento> GetDocumentos()
        {
            List<Documento> documentos = new List<Documento>();
            List<Entidad> datos = BaseDatos.BaseDatos.ObtenerTodos("DocumentoTabla");

            foreach (Entidad entidad in datos)
            {
                DocumentoDato documentData = entidad as DocumentoDato;
                if (documentData != null) documentos.Add(Transformer.ToDocumento(documentData));
            }

            return documentos;
        }

        public static bool AltaEjemplar(Ejemplar ejemplar)
        {
            return BaseDatos.BaseDatos.AñadirFila("EjemplarTabla", Transformer.ToEjemplarDato(ejemplar));
        }

        public static bool BajaEjemplar(Ejemplar ejemplar)
        {
            return BaseDatos.BaseDatos.BorrarFila("EjemplarTabla", ejemplar.Codigo);
        }

        public static bool ExisteEjemplar(string codigo)
        {
            return BaseDatos.BaseDatos.ObtenerDatos("EjemplarTabla", codigo) != null;
        }

        public static Ejemplar GetEjemplar(string codigo)
        {
            EjemplarDato ejemplarData = BaseDatos.BaseDatos.ObtenerDatos("EjemplarTabla", codigo) as EjemplarDato;
            if (ejemplarData == null) return null;
            return Transformer.ToEjemplar(ejemplarData);
        }

        public static List<Ejemplar> GetEjemplares(Documento documento)
        {
            List<Ejemplar> ejemplares = new List<Ejemplar>();
            List<Entidad> datos = BaseDatos.BaseDatos.ObtenerTodos("EjemplarTabla");

            foreach (Entidad entidad in datos)
            {
                EjemplarDato ejemplarData = entidad as EjemplarDato;
                if (ejemplarData != null && ejemplarData.IsbnDocumento == documento.ISBN)
                {
                    ejemplares.Add(Transformer.ToEjemplar(ejemplarData));
                }
            }
            return ejemplares;
        }

        public static bool ActualizarEjemplar(Ejemplar ejemplar)
        {
            BaseDatos.BaseDatos.BorrarFila("EjemplarTabla", ejemplar.Codigo);
            return BaseDatos.BaseDatos.AñadirFila("EjemplarTabla", Transformer.ToEjemplarDato(ejemplar));
        }

        public static bool ActualizarDisponibilidad(List<Ejemplar> ejemplares)
        {
            bool exito = true;

            foreach (Ejemplar ej in ejemplares)
            {
                bool resultado = BaseDatos.BaseDatos.ModificarFila("EjemplarTabla",ej.Codigo,"Prestado",!ej.Disponible);
                if (!resultado) exito = false;

            }
            return exito;
        }
    }
}