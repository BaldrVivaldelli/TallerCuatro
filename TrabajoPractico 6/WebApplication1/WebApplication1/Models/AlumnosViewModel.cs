using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class AlumnosViewModel
    {

        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Legajo { get; set; }
        public List<Materia> Materias { get; set; }

    }
}