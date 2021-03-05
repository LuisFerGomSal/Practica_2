using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operaciones
{
    class Program
    {
        static void Main(string[] args)
        {

            //delcracion de variables
            String n1;
            String n2;

            //captura de datos
            Console.WriteLine("ingresa numero1: ");
            n1 = Console.ReadLine();

            Console.WriteLine("ingresa numero2: ");
            n2 = Console.ReadLine();

            //conversion de variables a tipo int
            int numero1 = int.Parse(n1);
            int numero2 = int.Parse(n2);

            //operaciones
            int suma = numero1 + numero2;
            int multi = numero1 * numero2;
            int resta = numero1 - numero2;
            int division = numero1 / numero2;
            int residuo = numero1 % numero2;

            //mostrar en pantalla
            //Console.WriteLine("HOLA");
            Console.WriteLine("LA SUMA ES: {0}", suma);
            Console.WriteLine("LA RESTA ES: {0} ", resta);
            Console.WriteLine("LA DIVISON ES: {0} ", division);
            Console.WriteLine("LA MULTIPLICACION ES: {0} ", multi);
            Console.WriteLine("EL RESIDUO ES: {0} ", residuo);

            Console.ReadKey();

        }
    }
}
