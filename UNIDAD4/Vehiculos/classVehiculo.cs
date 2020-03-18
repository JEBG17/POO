using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehiculos
{
    class classVehiculo
    {
        // atributos de l clase 
        public string tipocombusstible, color, sonido;
        public int NumeroLlantas, NumeroPuertas, NumeroVentanas;

        /*constructor de la case, es un metodo que se llama igual que
         la clase  y se ejecita automaticamente al crear elobjeto*/
         public classVehiculo()
        {
            tipocombusstible = "";
            color = "Blanco";
            NumeroLlantas = 1;
            NumeroPuertas = 0;
            NumeroVentanas = 0;
        }
        public string ArrancarMotor()
        {
            sonido=" ( RUN RUN )";
            return "Se arrancó el motor " + sonido;
        }
        public string PararMotor()
        {
            sonido= " ( Rawwadadaaaaw )";
            return "Se detuvó el motor " + sonido;
        }
    }
}
