using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Culebrita
{
    public partial class Form1 : Form
    {
        Serpiente objCabeza;
        Comida objComida;
        Graphics juego;
        int dirX = 0, dirY = 0;
        int cuadro;
        int puntos = 0;
        Boolean ejeX = true, ejeY = true;
        
        public Form1()
        {
            InitializeComponent();
            objCabeza = new Serpiente(10, 10);
            objComida = new Comida();
            cuadro = 10;
            juego = pbTablero.CreateGraphics();
        }
        public void Movimiento()
        {
            objCabeza.Mover(objCabeza.X() + dirX, objCabeza.Y() + dirY);
        }
        public void Dibujar()
        {
            juego.Clear(Color.White);
            objCabeza.Dibujar(juego);
            objComida.Dibujar(juego);
        }

        private void Ciclo_Tick(object sender, EventArgs e)
        {
            Dibujar();
            Movimiento();
            ChoqueCuerpo();
           ChoquePared();
            
            if(objCabeza.Choque(objComida))
            {
                objComida.Colocar();
                objCabeza.Meter();
                puntos++;
                lblPuntos.Text = puntos.ToString();
            }
            
        }
        public void finJuego()
        {
            puntos = 0;
            lblPuntos.Text = "0";
            ejeX = true;
            ejeY = true;
            dirX = 0;
            dirY = 0;
            objCabeza = new Serpiente(10, 10);
            objComida = new Comida();
            MessageBox.Show("Oh no. Perdiste");
        }
        public void ChoquePared()
        {
            if(objCabeza.X() < 0 || objCabeza.X()>710 || objCabeza.Y()<0 ||objCabeza.Y()>310)
            {
                finJuego();
            }
        }

       

        public void ChoqueCuerpo()
        {
            Serpiente temporal;
            try
            {
                temporal = objCabeza.verSiguiente().verSiguiente();
            }catch (Exception)
            {
                temporal = null;
            }
            while (temporal!= null)
            {
                if (objCabeza.Choque(temporal))
                {
                    finJuego();
                }
                else
                {
                    temporal = temporal.verSiguiente();
                }
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (ejeX)
            {
                if (e.KeyCode== Keys.Up)
                {
                    dirY = -cuadro;
                    dirX = 0;
                    ejeX = false;
                    ejeY = true;
                }
                if(e.KeyCode== Keys.Down)
                {
                    dirY = cuadro;
                    dirX = 0;
                    ejeX = false;
                    ejeY = true;
                }
            }
            if (ejeY)
            {
                if(e.KeyCode == Keys.Right)
                {
                    dirY = 0;
                    dirX = cuadro;
                    ejeX = true;
                    ejeY = false;
                }
                if(e.KeyCode==Keys.Left)
                {
                    dirY = 0;
                    dirX = - cuadro;
                    ejeX = true;
                    ejeY = false;
                }
            }
        }
    }
}
