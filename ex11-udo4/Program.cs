using System;

namespace ex11_udo4
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 10;
            int num2 = 20;

            if (num1 <= num2)
            {
                if (num1 == num2)
                {
                    Console.WriteLine("Los numeros" + num1 + "y" + num2 + "son iguales");
                }

                else

                    Console.WriteLine("El numero" + num1 + "es mayor que el numero" + num2);
            }

            else

                Console.WriteLine("El numero" + num2 + "es mayor que el numero" + num1);
                }
            }
}
