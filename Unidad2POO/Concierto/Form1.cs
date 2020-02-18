using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Concierto
{
    public partial class Form1 : Form
    {
        ClassAsistente objAsisten = new ClassAsistente();
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCapturar_Click(object sender, EventArgs e)
        {
            if  (cmbAsistentes.Text== "")
            {
                errorProvider1.SetError(cmbAsistentes, "Selecciona un asistente ");
                cmbAsistentes.Focus();
                return;
            }
            if (cmbEntradas.Text=="")
            {
                errorProvider2.SetError(cmbEntradas, "Selecciona el numero de entradas");
                cmbEntradas.Focus();
                return;
            }
            objAsisten.asistente = Convert.ToString(cmbAsistentes.Text);
            objAsisten.cont = Convert.ToInt32(cmbEntradas.Text);
            objAsisten.Asisten();
            MessageBox.Show("Entradas capturadas");
            cmbAsistentes.Text = "";
            cmbEntradas.Text = "";
        }

        public void cmbEntradas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            textBox1.Text = objAsisten.Bebes.ToString();
            textBox2.Text = objAsisten.niños.ToString();
            textBox3.Text = objAsisten.adultos.ToString();
            textBox4.Text = objAsisten.TEdad.ToString();
        }
    }
}
