using System;
using System.Diagnostics;
using System.Numerics;
using System.Security.AccessControl;
namespace Program
{
    class tabla
    {
        static void Main(string[] args)
        {
            double tt = 0;

            Console.WriteLine("Ingrese la tabla de multiplicar que desea conocer");
            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < 10; i++)
            {
               
                tt = num * (i + 1);
                Console.WriteLine($"{num}*{i + 1}=" + tt);

            }
            

        }
    }
}
