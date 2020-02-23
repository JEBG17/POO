using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerimetroAeeaCuadrado
{
    class ClassCuadrado
    {
        //Atributos de la clase
        public double lado,per,area;

        //metodo de la clase
        public void CalcularAreayPerimetro()
        {
            per = lado*4;

            area = lado * lado;

            
        }

    }
}
