using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FechaDeNacmiento
{
    class ClasePersona
    {
        //Atributos de la clase 
        public int AnioAC, MesAC, diaAC, anioNA, mesNA, diaNA;
       public  string Mayor;

        //Metodo de l clase 
        public void MayorDeEdad ()
        {
            if (AnioAC-anioNA > 18)
            {
                Mayor = "Es mayor";
            }
            else
            {
                if (AnioAC-anioNA == 18)
                {
                    if (MesAC > mesNA)
                    {
                        Mayor = "Es mayor";
                    }
                    else
                    {
                        if (MesAC == mesNA)
                        {
                            if (diaAC < diaNA)
                            {
                                Mayor = "Es mayor";
                            }
                            else
                            {
                                if (diaAC == diaNA)
                                {
                                    Mayor = "Es mayor ";
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
