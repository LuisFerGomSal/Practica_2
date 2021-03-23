using System;

namespace TiendaParaGatos
{
    class Program
    {
        static void Main(string[] args)
        {
            double latas, total = 0;
            String line;
            
            Console.WriteLine("¡Bienvenido a la tienda de comida para gatos!");

            Console.WriteLine("Ingresa el numero de latas que desea comprar: ");
            line = Console.ReadLine();
            latas = int.Parse(line);

            if(latas < 50)
            {
                total = latas * 2;
            }
            else if(latas >= 50 && latas < 100)
            {
                total = latas * 1.75;
            }
            else if(latas >= 100)
            {
                total = latas * 1.5;
            }

            Console.WriteLine("Cantidad: " + latas + " Costo total: $" + total + " MXN");
        }
    }
}
