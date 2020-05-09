using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrizSumaFCD
{
    class Elementos
    {
        public int[,] arregloBid;
        public int[] sumaFila;
        public int[] sumaColumna;
        public int[] sumaDiagonal;
        public int s = 0;
        public int t { set; get; }

        //matodos
        public void ObtenerArregloSumaFilas()
        {

            for (int j = 0; j < t; j++)
            {
                s = 0;
                for (int i = 0; i < t; i++)
                {
                    s = s + arregloBid[i, j];
                    sumaFila[i] = s;

                }

            }

        }
        public void ObtenerArregloSumaColumnas()
        {
            for (int i = 0; i < t; i++)
            {
                s = 0;

                for (int j = 0; j < t; j++)
                {
                    s = s + arregloBid[i, j];
                    sumaColumna[i] = s;
                }

            }


        }
        public void ObtenerArregloSumaDiagonal()
        {
            for (int i = 0; i < t; i++)
            {

                for (int j = 0; j < t; j++)
                {
                    if (i == j)
                    {
                        sumaDiagonal[i] += arregloBid[i, j];
                    }


                }

            }



        }
    }
}
