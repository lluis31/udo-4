using System;

namespace ex15_udo4
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                int num = 1;
                bool respuesta;

                while (num <=200)
                {
                    Console.Write(" Escribe un numero", num);
                    respuesta = multiplo2(num);

                    if (respuesta) Console.WriteLine("Es multiple de 2");
                    else Console.WriteLine("No es multiplo de 2");

                    num++;
                }

             }
         }
            public static bool multiplo2 (int n)
              {
            if ((n % 2) != 0) return false;
            else return true;

        }
     }
}

        

