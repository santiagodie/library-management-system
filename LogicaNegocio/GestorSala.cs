using ModeloDominio;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;

public class GestorSala : GestorUsuarios
{
	public GestorSala() : base()
	{
	}

	public bool AltaPrestamo(Usuario usuario, List<Ejemplar> ejemplares, PersonalSala responsable)
	{
		
		DateTime[] fechas = new DateTime[2];

		bool hayLibros = false;
		bool hayAudio = false;

        if (usuario is null || !Persistencia.Persistencia.Instancia.ExisteUsuario(usuario.Dni) || usuario.Estado == EstadoUsuario.Sancionado || ejemplares == null || ejemplares.Count==0 || responsable is null)
        {
            return false;
        }

        foreach (var ej in ejemplares)
		{
            if (!ej.Disponible)
            {
                return false;
            }
            if (ej.Documento is Libro) hayLibros=true;
			else if (ej.Documento is Audiolibro)hayAudio=true;
		}

		foreach(var ej in ejemplares) ej.Disponible = false;

            if (hayLibros) fechas[0]= DateTime.Today.AddDays(15);
		if (hayAudio) fechas[1] = DateTime.Today.AddDays(10);

		Prestamo nuevoPrestamo = new Prestamo(fechas, usuario, ejemplares, responsable);
		bool guardado = Persistencia.Persistencia.Instancia.AltaPrestamo(nuevoPrestamo);
		if (guardado)
		{
            Persistencia.Persistencia.Instancia.ActualizarDisponibilidad(ejemplares);
			return true;
		}
		return false;
	}

	public Usuario ConsultarUsuario(Prestamo prestamo) 
	{
		return prestamo.Usuario;
	}

	public bool EstaFinalizado(Prestamo prestamo)
	{
		return prestamo.EstaFinalizado();
	}

	public List<Ejemplar> GetEjemplaresPendientes(Prestamo prestamo)
	{
		return prestamo.EjemplaresPrestados;
	}

    public Prestamo GetPrestamoActivo(Ejemplar ejemplar) //lo necesito también para que el personal de adquisiciones pueda saber fechas de disponibilidad de documentos
    {
        return Persistencia.Persistencia.Instancia.GetPrestamoActivo(ejemplar);
    }

    //Post: devuelve la lista de préstamos hechos por el usuario en ese día 
    public List<Prestamo> GetPrestamos(Usuario usuario, DateTime fecha)
    {
        return Persistencia.Persistencia.Instancia.GetPrestamos(usuario, fecha);
    }

    //Post: devuelve la lista de préstamos hechos por el usuario sobre ese documento
    public List<Prestamo> GetPrestamos(Usuario usuario, Documento documento)
    {
        return Persistencia.Persistencia.Instancia.GetPrestamos(usuario, documento);
    }

    //Post: devuelve la lista de préstamos hechos sobre ese documento
    public List<Prestamo> GetPrestamos(Documento documento)
    {
        return Persistencia.Persistencia.Instancia.GetPrestamos(documento);
    }


    public bool DevolverEjemplar(Ejemplar ejemplar)
	{
		Prestamo prestamo = GetPrestamoActivo(ejemplar);
		if(prestamo == null) return false;
		if(!prestamo.DevolverEjemplar(ejemplar)) return false;
		ejemplar.Disponible = true;
		if(!Persistencia.Persistencia.Instancia.ActualizarEjemplar(ejemplar)) return false;
		if(!Persistencia.Persistencia.Instancia.ActualizarPrestamo(prestamo)) return false;
		return true;
	}

    //Post: devuelve la lista de todos los préstamos con algún ejemplar retrasado
	public List<Prestamo> GetPrestamosRetrasados()
    {
        List<Prestamo> lista = new List<Prestamo>();

        var prestamos = Persistencia.Persistencia.Instancia.GetPrestamos();
        if (prestamos == null) return lista;

        foreach (Prestamo prestamo in prestamos)
        {
            if (prestamo == null || prestamo.FechaFin == null || prestamo.FechaFin.Length != 2) continue;

            if (prestamo.QuedanLibros() && DateTime.Today > prestamo.FechaFin[0])
			{
				lista.Add(prestamo);
			}
			else if (prestamo.QuedanAudios() && DateTime.Today > prestamo.FechaFin[1])
            {
                lista.Add(prestamo);
            }
        }
        return lista;
    }

    //Post: devuelve la lista de todos los ejemplares retrasados del préstamo
    public List<Ejemplar> GetEjemplaresRetrasados(Prestamo prestamo)
	{
        List<Ejemplar> lista = new List<Ejemplar>();
        if ( DateTime.Today > prestamo.FechaFin[0])
        {
            lista.AddRange(prestamo.GetLibrosPendientes());
        }
        if ( DateTime.Today > prestamo.FechaFin[1])
        {
            lista.AddRange(prestamo.GetAudiosPendientes());
        }
		return lista;

    }

    //Post: devuelve todos los ejemplares en préstamo actualmente
	public List<Ejemplar> GetEjemplaresPrestamo()
	{
		List<Ejemplar> lista = new List<Ejemplar>();
		foreach (Prestamo prestamo in Persistencia.Persistencia.Instancia.GetPrestamos()) {
			lista.AddRange(prestamo.EjemplaresPrestados);
			//lista.AddRange(prestamo.EjemplaresDevueltos);
		}
		return lista;
	}
}