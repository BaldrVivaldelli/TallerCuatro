using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoPracticoDos
{
    class IFigura
    {
        private string nombre { set; get; }
        private double radious { set; get; }
        private double basee { set; get; }
        private double altura { set; get; }
        private int cantidadDeLados { set; get; }
        private double lado { set; get; }
        private List<int> lados { set; get; }

        protected double calcularArea(IFigura figura) {
            double area = 0.00;
            double aux = 0.00;
            switch (figura.nombre)
            {
                case "circulo":
                    aux = Math.PI * figura.radious;
                    area = Math.Pow(aux,2);
                break;
                case "triangulo":
                    area = figura.basee * figura.altura;
                break;
                case "cuadrado":
                    area = Math.Pow(figura.lado, 2);
                break;    
            }
            return area;
        }

        protected double calcularLongitud(IFigura figura)
        {
            double longitud;

            foreach(int x in figura.lados)
            {
                longitud = +x;
            }
            return longitud;
        }
    }
}
