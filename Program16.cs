using System;

namespace ConsoleApp17
{
    class Program16
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escribe un precio");
            string Njoke = Console.ReadLine();
            double num = Convert.ToDouble(Njoke);

            double op = num+num*0.21;

            Console.WriteLine("El precio con iva es {0}",op);
           
        }
    }
}
