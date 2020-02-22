using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatosDePersonas
{
    public partial class Form1 : Form
    {
        ClassPersona objPersonas = new ClassPersona();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            //dtpFechaNacimiento.Value.Year;
            objPersonas.FechaNacimiento()=dtpFechaNacimiento.Value.Year, dtpFechaNacimiento.Value.Month, dtpFechaNacimiento.Value.Day);
            objPersonas.FechaNacimiento();
            objPersonas.estado = cmbEstado.Text;
            objPersonas.Estado();
            objPersonas.tipo = cmbTipo.ToString();
            objPersonas.Tipo();
            txtNombre.Text = "";
            txtPaterno.Text = "";
            txtMaterno.Text = "";
            cmbEstado.Text = "";
            cmbTipo.Text = "";
            txtTelefono.Text = "";


        }

        private void btnInforme_Click(object sender, EventArgs e)
        {
            Form evaluacion = new Form2();
            evaluacion.Show();

        }
    }
}
