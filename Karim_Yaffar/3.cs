using System;
using System.Diagnostics;
using System.Security.AccessControl;
namespace Program
{
    class PAPELERIA
    {
        static void Main(string[] args)
        {
            double tt = 0;
            Console.WriteLine("Ingrese las horas utilizadas");
            int h = int.Parse(Console.ReadLine());

            Console.WriteLine("INGRESE LA MAQUINA UTILIZADA");
            Console.WriteLine("1 = 10 MEGAS");
            Console.WriteLine("2 = 30 MEGAS");
            Console.WriteLine("3 = 50 MEGAS");
            Console.WriteLine("4 = 100 MEGAS");
            Console.WriteLine("5 = 150 MEGAS");
            int M = int.Parse(Console.ReadLine());
            switch (M)
            {
                case 1:
                    {
                        tt = h * 10;
                    }

                    break;
                case 2:
                    {
                        tt = h * 15;
                    }

                    break;
                case 3:
                    {
                        tt = h * 20;
                    }

                    break;
                case 4:
                    {
                        tt = h * 25;
                    }

                    break;
                case 5:
                    {
                        tt = h * 30;
                    }

                    break;

            }

            Console.WriteLine("El costo es de " + tt);

        }
    }
}

