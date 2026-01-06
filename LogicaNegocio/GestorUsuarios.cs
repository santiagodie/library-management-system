using System;
using System.Collections.Generic;
using ModeloDominio;
using Persistencia;
using BaseDatos;
using System.Linq;

public class GestorUsuarios
{
    const string LetrasDNI = "TRWAGMYFPDXBNJZSQVHLCKE";

    public GestorUsuarios()
    {
    }

    public class ResultadoLogin
    {
        public Rol Rol { get; set; }
        public Persona Persona { get; set; }
        public bool Exito { get; set; }
        public string MensajeError { get; set; }
    }

    //PRE: dni y contraseña no pueden ser nulos o vacíos.
    //POST: valida las credenciales y devuelve un objeto ResultadoLogin con el éxito del proceso, el rol asignado y los datos de la persona.
    public ResultadoLogin ValidarLogin(string dni, string contraseña)
    {
        ResultadoLogin resultado = new ResultadoLogin { Exito = false };

        if (string.IsNullOrEmpty(dni) || string.IsNullOrEmpty(contraseña))
        {
            resultado.MensajeError = "Datos vacíos.";
            return resultado;
        }

        if (!Persistencia.Persistencia.ExistePersona(dni))
        {
            resultado.MensajeError = "No existe ninguna cuenta con ese DNI.";
            return resultado;
        }

        string hashPass = Hash.GetHash(contraseña);

        if (Persistencia.Persistencia.ExistePersonalSala(dni))
        {
            PersonalSala p = Persistencia.Persistencia.GetPersonalSala(dni);
            if (p.HashContraseña == hashPass)
            {
                resultado.Exito = true;
                resultado.Persona = p;

                if (Persistencia.Persistencia.ExisteUsuario(dni))
                {
                    resultado.Rol = Rol.UsuarioYSala;
                }
                else
                {
                    resultado.Rol = Rol.PersonalSala;
                }
                return resultado;
            }
        }

        if (Persistencia.Persistencia.ExistePersonalAdquisiciones(dni))
        {
            PersonalAdquisiciones p = Persistencia.Persistencia.GetPersonalAdquisiciones(dni);
            if (p.HashContraseña == hashPass)
            {
                resultado.Exito = true;
                resultado.Persona = p;

                if (Persistencia.Persistencia.ExisteUsuario(dni))
                {
                    resultado.Rol = Rol.UsuarioYAdquisiciones;
                }
                else
                {
                    resultado.Rol = Rol.PersonalAdquisiciones;
                }
                return resultado;
            }
        }

        if (Persistencia.Persistencia.ExisteUsuario(dni))
        {
            Usuario u = Persistencia.Persistencia.GetUsuario(dni);
            if (u.HashContraseña == hashPass)
            {
                resultado.Exito = true;
                resultado.Rol = Rol.Usuario;
                resultado.Persona = u;
                return resultado;
            }
        }

        resultado.MensajeError = "Contraseña incorrecta.";
        return resultado;
    }

    //PRE: usuario no puede ser nulo. Debe tener Nombre, DNI y HashContraseña válidos. El DNI no debe existir previamente.
    //POST: registra al usuario en el sistema. Devuelve true si el alta se realizó con éxito en la persistencia.
    public bool AltaUsuario(Usuario usuario)
    {
        if (Persistencia.Persistencia.ExisteUsuario(usuario.Dni))
        {
            return false;
        }

        if (string.IsNullOrEmpty(usuario.Nombre) || string.IsNullOrEmpty(usuario.Dni) || string.IsNullOrEmpty(usuario.HashContraseña))
        {
            return false;
        }

        if (!EsDniValido(usuario.Dni))
        {
            return false;
        }

        return Persistencia.Persistencia.AltaUsuario(usuario);
    }

    //PRE: usuario no puede ser nulo y debe estar en un estado diferente de Inactivo.
    //POST: marca al usuario como inactivo en el sistema. Devuelve true si la baja lógica se procesó correctamente.
    public bool BajaUsuario(Usuario usuario)
    {
        if (usuario.Estado != EstadoUsuario.Inactivo)
        {
            return Persistencia.Persistencia.BajaUsuario(usuario);
        }
        return false;
    }

    //PRE: Dni no puede ser nulo o vacío.
    //POST: devuelve el objeto Usuario asociado al DNI proporcionado, o null si no se encuentra en la persistencia.
    public Usuario ConsultarUusuario(String Dni)
    {
        return Persistencia.Persistencia.GetUsuario(Dni);
    }

    //PRE: ---
    //POST: devuelve una lista con todos los usuarios registrados en el sistema.
    public List<Usuario> GetListaUsuarios()
    {
        return Persistencia.Persistencia.GetListaUsuarios();
    }

    //PRE: usuario no puede ser nulo.
    //POST: devuelve la lista de préstamos activos del usuario que han superado su fecha límite de devolución.
    public List<Prestamo> GetPrestamosRetrasados(Usuario usuario)
    {
        var todos = Persistencia.Persistencia.GetPrestamos(usuario);

        List<Prestamo> retrasados = new List<Prestamo>();

        foreach (var p in todos)
        {
            if (!p.EstaFinalizado())
            {
                bool libroCaducado = p.QuedanLibros() && DateTime.Today > p.FechaFin[0];
                bool audioCaducado = p.QuedanAudios() && DateTime.Today > p.FechaFin[1];

                if (libroCaducado || audioCaducado)
                {
                    retrasados.Add(p);
                }
            }
        }
        return retrasados;
    }

    //PRE: usuario no puede ser nulo.
    //POST: devuelve la lista de ejemplares que el usuario tiene prestados actualmente (sin devolver).
    public List<Ejemplar> GetEjemplaresPrestados(Usuario usuario)
    {
        var todos = Persistencia.Persistencia.GetPrestamos(usuario);
        List<Ejemplar> enCasaUsuario = new List<Ejemplar>();

        foreach (var p in todos)
        {
            if (!p.EstaFinalizado())
            {
                enCasaUsuario.AddRange(p.EjemplaresPrestados);
            }
        }
        return enCasaUsuario;
    }

    //PRE: dniCompleto debe tener una longitud de 9 caracteres (8 números y 1 letra).
    //POST: devuelve true si el formato es correcto y el dígito de control (letra) coincide con el número.
    public bool EsDniValido(string dniCompleto)
    {
        if (dniCompleto.Length != 9)
        {
            return false;
        }

        if (!int.TryParse(dniCompleto.Substring(0, 8), out int numeroDNI))
        {
            return false;
        }

        return char.ToUpper(dniCompleto[8]) == LetrasDNI[numeroDNI % 23];
    }

    //PRE: ejemplar no puede ser nulo y debe estar asociado a un préstamo activo.
    //POST: devuelve la fecha de devolución prevista para el ejemplar según su tipo de documento.
    public DateTime GetFechaDisponible(Ejemplar ejemplar)
    {
        if (ejemplar.Documento is Libro) return Persistencia.Persistencia.GetPrestamoActivo(ejemplar).FechaFin[0];
        else if (ejemplar.Documento is Audiolibro) return Persistencia.Persistencia.GetPrestamoActivo(ejemplar).FechaFin[1];
        return DateTime.MinValue;
    }

    //PRE: personaLogueada no puede ser nula.
    //POST: devuelve una lista de objetos EjemplarPrestado filtrada por texto y estado de pendiente, ordenada por fecha de inicio.
    public List<EjemplarPrestado> ObtenerMisPrestamosFiltrados(Persona personaLogueada, string textoBuscar, bool soloPendientes)
    {
        Usuario usuario = Persistencia.Persistencia.GetUsuario(personaLogueada.Dni);
        if (usuario == null) return new List<EjemplarPrestado>();
        List<Prestamo> misPrestamos = Persistencia.Persistencia.GetPrestamos(usuario);

        var consulta = misPrestamos.AsQueryable();

        if (soloPendientes)
        {
            consulta = consulta.Where(p => !p.EstaFinalizado());
        }

        if (!string.IsNullOrEmpty(textoBuscar))
        {
            string textoMinuscula = textoBuscar.ToLower();
            consulta = consulta.Where(p =>
                p.EjemplaresPrestados.Any(e => e.Documento.Titulo.ToLower().Contains(textoMinuscula))
            );
        }

        List<Prestamo> prestamos = consulta.OrderByDescending(p => p.FechaInicio).ToList();
        List<EjemplarPrestado> ejemplares = new List<EjemplarPrestado>();
        foreach (Prestamo p in prestamos)
        {
            foreach (Ejemplar e in p.EjemplaresPrestados)
            {
                Documento d = e.Documento;
                int i;
                if (d is Libro)
                {
                    i = 0;
                }
                else
                {
                    i = 1;
                }
                if (((soloPendientes && p.GetLibrosPendientes().Contains(e)) || !soloPendientes) && ((!string.IsNullOrEmpty(textoBuscar) && d.Titulo.ToLower().Contains(textoBuscar.ToLower())) || string.IsNullOrEmpty(textoBuscar)))
                {
                    ejemplares.Add(new EjemplarPrestado(d.Titulo, d.Autor, d.ISBN, p.FechaInicio, p.FechaFin[i], p.GetLibrosPendientes().Contains(e)));
                }
            }
        }
        return ejemplares;
    }

    //PRE: dni no puede ser nulo o vacío.
    //POST: devuelve true si existe un usuario con el DNI especificado en el sistema.
    public bool ExisteUsuario(string dni)
    {
        return Persistencia.Persistencia.ExisteUsuario(dni);
    }

    //PRE: idEjemplar no puede ser nulo o vacío. El ejemplar debe existir en la persistencia.
    //POST: devuelve el ejemplar con el código especificado, o null si no existe.
    public Ejemplar ConsultarEjemplar(string idEjemplar)
    {
        if (string.IsNullOrEmpty(idEjemplar) || !Persistencia.Persistencia.ExisteEjemplar(idEjemplar)) return null;

        return Persistencia.Persistencia.GetEjemplar(idEjemplar);
    }
}