﻿using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bidimensional2
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		int[,] arrayA = new int[100, 100];
		int[,] arrayB = new int[100, 100];
		int[,] arrayC = new int[100, 100];
		int Fil;
		int col;
		int i, j;
		String acumA;
		String acumB;
		String acumC;
		
		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void btnDatosA_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Matriz A", "Ingresar datos", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
			for(i = 0; i < Fil; i++)
			{
				acumA += "/r/n";
				for (j = 0; j < col; j++)
				{
					arrayA[i, j] = Convert.ToInt16(Interaction.InputBox("Matriz A " + i + ", " + j));
					acumA += arrayA[i, j] + "/n";
					txtA.Text = acumA;
				}
			}
		}

		private void btnCerrar_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void btnSuma_Click(object sender, EventArgs e)
		{
			for(i=0; i <Fil; i++)
			{
				acumA += "/r/n/n";
				for(j=0; j < col; i++)
				{
					arrayC[i, j] = arrayA[i, j] + arrayB[i, j];
					acumC += arrayC[i, j] + "/n";
					txtC.Text = acumC;
				}
			}
		}

		private void btnMultipliccion_Click(object sender, EventArgs e)
		{
			for (i = 0; i < Fil; i++)
			{
				acumA += "/r/n/n";
				for (j = 0; j < col; i++)
				{
					arrayC[i, j] = arrayA[i, j] * arrayB[i, j];
					acumC += arrayC[i, j] + "/n";
					txtC.Text = acumC;
				}

			}
		}

		private void btnDivision_Click(object sender, EventArgs e)
		{
			for (i = 0; i < Fil; i++)
			{
				acumA += "/r/n/n";
				for (j = 0; j < col; i++)
				{
					arrayC[i, j] = arrayA[i, j] / arrayB[i, j];
					acumC += arrayC[i, j] + "/n";
					txtC.Text = acumC;
				}
			}
		}

		private void btnResta_Click(object sender, EventArgs e)
		{
			for (i = 0; i < Fil; i++)
			{
				acumA += "/r/n/n";
				for (j = 0; j < col; i++)
				{
					arrayC[i, j] = arrayA[i, j] - arrayB[i, j];
					acumC += arrayC[i, j] + "/n";
					txtC.Text = acumC;
				}
			}
		}

		private void btnLimpiar_Click(object sender, EventArgs e)
		{
			txtA.Clear();
			txtB.Clear();
			txtC.Clear();
			acumA = "";
			acumB = "";
			acumC = "";
		}

		private void btnDatosB_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Matriz B", "Ingresar datos", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
			for (i = 0; i < Fil; i++)
			{
				acumA += "/r/n";
				for (j = 0; j < col; j++)
				{
					arrayA[i, j] = Convert.ToInt16(Interaction.InputBox("Matriz B " + i + ", " + j));
					acumB += arrayB[i, j] + "/n";
					txtB.Text = acumB;
				}
			}

		}

		private void btnTamaño_Click(object sender, EventArgs e)
		{
			Fil = Convert.ToInt16(Interaction.InputBox("¿Cuntas filas tiene la matriz?"));
			col = Convert.ToInt16(Interaction.InputBox("¿Cuntas columnas?"));
		}
	}
}
