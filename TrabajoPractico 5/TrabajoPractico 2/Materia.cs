using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoPractico_2
{
    /*
     
        Nombre
        Año
        Cuatrimestre
        Notas
         
         */

    public class Materia
    {
        public string nombre { get;  set; }
        public string year { get;  set; }
        public string cuatrimestre { get;  set; }
        public Nota notas { get; set; }

        public Materia(string nombre, string year, string cuatrimestre, Nota notas){
            this.nombre = nombre;
            this.year = year;
            this.cuatrimestre = cuatrimestre;
            this.notas = notas;
        }

    }
}
