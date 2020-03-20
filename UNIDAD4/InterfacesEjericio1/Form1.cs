using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfacesEjericio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            switch (cmbTipo.Text)
            {
                case "Cilindro":
                    {
                        this.Hide();
                        FCilindro cilindro = new FCilindro();
                        cilindro.Show();
                        break;
                    }
                case "Cubo":
                    {
                        this.Hide();
                        FCubo cubo = new FCubo();
                        cubo.Show();
                        break;
                    }
                case "Piramide":
                    {
                        this.Hide();
                        FPiramide piramide = new FPiramide();
                        piramide.Show();
                        break;
                    }
            }
        }
    }
}
