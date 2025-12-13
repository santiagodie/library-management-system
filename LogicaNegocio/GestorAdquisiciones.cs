using ModeloDominio;
using Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;

public class GestorAdquisiciones : GestorUsuarios
{

    public GestorAdquisiciones() : base()
	{
	}

	public bool AltaDocumento(Documento documento)
	{
        if (documento == null || string.IsNullOrEmpty(documento.Titulo) || string.IsNullOrEmpty(documento.Editorial) || string.IsNullOrEmpty(documento.Autor) || string.IsNullOrEmpty(documento.ISBN)) return false;

        if (Persistencia.Persistencia.ExisteDocumento(documento.ISBN)) return false;

        if (documento is Audiolibro audio)
        {
            if (audio.Formato == 0) return false;
        }

        return Persistencia.Persistencia.AltaDocumento(documento);
    }

	public bool AltaEjemplar(string localizacion, bool disponible, Documento documento, PersonalAdquisiciones responsable)
	{
		if (documento == null || responsable is null || !Persistencia.Persistencia.ExisteDocumento(documento.ISBN) || string.IsNullOrEmpty(localizacion)) return false;

        return Persistencia.Persistencia.AltaEjemplar(new Ejemplar(localizacion, disponible, documento, responsable));
	}

    public bool BajaEjemplar(Ejemplar ejemplar)
    {
        if (ejemplar == null || !Persistencia.Persistencia.ExisteEjemplar(ejemplar.Codigo)) return false;

        return Persistencia.Persistencia.BajaEjemplar(ejemplar);

    }

    public Ejemplar ConsultarEjemplar(string idEjemplar) 
    { 
        if(string.IsNullOrEmpty(idEjemplar)|| !Persistencia.Persistencia.ExisteEjemplar(idEjemplar)) return null;

        return Persistencia.Persistencia.GetEjemplar(idEjemplar);
    }

    public bool HayDisponibles(Documento documento)
    {
        if(documento == null || !Persistencia.Persistencia.ExisteDocumento(documento.ISBN)) return false;
        var ejemplares = Persistencia.Persistencia.GetEjemplares(documento);
        return ejemplares.Any(e => e.Disponible);
    }

    public DateTime? FechaDisponible(Documento documento)
    {
        if (documento == null || !Persistencia.Persistencia.ExisteDocumento(documento.ISBN)) return null;

        if (HayDisponibles(documento)) return DateTime.Now;

        DateTime fecha = DateTime.MaxValue;

        foreach(var ej in GetEjemplares(documento))
        {
            if (fecha > GetFechaDisponible(ej)) fecha = GetFechaDisponible(ej);
        }
        return fecha;
    }

    public Documento DocumentoMasLeidoMes()
    {
        List<Prestamo> prestamos = Persistencia.Persistencia.GetPrestamos();

        DateTime haceUnMes = DateTime.Today.AddDays(-30);

        var documentoTop = prestamos
            .Where(p => p.FechaInicio >= haceUnMes)
            .SelectMany(p => p.EjemplaresPrestados)
            .GroupBy(e => e.Documento.Titulo)
            .OrderByDescending(grupo => grupo.Count())
            .FirstOrDefault();

        if (documentoTop == null) return null;

        return documentoTop.First().Documento;
    }

    public List<Documento> GetDocumentos()
    {
        return Persistencia.Persistencia.GetDocumentos();
    }

    public List<Ejemplar> GetEjemplares(Documento documento)
    {
        return Persistencia.Persistencia.GetEjemplares(documento);
    }
}
