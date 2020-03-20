using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesEjericio1
{
    class Piramide : Volumen
    {
        public double Lado;
        public double Altura;
        public double Resultado;

        public double CacularVolumen()
        {
            Resultado = ((Lado * Lado) * Altura) * 1 / (3);
            return Resultado;
            throw new NotImplementedException();
        }

       
    }
}