using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoPracticoDos
{
    class Triangulo : IFigura
    {
        private int ladoUno { set; get; }
        private int ladoDos { set; get; }
        private int ladoTres { set; get; }

        public Triangulo(int ladoUno, int ladoDos, int ladoTres)
        {

            this.ladoDos = ladoDos;
            this.ladoUno = ladoUno;
            this.ladoTres = ladoTres;
              
        }
    }
}
