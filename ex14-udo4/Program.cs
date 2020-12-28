using System;

namespace ex14_udo4
{
    class Program
    {
        static void Main(string[] args)
        {
            double area = 0;
            double radio = 0;

            Console.Write("Ingrese el radio del circulo: ");

            radio = Int32.Parse(Console.ReadLine());

            area = radio * radio * Math.PI;

            Console.WriteLine("El Area del Circulo: " + area);

            Console.ReadKey();
        }
    }
}
