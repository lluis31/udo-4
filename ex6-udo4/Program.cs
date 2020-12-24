using System;

namespace ex6_udo4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escribe el precio del producto");
            double precio = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Escribe la forma de pago: tarjeta o efectivo");
            string forma = (Console.ReadLine()).ToLower();

            if (forma.Equals("tarjeta"))
            {

                Console.WriteLine("Introduce el numero de tarjeta porfavor");
                int numero_cuenta = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("El producto con precio" + precio + "se ha pagado" + "con el numero de cuenta" + numero_cuenta);
            }
            else if (forma.Equals("Efectivo"))
            {

                Console.WriteLine("El producto con precio" + precio + "se ha pagado");
            }
            else
            {
                Console.WriteLine("La forma de pago introducida no es correcta");
            }
            Console.ReadLine();
        }
    }
}
