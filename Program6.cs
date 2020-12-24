using System;

namespace ConsoleApp11
{
    class Program6
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pon un precio al producto");
            string Njoke = Console.ReadLine();
            double precio = Convert.ToDouble(Njoke);

            Console.WriteLine("Metodo de pago (escribe numero)-> 1)Efectivo  2)Tarjeta"  );
            string Mjoke = Console.ReadLine();
            int metodo = Convert.ToInt32(Mjoke);

            if (metodo == 2)
            {
                Console.WriteLine("Pon numero de la tarjeta");
                string Ljoke = Console.ReadLine();
                int tarjeta = Convert.ToInt32(Ljoke);

                Console.WriteLine("El precio es de {0}, y el numero de la tarjeta es {1}",precio,tarjeta);
            }
            else
                Console.WriteLine("El precio es de {0} en efectivo pls", precio);
        }
    }
}
