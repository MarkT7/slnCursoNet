using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Autor
{
	public string Nombre { get; set; }
	public string Apellido { get; set; }
	public DateTime FechaNacimiento { get; set; }
	public string Domicilio { get; set; }
	public string Ciudad { get; set; }
	public string Pais { get; set; }
	public List<Titulo> Titulos { get; set; };

    public Autor()
	{
	}

	public Autor(string nombre, string apellido, DateTime fechanacimiento,
		string domicilio, string ciudad, string pais, List<Titulo> titulos)
	{
		Nombre = nombre;
		Apellido = apellido;
		FechaNacimiento = fechanacimiento;
		Domicilio = domicilio;
		Ciudad = ciudad;
		Pais = pais;
		Titulos = titulos;
	}
}
