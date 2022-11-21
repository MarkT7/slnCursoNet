using System;

public class Titulo
{
	public string NombreAutor { get; set; };
	public string Titulo { get; set; };
	public string Categoria { get; set; };
	public int Precio { get; set; };
	public string Notas { get; set; };
	public Autor Autor1 { get; set; };


    public Titulo(string nombreautor, string titulo, string categoria, int precio, string notas, Autor autor1)
	{
		NombreAutor = nombreautor;
		Titulo = titulo;
		Categoria = categoria;
		Precio = precio;
		Notas = notas;
		Autor1 = autor1;
	}

	public Titulo()
	{
	}
}
