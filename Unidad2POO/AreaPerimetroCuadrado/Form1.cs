using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AreaPerimetroCuadrado
{
    public partial class Form1 : Form
    {
        ClassCuadrado objCuadro = new ClassCuadrado();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcularAP_Click(object sender, EventArgs e)
        {
            if (txtLado.Text=="")
            {
                errorProvider1.SetError(txtLado, "Introduce el dato que se te pide ");
                txtLado.Focus();
                return;
            }

            objCuadro.lado = Convert.ToDouble(txtLado.Text);
            objCuadro.Calcular();
            lblArea.Text = "El área del cuadrado es: " + objCuadro.a.ToString();
            lblPerimetro.Text = "El perímetro del cuadrado es: " + objCuadro.p.ToString();
        }
    }
}
