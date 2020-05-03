
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TorneoFutbol
{
	class Torneo
	{
		public string NombreTorneo { get; set; }
		public int NumeroEquipos { get; set; }
		public int NumeroPartidosEquipos { get; set; }
		public string FechaInicio { get; set; }
		public string FechaFin { get; set; }
		//Arreglo Multidimensional
		public int[,] PuntosXPartidos;
		//Arreglo Unidemencional
		public int[] SumaPuntaje;
		public string[] NombreDeEquipos;

		//Construcutor de la clase 
		public Torneo ()
		{
			NombreTorneo = "";
			NumeroEquipos = 0;
			NumeroPartidosEquipos = 0;
			FechaInicio = "";
			FechaFin = "";

		}

	
	}
}
