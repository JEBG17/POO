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

namespace AlumnosYMaestros2
{
	public partial class Form1 : Form
	{
		Alumno[] alumno;
		Maestro[] maestros;
		Personas[] Persona;
		int Cantidad;
		int c = 0;
		StreamWriter ArchivoAyM2;
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			ArchivoAyM2 = new StreamWriter("ArchivoAlumnoMaestro2.txt");

		}

		private void btnAceptar_Click(object sender, EventArgs e)
		{
			Cantidad = (int)nudCantidad.Value;
			Persona = new Personas[Cantidad];

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
			Persona[c] = new Personas();
			alumno = new Alumno[Cantidad];
			alumno[c] = new Alumno();
			maestros = new Maestro[Cantidad];
			maestros[c] = new Maestro();
			if (c < Cantidad)
			{
				Persona[c].NombreCompleto = txtNombre.Text;
				Persona[c].FechaNacimiento = dtpFecha.Value;
				Persona[c].Curp = txtCurp.Text;
				Persona[c].Telefono = int.Parse(txtTelefono.Text);
				Persona[c].Correo = txtCorreo.Text;
				if (cmbTipo.Text == "Alumno")
				{
					alumno[c].NumeroControl = int.Parse(txtNcontrol.Text);
					alumno[c].Carrera = txtCarrera.Text;

					alumno[c].MateriasyCal = new string[2, 4];
					alumno[c].MateriasyCal[0, 0] = txtMateriaA1.Text;
					alumno[c].MateriasyCal[0, 1] = txtMateriaA2.Text;
					alumno[c].MateriasyCal[0, 2] = txtMateriaA3.Text;
					alumno[c].MateriasyCal[0, 3] = txtMateriaA4.Text;
					alumno[c].MateriasyCal[1, 0] = txtCalificacionA1.Text;
					alumno[c].MateriasyCal[1, 1] = txtCalificacionA2.Text;
					alumno[c].MateriasyCal[1, 2] = txtCalificacionA3.Text;
					alumno[c].MateriasyCal[1, 3] = txtCalificacionA4.Text;
				}
				if (cmbTipo.Text == "Maestro")
				{
					maestros[c].NumeroMaestro = int.Parse(txtNumMaestro.Text);
					maestros[c].Sueldo = int.Parse(txtSueldo.Text);
					//arreglo unidimensinal
					maestros[c].Materias[0] = txtMateria1.Text;
					maestros[c].Materias[1] = txtMateria2.Text;
					maestros[c].Materias[2] = txtMateria3.Text;
					maestros[c].Materias[3] = txtMateria4.Text;
					maestros[c].Materias[4] = txtMateria5.Text;
					maestros[c].Materias[5] = txtMateria6.Text;
				}
			}

			ArchivoAyM2.WriteLine(Persona[c].NombreCompleto);
			ArchivoAyM2.WriteLine(Persona[c].FechaNacimiento);
			ArchivoAyM2.WriteLine(Persona[c].Curp);
			ArchivoAyM2.WriteLine(Persona[c].Telefono);
			ArchivoAyM2.WriteLine(Persona[c].Correo);

			switch(cmbTipo.Text)
			{
				case "Alumno":
					{
						ArchivoAyM2.WriteLine(alumno[c].NumeroControl);
						ArchivoAyM2.WriteLine(alumno[c].Carrera);
						ArchivoAyM2.WriteLine(alumno[c].MateriasyCal[0, 0]);
						ArchivoAyM2.WriteLine(alumno[c].MateriasyCal[0, 1]);
						ArchivoAyM2.WriteLine(alumno[c].MateriasyCal[0, 2]);
						ArchivoAyM2.WriteLine(alumno[c].MateriasyCal[0, 3]);
						ArchivoAyM2.WriteLine(alumno[c].MateriasyCal[1, 0]);
						ArchivoAyM2.WriteLine(alumno[c].MateriasyCal[1, 1]);
						ArchivoAyM2.WriteLine(alumno[c].MateriasyCal[1, 2]);
						ArchivoAyM2.WriteLine(alumno[c].MateriasyCal[1, 3]);
						break;
					}
				case "Maestro":
					{
						ArchivoAyM2.WriteLine(maestros[c].NumeroMaestro);
						ArchivoAyM2.WriteLine(maestros[c].Sueldo);
						ArchivoAyM2.WriteLine(maestros[c].Materias[0]);
						ArchivoAyM2.WriteLine(maestros[c].Materias[1]);
						ArchivoAyM2.WriteLine(maestros[c].Materias[2]);
						ArchivoAyM2.WriteLine(maestros[c].Materias[3]);
						ArchivoAyM2.WriteLine(maestros[c].Materias[4]);
						ArchivoAyM2.WriteLine(maestros[c].Materias[5]);

						break;
					}
			}
		}

	}
}
