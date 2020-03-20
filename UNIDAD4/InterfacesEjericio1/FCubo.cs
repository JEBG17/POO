using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfacesEjericio1
{
    public partial class FCubo : Form
    {
        public FCubo()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Cubo objCubo = new Cubo();
            objCubo.Lado = double.Parse(txtLado.Text);
            objCubo.CacularVolumen();
            MessageBox.Show("El volumen es: " + objCubo.Resultado + " cm3");
        }
    }
}
