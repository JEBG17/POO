using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatosDePersonas
{
    class ClassPersona
    {
        //atributos de la clase
        public int fecha = 0, mayorEdad = 0, Nayarit = 0, telefono;
        public int alumno = 0, docente = 0, administrativo = 0;
        public string estado, tipo;

        int anioNac, mesNac, diaNac, anioAct, mesAct, diaAct;

        //metodo de la clase 
        public void Registro()
        {
            
        }
        public void FechaNacimiento()
        {
           if (anioAct-anioNac >18)
           {
                mayorEdad++;
           }
           else if (anioAct-anioNac==18)
           {

           }
           if (mesAct > mesNac)
           {

           }
           else if (mesAct==mesNac)
           {

           }
           if (diaAct>diaNac)
           {
                mayorEdad++;
           }
        }
        public void Estado()
        {
            if (estado == "Nayrit")
            {
                Nayarit++;
            }
        }
        public void Tipo()
        {
            switch(tipo)
            {
                case "Alumno":
                    {
                        alumno++;
                        break;
                    }
                case "Docente":
                    {
                        docente++;
                        break;
                    }
                default:
                    {
                        administrativo++;
                        break;
                    }
            }
        }
        public void Telefono()
        {
            if (telefono<0)
            {
                
            }
        }
    }
}
