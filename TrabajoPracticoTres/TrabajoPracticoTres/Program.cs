using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            var l = new List<triangulos>();
            l.Add(new triangulos(5, 5, 5));
            l.Add(new triangulos(2, 10, 1));
            l.Add(new triangulos(14, 5, 20));
            l.Add(new triangulos(80, 2, 8));
            l.Add(new triangulos(1, 1, 8));

            var l2 = l.Where((h) => h.perimetro() > 10).ToList();

            foreach (var item in l2)
            {
                Console.WriteLine($" {item.perimetro()}");
                Console.ReadLine();

            }


        }

    }

    public class triangulos
    {
        public int lado1;
        public int lado2;
        public int lado3;
        public triangulos(int a, int b, int c)
        {
            lado1 = a;
            lado2 = b;
            lado3 = c;
        }

    }

    public static class MyClass
    {

        public static int perimetro(this triangulos a)
        {
            return a.lado1 + a.lado2 + a.lado3;
        }

    }


}
