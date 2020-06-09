using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoStreams
{
	class Ejemplo
	{
		public void abrirArchivo()
		{
			Stream fs = new FileStream("./archivo.txt ", FileMode.Open, FileAccess.Read);

			//obter numero de byts
			long quantity = fs.Length;
			Console.WriteLine($"El archivo tiene una longitud de {quantity} Byts");

			for (long count = 0; count < quantity; count++)
			{
				fs.Seek(count, SeekOrigin.Begin);
				int valor = fs.ReadByte();
				Console.WriteLine($"Posicion {count} {(char)valor}");
			}
			// cerrar stream
			fs.Close();

			Console.ReadKey();
		}
		public void LeerByteAByte()
		{
			Stream fs = new FileStream("./archivo.txt ", FileMode.Open, FileAccess.Read);

			//obter numero de byts
			long quantity = fs.Length;
			Console.WriteLine($"El archivo tiene una longitud de {quantity} Byts");

			int valor = 0;
			while (valor != -1)
			{
				valor = fs.ReadByte();
				if (valor != -1)
				{
					Console.WriteLine($"{ (char)valor}");
				}
			}
			Console.ReadKey();

		}	
		public void LeerLinea()
		{
			Stream fs = new FileStream("./archivo.txt ", FileMode.Open, FileAccess.Read);

			//obter numero de byts
			long quantity = fs.Length;
			Console.WriteLine($"El archivo tiene una longitud de {quantity} Byts");

			StreamReader Sr = new StreamReader(fs);
			string linea = Sr.ReadLine();
			Console.WriteLine(linea);

			while (!Sr.EndOfStream)
			{
				Console.WriteLine(Sr.ReadLine());

			}
			fs.Close();


			Console.ReadKey();
		}
		public void Linea()
		{
			Stream fs = new FileStream("./archivo.txt ", FileMode.Open, FileAccess.Read);

			//obter numero de byts
			long quantity = fs.Length;
			Console.WriteLine($"El archivo tiene una longitud de {quantity} Byts");

			StreamReader Sr = new StreamReader(fs);
			string Todo = Sr.ReadToEnd();
			Console.WriteLine(Todo);
			fs.Close();

			Console.ReadKey();
		}
		public void Escribir()
		{
			Stream fs = new FileStream("./escribirarchivo.txt ", FileMode.Create, FileAccess.Write);

			StreamWriter Sw = new StreamWriter(fs);

			Sw.WriteLine("Hola, este es un archivo escrito desde C#");

			Sw.Close();
			fs.Close();

			Console.ReadKey();
		}
		
	}
}
