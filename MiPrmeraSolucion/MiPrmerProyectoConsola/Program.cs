using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPrmerProyectoConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B, C;
            Console.Write("Introduce un número: ");
            A = Convert.ToInt32(Console.ReadLine());

            Console.Write("Itroduce otro número: ");
            B = Convert.ToInt32(Console.ReadLine());
            C = A + B;

            Console.WriteLine("La suma de los numeros es: " + C);
            Console.ReadKey();
        }
    }
}
