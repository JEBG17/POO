using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vehiculos
{
    public partial class Form1 : Form
    {
        classVehiculo objAereo = new classVehiculo();
        Aereo objAereos = new Aereo();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnArrancar_Click(object sender, EventArgs e)
        {
            objAereo.sonido = btnArrancar.Text;
            MessageBox.Show(objAereo.ArrancarMotor());

        }

        private void btnApagarMotor_Click(object sender, EventArgs e)
        {
            objAereo.sonido = btnApagarMotor.Text;
            MessageBox.Show(objAereo.PararMotor());
        }

        private void btnEstado_Click(object sender, EventArgs e)
        {
            objAereos.estado = btnEstado.Text;
            objAereos.TipoAereo = cmbTipoVehiculo.Text.ToString();
            objAereos.enVuelo();
            MessageBox.Show(objAereos.enVuelo().ToString());

        }
        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            objAereos.tipocombusstible = ttComustible.Text;
            objAereo.color = txtColor.Text;
            objAereo.NumeroLlantas = int.Parse(txtLlantas.Text);
            objAereo.NumeroPuertas = int.Parse(txtPuertas.Text);
            objAereo.NumeroVentanas = int.Parse(txtVentana.Text);
            objAereos.NumTurbinas = int.Parse(txtTurbinas.Text);
            objAereos.numAlas = int.Parse(txtAlas.Text);
            objAereos.numHelices = int.Parse(txtHelices.Text);
            objAereos.TipoAereo = cmbTipoVehiculo.Text;
            MessageBox.Show("La información de " + cmbTipoVehiculo.Text + " se ha guardado");
        }
    }
}
