using System;

namespace ex21_udo4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escriba un dia de la semana:");
            string dia = Console.ReadLine();

            switch (dia.ToLower())
            {
                case "lunes":
                case "martes":
                case "miercoles":
                case "jueves":
                case "viernes":
                case "sabado":
                    Console.WriteLine("{0} es laborable", dia);
                    break;
                case "domingo":
                    Console.WriteLine("{0} no es laborable", dia);
                    break;
                default:
                    Console.WriteLine("{0} dia no valido", dia);
                    break;
            }
        }
    }
}
