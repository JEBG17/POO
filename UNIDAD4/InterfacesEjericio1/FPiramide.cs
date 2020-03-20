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
    public partial class FPiramide : Form
    {
        public FPiramide()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Piramide objPiramide = new Piramide();
            objPiramide.Lado = double.Parse(txtLado.Text);
            objPiramide.Altura = double.Parse(txtAltura.Text);
            objPiramide.CacularVolumen(); 
            MessageBox.Show("El volumn es: " + objPiramide.Resultado + " cm3");

        }
    }
}
