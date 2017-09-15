using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoPracticoUno
{
    class Rodado: IMovilidad
    {
        private Rueda ruedas { get; set; }
        private CajaDeCambio cajaDeCambios { get; set; }
        private Motor  motor { get; set; }

        public Rodado(Motor motor, Motor ruedas, Rueda cajaDeCambios)
        {
            this.ruedas = ruedas;
            this.cajaDeCambios = cajaDeCambios;
            this.motor = motor;
        }
    }
}
