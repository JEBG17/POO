using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumerosMayorMenor
{
	public partial class Form1 : Form
	{
		Numeros objNumeros;
		int i, numero=0;
		public Form1()
		{
			InitializeComponent();
		}

		private void btnAceptar_Click(object sender, EventArgs e)
		{
			objNumeros = new Numeros();
			numero = int.Parse(txtCantidad.Text);
			objNumeros.arregloNumeros = new int[numero];

			groupBox1.Enabled = true;
			txtCantidad.Enabled = false;
			btnAceptar.Enabled = false;

		}

		private void button3_Click(object sender, EventArgs e)
		{
			for (i = 0; i < objNumeros.arregloNumeros[i];i++)
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

			MessageBox.Show("El mayor es " + objNumeros.Mayor +"/n"+ "El menor es: "+ objNumeros.Menor );

		}

		private void button2_Click(object sender, EventArgs e)
		{

			for( int i=0 ; i < numero; i++)
			{
				objNumeros.arregloNumeros[i] = Convert.ToInt16(txtNumero.Text);
				MessageBox.Show("Numero capturado");
				txtNumero.Clear();

			}

			if (i==numero)
			{
				MessageBox.Show("Se capturaron todos los datos");
			}
			btnImprimir.Enabled = true;
		}
	}
}
