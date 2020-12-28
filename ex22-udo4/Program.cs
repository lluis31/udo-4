using System;

namespace ex22_udo4
{
    class Program
    {
        static void Main(string[] args)
        {
            string contrasenya = "abrete";
            bool v = false;
            do
            {
                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine("\nIntroduzca la contraseña:");
                    string inPass = Console.ReadLine();

                    if (inPass != contrasenya)
                    {
                        Console.WriteLine("Contraseña incorrecta");
                    }
                    else
                    {
                        i = 4;  //No acierta, sale del bucle for antes de tiempo
                        Console.WriteLine("Contraseña correcta, Enhorabuena!");
                        v = true; //Si acierta, sale del bucle while

                    }

                    v = true;
                }
            } while (!v);
        }
    }
}
