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
    public partial class FCirculo : Form
    {
        Circulo objCirculo = new Circulo();
        public FCirculo()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            objCirculo.Lado = Convert.ToDouble(txtRadio.Text);
            objCirculo.Area();
            objCirculo.Perimetro();
            lblPerimetro.Text = "El perimetro es: " + objCirculo.Perimetro1 + " cm";
            lblArea.Text = "El area es: " + objCirculo.Area1 + " cm²";
        }
    }
}
