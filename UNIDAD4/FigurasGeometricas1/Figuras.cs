using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigurasGeometricas1
{
    abstract class Figuras
    {
        private double lado, altura, perimetro, area, lado2, lado3;

        //Constructor de la clase
        public Figuras()
        {
            lado = 0;
            lado2 = 0;
            lado3 = 0;
            altura = 0;
            perimetro = 0;
            area = 0;
        }

        public double Lado
        {
            set
            {
                lado = value;

            }
            get
            {
                return lado;
            }
        }
        public double Altura
        {
            set
            {
                altura = value;
            }
            get
            {
                return altura;
            }
        }
        public double Perimetro1
        {
            set
            {
                perimetro = value;
            }
            get
            {
                return perimetro;
            }
        }
        public double Area1
        {
            set
            {
                area = value;
            }
            get
            {
                return area;
            }
        }
        public double Lado2
        {

            set
            {
                lado2 = value;
            }
            get
            {
                return lado2;
            }
        }
        public double Lado3
        {
            set
            {
                lado3 = value;
            }
            get
            {
                return lado3;
            }
        }

        public abstract double Perimetro();

        public abstract double Area();

    }
}
