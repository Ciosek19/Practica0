using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
   internal class Program
   {              
      static void Main()
      {
         int n;
         do
         {
            Console.WriteLine("Escribe un numero");
            n = int.Parse(Console.ReadLine());
            if (n < 1)
            {
               Console.WriteLine("Debe ser mayor o igual que 1");
            }
         } while (n < 1);

         for (int i = 1; i <= n; i++)
         {
            int resultado = i * i;
            Console.WriteLine("El valor al cuadrado de " + i + " es de " + resultado);
         }
         Console.ReadKey();
      }
   }
}
