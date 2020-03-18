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
    public partial class FTriangulo : Form
    {
        public FTriangulo()
        {
            InitializeComponent();
        }

        private void lblTriangulo_Click(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            switch(cmbTriangulos.Text)
            {
                case "Equilátero":
                    {
                        Equilatero equilatero = new Equilatero();
                        equilatero.Show(); 
                        
                        break;
                    }
                case "Escaleno":
                    {
                        Escaleno escaleno = new Escaleno();
                        escaleno.Show();
                        break;
                    }
                case "Isósceles":
                    {
                        Isosceles isosceles = new Isosceles();
                        isosceles.Show();
                        break; 
                    }
            }
        }
    }
}
