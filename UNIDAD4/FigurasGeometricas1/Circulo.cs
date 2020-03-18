using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigurasGeometricas1
{
    class Circulo : Figuras
    {
        public override double Perimetro()
        {
            Perimetro1 = (Lado * 2) * 3.1416;
            return Perimetro1;

        }
        public override double Area()
        {
            Area1 = 3.1416 * (Lado * Lado);
            return Area1;

        }
    }
}
