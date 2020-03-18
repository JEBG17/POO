using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigurasGeometricas1
{
    class TrianguloEquilatero:Triangulo
    {
        public override double Perimetro()
        {
            Perimetro1 = Lado * 3;
            return base.Perimetro1;
        }
        public override double Area()
        {
            Area1 = (Lado * Altura) / 2;
            return base.Area1;
        }
    }
}
