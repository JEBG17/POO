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
    public partial class Equilatero : Form
    {
        public Equilatero()
        {
            InitializeComponent();
        }

        private void gbxRes_Enter(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            TrianguloEquilatero objEquilatero = new TrianguloEquilatero();
            objEquilatero.Lado = double.Parse(txtLado.Text);
            objEquilatero.Altura = double.Parse(txtAltura.Text);
            objEquilatero.Perimetro();
            objEquilatero.Area();
            lblArea.Text = "El área es: " + objEquilatero.Area1 + " cm²";
            lblPerimetro.Text = "El perimetro es: " + objEquilatero.Perimetro1 + " cm";
        }
    }
}
