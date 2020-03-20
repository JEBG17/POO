using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesEjericio1
{
    class Cubo:Volumen
    {
        //Atributos 
        public double Lado;
        public double Resultado;
       
        //implementacion de la interfase

        public double CacularVolumen()
        {
            Resultado = (Lado * Lado) * Lado;
            return Resultado;
            
            throw new NotImplementedException();
        }

       
        
       
    }
}
