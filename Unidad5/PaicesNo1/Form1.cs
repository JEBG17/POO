using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaicesNo1
{
	public partial class Form1 : Form
	{
		Pais objPais = new Pais();

		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void btnGiardarImprimir_Click(object sender, EventArgs e)
		{
			if (txtPais.Text == "")
			{
				errorProvider1.SetError(txtPais, "Debe ingresar el nombre del pais");
				txtPais.Focus();
				return;
			}
			errorProvider1.SetError(txtPais, "");

			if (txtPoblacion.Text == "")
			{
				errorProvider1.SetError(txtPoblacion,"Ingrese el numero de poblacion ");
				txtPoblacion.Focus();
				return;
			}
			errorProvider1.SetError(txtPoblacion, "");

			if (txtIidioma.Text == "")
			{
				errorProvider1.SetError(txtIidioma, "Debe ingresar el idioma ");
				txtIidioma.Focus();
				return;
			}
			errorProvider1.SetError(txtIidioma, "");

			if (txtColor1.Text == "")
			{
				errorProvider1.SetError(txtColor1, "Debe ingresar un color de su bandera");
				txtColor1.Focus();
				return;
			}
			errorProvider1.SetError(txtColor1, "");

			if (txtColor2.Text == "")
			{
				errorProvider1.SetError(txtColor2, "Debe ingresar un color de su bandera");
				txtColor2.Focus();
				return;
			}
			errorProvider1.SetError(txtColor2, "");

			if (txtColor3.Text == "")
			{
				errorProvider1.SetError(txtColor3, "Debe ingresar un color de su bandera");
				txtColor3.Focus();
				return;
			}
			errorProvider1.SetError(txtColor3, "");

			objPais.NombreDelPais = txtPais.Text;
			objPais.PoblacionTotal = int.Parse(txtPoblacion.Text);
			objPais.IdiomaPredominante = txtIidioma.Text;
			objPais.ColoresBandera[0] = txtColor1.Text;
			objPais.ColoresBandera[1] = txtColor2.Text;
			objPais.ColoresBandera[2] = txtColor3.Text;

			lblDNombre.Text = "Nombre: " + objPais.NombreDelPais;
			lblDPoblacion.Text = "La poblcion total: " + objPais.PoblacionTotal;
			lblDIdioma.Text = "El idioma predominante: " + objPais.IdiomaPredominante;
			lblDColores.Text = "Los 3 colores principales son: " + objPais.ColoresBandera[0] + ", " + objPais.ColoresBandera[1] + ", " + objPais.ColoresBandera[2];
		}

		
	}	
}
