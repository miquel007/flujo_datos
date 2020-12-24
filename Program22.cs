using System;

namespace ConsoleApp20
{
    class Program22
    {
        static void Main(string[] args)
        {
            string pass = "rubale";
            int flow = 3;
            bool go = false;
            string inten;

            while (flow != 0  && !go )
            {
                Console.WriteLine("Tens {0} intens per saber la contrasenya",flow);
                inten = Console.ReadLine();

                if (inten.Equals(pass))
                    go = true;
                else
                    flow--;
                
            }

            Console.WriteLine("Ho has aconseguit en {0} intens", flow);
        }
    }
}
