using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FechaDeNacmiento
{
    public partial class Form1 : Form
    {
        ClasePersona objPersona = new ClasePersona();      

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSaber_Click(object sender, EventArgs e)
        {
            objPersona.AnioAC = int.Parse(DateTime.Today.Year.ToString());
            objPersona.MesAC = int.Parse(DateTime.Today.Month.ToString());
            objPersona.diaAC = int.Parse(DateTime.Today.Day.ToString());
            objPersona.anioNA = int.Parse(dtpFecha.Value.Year.ToString());
            objPersona.mesNA = int.Parse(dtpFecha.Value.Month.ToString());
            objPersona.diaNA=int.Parse(dtpFecha.Value.Day.ToString());
            objPersona.MayorDeEdad();
            lblResultado.Text = objPersona.Mayor;
            
        }
    }
}
