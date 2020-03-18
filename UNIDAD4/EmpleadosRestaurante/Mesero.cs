using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpleadosRestaurante
{
    class Mesero:Empleado
    {
        

        
        public override double calcularSueldo()
        {
            Sueldo = Propina + Sueldo;
            return Sueldo;
        }
    }
}
