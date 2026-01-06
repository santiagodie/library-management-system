using ModeloDominio;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;

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

        if (usuario is null || !Persistencia.Persistencia.ExisteUsuario(usuario.Dni) || usuario.Estado == EstadoUsuario.Sancionado || ejemplares == null || ejemplares.Count==0 || responsable is null)
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
		bool guardado = Persistencia.Persistencia.AltaPrestamo(nuevoPrestamo);
		if (guardado)
		{
            Persistencia.Persistencia.ActualizarDisponibilidad(ejemplares);
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
        return Persistencia.Persistencia.GetPrestamoActivo(ejemplar);
    }

    //Post: devuelve la lista de préstamos hechos por el usuario en ese día 
    public List<Prestamo> GetPrestamos(Usuario usuario, DateTime fecha)
    {
        return Persistencia.Persistencia.GetPrestamos(usuario, fecha);
    }

    //Post: devuelve la lista de préstamos hechos por el usuario sobre ese documento
    public List<Prestamo> GetPrestamos(Usuario usuario, Documento documento)
    {
        return Persistencia.Persistencia.GetPrestamos(usuario, documento);
    }

    //Post: devuelve la lista de préstamos hechos sobre ese documento
    public List<Prestamo> GetPrestamos(Documento documento)
    {
        return Persistencia.Persistencia.GetPrestamos(documento);
    }


    public bool DevolverEjemplar(Ejemplar ejemplar)
	{
		Prestamo prestamo = GetPrestamoActivo(ejemplar);
		if(prestamo == null) return false;
		if(!prestamo.DevolverEjemplar(ejemplar)) return false;
		ejemplar.Disponible = true;
		if(!Persistencia.Persistencia.ActualizarEjemplar(ejemplar)) return false;
		if(!Persistencia.Persistencia.ActualizarPrestamo(prestamo)) return false;
		return true;
	}

    public bool DevolverEjemplares(Prestamo prestamo, List<Ejemplar> librosADevolver)
    {
        foreach (Ejemplar ej in librosADevolver)
        {
            if (!prestamo.DevolverEjemplar(ej)) return false;

            ej.Disponible = true;

            Persistencia.Persistencia.ActualizarEjemplar(ej); 
        }

        return Persistencia.Persistencia.ActualizarPrestamo(prestamo);
    }

    //Post: devuelve la lista de todos los préstamos con algún ejemplar retrasado
    public List<Prestamo> GetPrestamosRetrasados()
    {
        List<Prestamo> lista = new List<Prestamo>();

        var prestamos = Persistencia.Persistencia.GetPrestamos();
        if (prestamos == null) return lista;

        foreach (Prestamo prestamo in prestamos)
        {
            if (prestamo == null || prestamo.FechaFin == null || prestamo.FechaFin.Length != 2) continue;

            if (prestamo.Vencido)
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
		foreach (Prestamo prestamo in Persistencia.Persistencia.GetPrestamos()) {
			lista.AddRange(prestamo.EjemplaresPrestados);
			//lista.AddRange(prestamo.EjemplaresDevueltos);
		}
		return lista;
	}
    public List<Prestamo> GetPrestamosActivos()
    {
        return Persistencia.Persistencia.GetPrestamos()
               .Where(p => p != null)
               .Where(p => p.Activo)
               .OrderBy(p => p.FechaVencimiento)
               .ToList();
    }

    public List<string> GetListaCodigosPrestados()
    {
        var prestamosPendientes = Persistencia.Persistencia.GetPrestamos()
                                 .Where(p => !p.EstaFinalizado());

        return prestamosPendientes
            .SelectMany(p => p.EjemplaresPrestados)
            .Select(e => e.Codigo)
            .Distinct()
            .OrderBy(c => c)
            .ToList();
    }

    public List<Prestamo> GetUltimosPrestamos(int cantidad = 20)
    {
        return Persistencia.Persistencia.GetPrestamos()
               .Where(p => p != null)
               .OrderByDescending(p => p.FechaInicio)
               .Take(cantidad)
               .ToList();
    }


    public List<Prestamo> GetUltimasDevoluciones(int cantidad = 20)
    {
        return Persistencia.Persistencia.GetPrestamos()
               .Where(p => p != null)
               .Where(p => p.EjemplaresDevueltos != null && p.EjemplaresDevueltos.Count > 0)
               .OrderByDescending(p => p.FechaInicio)
               .Take(cantidad)
               .ToList();
    }


    //Post: devuelve un listado de préstamos filtrado
    public List<ItemBusquedaPrestamo> BuscarPrestamos( string textoUsuario,string textoTitulo, string textoAutor, string textoISBN, string codigoEjemplar, string tipoFiltro, DateTime? fechaFiltro, string estadoFiltro)
    {
        List<ItemBusquedaPrestamo> resultados = new List<ItemBusquedaPrestamo>();
        var todosLosPrestamos = Persistencia.Persistencia.GetPrestamos();

        foreach (var p in todosLosPrestamos)
        {
            if (p == null) continue;

            if (!string.IsNullOrWhiteSpace(textoUsuario))
            {
                if (!p.Usuario.Nombre.ToLower().Contains(textoUsuario.ToLower().Trim()) &&
                    !p.Usuario.Dni.ToLower().Contains(textoUsuario.ToLower().Trim())) continue;
            }

            if (fechaFiltro.HasValue)
            {
                if (p.FechaInicio.Date != fechaFiltro.Value.Date) continue;
            }

            List<ModeloDominio.Ejemplar> todosEjemplares = new List<ModeloDominio.Ejemplar>();
            todosEjemplares.AddRange(p.EjemplaresPrestados);
            if (p.EjemplaresDevueltos != null) todosEjemplares.AddRange(p.EjemplaresDevueltos);

            foreach (var ej in todosEjemplares)
            {
                if (!string.IsNullOrWhiteSpace(textoTitulo))
                {
                    if (!ej.Documento.Titulo.ToLower().Contains(textoTitulo.ToLower().Trim())) continue;
                }

                if (!string.IsNullOrWhiteSpace(textoAutor))
                {
                    if (!ej.Documento.Autor.ToLower().Contains(textoAutor.ToLower().Trim())) continue;
                }

                if (tipoFiltro != "Todos" && !string.IsNullOrEmpty(tipoFiltro))
                {
                    bool esLibro = ej.Documento is ModeloDominio.Libro;
                    if (tipoFiltro == "Libro" && !esLibro) continue;
                    if (tipoFiltro == "Audiolibro" && esLibro) continue;
                }

                if (!string.IsNullOrWhiteSpace(textoISBN))
                {
                    if (!ej.Documento.ISBN.ToLower().Contains(textoISBN.ToLower().Trim())) continue;
                }

                if (!string.IsNullOrWhiteSpace(codigoEjemplar))
                {
                    if (!ej.Codigo.ToLower().Contains(codigoEjemplar.ToLower().Trim())) continue;
                }

                string estadoTexto = "Prestado";
                DateTime fechaLimite = (ej.Documento is ModeloDominio.Libro) ? p.FechaFin[0] : p.FechaFin[1];
                bool esDevuelto = (p.EjemplaresDevueltos != null && p.EjemplaresDevueltos.Contains(ej));
                bool esVencido = !esDevuelto && (DateTime.Today > fechaLimite);

                if (esDevuelto) estadoTexto = "Devuelto";
                else if (DateTime.Today > fechaLimite)
                {
                    int dias = (DateTime.Today - fechaLimite).Days;
                    estadoTexto = $"Vencido ({dias} días)";
                }

                if (estadoFiltro != "Todos")
                {
                    if (estadoFiltro == "Devueltos" && !esDevuelto) continue;
                    if (estadoFiltro == "Vencidos" && !esVencido) continue;
                    if (estadoFiltro == "Activos" && (esDevuelto || esVencido)) continue;
                }

                resultados.Add(new ItemBusquedaPrestamo
                {
                    PrestamoCompleto = p,
                    DniUsuario = p.Usuario.Dni,
                    Usuario = $"{p.Usuario.Nombre} ({p.Usuario.Dni})",
                    Titulo = ej.Documento.Titulo,
                    Autor = ej.Documento.Autor,
                    Tipo = (ej.Documento is ModeloDominio.Libro) ? "Libro" : "Audiolibro",
                    ISBN = ej.Documento.ISBN,
                    CodigoEjemplar = ej.Codigo,
                    FechaInicio = p.FechaInicio.ToShortDateString(),
                    FechaLimite = (estadoTexto == "Devuelto") ? "-" : fechaLimite.ToShortDateString(),
                    Estado = estadoTexto
                });
            }
        }
        return resultados;
    }

    public List<string> GetListaTitulos()
    {
        return Persistencia.Persistencia.GetDocumentos()
                .Select(d => d.Titulo)
                .Distinct()
                .OrderBy(t => t)
                .ToList();
    }

    public List<string> GetListaAutores()
    {
        return Persistencia.Persistencia.GetDocumentos()
                .Select(d => d.Autor)
                .Where(a => !string.IsNullOrEmpty(a))
                .Distinct()
                .OrderBy(a => a)
                .ToList();
    }

    public List<string> GetListaUsuariosBusqueda()
    {
        return GetListaUsuarios()
                .Select(u => $"{u.Nombre} ({u.Dni})")
                .Distinct()
                .OrderBy(u => u)
                .ToList();
    }

    public List<string> GetListaISBNs()
    {
        return Persistencia.Persistencia.GetDocumentos()
                .Select(d => d.ISBN)
                .Distinct()
                .ToList();
    }

    public List<Ejemplar> GetEjemplaresDisponibles()
    {
        List<Ejemplar> listaFinal = new List<Ejemplar>();

        List<Documento> todosLosDocumentos = Persistencia.Persistencia.GetDocumentos();

        foreach (Documento doc in todosLosDocumentos)
        {
            List<Ejemplar> ejemplaresDelLibro = Persistencia.Persistencia.GetEjemplares(doc);

            foreach (Ejemplar ej in ejemplaresDelLibro)
            {
                if (ej.Disponible)
                {
                    listaFinal.Add(ej);
                }
            }
        }

        return listaFinal;
    }

    public int GetCantidadPrestamosHoy()
    {
        return Persistencia.Persistencia.GetPrestamos().Count(p => p.FechaInicio.Date == DateTime.Today);
    }

    public int GetCantidadPrestamosActivos()
    {
        return Persistencia.Persistencia.GetPrestamos().Count(p => p.Activo);
    }
}

public class ItemBusquedaPrestamo
{
    [Browsable(false)]
    public Prestamo PrestamoCompleto { get; set; }
    public string Usuario { get; set; } //Nombre o dni
    public string Titulo { get; set; }
    public string Autor { get; set; }
    public string Tipo { get; set; }
    public string ISBN { get; set; }
    public string CodigoEjemplar { get; set; }
    public string FechaInicio { get; set; }
    public string FechaLimite { get; set; }
    public string Estado { get; set; }
    public string DniUsuario { get; set; } // lo pongo para poder pinchar en el usuario
}