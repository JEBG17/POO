using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.IO;

namespace MatrizSuma
{
	public partial class Form1 : Form
	{
		Elementos objElementos;
		StreamWriter ArchivoSM;
		public Form1()
		{
			InitializeComponent();
		}

		private void btnAceptar_Click(object sender, EventArgs e)
		{
			objElementos = new Elementos();
			objElementos.t = int.Parse(txtTamaño.Text);
			objElementos.arregloBid = new int[objElementos.t, objElementos.t];

			for (int f = 0; f < objElementos.t; f++)
			{
				for (int c = 0; c < objElementos.t; c++)
				{
					objElementos.arregloBid[f, c] = Convert.ToInt16(Interaction.InputBox("Introduce un numero " + "(" + f + " ," + c + ")"));
				}
			}
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			ArchivoSM = new StreamWriter("archivoSM.txt");
		}

		private void btnImprimir_Click(object sender, EventArgs e)
		{
			objElementos.ObtenerArregloSumaColumnas();
			for (int i = 0; i < objElementos.t; i++)
			{
				for (int j = 0; j < objElementos.t; j++)
				{
					rtbMatriz.Text += objElementos.arregloBid[i, j] + " ";
				}
				

			}
			ArchivoSM.WriteLine(rtbMatriz.Text);
			ArchivoSM.Close();
		}

		private void btnImpFilas_Click(object sender, EventArgs e)
		{
			objElementos.sumaFila = new int[objElementos.t];
			for (int i = 0; i < objElementos.t; i++)
			{
				txtSumaFilas.Text += objElementos.sumaFila[i] + " ";
			}
			ArchivoSM.WriteLine(txtSumaFilas.Text);
		}

		private void btnImpDiagonal_Click(object sender, EventArgs e)
		{
			objElementos.sumaDiagonal = new int[objElementos.t];
			for (int i = 0; i < objElementos.t; i++)
			{
				txtSumaDiagonal.Text += objElementos.sumaDiagonal[i] + " ";
			}
			ArchivoSM.WriteLine(txtSumaDiagonal.Text);
		}

		private void btnImpColumnas_Click(object sender, EventArgs e)
		{
			objElementos.sumaColumna = new int[objElementos.t];
			for (int i = 0; i < objElementos.t; i++)
			{
				txtSmaColum.Text += objElementos.sumaColumna[i] + " ";
			}
			ArchivoSM.WriteLine(txtSumaDiagonal.Text);
			ArchivoSM.Close();
		}
	}
}
