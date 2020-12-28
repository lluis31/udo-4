using System;

namespace ex16_udo4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce el precio del producto:");

            double precio = Convert.ToDouble(Console.ReadLine());
            double IVA = (precio * 21 / 100);
            double total = precio + IVA;

            Console.WriteLine("El precio final, IVA incluido es: {0}", total);
        }
    }
}
