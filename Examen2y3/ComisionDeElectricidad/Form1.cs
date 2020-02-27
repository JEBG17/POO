using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComisionDeElectricidad
{
    public partial class Form1 : Form
    {
        ClassRecibo objRecibo = new ClassRecibo();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            objRecibo.Tipo = cmbTipo.Text.ToString();
            objRecibo.Kilowatts = double.Parse(txtKw.Text.ToString());
            objRecibo.CalcularPago();
            lblResultado.Text = "Le corresponde pagar: " + objRecibo.Kw.ToString()+ " pesos";
            txtKw.Text = "";

        }
    }
}
