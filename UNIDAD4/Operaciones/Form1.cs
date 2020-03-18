using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Operaciones
{
    public partial class Form1 : Form
    {
        Suma objSuma = new Suma();
        Resta objResta = new Resta();
        Multiplicacion objMultiplicacion = new Multiplicacion();
        Division objDivision = new Division();

        public Form1()
        {
            InitializeComponent();
        }

        private void lblSuma_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (txtValor1.Text =="")
            {
                errorProvider1.SetError(txtValor1, "Introduce un número");
                txtValor1.Focus();
                return;
            }
            if(txtValor2.Text=="")
            {
                errorProvider1.SetError(txtValor2, "Introduce otro número");
                txtValor2.Focus();
                return;
            }


            objSuma.num1 = Convert.ToDouble (txtValor1.Text);
            objSuma.num2 = Convert.ToDouble(txtValor2.Text);
            objSuma.suma();
            lblSuma.Text = objSuma.num1 +" + "+objSuma.num2 + " = "+objSuma.res.ToString();
            objResta.num1 = Convert.ToDouble(txtValor1.Text);
            objResta.num2 = Convert.ToDouble (txtValor2.Text);
            objResta.resta();
            lblResta.Text = objResta.num1+" - "+ objResta.num2+" = " +objResta.res.ToString();
            objMultiplicacion.num1 = Convert.ToDouble(txtValor1.Text);
            objMultiplicacion.num2 =Convert.ToDouble (txtValor2.Text);
            objMultiplicacion.multiplicacion();
             lblMultiplicacion.Text = objMultiplicacion.num1 + " x " + objMultiplicacion.num2 + " = " + objMultiplicacion.res.ToString();
            objDivision.num1 = Convert.ToDouble(txtValor1.Text);
            objDivision.num2 = Convert.ToDouble(txtValor2.Text);
            objDivision.divicion();
             lblDivision.Text = objDivision.num1 + " ÷ " + objDivision.num2 + " = " + objDivision.res.ToString();


        }
    }
}
