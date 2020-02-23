using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caseta
{
    public partial class Form1 : Form
    {
        ClassVehiculo objVehiculos = new ClassVehiculo();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCobrar_Click(object sender, EventArgs e)
        {
            if(cmbVehiculo.Text=="")
            {
                errorProvider1.SetError(cmbVehiculo, "Introduce el tipo de vehiculo");
                cmbVehiculo.Focus();
                return;

            }

            objVehiculos.vehiculo = (cmbVehiculo.Text);
            objVehiculos.Cobrar();
            lblPagoVehiculo.Text = "El pago por su vehiculo es de: " + objVehiculos.vehi.ToString() + " pesos.";
        }
    }
}
