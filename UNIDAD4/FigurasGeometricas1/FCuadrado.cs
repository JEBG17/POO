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
    public partial class FCuadrado : Form
    {
        Cuadrado objCuadrado = new Cuadrado();
        public FCuadrado()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            objCuadrado.Lado = Convert.ToDouble(txtLado.Text);
            objCuadrado.Area();
            objCuadrado.Perimetro();
            lblPerimetro.Text = "El perimetro es: " + objCuadrado.Perimetro1 + " cm";
            lblArea.Text = "El área es: " + objCuadrado.Area1 + " cm²";
        }
    }
}
