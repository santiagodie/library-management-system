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

    public ResultadoLogin ValidarLogin(string dni, string contraseña)
    {
        ResultadoLogin resultado = new ResultadoLogin { Exito = false };

        if (string.IsNullOrEmpty(dni) || string.IsNullOrEmpty(contraseña))
        {
            resultado.MensajeError = "Datos vacíos.";
            return resultado;
        }

        if (!Persistencia.Persistencia.Instancia.ExistePersona(dni))
        {
            resultado.MensajeError = "No existe ninguna cuenta con ese DNI.";
            return resultado;
        }

        string hashPass = Hash.GetHash(contraseña);

        if (Persistencia.Persistencia.Instancia.ExistePersonalSala(dni))
        {
            PersonalSala p = Persistencia.Persistencia.Instancia.GetPersonalSala(dni);
            if (p.HashContraseña == hashPass)
            {
                resultado.Exito = true;
                resultado.Persona = p;

                if (Persistencia.Persistencia.Instancia.ExisteUsuario(dni))
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

        if (Persistencia.Persistencia.Instancia.ExistePersonalAdquisiciones(dni))
        {
            PersonalAdquisiciones p = Persistencia.Persistencia.Instancia.GetPersonalAdquisiciones(dni);
            if (p.HashContraseña == hashPass)
            {
                resultado.Exito = true;
                resultado.Persona = p;

                if (Persistencia.Persistencia.Instancia.ExisteUsuario(dni))
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

        if (Persistencia.Persistencia.Instancia.ExisteUsuario(dni))
        {
            Usuario u = Persistencia.Persistencia.Instancia.GetUsuario(dni);
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

    public bool AltaUsuario(Usuario usuario)
    {
        if (Persistencia.Persistencia.Instancia.ExisteUsuario(usuario.Dni))
        {
            //Console.WriteLine($"Error: El usuario con ID {usuario.Id} ya existe."); Creo que hay que hacerlo con excepciones para poder cogerlas en la interfaz ( try{} catch(e){} )
            return false;
        }

        if (string.IsNullOrEmpty(usuario.Nombre) || string.IsNullOrEmpty(usuario.Dni) || string.IsNullOrEmpty(usuario.HashContraseña))
        {
            // Console.WriteLine("Error: El nombre, DNI y contraseña son obligatorios.");
            return false;
        }

        if (!EsDniValido(usuario.Dni))
        {
            //Console.WriteLine("Error: El DNI no es válido.");
            return false;
        }

        return Persistencia.Persistencia.Instancia.AltaUsuario(usuario);
    }

    public bool BajaUsuario(Usuario usuario)
    {
        return Persistencia.Persistencia.Instancia.BajaUsuario(usuario);
    }

    public Usuario ConsultarUusuario(String Dni)
    {
        return Persistencia.Persistencia.Instancia.GetUsuario(Dni);
    }

    public List<Usuario> GetListaUsuarios()
    {
        return Persistencia.Persistencia.Instancia.GetListaUsuarios();
    }

    public List<Prestamo> GetPrestamosRetrasados(Usuario usuario)
    {
        var todos = Persistencia.Persistencia.Instancia.GetPrestamos(usuario);

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

    public List<Ejemplar> GetEjemplaresPrestados(Usuario usuario)
    {
        var todos = Persistencia.Persistencia.Instancia.GetPrestamos(usuario);
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

        // Ignoramos mayúsculas/minúsculas para la comparación
        return char.ToUpper(dniCompleto[8]) == LetrasDNI[numeroDNI % 23];
    }

    public DateTime GetFechaDisponible(Ejemplar ejemplar) //lo necesito para que el personal de adquisiciones pueda saber fechas de disponibilidad de documentos
    {
        if (ejemplar.Documento is Libro) return Persistencia.Persistencia.Instancia.GetPrestamoActivo(ejemplar).FechaFin[0];
        else if (ejemplar.Documento is Audiolibro) return Persistencia.Persistencia.Instancia.GetPrestamoActivo(ejemplar).FechaFin[1];
        return DateTime.MinValue;
    }

    public List<EjemplarPrestado> ObtenerMisPrestamosFiltrados(Persona personaLogueada, string textoBuscar, bool soloPendientes)
    {
        Usuario usuario = Persistencia.Persistencia.Instancia.GetUsuario(personaLogueada.Dni);
        if (usuario == null) return new List<EjemplarPrestado>();
        List<Prestamo> misPrestamos = Persistencia.Persistencia.Instancia.GetPrestamos(usuario);

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

        List<Prestamo> prestamos= consulta.OrderByDescending(p => p.FechaInicio).ToList();
        List<EjemplarPrestado> ejemplares=new List<EjemplarPrestado>();
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
                if (((soloPendientes && p.GetLibrosPendientes().Contains(e)) || !soloPendientes)&&((!string.IsNullOrEmpty(textoBuscar) && d.Titulo.ToLower().Contains(textoBuscar.ToLower())) || string.IsNullOrEmpty(textoBuscar)))
                {
                    ejemplares.Add(new EjemplarPrestado(d.Titulo, d.Autor, d.ISBN, p.FechaInicio, p.FechaFin[i], p.GetLibrosPendientes().Contains(e)));
                }
            }
        }
        return ejemplares;
    }
}
