using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaPerimetroCuadrado
{
    class ClassCuadrado
    {
        //Atributos de la clase
        public double a, p,lado;
        //metodo de la clase 
        public void Calcular()
        {
            a = lado * 4;

            p = lado * lado;
        }
    }
}
