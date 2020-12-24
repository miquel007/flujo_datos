using System;
using System.Collections.Generic;

namespace ConsoleApp10
{
    class Program5
    {
        static void Main(string[] args)
        {
                Console.WriteLine("Escribe un dia de la semana");
                string semana = Console.ReadLine();

                semana = semana.ToLowerInvariant();

            List<String> lista = new List<string>();   
            lista.Add("lunes");
            lista.Add("martes");
            lista.Add("miercoles");
            lista.Add("jueves");
            lista.Add("viernes");
            lista.Add("sabado");
            lista.Add("domingo");

            bool has = lista.Exists(x => x == semana);
            if (has)
            {

                if (semana.Equals("domingo") || semana.Equals("sabado"))
                    Console.WriteLine("Es finde");
                else
                    Console.WriteLine("No finde :(");
            }
            else
                Console.WriteLine("No es ni un nombre de la semana");

        }
    }
}
