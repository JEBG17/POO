using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlumnoYMaestro1
{
	public partial class Form1 : Form
	{
		DatosPersonas objPersonas = new DatosPersonas();
		Alumno objAlumno = new Alumno();
		Maestro objMaestro = new Maestro();
		

		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			this.gbxDatos.Enabled = false;
			this.gbxAlumno.Enabled = false;
			this.cmbTipo.Enabled = true;
			this.btnAceptar.Enabled = true;
			this.gbxMaestro.Enabled = false;
			this.btnGuardar.Enabled = false;
			this.btnImprimir.Enabled = false;
		}

		private void btnAceptar_Click(object sender, EventArgs e)
		{
			switch (cmbTipo.Text)
			{
				case "Alumno":
					{
						this.gbxDatos.Enabled = true;
						this.gbxAlumno.Enabled = true;
						this.gbxMaestro.Enabled = false;
						btnGuardar.Enabled = true;
						
						break;
					}
				case "Maestro":
					{
						this.gbxAlumno.Enabled = false;
						this.gbxDatos.Enabled = true;
						this.gbxMaestro.Enabled = true;
						btnGuardar.Enabled = true;
						break;
					}
			}
		}

		private void btnGuardar_Click(object sender, EventArgs e)
		{
			if (txtNombre.Text == "")
			{
				errorProvider1.SetError(txtNombre, "Debe ingresar el nombre");
				txtNombre.Focus();
				return;
			}
			errorProvider1.SetError(txtNombre, "");

			if (txtCurp.Text == "")
			{
				errorProvider1.SetError(txtCurp, "Debe ingresar la CURP");
				txtCurp.Focus();
				return;
			}
			errorProvider1.SetError(txtCurp, "");

			if (txtTelefono.Text == "" )
			{
				errorProvider1.SetError(txtTelefono, "Debe ingresar el número telefonico correcto");
				txtTelefono.Focus();
				return;
			}
			errorProvider1.SetError(txtTelefono, "");

			objPersonas.NombreCompleto = txtNombre.Text;
			objPersonas.FechaNacimiento = dtpFecha.Value;
			objPersonas.Curp = txtCurp.Text;
			objPersonas.Telefono = int.Parse(txtTelefono.Text);
			objPersonas.Correo = txtCorreo.Text;

			if (cmbTipo.Text == "Alumno")
			{
				// datos del Alumno
				objAlumno.NumeroControl = int.Parse(txtNcontrol.Text);
				objAlumno.Carrera = txtCarrera.Text;
				//Arreglos multodimencionales
				objAlumno.MateriasyCal = new string[2, 4];
				objAlumno.MateriasyCal[0, 0] = txtMateriaA1.Text;
				objAlumno.MateriasyCal[0, 1] = txtMateriaA2.Text;
				objAlumno.MateriasyCal[0, 2] = txtMateriaA3.Text;
				objAlumno.MateriasyCal[0, 3] = txtMateriaA4.Text;
				objAlumno.MateriasyCal[1, 0] = txtCalificacionA1.Text;
				objAlumno.MateriasyCal[1, 1] = txtCalificacionA2.Text;
				objAlumno.MateriasyCal[1, 2] = txtCalificacionA3.Text;
				objAlumno.MateriasyCal[1, 3] = txtCalificacionA4.Text;
			}
			if (cmbTipo.Text == "Maestro")
			{
				objMaestro.NumeroMaestro = int.Parse(txtNumMaestro.Text);
				objMaestro.Sueldo = int.Parse(txtSueldo.Text);
				//arreglo unidimensinal
				objMaestro.Materias[0] = txtMateria1.Text;
				objMaestro.Materias[1] = txtMateria2.Text;
				objMaestro.Materias[2] = txtMateria3.Text;
				objMaestro.Materias[3] = txtMateria4.Text;
				objMaestro.Materias[4] = txtMateria5.Text;
				objMaestro.Materias[5] = txtMateria6.Text;
			}
			btnImprimir.Enabled = true;
			Limpiar();
		}

		private void btnImprimir_Click(object sender, EventArgs e)
		{
			txtNombre.Text=objPersonas.NombreCompleto ;
			dtpFecha.Value= objPersonas.FechaNacimiento;
			txtCurp.Text=objPersonas.Curp;
			txtTelefono.Text=objPersonas.Telefono.ToString();
			txtCorreo.Text=objPersonas.Correo;
			txtNcontrol.Text=objAlumno.NumeroControl.ToString();
			txtCarrera.Text=objAlumno.Carrera;
			if (cmbTipo.Text == "Alumno")
			{
				txtMateriaA1.Text = objAlumno.MateriasyCal[0, 0];
				txtMateriaA2.Text = objAlumno.MateriasyCal[0, 1];
				txtMateriaA3.Text = objAlumno.MateriasyCal[0, 2];
				txtMateriaA4.Text = objAlumno.MateriasyCal[0, 3];
				txtCalificacionA1.Text = objAlumno.MateriasyCal[1, 0];
				txtCalificacionA2.Text = objAlumno.MateriasyCal[1, 1];
				txtCalificacionA3.Text = objAlumno.MateriasyCal[1, 2];
				txtCalificacionA4.Text = objAlumno.MateriasyCal[1, 3];
			}
			if (cmbTipo.Text == "Maestro")
			{
				txtNumMaestro.Text = objMaestro.NumeroMaestro.ToString();
				txtSueldo.Text = objMaestro.Sueldo.ToString();
				txtMateria1.Text = objMaestro.Materias[0];
				txtMateria2.Text = objMaestro.Materias[1];
				txtMateria3.Text = objMaestro.Materias[2];
				txtMateria4.Text = objMaestro.Materias[3];
				txtMateria5.Text = objMaestro.Materias[4];
				txtMateria6.Text = objMaestro.Materias[5];

			}

		}
		private void Limpiar()
		{
			txtNombre.Clear();
			txtCurp.Clear();
			txtTelefono.Clear();
			txtCorreo.Clear();
			txtNcontrol.Clear();
			txtCarrera.Clear();
			txtMateriaA1.Clear();
			txtMateriaA2.Clear();
			txtMateriaA3.Clear();
			txtMateriaA4.Clear();
			txtCalificacionA1.Clear();
			txtCalificacionA2.Clear();
			txtCalificacionA3.Clear();
			txtCalificacionA4.Clear();
			txtNumMaestro.Clear();
			txtSueldo.Clear();
			txtMateria1.Clear();
			txtMateria2.Clear();
			txtMateria3.Clear();
			txtMateria4.Clear();
			txtMateria5.Clear();
			txtMateria6.Clear();
		}
	}
}
