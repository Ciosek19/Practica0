using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
   internal class Program
   {
      static void Main()
      {
         int lado;
         Console.Write("Ingrese el valor de lado: ");
         lado = int.Parse(Console.ReadLine());

         // Primera línea de asteriscos
         for (int asterisco = 1; asterisco <= lado; asterisco++)
         {
            Console.Write("*");
         }
         Console.WriteLine();

         // Líneas intermedias
         for (int asterisco = 1; asterisco <= lado - 2; asterisco++)
         {
            Console.Write("*");
            for (int espacio = 1; espacio <= lado - 2; espacio++)
            {
               Console.Write(" ");
            }
            Console.Write("*");
            Console.WriteLine();
         }

         // Última línea de asteriscos
         for (int asterisco = 1; asterisco <= lado; asterisco++)
         {
            Console.Write("*");
         }
         Console.ReadKey();
      }
   }

}
