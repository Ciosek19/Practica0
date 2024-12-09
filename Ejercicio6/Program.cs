using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6
{
   internal class Program
   {
      static void Main()
      {
         Console.WriteLine("Introduce un año");
         int año = int.Parse(Console.ReadLine());

         if (año % 4 == 0 && año % 100 != 0)
         {
            Console.WriteLine("El año " + año + " es bisiesto");
         }
         else if (año % 400 == 0 && año % 100 == 0)
         {
            Console.WriteLine("El año " + año + " es bisiesto");
         }
         else
         {
            Console.WriteLine("El año " + año + " no es bisiesto");
         }
         Console.ReadKey();
      }
   }

}
