using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaisesNo2
{
	public partial class Form1 : Form
	{
		//Declaracion del vector
		 Paises[] Pais;
		int Npais;
	    int c = 0;
		

		public Form1()
		{
			InitializeComponent();
		}

		private void btnAceptar_Click(object sender, EventArgs e)
		{
			
			Npais = int.Parse(txtCantidad.Text);
			Pais = new Paises[Npais];

			this.gbxPaises.Enabled = true;
			this.gbxBnderas.Enabled = true;
			this.gbxRegistro.Enabled = false;
			txtCantidad.Clear();

		}

		private void btnGuardar_Click(object sender, EventArgs e)
		{
			
			if (c<Npais)
			{
				Pais[c] = new Paises();
				Pais[c].NombreDelPais= txtPais.Text;
				Pais[c].PoblacionTotal = int.Parse(txtPoblacion.Text);
				Pais[c].IdiomaPredominante = txtIdioma.Text;
				Pais[c].ColoresBandera[0] = txtColor1.Text;
				Pais[c].ColoresBandera[1] = txtColor2.Text;
				Pais[c].ColoresBandera[2] = txtColor3.Text;
				c++;
				Limpiar();
				txtPais.Focus();
			}
			if (c==Npais)
			{
				MessageBox.Show("Se han captutrado todos los datos");
				gbxBuscar.Enabled = true;
				gbxPaises.Enabled = false;
				gbxBnderas.Enabled = false;
				gbxRegistro.Enabled = true;
				Limpiar();
			}
		}

		private void btnBuscar_Click(object sender, EventArgs e )
		{
		
		
				for (int i = 0; i < Npais; i++)
				{
					if (txtBuscar.Text == Pais[i].NombreDelPais)
					{
						lblRNombre.Text = "Nombre del país: " + Pais[i].NombreDelPais;
						lblRPoblacion.Text = "La poblacion total: " + Pais[i].PoblacionTotal;
						lblRIdioma.Text = "El idioma predominate: " + Pais[i].IdiomaPredominante;
						lblRcolor.Text= "Los 3 colores prinsipales de la bandera: " + Pais[i].ColoresBandera[0] + ", " + Pais[i].ColoresBandera[1] + ", " + Pais[i].ColoresBandera[2];

					}

				}
			
			
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			this.gbxPaises.Enabled = false;
			this.gbxBnderas.Enabled = false;
			this.gbxBuscar.Enabled = false;
			
		}
		private void Limpiar()
		{
			txtPais.Clear();
			txtPoblacion.Clear();
			txtIdioma.Clear();
			txtColor1.Clear();
			txtColor2.Clear();
			txtColor3.Clear();
		}
	}
}
