using System;

namespace ConsoleApp18
{
    class Program20
    {
        static void Main(string[] args)
        {            
            Console.WriteLine("Cuantas ventas se han realizado?");
            string Nfake = Console.ReadLine();
            int ventas = Convert.ToInt32(Nfake);


            string Mfake;
            double venta;
            double op = 0;

            while (ventas != 0 )
            {
                Console.WriteLine("Cuanto se ha ganado?");
                Mfake = Console.ReadLine();
                venta = Convert.ToDouble(Mfake);
                op = op + venta;
                ventas--;
            }

            Console.WriteLine("Se ha ganado {0}",op);

        }
    }
}
