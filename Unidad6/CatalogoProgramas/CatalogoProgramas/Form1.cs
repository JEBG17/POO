using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace CatalogoProgramas
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void btnBuscar_Click(object sender, EventArgs e)
		{
			OpenFileDialog buscar = new OpenFileDialog();

			if (buscar.ShowDialog()== DialogResult.OK)
			{
				txtDireccion.Text = buscar.FileName;
			}
		}

		private void btnAbrir_Click(object sender, EventArgs e)
		{
			Process.Start(txtDireccion.Text);
		}

		private void btnSalir_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
	}
}
