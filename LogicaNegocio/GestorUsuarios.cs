using System;
using System.Collections.Generic;
using ModeloDominio;
using Persistencia;

public class GestorUsuarios
{
   protected Persistencia persistencia;

    const string LetrasDNI = "TRWAGMYFPDXBNJZSQVHLCKE";

    public GestorUsuarios()
	{
        this.persistencia = new Persistencia();
	}

    public bool AltaUsuario(Usuario usuario)
    {
        if (this.persistencia.ExisteUsuario(usuario.Id))
        {
            Console.WriteLine($"Error: El usuario con ID {usuario.Id} ya existe.");
            return false;
        }

        if (string.IsNullOrEmpty(usuario.Nombre) || string.IsNullOrEmpty(usuario.Dni) || string.IsNullOrEmpty(usuario.Contraseña))
        {
            Console.WriteLine("Error: El nombre, DNI y contraseña son obligatorios.");
            return false;
        }

        if (!EsDniValido(usuario.Dni))
        {
            Console.WriteLine("Error: El DNI no es válido.");
            return false;
        }

        return persistencia.AltaUsuario(usuario);
    }

    public bool BajaUsuario(Usuario usuario)
    {
        return persistencia.BajaUsuario(usuario);
    }

    public Usuario ConsultarUusuario(String Dni)
    {
       return Persistencia.GetUsuario(Dni);
    }

    public List<Usuario> GetListaUsuarios()
    {
        return persistencia.GetListaUsuarios();
    }
    
    public List<Prestamo> GetPrestamosRetrasados(Usuario usuario)
    {
        return persistencia.GetPrestamosRetrasados(usuario);
    }

    public List<Ejemplar> GetEjemplaresPrestados(Usuario usuario)
    {
        return persistencia.GetEjemplaresPrestados(usuario);
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
}
