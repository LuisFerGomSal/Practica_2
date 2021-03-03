using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Int
{
    class Program
    {
        static void Main(string[] args)
        {
            // declaración de variables int con valor estatico
            int numero1 = 5;
            int numero2 = 6;
            int numero3 = 7;


            //sumar las variables
            int suma = numero1 + numero2 + numero3;

            //imprimir en pantalla
            Console.WriteLine("El valor de suma es: " + suma);
            Console.WriteLine("Presiona cualquier tecla para continuar...");
            Console.ReadKey(); //se sale cuando detecta la presion de una tecla
        }
    }
}
