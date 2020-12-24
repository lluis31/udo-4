using System;

namespace ex13_udo4
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            Console.Write("Introduce tu nombre: "); nombre = Console.ReadLine();
            if (nombre == "Lluis")
            {
                Console.WriteLine();
                Console.WriteLine("Bienvenido Lluis");
            }
        }
    }
}
