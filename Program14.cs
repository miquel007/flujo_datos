using System;

namespace ConsoleApp15
{
    class Program14
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pon el radio del circulo");
            string Njoke = Console.ReadLine();
            double radi = Convert.ToDouble(Njoke);

            double op = Math.Pow(Math.PI,2)*radi;

            Console.WriteLine("El area del circuleo es {0}",op);

        }
    }
}
