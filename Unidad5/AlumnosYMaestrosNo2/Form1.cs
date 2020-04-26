using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlumnosYMaestrosNo2
{
	public partial class Form1 : Form
	{
		Alumno[] alumno;
		Maestro[] maestros;
		Perosonas[] Persona;
		int Cantidad;
		int c = 0;

		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void btnAceptar_Click(object sender, EventArgs e)
		{
			Cantidad = (int)nudCantidad.Value;
			Persona = new Perosonas[Cantidad];

			switch(cmbTipo.Text)
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
			if (c < Cantidad)
			{
				Persona[c] = new Perosonas();
				Persona[c].NombreCompleto = txtNombre.Text;
				Persona[c].FechaNacimiento = dtpFecha.Value;
				Persona[c].Curp = txtCurp.Text;
				Persona[c].Telefono = int.Parse(txtTelefono.Text);
				Persona[c].Correo = txtCorreo.Text;
				if (cmbTipo.Text == "Alumno")
				{
					alumno = new Alumno[Cantidad];
					alumno[c] = new Alumno();
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
					maestros = new Maestro[Cantidad];
					maestros[c] = new Maestro();
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
				Perosonas MiPersona = new Perosonas();
				Alumno MiAlumno = new Alumno();
				Maestro MiMaestro = new Maestro();

				MiPersona.NombreCompleto = txtNombre.Text;
				MiPersona.FechaNacimiento = dtpFecha.Value;
				MiPersona.Curp = txtCurp.Text;
				MiPersona.Telefono = int.Parse(txtTelefono.Text);
				MiPersona.Correo = txtCorreo.Text;
				if (cmbTipo.Text == "Alumno")
				{
					MiAlumno.NumeroControl = int.Parse(txtNcontrol.Text);
					MiAlumno.Carrera = txtCarrera.Text;
					MiAlumno.MateriasyCal[0, 0] = txtMateriaA1.Text;
					MiAlumno.MateriasyCal[0, 1] = txtMateriaA2.Text;
					MiAlumno.MateriasyCal[0, 2] = txtMateriaA3.Text;
					MiAlumno.MateriasyCal[0, 3] = txtMateriaA4.Text;
					MiAlumno.MateriasyCal[1, 0] = txtCalificacionA1.Text;
					MiAlumno.MateriasyCal[1, 1] = txtCalificacionA2.Text;
					MiAlumno.MateriasyCal[1, 2] = txtCalificacionA3.Text;
					MiAlumno.MateriasyCal[1, 3] = txtCalificacionA4.Text;
				}
				if (cmbTipo.Text == "Maestro")
				{
					MiMaestro.NumeroMaestro = int.Parse(txtNumMaestro.Text);
					MiMaestro.Sueldo = int.Parse(txtSueldo.Text);
					MiMaestro.Materias[0] = txtMateria1.Text;
					MiMaestro.Materias[1] = txtMateria2.Text;
					MiMaestro.Materias[2] = txtMateria3.Text;
					MiMaestro.Materias[3] = txtMateria4.Text;
					MiMaestro.Materias[4] = txtMateria5.Text;
					MiMaestro.Materias[5] = txtMateria6.Text;
				}
				Persona.Add(MiPersona,MiAlumno,MiMaestro);
				



					dgvResultados.DataSource = null;
				dgvResultados.DataSource = Persona;

			}
		}
	}
}
