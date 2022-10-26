using System;
using System.Diagnostics;
using System.Numerics;
using System.Security.AccessControl;
namespace Program
{
    class tenis
    {
        static void Main(string[] args)
        {
            double precio = 0, total = 0, descuento = 0;
            int marca;
            do
            {

                Console.Clear();
                Console.WriteLine("Que marca de tenis quieres comprar?");
                Console.WriteLine("Nike = 1");
                Console.WriteLine("Adidas = 2");
                Console.WriteLine("Puma = 3");
                marca = int.Parse(Console.ReadLine());
                if (marca == 1) descuento = 0.10;
                else if (marca == 2) descuento = 0.15;
                else if (marca == 3) descuento = 0.20;
            } while (marca == 0 || marca > 3);

            Console.WriteLine();
            Console.WriteLine("ingresa el precio de los tenis: ");
            precio = double.Parse(Console.ReadLine());
            total = precio - (precio * descuento);
            Console.WriteLine("el total a pagar seria:" + total);

        }
    }
}
