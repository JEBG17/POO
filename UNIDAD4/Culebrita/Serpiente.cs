using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Culebrita
{
    class Serpiente:Objeto
    {
        // refenciar
        Serpiente siguiente;

        public Serpiente(int x,int y)
        {
            this.x = x;
            this.y= y;
            this.siguiente = null;

        }
        public void Dibujar(Graphics g)
        {
            if (siguiente != null)
            {
                siguiente.Dibujar(g);
            }
            g.FillRectangle(new SolidBrush(Color.Yellow), this.x, this.y, this.ancho, this.ancho);

        }
        public void Mover(int x, int y)
        {
            //para cambiar la posicion 
            if (siguiente != null)
            {
                siguiente.Mover(this.x, this.y);
            }
            this.x = x;
            this.y = y;
        }
        public void Meter()
        {
            if (siguiente == null)
            {
                siguiente = new Serpiente(this.x, this.y);
            }
            else
            {
                siguiente.Meter();
            }
        }
        public int X()
        {
            return this.x;
        }
        public int Y()
        {
            return this.y;
        }
        public Serpiente verSiguiente()
        {
            return siguiente;
        }
    }
}
