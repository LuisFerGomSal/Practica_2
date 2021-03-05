using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Burguer
{
    class Program
    {
        static void Main(string[] args)
        {

            //declaracion de variables
            int cantBur, cantPap, cantBeb;
            double total;
            String linea;
            const double precioBur = 45;
            const double precioPap = 15;
            const double precioBeb = 20;

            //captura de datos
            Console.WriteLine("Ingresa el numero de amburguesas: ");
            linea = Console.ReadLine();
            cantBur = int.Parse(linea);

            Console.WriteLine("Ingresa el numero de papas: ");
            linea = Console.ReadLine();
            cantPap = int.Parse(linea);

            Console.WriteLine("Ingresa el numero de bebidas: ");
            linea = Console.ReadLine();
            cantBeb = int.Parse(linea);

            //calculo total
            total = (cantBur * precioBur) + (cantPap * precioPap) + (cantBeb * precioBeb);
            Console.WriteLine("El total es {0}.", total);
            Console.ReadKey();

        }
    }
}
