using System;

public class Empleado
{
	public string Nombre { get; set; }
	public string Apellido { get; set; }
	public string Titulo { get; set; }
	public DateTime FechaIngreso { get; set; }

	public Empleado(string nombre, string apellido, string titulo, DateTime fechaingreso)
	{
		Nombre = nombre;
		Apellido = apellido;
		Titulo = titulo;
		FechaIngreso = fechaingreso;
	}

    public Empleado()
	{
	}
}
