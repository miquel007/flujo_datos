using System;

namespace ConsoleApp12
{
    class Program17_18_19
    {
        static void Main(string[] args)
        {
            for (int i = 1; i<101; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("_______________________________");

            int num1 = 1;

            while (num1 < 101)
            {
                Console.WriteLine(num1);
                num1++;
            }
            Console.WriteLine("_______________________________");

            num1 = 1;

            while (num1 < 101)
            {
               if (num1%2==0  ||  num1%3==0)
                    Console.WriteLine(num1);
                num1++;
            }
        }
    }
}
