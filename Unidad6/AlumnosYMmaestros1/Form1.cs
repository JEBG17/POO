using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace AlumnosYMmaestros1
{
	public partial class Form1 : Form
	{
		DatosPersona objPersonas = new DatosPersona();
		Alumno objAlumno = new Alumno();
		Maestro objMaestro = new Maestro();
		StreamWriter ArchivoAyM;

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
			ArchivoAyM = new StreamWriter("archivoAlumnoYMaestros.txt");
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

			if (txtTelefono.Text == "")
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

		}

		private void btnImprimir_Click(object sender, EventArgs e)
		{
			
			if (cmbTipo.Text == "Alumno")
			{
				txtNombre.Text = objPersonas.NombreCompleto;
				dtpFecha.Value = objPersonas.FechaNacimiento;
				txtCurp.Text = objPersonas.Curp;
				txtTelefono.Text = objPersonas.Telefono.ToString();
				txtCorreo.Text = objPersonas.Correo;
				txtNcontrol.Text = objAlumno.NumeroControl.ToString();
				txtCarrera.Text = objAlumno.Carrera;
				txtMateriaA1.Text = objAlumno.MateriasyCal[0, 0];
				txtMateriaA2.Text = objAlumno.MateriasyCal[0, 1];
				txtMateriaA3.Text = objAlumno.MateriasyCal[0, 2];
				txtMateriaA4.Text = objAlumno.MateriasyCal[0, 3];
				txtCalificacionA1.Text = objAlumno.MateriasyCal[1, 0];
				txtCalificacionA2.Text = objAlumno.MateriasyCal[1, 1];
				txtCalificacionA3.Text = objAlumno.MateriasyCal[1, 2];
				txtCalificacionA4.Text = objAlumno.MateriasyCal[1, 3];


				ArchivoAyM.Write(objPersonas.NombreCompleto);
				ArchivoAyM.Write(objPersonas.FechaNacimiento);
				ArchivoAyM.Write(objPersonas.Curp);
				ArchivoAyM.Write(objPersonas.Telefono.ToString());
				ArchivoAyM.Write(objPersonas.Correo);
				ArchivoAyM.Write(objAlumno.NumeroControl.ToString());
				ArchivoAyM.Write(objAlumno.Carrera);
				ArchivoAyM.Write(objAlumno.MateriasyCal[0,0]);
				ArchivoAyM.Write(objAlumno.MateriasyCal[0,1]);
				ArchivoAyM.Write(objAlumno.MateriasyCal[0,2]);
				ArchivoAyM.Write(objAlumno.MateriasyCal[0, 3]);
				ArchivoAyM.Write(objAlumno.MateriasyCal[1, 0]);
				ArchivoAyM.Write(objAlumno.MateriasyCal[1, 1]);
				ArchivoAyM.Write(objAlumno.MateriasyCal[1, 2]);
				ArchivoAyM.Write(objAlumno.MateriasyCal[1, 3]);
				ArchivoAyM.Close();
			}

		}

	}
}
