using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoStreams
{
	class Program
	{
		static void Main(string[] args)
		{
			using (Stream fs = new FileStream("./escribirarchivo.txt ", FileMode.Create, FileAccess.Write))
			{

				using (StreamWriter Sw = new StreamWriter(fs))
				{
					Sw.WriteLine("Hola, este es un archivo escrito desde C#");

				}

				
			}
			Console.ReadKey();
		}  
	}
}
