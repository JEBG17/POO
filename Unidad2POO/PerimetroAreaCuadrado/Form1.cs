using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PerimetroAeeaCuadrado
{
    public partial class Form1 : Form
    {
        ClassCuadrado objCuadrado = new ClassCuadrado();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcularAP_Click(object sender, EventArgs e)
        {
            objCuadrado.lado=Convert.ToDouble(txtLado.Text);
            objCuadrado.CalcularAreayPerimetro();
            lblPerimetro.Text= objCuadrado.per.ToString();
            lblArea.Text = objCuadrado.area.ToString();

            

        }
    }
}
