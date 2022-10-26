using System;
using System.Diagnostics;
using System.Numerics;
using System.Security.AccessControl;
namespace Program
{
    class horas
    {
        static void Main(string[] args)
        {
            double H, pxh, resultado;

            Console.WriteLine("ingresa las horas trabajadas:");
            H = double.Parse(Console.ReadLine());
            if (H > 0)
            {
                Console.WriteLine("ingresa el pago por hora:");
                pxh = double.Parse(Console.ReadLine());
                resultado = H * pxh;
                Console.WriteLine("sueldo total:" + resultado);
                Console.ReadKey();
            }
            else
                Console.WriteLine("Usted no trabaja");
        }
    }
}
