using System;
using System.Diagnostics;
using System.Numerics;
using System.Security.AccessControl;
namespace Program
{
    class pares
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("ingrese numero:");
            num = int.Parse(Console.ReadLine());
            if ((num % 2) == 0)
            {
                Console.WriteLine("numero par:");
            }
            else
            {
                Console.WriteLine("numero impar");
            }
            Console.ReadKey();
        }
    }
}
