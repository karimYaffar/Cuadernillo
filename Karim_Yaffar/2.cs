using System;
using System.Security.AccessControl;
namespace Program
{
    class CALIFICACIÓN
    {
        static void Main(string[] args)
        {
            double tt = 0, aux = 0, mat = 0, t = 0, tf = 0;

            Console.WriteLine("Ingrese el numero de materias que tiene");
            int num = int.Parse(Console.ReadLine()); 

            for (int i = 0; i < num; i++)
            {
                Console.WriteLine($"Ingrese la calificacion de la materia {i+1}");
                mat = double.Parse(Console.ReadLine());
                tt = tt + mat;

            }
            tf = tt / num; 

            Console.WriteLine("Su promedio es de  " + tf);


        }
    }
}
