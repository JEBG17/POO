using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComisionDeElectricidad
{
    class ClassRecibo
    {
        //Atributos de la clase
        public double Kilowatts=0, Kw=0;
        public string Tipo;

        // metodo de la clase 
        public void CalcularPago()
        {
           switch(Tipo)
           {
                case "Hogar":
                    {
                        if (Kilowatts>0 & Kilowatts <= 250)
                        {
                            Kw = Kilowatts * 0.65;
                        }
                        else if (Kilowatts > 250 & Kilowatts <= 500)
                        {
                            Kw = Kilowatts * 0.85;
                        }
                        else if (Kilowatts > 500 & Kilowatts <= 1200)
                        {
                            Kw = Kilowatts * 1.5;
                        }
                        else if(Kilowatts>1200 & Kilowatts<=2100)
                        {
                            Kw = Kilowatts * 2.5;

                        }
                        else
                        {
                            Kw = Kilowatts * 3;
                        }
                        break;

                    }
                case "Negocio":
                    {
                        Kw = Kilowatts * 5;
                        break;
                    }
           }
        }
    }
}
