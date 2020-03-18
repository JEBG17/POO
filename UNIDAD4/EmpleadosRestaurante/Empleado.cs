using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpleadosRestaurante
{
    abstract class Empleado
    {
        string nombre,cajero,mesero,repartidor;
        double fechaNacimiento, diasTrabajados, sueldo,reparto,propinaSemanal;

        public string Nombre
        {
            set
            {
                nombre = value;
            }
            get
            {
                return nombre;
            }
        }
        public string Mesero
        {
            set
            {
                mesero = value;
            }
            get
            {
                return mesero;
            }
        }
        public string Cajero
        {
            set
            {
                cajero = value;
            }
            get
            {
                return cajero;
            }
        }
        public string Repartidor
        {
            set
            {
                repartidor = value;
            }
            get
            {
                return repartidor;
            }
        }
        public double FechaNacimiento
        {
            set
            {
                fechaNacimiento = value;
            }
            get
            {
                return fechaNacimiento;
            }
        }
        public double DiasTrabajados
        {
            set
            {
                diasTrabajados = value;
            }
            get
            {
                return diasTrabajados;
            }
        }
        public double Sueldo
        {
            set
            {
                sueldo = value;
            }
            get
            {
                return sueldo;
            }
        }
        public double Reparto
        {
            set
            {
                reparto = value;
            }
            get
            {
                return reparto;
            }
        }
        public double Propina
        {
            set
            {
                propinaSemanal = value;
            }
            get
            {
                return propinaSemanal;
            }
        }
        public abstract double calcularSueldo();
    }
}
