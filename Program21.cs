using System;
using System.Collections.Generic;

namespace ConsoleApp19
{
    class Program21
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escribe un dia de la semana");
            string semana = Console.ReadLine();

            semana = semana.ToLowerInvariant();

            switch (semana)
            {
                case "sabado":
                    Console.WriteLine("Es finde");
                    break;
                case "domingo":
                    Console.WriteLine("Es finde");
                    break;
                default:
                    Console.WriteLine("No finde :(");
                    break;
            }

        }
    }
}
