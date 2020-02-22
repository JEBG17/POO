using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grados
{
    public partial class Form1 : Form
    {
        Class_Temperatura objtemperatura = new Class_Temperatura(); 
        public Form1()
        {
            InitializeComponent();
        }

        private void btnComvertir_Click(object sender, EventArgs e)
        {
            if (txtNGrados.Text == "")
            {
                errorProvider1.SetError(txtNGrados, "Introduce un valor ");
                txtNGrados.Focus();
                return;
            }



           objtemperatura.grado = cmbGrados.Text;
           objtemperatura.grados = Convert.ToDouble(txtNGrados.Text);
            objtemperatura.calcularGrados();
            lblCentigrados.Text = "Son "+objtemperatura.centigrados.ToString()+" °Fahrenheit";
            lblFahrenheit.Text =  "Son " + objtemperatura.fahren.ToString() + " °Celsius";
        }
    }
}
