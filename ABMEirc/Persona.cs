using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABMEirc
{
	public class Persona
	{
		private int Id { get; set; }
		private string Nombre { get; set; }
		
		public Persona(string nombre)
		{
			this.Nombre = nombre;
		}

		public Persona()
		{}
	
		public string atributoNombre
		{
			get
			{ return this.Nombre; }
			set
			{ this.Nombre = value; }
		}

		public int atributoId
		{
			get
			{ return this.Id; }
			set
			{ this.Id = value; }
		}
	}
}
