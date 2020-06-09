using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlumnosYMmaestros1
{
	class DatosPersona
	{
		//declaracion de variables 
		public string NombreCompleto { set; get; }
		public DateTime FechaNacimiento { get; set; }
		public string Curp { get; set; }
		public int Telefono { get; set; }
		public string Correo { get; set; }

		//constructor
		public DatosPersona()
		{
			NombreCompleto = "";
			Curp = "";
			Telefono = 0;
			Correo = "";
		}
	}
}
