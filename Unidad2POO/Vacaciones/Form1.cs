using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vacaciones
{
    public partial class Form1 : Form
    {
        ClassEmpleado objEmpleados = new ClassEmpleado();
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnVacacionesDeLaEmpresa_Click(object sender, EventArgs e)
        {
            if(textBox1.Text =="")
            {
                errorProvider1. SetError(textBox1, "Introduce el dato que se te pide ");
                textBox1.Focus();
                return;

            }

            objEmpleados.aTrabajo= Convert.ToInt32(textBox1.Text);
            objEmpleados.Vacaciones();
            lblDiasVacaciones.Text = "Le corresponde: "+objEmpleados.unAnio.ToString()+ " días de vacaciones";
        }
    }
}
