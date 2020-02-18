using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Embotelladora
{
    public partial class frmEmbotelladora : Form
    {
        public frmEmbotelladora()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClassBotella objBotella = new ClassBotella();
            objBotella.nivelLlenado = Convert.ToInt32 (txtNivelLlenado.Text);
           MessageBox.Show (objBotella.verifiarLlenado());

        }

        private void frmEmbotelladora_Load(object sender, EventArgs e)
        {

        }
    }
}
