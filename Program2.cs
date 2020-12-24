using System;

namespace ConsoleApp7
{
    class Program2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escribe tu nombre");
            string nom = Console.ReadLine();

            Console.WriteLine("Escribe el nombre de una ciudad");
            string ciutat = Console.ReadLine();

            Console.WriteLine("Hola {0} bienvenido a {1}",nom,ciutat);
            
        }
    }
}
