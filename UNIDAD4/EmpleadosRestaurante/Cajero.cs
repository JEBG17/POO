using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpleadosRestaurante
{
    class Cajero:Empleado
    {

        public override double calcularSueldo()
        {
            if (Cajero== "Caja 1")
            {
                Sueldo = Sueldo;
            }
            else if (Cajero=="Caja 2")
            {
                Sueldo = Sueldo + (Sueldo * .03);
            }

            
            return Sueldo;
        }
    }
}
