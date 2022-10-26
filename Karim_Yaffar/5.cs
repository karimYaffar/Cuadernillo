using System;
using System.Diagnostics;
using System.Numerics;
using System.Security.AccessControl;
namespace Program
{
    class croquetas
    {
        static void Main(string[] args)
        {
            double precio = 0, total = 0;
            int tipo, cant;
            do
            {

                Console.Clear();
                Console.WriteLine("Ingresa que marca de croquetas quieres comprar: ");
                Console.WriteLine("Nogacan = 1");
                Console.WriteLine("Pedigree = 2");
                Console.WriteLine("Dog Chow = 3");
                Console.WriteLine("Ganador = 4");
                tipo = int.Parse(Console.ReadLine());
                if (tipo == 1) precio = 20;
                else if (tipo == 2) precio = 30;
                else if (tipo == 3) precio = 35;
                else if (tipo == 4) precio = 40;
            } while (tipo == 0 || tipo > 4);

            Console.WriteLine("cuantos kg va comprar?");
            cant = int.Parse(Console.ReadLine());
            total = (cant * precio);
            Console.WriteLine("el total a pagar seria:" + total);


        }
    }
}
