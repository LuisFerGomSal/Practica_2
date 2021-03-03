using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoPerimetro
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaracion de variables
            int a = 10;
            int b = 10;
            int c = 7;

            //suma de variables
            int perimetro = a + b + c;

            //impresion de variables
            Console.WriteLine("El perimetro del triangulo es: " + perimetro);
            Console.WriteLine("Presiona cualquier tecla para continuar...");
            Console.ReadKey();

        }
    }
}
