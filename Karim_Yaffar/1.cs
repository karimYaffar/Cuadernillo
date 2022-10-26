
using System;
using System.Security.AccessControl;
namespace Program
{
    class DESCUENTO_FOVISSSTE
    {
        static void Main(string[] args)
        {
            double descuento, total_sueldo;
           
            
                Console.WriteLine("Ingrese su sueldo quincenal ");
                double sueldo = double.Parse(Console.ReadLine());
            if (sueldo > 0)
            {
                descuento = (sueldo * 0.30) * 24;
                total_sueldo = (descuento + sueldo) * (24);

                Console.WriteLine("Su sueldo total de un año es de " + total_sueldo);

                Console.WriteLine("Uste abona " + descuento);
            }
            else
                Console.WriteLine("usted ni trabaja");


        }
    }
}
