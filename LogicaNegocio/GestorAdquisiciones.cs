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

        if (Persistencia.ExisteDocumento(documento.ISBN)) return false;

        if (documento is Audiolibro audio)
        {
            if (audio.Formato == 0) return false;
        }

        return Persistencia.AltaDocumento(documento);
    }

	public bool AltaEjemplar(string localizacion, bool disponible, Documento documento, PersonalAdquisiciones responsable)
	{
		if (documento == null || responsable == null || !Persistencia.ExisteDocumento(documento.ISBN) || string.IsNullOrEmpty(localizacion)) return false;

        return Persistencia.AltaEjemplar(new Ejemplar(localizacion, disponible, documento, responsable));
	}

    public bool BajaEjemplar(Ejemplar ejemplar)
    {
        if (ejemplar == null || !Persistencia.ExisteEjemplar(ejemplar.Codigo)) return false;

        return Persistencia.BajaEjemplar(ejemplar);

    }

    public Ejemplar ConsultarEjemplar(string idEjemplar) 
    { 
        if(string.IsNullOrEmpty(idEjemplar)|| !Persistencia.ExisteEjemplar(idEjemplar)) return null;

        return Persistencia.GetEjemplar(idEjemplar);
    }

    public bool HayDisponibles(Documento documento)
    {
        if(documento == null || !Persistencia.ExisteDocumento(documento.ISBN)) return false;
        var ejemplares = Persistencia.GetEjemplares(documento);
        return ejemplares.Any(e => e.Disponible);
    }

    public DateTime? FechaDisponible(Documento documento)
    {
        if (documento == null || !Persistencia.ExisteDocumento(documento.ISBN)) return null;

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
        List<Prestamo> prestamos = Persistencia.GetPrestamos();

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
        return Persistencia.GetDocumentos();
    }

    public List<Ejemplar> GetEjemplares(Documento documento)
    {
        return Persistencia.GetEjemplares(documento);
    }
}
