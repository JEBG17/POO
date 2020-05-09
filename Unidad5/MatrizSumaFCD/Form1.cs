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

namespace MatrizSumaFCD
{
    public partial class Form1 : Form
    {
        Elementos objElementos;

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

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            objElementos.ObtenerArregloSumaColumnas();
            for (int i = 0; i < objElementos.t; i++)
            {
                for (int j = 0; j < objElementos.t; j++)
                {
                    rtbMatriz.Text += objElementos.arregloBid[i, j] + " ";
                }
                "/n";

            }
        }

        private void btnImpFilas_Click(object sender, EventArgs e)
        {
            objElementos.sumaFila = new int[objElementos.t];
            for (int i = 0; i < objElementos.t; i++)
            {
                txtSumaFilas.Text += objElementos.sumaFila[i] + " ";
            }

        }

        private void btnImpColumnas_Click(object sender, EventArgs e)
        {
            objElementos.sumaColumna = new int[objElementos.t];
            for (int i = 0; i < objElementos.t; i++)
            {
                txtSmaColum.Text += objElementos.sumaColumna[i] + " ";
            }
        }

        private void btnImpDiagonal_Click(object sender, EventArgs e)
        {
            objElementos.sumaDiagonal = new int[objElementos.t];
            for (int i = 0; i < objElementos.t; i++)
            {
                txtSumaDiagonal.Text += objElementos.sumaDiagonal[i] + " ";
            }

        }
    }
}
