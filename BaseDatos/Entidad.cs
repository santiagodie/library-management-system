using System;

public abstract class Entidad
{
	public abstract string ObtenerClave();
	public abstract bool ModificarDato(string nombre, Object dato);
	public abstract Object ObtenerDato(string nombre);
}
