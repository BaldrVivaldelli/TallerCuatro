using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoPractico_1
{
    class Program
    {
        /*
                    
            Realizar un programa de consola que permita ingresar el nombre y la edad, con estos datos debe imprimir un mensaje diciendo si es mayor de edad o no.

            Realizar un programa de consola que permita ingresar un numero y calcule la suma de todos los numeros enteros anteriores

            Realizar un programa de consola que permita ingresar 2 valores y encuentr el maximo comun divisor

            Realizar un programa de consola que permita ingresar numeros y que termine de pedir numeros cuando se ingresa 0 y calcule el promedio de todos los ingresados
             
        */
        static void Main(string[] args)
        {
            //Realizar un programa de consola que permita ingresar el nombre y apellido por separado, con estos datos debe imprimir un mensaje con el nombre completo.
            string  nombre;
            string apellido;

            Console.WriteLine("Ingresa tu nombre: ");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingresa tu apellido: ");
            apellido = Console.ReadLine();
            Console.WriteLine(nombre + apellido);

            //Realizar un programa de consola que permita ingresar el nombre y la edad, con estos datos debe imprimir un mensaje diciendo si es mayor de edad o no.

            int num;
            Console.WriteLine("Ingresa tu edad: ");
            num = Convert.ToInt32(Console.ReadLine());
            if (num > 18)
            {
                Console.WriteLine("es menor");
            }
            else {
                Console.WriteLine("es mayor");
            }

            //Realizar un programa de consola que permita ingresar 2 valores y encuentr el maximo comun divisor

            Console.WriteLine("ingresa primer numero");
            int primerNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("ingresa primer numero");
            int segundoNum = Convert.ToInt32(Console.ReadLine());

            int a = Math.Max(primerNum, segundoNum);
            int b = Math.Min(primerNum, segundoNum);

            int res;


            do
            {
                res = b;
                b = a % b;
                a = res;

            } while (b != 0);

            Console.WriteLine("El maximo comun divisor es " + res);


            //Realizar un programa de consola que permita ingresar numeros y que termine de pedir numeros cuando se ingresa 0 y calcule el promedio de todos los ingresados
            List<int> iList = new List<int>();            
            Console.WriteLine("ingresa primer numero");

            int auxNum;
            double auxTotal = 0.0d;
            do {

                auxNum= Convert.ToInt32(Console.ReadLine());
                iList.Add(auxNum);

            } while (b != 0);
            //saco el promedio
            foreach (int element in iList)
            {
                auxNum = element;
            }
            auxTotal = auxTotal / iList.Count;
            Console.WriteLine("El promedio es " + res);

        }
    }
}
