using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Culebrita
{
    class Comida:Objeto
    {
        //constructor
        public Comida()
        {
            this.x = Generar(73);
            this.y = Generar(33);
        }
        //Metodo para dibujar la comida
        public void Dibujar(Graphics g)
        {
            g.FillRectangle(new SolidBrush(Color.Blue), this.x, this.y, this.ancho, this.ancho);
        }
        //metodo para colocar la comida 
        public void Colocar()
        {
            this.x = Generar(73);
            this.y = Generar(33);
        }
        //Metodo para generar la comida en distintas posiciones 
        public int Generar(int n)
        {
            Random random =new Random();
            int num = random.Next(0, n) * 10;
            return num;
        }
    }
}
