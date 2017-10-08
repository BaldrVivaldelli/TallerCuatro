using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoPractico_2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool finDeCarga = false;
            List<Materia> materiasCargadas = new List<Materia>();
            string materia;
            string year;
            string cuatrimestre;
            Nota nota;
            string otraMateria;
            string tipoNota;
            string valorNota;
            string fechaNota;
            Materia materiaACargar;
            materia = null;
            //cargo los datos

            do
            {
                Console.WriteLine("ingresar materia");
                materia = Console.ReadLine();
                Console.WriteLine("ingresa year");
                year = Console.ReadLine();
                Console.WriteLine("ingresa cuatrimestre");
                cuatrimestre = Console.ReadLine();
                Console.WriteLine("ingresa tipo de nota");
                tipoNota = Console.ReadLine();
                Console.WriteLine("ingresa fecha");
                fechaNota = Console.ReadLine();                
                Console.WriteLine("ingresa fecha");
                valorNota = Console.ReadLine();
                nota = new Nota(tipoNota, fechaNota, valorNota);
                Console.WriteLine("Desea cargar otra materia mas    ");
                otraMateria = Console.ReadLine();
                if (otraMateria.Equals("si")){
                    finDeCarga = true;
                }

                materiaACargar = new Materia(materia, year, cuatrimestre, nota);
                materiasCargadas.Add(materiaACargar);
            } while (finDeCarga);

            //procesoTodo
            
            //se seleciciona solo las materias del primer cuatrimestre
            List<Materia> materiasPrimerCuatri = materiasCargadas.Where(linqMateria => linqMateria.cuatrimestre.Contains("primer")).ToList();
            //ordenado por nombre
            materiasCargadas.OrderByDescending(x => x.nombre);
            //esto es chino basico, pero resumiendo. Primero hago un where del tipo Nota TP para quedarme ya con todos los TP y despues al resultado selecciono la clase nota
            List < Nota > notasDelTipoTP = materiasCargadas.Where(linqMateria => linqMateria.notas.tipo.Contains("TP")).Select(tipoNotas => tipoNotas.notas).ToList();
            
        }
    }
}
