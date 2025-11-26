using Microsoft.SqlServer.Server;
using System;
using System.Collections.ObjectModel;
using System.Security.Policy;

public class KeyedList<TItem> : KeyedCollection<string,TItem>
{
	public KeyedList() : base()
	{

	}
	protected override string GetKeyForItem(TItem item)
	{
		return "";
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
	public Entidad ObtenerDatos(string clave)
	{
		if (this.Dictionary.TryGetValue(clave, out Entidad entidad))
		{
			return entidad;
		}
		return null;
	}
	public bool BorrarFila(string clave)
	{
		return this.Dictionary.Remove(clave);
	}
    // ✅ CORRECTO
    public bool ModificarFila(string clave, string columna, Object dato)
    {
        if (this.Dictionary.TryGetValue(clave, out Entidad entidad))  
        {
            return entidad.ModificarDato(columna, dato);
        }
        return false;  
    }
    public Object ObtenerUnDato(string clave,string columna)
	{
        if (this.Dictionary.TryGetValue(clave, out Entidad entidad)){
            return entidad.ObtenerDato(columna);
        }
        return null;
    }
}
