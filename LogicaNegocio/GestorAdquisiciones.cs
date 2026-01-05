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

	//PRE: documento no puede ser nulo y debe tener todos los campos obligatorios (Titulo, Editorial, Autor, ISBN). Si es audiolibro, debe tener formato válido.
	//POST: da de alta el documento en la persistencia. Devuelve true si se creó correctamente, false en caso contrario.
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

	//PRE: documento y responsable no pueden ser nulos. El documento debe existir en la persistencia. Localizacion no puede ser vacía.
	//POST: da de alta un nuevo ejemplar en la persistencia. Devuelve true si se creó correctamente, false en caso contrario.
	public bool AltaEjemplar(string localizacion, bool disponible, Documento documento, PersonalAdquisiciones responsable)
	{
		if (documento == null || responsable is null || !Persistencia.Persistencia.ExisteDocumento(documento.ISBN) || string.IsNullOrEmpty(localizacion)) return false;

        return Persistencia.Persistencia.AltaEjemplar(new Ejemplar(localizacion, disponible, documento, responsable));
	}

	//PRE: ejemplar no puede ser nulo y debe existir en la persistencia.
	//POST: da de baja el ejemplar en la persistencia. Devuelve true si se dio de baja correctamente, false en caso contrario.
    public bool BajaEjemplar(Ejemplar ejemplar)
    {
        if (ejemplar == null || !Persistencia.Persistencia.ExisteEjemplar(ejemplar.Codigo)) return false;

        return Persistencia.Persistencia.BajaEjemplar(ejemplar);

    }

	//PRE: idEjemplar no puede ser nulo o vacío. El ejemplar debe existir en la persistencia.
	//POST: devuelve el ejemplar con el código especificado, o null si no existe.
    public Ejemplar ConsultarEjemplar(string idEjemplar)
    { 
        if(string.IsNullOrEmpty(idEjemplar)|| !Persistencia.Persistencia.ExisteEjemplar(idEjemplar)) return null;

        return Persistencia.Persistencia.GetEjemplar(idEjemplar);
    }

	//PRE: documento no puede ser nulo y debe existir en la persistencia.
	//POST: devuelve true si hay al menos un ejemplar disponible del documento, false en caso contrario.
    public bool HayDisponibles(Documento documento)
    {
        if(documento == null || !Persistencia.Persistencia.ExisteDocumento(documento.ISBN)) return false;
        var ejemplares = Persistencia.Persistencia.GetEjemplares(documento);
        return ejemplares.Any(e => e.Disponible);
    }

	//PRE: documento no puede ser nulo y debe existir en la persistencia.
	//POST: devuelve la fecha más próxima en que estará disponible un ejemplar del documento. Si hay disponibles ahora, devuelve DateTime.Now. Si no existe, devuelve null.
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

    //PRE: ---
    //POST: devuelve el documento más prestado en los últimos 30 días, o null si no hay préstamos en ese período.
    public Documento DocumentoMasLeidoMes()
    {
        List<Prestamo> prestamos = Persistencia.Persistencia.GetPrestamos();

        DateTime haceUnMes = DateTime.Today.AddDays(-30);

        var documentoTop = prestamos
            .Where(p => p != null && p.FechaInicio >= haceUnMes 
                        && p.EjemplaresPrestados != null && p.EjemplaresPrestados.Count > 0)
            .SelectMany(p => p.EjemplaresPrestados)
            .GroupBy(e => e.Documento.Titulo)
            .OrderByDescending(grupo => grupo.Count())
            .FirstOrDefault();

        if (documentoTop == null) return null;

        return documentoTop.First().Documento;
    }

    //PRE: ---
    //POST: devuelve la lista de todos los documentos en la persistencia.
    public List<Documento> GetDocumentos()
    {
        return Persistencia.Persistencia.GetDocumentos();
    }

	//PRE: documento no puede ser nulo.
	//POST: devuelve la lista de todos los ejemplares del documento especificado.
    public List<Ejemplar> GetEjemplares(Documento documento)
    {
        return Persistencia.Persistencia.GetEjemplares(documento);
    }
}
