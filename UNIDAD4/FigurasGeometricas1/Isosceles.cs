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
    public partial class Isosceles : Form
    {
        public Isosceles()
        {
            InitializeComponent();
        }

        private void Isosceles_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Trianguloisosceles objIsosceles = new Trianguloisosceles();
            objIsosceles.Lado = double.Parse(txtBase.Text);
            objIsosceles.Altura = double.Parse(txtAltura.Text);
            objIsosceles.Lado2 = double.Parse(txtLadoa.Text);
            objIsosceles.Perimetro();
            objIsosceles.Area();
            lblPerimetro.Text = "El perimetro es: " + objIsosceles.Perimetro1 + " cm";
            lblArea.Text="El área del"+ objIsosceles.Area1 + " cm²";
        }
    }
}
