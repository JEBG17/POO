using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vacaciones
{
    class ClassEmpleado
    {
        //atributos de la clase
        public int aTrabajo,unAnio;

        //metodo de la clase
        public void Vacaciones()
        {
            if (aTrabajo <= 5)
            {
                unAnio = 5;
            }
            else if (aTrabajo >= 6 & aTrabajo < 11)
            {
                unAnio = 10;

            }
            else if (aTrabajo>=11 & aTrabajo<20)
            {
                unAnio = (aTrabajo-10)+10;
            }
            else if(aTrabajo>20 & aTrabajo<33)
            {
                unAnio = (aTrabajo - 10) * 2;
            }
            else
            {
                unAnio = 45;
            }
        }
    }
}
