using Microsoft.SqlServer.Server;
using System;
using System.Collections.ObjectModel;
using System.Security.Policy;

public class KeyedList<TItem> : KeyedCollection<object,TItem>
{
	public KeyedList() : base()
	{

	}
	protected override Object GetKeyForItem(TItem item)
	{
		return null;
	}
}
public class Tabla : KeyedList<Entidad>
{
	public Tabla() : base()
	{
	}
	public bool AñadirFila(Entidad entidad)
	{
		if (!this.Contains(entidad.ObtenerClave()))
		{
			this.Dictionary.Add(entidad.ObtenerClave(), entidad);
			return true;
		}
		return false;
	}
	public Entidad ObtenerDatos(object clave)
	{
		if (this.Dictionary.TryGetValue(clave, out Entidad entidad))
		{
			return entidad;
		}
		return null;
	}
	public bool BorrarFila(object clave)
	{
		return this.Dictionary.Remove(clave);
	}
	public bool ModificarFila(object clave, string columna, Object dato)
	{
		if (this.Dictionary.TryGetValue(clave, out Entidad entidad)){
			return entidad.ModificarDato(columna, dato);
		}
		return false;
	}
}
