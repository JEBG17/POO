using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiPrimeraClase
{
    public partial class Form1 : Form
    {
        ArrayList personas = new ArrayList();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Persona persona1 = new Persona();
            persona1.ID = "1010";
            persona1.Nombres = "Jesus";
            persona1.Apellidos = "Benitez";
            persona1.Correo = "jesusmdo1012@gmail.com";
            persona1.FechaNacimiento = new DateTime(2001,1,7);
            persona1.Salario = 10000;
            personas.Add(persona1);

            dgvDatos.DataSource = personas;
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            if (txtID.Text=="")
            {
                errorProvider1.SetError(txtID, "Debe ingresar un ID de la persona");
                txtID.Focus();
                return;
            }
            errorProvider1.SetError(txtID, "");

            if (Existe(txtID.Text))
            {
                errorProvider1.SetError(txtID, "El ID de el empleado ya ha sido registrado");
                txtID.Focus();
                return;
            }
            errorProvider1.SetError(txtID, "");

        

            if (txtNombres.Text == "")
            {
                errorProvider1.SetError(txtNombres, "Debe ingresar nombre(s) de la persona");
                txtNombres.Focus();
                return;
            }
            errorProvider1.SetError(txtNombres, "");

            if (txtApelldos.Text == "")
            {
                errorProvider1.SetError(txtApelldos, "Debe ingresar apellido(s) de la persona");
                txtApelldos.Focus();
                return;
            }
            errorProvider1.SetError(txtApelldos, "");

            Regex regEmail = new Regex(@"^(([^<>()[\]\\.,;:\s@\""]+"
                                    + @"(\.[^<>()[\]\\.,;:\s@\""]+)*)|(\"".+\""))@"
                                    + @"((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}]"
                                    + @"\.[0-9]{1,3}\])|(([a-zA-Z\-0-9]+\.)+"
                                    + @"[a-zA-Z]{2,}))$", RegexOptions.Compiled);

            if (!regEmail.IsMatch(txtMail.Text))
            {
                errorProvider1.SetError(txtMail, "Debe ingresar una dirección de correo valida");
                txtMail.Focus();
                return;
            }
            errorProvider1.SetError(txtMail, "");

            decimal Salario;
            if (!Decimal.TryParse(txtSalario.Text, out Salario))
            {
                errorProvider1.SetError(txtSalario, "Debe ingresar números en el campo salario");
                txtSalario.Focus();
                return;
            }

            if ( Salario<0)
            {
                errorProvider1.SetError(txtSalario, "Debe ingresar números positivo");
                txtSalario.Focus();
                return;
            }

            Persona MiPersona = new Persona();
            MiPersona.ID = txtID.Text;
            MiPersona.Nombres = txtNombres.Text;
            MiPersona.Apellidos = txtApelldos.Text;
            MiPersona.Correo = txtMail.Text;
            MiPersona.FechaNacimiento = dtpFNacimiento.Value;
            MiPersona.Salario = Salario;
            personas.Add(MiPersona);

            dgvDatos.DataSource = null;
            dgvDatos.DataSource = personas;

            txtID.Clear();
            txtNombres.Clear();
            txtApelldos.Clear();
            txtMail.Clear();
            txtSalario.Clear();
            txtID.Focus();
        }

        private bool Existe(string ID)
        {
            foreach (Persona persona in personas)
            {
                if (persona.ID == ID) return true;
            }
            return false;
        }
    }
}
