﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlumnosYMaestrosNo2
{
	class Maestro:Perosonas
	{
		public int NumeroMaestro { get; set; }
		public int Sueldo { get; set; }
		//constructor 
		public Maestro()
		{
			NumeroMaestro = 0;
			Sueldo = 0;
		}
		//Arreglo unidimensional
		public string[] Materias = new string[6];
	}
}
