using System;

namespace ConsoleApp16
{
    class Program15
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escribe un numero");
            string Njoke = Console.ReadLine();
            int num = Convert.ToInt32(Njoke);

            if (num%2 == 0)
                Console.WriteLine("Es divisible por 2");
            else
                Console.WriteLine("No es divisible por 2");
        }
    }
}
