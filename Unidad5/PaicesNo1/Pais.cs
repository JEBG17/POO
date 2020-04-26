using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaicesNo1
{
	class Pais
	{
		public string NombreDelPais { set; get; }

		public int PoblacionTotal { set; get; }

		public string IdiomaPredominante { set; get;}

		// Constructor de la clase 
		public Pais()
		{
			NombreDelPais = "";
			PoblacionTotal = 0;
			IdiomaPredominante = "";
		}

		//Declaracion del array
		public string[] ColoresBandera = new string[3];
	}
}
