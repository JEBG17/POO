using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concierto
{
    class ClassAsistente
    {
        //atributos de clase 
        public int  Bebes = 0, niños = 0, adultos = 0, TEdad = 0,cont=0;
        public string asistente;

        //metodos de la clase
        public int Asisten()
        {
            switch (asistente)
            {
                case "Bebes":
                    Bebes = Bebes + cont;
                    break;
                case "Niños":
                    niños = niños + cont;
                    break;
                case "Adultos":
                    adultos = adultos + cont;
                    break;
                case "Tercera Edad":
                    TEdad = TEdad + cont;
                    break;
            }
            return cont;
        }
    }
}
