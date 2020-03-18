using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operaciones
{

    class Operacion
    {
        //Atributos de la clase 
        double num1,num2,res;

        //Constructor
        public Operacion()
        {
            num1 = 0;
            num2 = 0;
            res = 0;
        }
        //Setter y getters
        public double Num1
        {
            set
            {
                num1 = value;
            }
            get
            {
                return num1;
            }
        }
        public double Num2
        {
            set
            {
                num2 = value;
            }
            get
            {
                return num2;
            }
        }
        public double Res
        {
            set
            {

            }
            get
            {
                return res;
            }
        }
     
    }
}
