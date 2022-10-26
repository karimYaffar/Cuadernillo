using System;
using System.Diagnostics;
using System.Numerics;
using System.Security.AccessControl;
namespace Program
{
    class num_positivo
    {
        static void Main(string[] args)
        {
            double n, pxh, resultado;

            Console.WriteLine("ingresa un numero");
            n = double.Parse(Console.ReadLine());
            if (n > 0)
                Console.WriteLine("El numero es positivo");
            else
                Console.WriteLine("El numero es negativo");

            Console.ReadKey();
        }
    }
}
