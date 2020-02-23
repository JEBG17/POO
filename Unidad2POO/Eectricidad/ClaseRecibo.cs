using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eectricidad
{
    class ClaseRecibo
    {
        //atributos de la claase 
       public double kilow,kw;
       public string tipo;
       //metodos d la clae 
        public void pago ()
        {
            switch (tipo)
            {
                case "Hogar":
                    {
                        if (kilow>=0 & kilow<=250)
                        {
                            kw = (kilow * 0.65);
                        }
                        else if (kilow>250 & kilow<= 500)
                        {
                            kw = kilow * 0.85;
                        }
                        else if(kilow>500 & kilow<=1200)
                        {
                            kw = kilow * 1.5;
                        }
                        else if(kilow>1200 & kilow<=2100)
                        {
                            kw = kilow * 2.5;
                        }
                        else
                        {
                            kw = kilow * 3;
                        }

                        break;
                    }
                case "Negocio":
                    {
                        kw = kilow * 5;

                        break;
                    }

            }
        }
        
    }
}
