using System;
using System.Collections.Generic;
using ModeloDominio;
using Persistencia;

public class GestorUsuarios
{

    const string LetrasDNI = "TRWAGMYFPDXBNJZSQVHLCKE";

    public GestorUsuarios()
	{
	}

    public bool AltaUsuario(Usuario usuario)
    {
        if (Persistencia.ExisteUsuario(usuario.Dni))
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

        return Persistencia.AltaUsuario(usuario);
    }

    public bool BajaUsuario(Usuario usuario)
    {
        return Persistencia.BajaUsuario(usuario);
    }

    public Usuario ConsultarUusuario(String Dni)
    {
       return Persistencia.GetUsuario(Dni);
    }

    public List<Usuario> GetListaUsuarios()
    {
        return Persistencia.GetListaUsuarios();
    }

    public List<Prestamo> GetPrestamosRetrasados(Usuario usuario)
    {
        var todos = Persistencia.GetPrestamos(usuario);

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
        var todos = Persistencia.GetPrestamos(usuario);
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
        if(ejemplar.Documento is Libro) return Persistencia.GetPrestamoActivo(ejemplar).FechaFin[0];
        else if (ejemplar.Documento is Audiolibro) return Persistencia.GetPrestamoActivo(ejemplar).FechaFin[1];
        return DateTime.MinValue;
    }
}
