using System;

namespace ex16_udo4
{
    class Program
    {
        static void Main(string[] args)
        {

            float iva, vv, pv;

            Console.Write("Introduce el valor del producto");
            vv = float.Parse(Console.ReadLine());

            iva = vv * 0.21F;
            pv = vv + iva;

            Console.WriteLine("El iva es:" + iva);
            Console.WriteLine("El precio de venta es:" + pv);

        }
    }
}
