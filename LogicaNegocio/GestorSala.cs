using ModeloDominio;
using System;
using System.Collections.Generic;

public class GestorSala : GestorUsuarios
{
	public GestorSala() : base()
	{
	}

	public bool SetPrestamo(Usuario usuario, Ejemplar[] ejemplares)
	{
		return persistencia.SetPrestamo(GenerarFechaFin(), usuario, ejemplares);
	}

	public bool DevolverEjemplar(Ejemplar ejemplar, Prestamo prestamo)
	{
		return prestamo.DevolverEjemplar(ejemplar);
	}

	public List<Prestamo> GetEjemplaresPrestamo()
	{
        List<Prestamo> lista = new List<Prestamo>;
		foreach (Prestamo prestamo in Persistencia.GetPrestamos) {
			//lista.Add(prestamo.EjemplaresPrestados);
			//lista.Add(prestamo.EjemplaresDevueltos);
		}

	private DateTime GenerarFechaFin()
	{
		return DateTime.Now.AddDays(15);
	}
}