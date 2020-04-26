using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlumnosYMaestrosNo2
{
	class Perosonas
	{

		//declaracion de variables 
		public string NombreCompleto { set; get; }
		public DateTime FechaNacimiento { get; set; }
		public string Curp { get; set; }
		public int Telefono { get; set; }
		public string Correo { get; set; }

		//constructor
		public Perosonas()
		{
			NombreCompleto = "";
			Curp = "";
			Telefono = 0;
			Correo = "";
		}
	}
}
