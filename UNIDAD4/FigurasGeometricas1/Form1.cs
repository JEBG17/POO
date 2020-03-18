using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FigurasGeometricas1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            switch(cmbFiguras.Text)
            {
                case "Cuadrado":
                    {
                        FCuadrado cuadrado = new FCuadrado();
                        cuadrado.Show();
                        break;
                    }
                case "Círculo":
                    {
                        FCirculo circulo = new FCirculo();
                        circulo.Show();
                        break;
                    }
                case "Triángulo":
                    {
                        FTriangulo triangulo = new FTriangulo();
                        triangulo.Show();
                        break;
                    }
            }
        }
    }
}
