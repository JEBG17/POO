using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpleadosRestaurante
{
    class Repartidor: Empleado
    {
        public override double calcularSueldo()
        {
            if (Repartidor=="Zona 1")
            {
                Sueldo = Sueldo + (5 * Reparto);
            }
            else if (Repartidor=="Zona 2")
            {
                Sueldo = Sueldo + (2 * Reparto);
            }
            return Sueldo ;
        }
    }
}
