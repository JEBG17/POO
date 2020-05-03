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

namespace TorneoFutbol
{
	public partial class Form1 : Form
	{
        Torneo objTorneo;
		int equipo, partidos, E, i, s;
		int suma, mayor=0;
		

		public Form1()
		{
			InitializeComponent();
		}

		private void btnImprimir_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Ganó con "+mayor+ " puntos ");
			btnAceptar.Enabled = true;
			txtNombreTorneo.Enabled = true;
			nudEquipos.Enabled = true;
			btnImprimir.Enabled = false;
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			

		}

		private void btnAceptar_Click(object sender, EventArgs e)
        {
			if( txtNombreTorneo.Text=="")
			{
				errorProvider1.SetError(txtNombreTorneo, "Debe de ingresar un nombre");
				txtNombreTorneo.Focus();
				return;
			}
			errorProvider1.SetError(txtNombreTorneo, "");


            objTorneo = new Torneo(); 
            objTorneo.NumeroEquipos = (int)nudEquipos.Value;
			equipo = objTorneo.NumeroEquipos;
            objTorneo.NombreTorneo = txtNombreTorneo.Text;
			objTorneo.NumeroPartidosEquipos = objTorneo.NumeroEquipos - 1;
			partidos = objTorneo.NumeroPartidosEquipos;
			objTorneo.PuntosXPartidos = new int[equipo, partidos];
			objTorneo.NombreDeEquipos = new string[equipo];
			
			for (E=0; E <equipo; E++)
			{
				objTorneo.NombreDeEquipos[E] = Interaction.InputBox("Introduce el nombre del equipo ");
			}

			if (E == equipo)
			{
				E = 0;
				for ( i = 0; i < equipo; i++)
			    {

				   for (int j = 0; j < partidos; j++)
				   {
					 objTorneo.PuntosXPartidos[i , j] = Convert.ToInt16(Interaction.InputBox("introduce los puntos del equipo "+objTorneo.NombreDeEquipos[E] + " del partido " + i +" , "+ j));

				   }
					E++;
			    }

			}
			if (i == equipo)
			{
				objTorneo.SumaPuntaje = new int[equipo];

				for (i = 0; i < equipo; i++ )
				{
					suma = 0;
					for(int j=0; j < partidos; j++)
					{
						suma = suma + objTorneo.PuntosXPartidos[i,j];	
					}
					objTorneo.SumaPuntaje[s]= suma;

					if (objTorneo.SumaPuntaje[s]> mayor)
					{
					
						mayor = objTorneo.SumaPuntaje[s];
					}
					s++;
				}

			}
			txtNombreTorneo.Clear();
			nudEquipos.Value = 1;
			txtNombreTorneo.Enabled = false;
			nudEquipos.Enabled = false;
			btnAceptar.Enabled = false;
			btnImprimir.Enabled = true;


			
			
			
        }

    }
}
