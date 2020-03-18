using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmpleadosRestaurante
{
    public partial class Form1 : Form
    {
        Repartidor objRepartidor;
        Mesero objMesero;
        Cajero objCajero;


        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblDias_Click(object sender, EventArgs e)
        {

        }

        private void btnSueldo_Click(object sender, EventArgs e)
        {
            switch (cmbTipoTrabajo.Text)
            {
                case "Repartidor":
                    {
                        objRepartidor = new Repartidor();
                        objRepartidor.Sueldo = double.Parse(txtSueldo.Text);
                        objRepartidor.Repartidor = comboBox1.Text;
                        objRepartidor.Reparto = double.Parse(txtPedidos.Text);
                        objRepartidor.calcularSueldo();
                        lblSueldoReparto.Text = "El sueldo total de repartidor es de: $" + objRepartidor.Sueldo+ " pesos";
                        break;
                    }
                case "Cajero":
                    {
                        objCajero = new Cajero();
                        objCajero.Sueldo = double.Parse(txtSueldo.Text);
                        objCajero.Cajero = cmbCaja.Text;
                        objCajero.calcularSueldo();
                        lblSueldoCajero.Text = "El sueldo total del cajero es: $" + objCajero.Sueldo + " pesos ";
                        break;

                    }
                case "Mesero":
                    {
                        objMesero = new Mesero();
                        objMesero.Sueldo = double.Parse(txtSueldo.Text);
                        objMesero.Propina = double.Parse(txtPropinas.Text);
                        objMesero.calcularSueldo();
                        lblSueldoMesero.Text = "sueldo total del mesero es: $" + objMesero.Sueldo + " pesos ";
                        break;
                    }
            }
          
            

        }
    }
}
