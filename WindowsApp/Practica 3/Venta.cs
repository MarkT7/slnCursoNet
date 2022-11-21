using System;

public class Venta
{
	public string Tienda { get; set; }
	public int NumeroOrden { get; set; }
	public DateTime Fecha { get; set; }
	public int Cantidad { get; set; }
	public string Titulo { get; set; }

	public Venta(string tienda, int numeroorden, DateTime fecha, int cantidad, string titulo)
	{
		Tienda = tienda;
		NumeroOrden = numeroorden;
		Fecha = fecha;
		Cantidad = cantidad;
		Titulo = titulo;
	}

    public Venta()
	{
	}
}
