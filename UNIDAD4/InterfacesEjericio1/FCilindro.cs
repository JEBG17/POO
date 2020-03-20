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
    public partial class FCilindro : Form
    {
        public FCilindro()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Calcular_Click(object sender, EventArgs e)
        {
            Cilindro objCilindro = new Cilindro();
            objCilindro.Lado = double. Parse(txtRadio.Text);
            objCilindro.Altura = double.Parse(txtAltura.Text);
            objCilindro.CacularVolumen();
            MessageBox.Show("Su volumen es: " + objCilindro.Resultado+ " cm3");
        }
    }
}
