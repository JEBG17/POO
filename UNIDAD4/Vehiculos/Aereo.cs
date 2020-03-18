using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehiculos
{
    class Aereo:classVehiculo
    {
       public int NumTurbinas, numAlas, numHelices;
        public string TipoAereo, estado;


        public Aereo()
        {
            numAlas = 0;
            NumTurbinas = 0;
            numHelices = 0;
            TipoAereo = "";

        }

        public string enVuelo()
        {
            estado = " Volando";
            return"EL "+TipoAereo +" esta "+ estado;
        }
    }
}
