using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caseta
{
    class ClassVehiculo
    {
        //atributos de la clase
        public string vehiculo;
        public int vehi;
        //metodos de la clase
        public void Cobrar()
        {
            switch(vehiculo)
            {
                case "Motociclista":
                    {
                        vehi = 50;
                        break;
                    }
                case "Automóvil":
                    {
                        vehi = 112;

                        break;
                    }
                case "Autobús":
                    {
                        vehi = 170;
                        break;
                    }
                case "Tráiler":
                    {
                        vehi = 250;
                        break;
                    }
            }

        }
    }
}
