using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Transportes
{
	public partial class Form1 : Form
	{
		Chofer objChofer;
		int Num;
		string nombreEmpresa;
		public Form1()
		{
			InitializeComponent();
		}

		private void btnAceptar_Click(object sender, EventArgs e)
		{
			Num =(int) nudNumConductores.Value;
			nombreEmpresa = txtNombreEmpresa.Text;

		}

		private void btnCapturar_Click(object sender, EventArgs e)
		{
			objChofer = new Chofer();

			objChofer.NombreChofer = new string[Num];

			objChofer.Kms = new int[Num, 7];
			

			for( int i=0; i < nudNumConductores.Value; i++)
			{
				objChofer.NombreChofer[i] = txtNombreConductor.Text;
				txtNombreConductor.Clear();
				txtNombreConductor.Focus();
				MessageBox.Show("Nombre captutado");
				
			}

				for(int f = 0; f < Num; f++)
				{
					for(int d = 0; d < 7; d++)
					{
						objChofer.Kms[f, d] = Convert.ToInt16(Interaction.InputBox("introduce los kilometros recorridos en la semana "+objChofer.NombreChofer[f]));
					}
				}


		}

		private void btnImprimir_Click(object sender, EventArgs e)
		{
			int n = dgvDatos.Rows.Add();
			for (int i = 0; i < nudNumConductores.Value; i++)
			{
				dgvDatos.Rows[n].Cells[0].Value = objChofer.NombreChofer[i];
			}

			for(int f=0;f< nudNumConductores.Value; f++)
			{
				int c=1;
				for (int d = 0; d < nudNumConductores.Value; d++)
				{
					dgvDatos.Rows[n].Cells[c].Value = objChofer.Kms[f,d];
					c++;
				}
			}
		}
	}
}
