using System;

namespace ex20_udo4
{
    class Program
    {
        static void Main(string[] args)
        {
            double total = 0;

             Console.WriteLine("Numero de ventas?");

            int numeroVentas = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < numeroVentas; i++)
            {
                Console.WriteLine("El precio de venta es n * {0}", i + 1);

                double precioVenta = Convert.ToDouble(Console.ReadLine());

                total = precioVenta + total;
            }
             Console.WriteLine("Numero total {0}", total);
        }
    }
}