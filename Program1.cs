using System;

namespace ConsoleApp6
{
    class Program1
    {
        static void Main(string[] args)
        {

            try
            {
                Console.WriteLine("Escribe un numero");
                string Njoke = Console.ReadLine();
                int num1 = Convert.ToInt32(Njoke);

                Console.WriteLine("Escribe un numero");
                string Mjoke = Console.ReadLine();
                int num2 = Convert.ToInt32(Mjoke);

                Console.WriteLine("Escribe un numero");
                string Ljoke = Console.ReadLine();
                int num3 = Convert.ToInt32(Ljoke);

                int op = num1 + num2 + num3;

                Console.WriteLine("numeros introducidos : {0} {1} {2}",num1,num2,num3);
                Console.WriteLine("La sumaa  = {0}",op);

            }

            catch (OverflowException)
            {
                Console.WriteLine("No se ha podido tranformar a numero");
            }
           
        }
    }
}
