using ModeloDominio;
using Persistencia;
using System;
using System.Collections.Generic;

public class GestorAdquisiciones : GestorUsuarios
{

    public GestorAdquisiciones() : base()
	{
	}

	public bool AltaDocumento(Documento documento)
	{
        if (documento == null || string.IsNullOrEmpty(documento.Titulo) || string.IsNullOrEmpty(documento.Editorial) || string.IsNullOrEmpty(documento.Autor) || string.IsNullOrEmpty(documento.ISBN)) return false;

        if (Persistencia.ExisteDocumento(documento)) return false;

        if (documento is Audiolibro audio)
        {
            if (audio.Formato == 0) return false;
        }

        return Persistencia.AltaDocumento(documento);
    }

	public bool AltaEjemplar(string localizacion, bool disponible, Documento documento, PersonalAdquisiciones responsable)
	{
		if (documento == null || responsable == null || !Persistencia.ExisteDocumento(documento) || string.IsNullOrEmpty(localizacion)) return false;

        return Persistencia.AltaEjemplar(new Ejemplar(localizacion, disponible, documento, responsable));
	}

    public bool BajaEjemplar(Ejemplar ejemplar)
    {
        if (ejemplar == null || !Persistencia.Existe(ejemplar)) return false;

        return Persistencia.BajaEjemplar(ejemplar);

    }

    public Ejemplar ConsultarEjemplar(string ISBN) 
    {
        if(string.IsNullOrEmpty(ISBN)|| !Persistencia.Existe(ISBN)) return null;

        return Persistencia.GetEjemplar(ISBN);

    }

    public bool HayDisponibles(Documento documento)
    {
        if(documento == null || !Persistencia.Existe(documento)) return false;
        return Persistencia.HayDisponibles(documento);
    }

    public DateTime? FechaDisponible(Documento documento)
    {
        if (documento == null || !Persistencia.Existe(documento)) return null;

        if (HayDisponibles(documento)) return DateTime.Now;

        DateTime fecha = DateTime.MaxValue;

        foreach(var ej in GetEjemplares(documento))
        {
            if (fecha > GetFechaDisponible(ej)) fecha = GetFechaDisponible(ej);
        }
        return fecha;
    }

    public Documento DocumentoMasLeidoMes(Documento documento) //del último mes
    {
        return PersistenciaDocumentoMasLeidoMes(documento);
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
