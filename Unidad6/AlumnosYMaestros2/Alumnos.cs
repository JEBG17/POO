using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlumnosYMaestros2
{
	class Alumnos:Personas
	{
		public int NumeroControl { set; get; }
		public string Carrera { get; set; }
		//constructor 
		public Alumnos()
		{
			NumeroControl = 0;
			Carrera = "";
		}
		//declaracion del arreglo multidimensional
		public string[,] MateriasyCal;
	
	}
}
