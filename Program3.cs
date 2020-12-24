using System;

namespace ConsoleApp8
{
    class Program3
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Escribe tu nombre");
                string nom = Console.ReadLine();

                Console.WriteLine("Escribe tu edad");
                string Njoke = Console.ReadLine();
                int edad = Convert.ToInt32(Njoke);


                Console.WriteLine("Hola {0} tu edad es {1}", nom, edad);
            }

            catch(FormatException)
            {
                Console.WriteLine("No es un nunmero la edad");
            }
        }
    }
}
