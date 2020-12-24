using System;

namespace ConsoleApp9
{
    class Program4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escribe un numero");
            string Njoke = Console.ReadLine();
            double num1 = Convert.ToDouble(Njoke);

            Console.WriteLine("Escribe un numero");
            string Mjoke = Console.ReadLine();
            double num2 = Convert.ToDouble(Mjoke);


            if (num1 < num2)
                Console.WriteLine("El numero {0} es mayor que {1}",num2,num1);
            else
                Console.WriteLine("El numero {0} es mayor que {1}", num1, num2);
         
        }
    }
}
