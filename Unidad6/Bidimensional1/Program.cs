﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Bidimensional1
{
	class Program
	{
		static void Main(string[] args)
		{
			StreamWriter archivoMatrices;
			int[,] notas1 = new int[2, 2]; // 2 bloques de 2 datos
			notas1[0, 0] = 1;
			notas1[0, 1] = 2;
			notas1[1, 0] = 3;
			notas1[1, 1] = 4;

			int[,] notas2 = // 2 bloques de 10 datos, prefijados
			{

			{1, 2, 3, 4, 5, 6, 7, 8, 9, 10},
			{11, 12, 13, 14, 15, 16, 17, 18, 19, 20}

			};

			Console.WriteLine("La nota1 del segundo alumno del grupo 1 es {0}",
				notas1[0, 1]);
			Console.WriteLine("La nota2 del tercer alumno del grupo 1 es {0}",
				notas2[0, 2]);

			archivoMatrices = new StreamWriter("ArchivoMatrices");
			archivoMatrices.WriteLine("La nota1 del segundo alumno del grupo 1 es {0}",
				notas1[0, 1]);
			archivoMatrices.WriteLine("La nota2 del tercer alumno del grupo 1 es {0}",
				notas2[0, 2]);

			Console.ReadKey();
		}
	}
}
