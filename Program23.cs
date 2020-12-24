using System;

namespace ConsoleApp21
{
    class Program23
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escribe un numero");
            string Njoke = Console.ReadLine();
            int num1 = Convert.ToInt32(Njoke);

            Console.WriteLine("Escribe un numero");
            string Mjoke = Console.ReadLine();
            int num2 = Convert.ToInt32(Mjoke);

            Console.WriteLine("Que operador quieres utilizar(escribe numnero): 1)+ 2)- 3)* 4)/ 5)^ 6)% ");
            string Ljoke = Console.ReadLine();
            int num3 = Convert.ToInt32(Ljoke);

            double op = 0;
            bool trun = true;

            switch (num3)
            {
                case 1:
                    op = num1 + num2;
                    break;
                case 2:
                    op = num1 - num2;
                    break;
                case 3:
                    op = num1 * num2;
                    break;
                case 4:
                    op = num1 / num2;
                    break;
                case 5:
                    op = Math.Pow(num1, num2);
                    break;
                case 6:
                    op = num1 % num2;
                    break;
                default:
                    trun = false;
                    break;
            }

            if (trun)
                Console.WriteLine("La operacion es {0}",op);
            else
                Console.WriteLine("Mal opcion");

        }
    }
}
