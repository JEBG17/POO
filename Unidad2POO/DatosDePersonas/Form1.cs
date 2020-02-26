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

        Form evaluacion = new Form2();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            objPersonas.anioAct = int.Parse(DateTime.Today.Year.ToString());
            objPersonas.mesAct = int.Parse(DateTime.Today.Month.ToString());
            objPersonas.diaAct = int.Parse(DateTime.Today.Day.ToString());
            objPersonas.anioNac = int.Parse(dtpFechaNacimiento.Value.Year.ToString());
            objPersonas.mesNac = int.Parse(dtpFechaNacimiento.Value.Month.ToString());
            objPersonas.diaNac = int.Parse(dtpFechaNacimiento.Value.Day.ToString());
            objPersonas.FechaNacimiento();
            objPersonas.estado = cmbEstado.ToString();
            objPersonas.Estado();
            objPersonas.tipo = cmbTipo.ToString();
            objPersonas.Tipo();
            txtNombre.Text = "";
            txtPaterno.Text = "";
            txtMaterno.Text = "";
            txtTelefono.Text = "";


        }

        private void btnInforme_Click(object sender, EventArgs e)
        {
            evaluacion.Show();

            
        }
    }
}
