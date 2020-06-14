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

namespace NumerosMayorMenor
{
	public partial class Form1 : Form
	{
		Numeros objNumeros;
		int i, numero = 0;
		StreamWriter ArchivoNum;
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			ArchivoNum = new StreamWriter("ArchivoNumeros.txt");
		}

		private void btnAceptar_Click(object sender, EventArgs e)
		{

			objNumeros = new Numeros();
			numero = int.Parse(txtCantidad.Text);
			

			groupBox1.Enabled = true;
			txtCantidad.Enabled = false;
			btnAceptar.Enabled = false;
		}

		private void btnGuardar_Click(object sender, EventArgs e)
		{
			objNumeros.arregloNumeros = new int[numero];
			for (int i = 0; i < numero; i++)
			{
				objNumeros.arregloNumeros[i] = int.Parse(txtNumero.Text);
				MessageBox.Show("Numero capturado");
				txtNumero.Clear();

			}

			if (i == numero)
			{
				MessageBox.Show("Se capturaron todos los datos");
			}
			btnImprimir.Enabled = true;
		}

		private void btnImprimir_Click(object sender, EventArgs e)
		{
			for (i = 0; i < objNumeros.arregloNumeros[i]; i++)
			{
				if (objNumeros.arregloNumeros[i] < objNumeros.Menor)
				{
					objNumeros.Menor = objNumeros.arregloNumeros[i];

				}
				if (objNumeros.arregloNumeros[i] > objNumeros.Mayor)
				{
					objNumeros.Mayor = objNumeros.arregloNumeros[i];
				}

			}

			MessageBox.Show("El mayor es " + objNumeros.Mayor + "/n" + "El menor es: " + objNumeros.Menor);
			ArchivoNum.WriteLine("El mayor es " + objNumeros.Mayor + "/n" + "El menor es: " + objNumeros.Menor);
			ArchivoNum.Close();
			TextReader leer = new StreamReader("ArchivoNumeros.txt");
			MessageBox.Show(leer.ReadToEnd());
			leer.Close();
		}
	}
}
	