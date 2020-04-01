using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioArreglos
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            int suma=0;
            double Promedio;
            //Arreglos 
            int[] calificaciones = { 9, 8, 6, 10, 7 };
            string[] Alumnos = { "Ernesto", "Angel", "Jesus", "Ivan", "Leti" };

            for(i=0; i < calificaciones.Length; i++)
            {
                Console.WriteLine("La nota de {0} es {1}", Alumnos[i], calificaciones[i]);
            }
           for(i=0;i<calificaciones.Length; i++)
            {
                suma = suma + calificaciones[i];
             
            }
            Promedio = suma / calificaciones.Length;
            Console.WriteLine("...........................");
            Console.WriteLine("La suma detodad las calificaciones es: {0}", suma);
            Console.WriteLine("El promedio de las calificaciones es: {0}", Promedio);

            Console.ReadLine();

        }
    }
}
