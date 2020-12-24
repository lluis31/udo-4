using System;

namespace ex3_udo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine ("Escribe tu nombre");
            String nombre = Console.ReadLine();

            Console.WriteLine ("Escribe tu edad");
            String edad = Console.ReadLine();

            Console.WriteLine("Te llamas" + nombre + "y tienes" + edad + "años"); 

            Console.ReadLine();
        }
    }
}
