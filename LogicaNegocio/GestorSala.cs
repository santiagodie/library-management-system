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

		foreach (var ej in ejemplares)
		{
			if(ej.Documento.Tipo == TipoDocumento.Libro) hayLibros=true;
			else hayAudio=true;
			ej.Disponible = false;
		}

		if (hayLibros)
		{
			fechas[0]= DateTime.Today.AddDays(15);
		}
		if (hayAudio) 
		{
			fechas[1] = DateTime.Today.AddDays(10);
		}

		Prestamo nuevoPrestamo = new Prestamo(fechas, usuario, ejemplares, responsable);
		return Persistencia.AltaPrestamo(nuevoPrestamo);
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

	public Prestamo GetPrestamoActivo(Ejemplar ejemplar)
	{
		return Persistencia.GetPrestamoActivo(ejemplar);
	}

	//Post: devuelve la lista de préstamos hechos por el usuario en ese día 
    public List<Prestamo> GetPrestamos(Usuario usuario, DateTime fecha)
    {
        return Persistencia.GetPrestamos(usuario, fecha);
    }

    //Post: devuelve la lista de préstamos hechos por el usuario sobre ese documento
    public List<Prestamo> GetPrestamos(Usuario usuario, Documento documento)
    {
        return Persistencia.GetPrestamos(usuario, documento);
    }

    //Post: devuelve la lista de préstamos hechos sobre ese documento
    public List<Prestamo> GetPrestamos(Documento documento)
    {
        return Persistencia.GetPrestamos(documento);
    }


    public bool DevolverEjemplar(Ejemplar ejemplar)
	{
		Prestamo prestamo = GetPrestamoActivo(ejemplar);
		if(prestamo == null) return false;
		if(!prestamo.DevolverEjemplar(ejemplar)) return false;
		ejemplar.Disponible = true;
		if(!Persistencia.ActualizarEjemplar(ejemplar)) return false;
		if(!Persistencia.ActualizarPrestamo(prestamo)) return false;
		return true;
	}

    //Post: devuelve la lista de todos los préstamos con algún ejemplar retrasado
	public List<Prestamo> GetPrestamosRetrasados()
    {
        List<Prestamo> lista = new List<Prestamo>();
        foreach (Prestamo prestamo in Persistencia.GetPrestamos())
        {
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
		foreach (Prestamo prestamo in Persistencia.GetPrestamos()) {
			lista.AddRange(prestamo.EjemplaresPrestados);
			//lista.AddRange(prestamo.EjemplaresDevueltos);
		}
		return lista;
	}

	private DateTime GenerarFechaFin(Ejemplar ejemplar)
	{
		if(ejemplar.Documento.Tipo == TipoDocumento.Libro) return DateTime.Now.AddDays(15);
		else return DateTime.Now.AddDays(10); //si es audiolibro
    }


}