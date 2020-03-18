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
    public partial class Escaleno : Form
    {
        public Escaleno()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            TrianguloEscaleno objEscaleno = new TrianguloEscaleno();
            objEscaleno.Lado = double.Parse(txtBase.Text);
            objEscaleno.Altura = double.Parse(txtAltura.Text);
            objEscaleno.Lado2 = double.Parse(txtLadoA.Text);
            objEscaleno.Lado3 = double.Parse(txtLadoC.Text);
            objEscaleno.Perimetro();
            objEscaleno.Area();
            lblPerimetro.Text = "El perimetro es: " + objEscaleno.Perimetro1 + " cm";
            lblArea.Text = "El área es: " + objEscaleno.Area1 + " cm²";
        }
    }
}
