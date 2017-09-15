using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoPracticoDos
{
    class Circulo : IFigura
    {
        private double radio { set; get; }


        public Circulo(double radio)
        {
            this.radio = radio;
        }


    }
}
