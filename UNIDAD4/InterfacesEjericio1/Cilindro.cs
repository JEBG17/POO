using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesEjericio1
{
    class Cilindro:Volumen
    {
        public double Lado;
        public double Altura;
        public double Resultado;

        public double CacularVolumen()
        {
            Resultado = (3.1416 * (Lado * Lado)) * Altura;
            return Resultado;
            throw new NotImplementedException();
        }

      

     }
}
