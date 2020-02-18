using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalificacionesGrupales
{
    class ClassCalificaciones1
    {

        //atributos de la clase
        public decimal PromeioGrupal = 0, sumarCalif = 0;
        public int CalifCapturada = 0, reprobado = 0, aprobado = 0;
        //metodo de la clase
        public void contarAprobados()
        {
            if (CalifCapturada >= 70)
                aprobado++;
            else
                reprobado++;

        }

        public void sumar()
        {
            sumarCalif += CalifCapturada;
        }

        public decimal calcularPromedio()
        {
            PromeioGrupal = sumarCalif / (aprobado + reprobado);
            return PromeioGrupal;

        }
    }
}
