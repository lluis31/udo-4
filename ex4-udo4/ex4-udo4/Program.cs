using System;

namespace ex4_udo4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escribe el primer numero");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Escibre el segundo numero");
            int num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2)
                Console.WriteLine("El primer numero es mayor");
            else
                Console.WriteLine("El segundo numero es mayor");

            Console.ReadLine();
        }
    }
}
