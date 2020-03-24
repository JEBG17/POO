using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Culebrita
{
    class Objeto
    {
        protected int x, y, ancho;

      

        //constructor
        public Objeto()
        {
            ancho = 10;
        }
       

        // metodo para detectar los choques
        public Boolean Choque(Objeto o)
        {
            int difx = Math.Abs(this.x - o.x);
            int dify = Math.Abs(this.y - o.x);
            if (difx >= 0 & difx < ancho & dify >=0 & dify < ancho)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
