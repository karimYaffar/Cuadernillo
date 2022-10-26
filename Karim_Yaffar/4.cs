using System;
using System.Diagnostics;
using System.Numerics;
using System.Security.AccessControl;
namespace Program
{
    class bios
    {
        static void Main(string[] args)
        {
            DateTime hoy = DateTime.Now;
            String fecha = hoy.ToString("dd/MM/yyyy");

            Console.WriteLine(fecha);

            Console.WriteLine("la fecha es correcta?");
            int num = int.Parse(Console.ReadLine());

            if (num == 1)
                Console.WriteLine("La bios funciona");
            else if (num == 0)
                Console.WriteLine("La bios no funciona");
            else
                Console.WriteLine("ingrese entre 1 y 0");
           
        }
    }
}
