using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_StringInt
{
    class Program
    {
        static void Main(string[] args)
        {
            //delcracion de variables
            String nombre;
            String edad;

            Console.WriteLine("ingresa tu nombre: ");
            nombre = Console.ReadLine();

            Console.WriteLine("ingresa tu edad: ");
            edad = Console.ReadLine();

            //mostrar en pantalla
            Console.WriteLine("te llamas " + nombre + " y tu edad es " + edad);
            Console.WriteLine("Presiona una tecla para continuar...");
            Console.ReadLine();
        }
    }
}
