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

namespace Paices1
{
	public partial class Form1 : Form
	{
		Pais objPais = new Pais();
		StreamWriter ArchivoPaises1;
		public Form1()
		{
			InitializeComponent();
		}

		private void btnGiardarImprimir_Click(object sender, EventArgs e)
		{
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

			ArchivoPaises1.Write("Nombre: " + objPais.NombreDelPais );
			ArchivoPaises1.Write("La poblcion total: " + objPais.PoblacionTotal);
;			ArchivoPaises1.Write("Los 3 colores principales son: " + objPais.ColoresBandera[0] + ", " + objPais.ColoresBandera[1] + ", " + objPais.ColoresBandera[2]);
			ArchivoPaises1.Close();

		}

		private void Form1_Load(object sender, EventArgs e)
		{
			ArchivoPaises1 = new StreamWriter("archivoPaises.txt");

		}
	}
}
