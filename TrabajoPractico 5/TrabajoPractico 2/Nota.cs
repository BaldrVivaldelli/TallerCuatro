using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoPractico_2
{
    
   public class Nota
    {
        /*
                Nota
                Tipo
                Fecha
                Valor
        */
        public string tipo { get;  set; }
        public string fecha { get;  set; }
        public string valor { get;  set; }

        public Nota(string tipo, string fecha, string valor) {
            this.tipo = tipo;
            this.fecha = fecha;
            this.valor = valor;
        }
    }
}
