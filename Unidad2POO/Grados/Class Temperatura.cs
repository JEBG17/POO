using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grados
{
    class Class_Temperatura
    {
        //atributos de la clase
        public double grados,centigrados, fahren;
        public string grado;
        //Metodos de la clase 
        public void calcularGrados()
        {
            if (grado == "Celsius")
            {
                centigrados = (grados * 1.8000) + 32;
            }
            else
            {
                fahren = (grados - 32) / 1.8000;
            }
        }
    }
}
