using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatosDePersonas
{
    public partial class Form2 : Form
    {
        ClassPersona objPersonas = new ClassPersona();
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            textBox2.Text = objPersonas.mayorEdad.ToString();
            textBox3.Text = objPersonas.Nayarit.ToString();
            textBox4.Text = objPersonas.alumno.ToString();
            textBox5.Text = objPersonas.docente.ToString();
            textBox6.Text = objPersonas.administrativo.ToString();
                
        }
    }
}
