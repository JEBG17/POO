using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigurasGeometricas1
{
    class Cuadrado:Figuras
    {
        public override double Perimetro()
        {
            Perimetro1 = Lado * 4;
            return Perimetro1;
            throw new NotImplementedException();


        }
        public override double Area()
        {
            Area1 = Lado * Lado;
            return Area1;
            throw new NotImplementedException();
        }
        

    }
}
