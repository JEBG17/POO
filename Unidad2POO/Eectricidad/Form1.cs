using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eectricidad
{
    public partial class Form1 : Form
    {
        ClaseRecibo objRecibo = new ClaseRecibo();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(cmbHogarNegocio.Text =="")
            {
                errorProvider1.SetError(cmbHogarNegocio, "Coloca tu tipo");
                cmbHogarNegocio.Focus();
                return;
            }

            if (txtKilowatts.Text == "")
            {
                errorProvider2.SetError(txtKilowatts, "Introduce los Kilowatts");
                txtKilowatts.Focus();
                return;
            }


            objRecibo.tipo = cmbHogarNegocio.Text;
            objRecibo.kilow = Convert.ToDouble(txtKilowatts.Text);
            objRecibo.pago();
            lblpagar.Text = "Usted debe a pagar: " + objRecibo.kw.ToString() + " Pesos";
        }
    }
}
