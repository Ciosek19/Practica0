using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
   internal class Program
   {
      static void Main()
      {
         Console.WriteLine("Introduce el día");
         int dia = int.Parse(Console.ReadLine());

         Console.WriteLine("Introduce el mes");
         int mes = int.Parse(Console.ReadLine());

         Console.WriteLine("Introduce el año");
         int año = int.Parse(Console.ReadLine());

         // Comprobamos que la fecha es correcta
         if ((dia >= 1 && dia <= 31) && (mes >= 1 && mes <= 12) && (año >= 0))
         {
            // Usamos el switch para escribir el mes junto con el día y el año
            switch (mes)
            {
               case 1:
                  Console.WriteLine($"{dia} de enero de {año}");
                  break;
               case 2:
                  Console.WriteLine($"{dia} de febrero de {año}");
                  break;
               case 3:
                  Console.WriteLine($"{dia} de marzo de {año}");
                  break;
               case 4:
                  Console.WriteLine($"{dia} de abril de {año}");
                  break;
               case 5:
                  Console.WriteLine($"{dia} de mayo de {año}");
                  break;
               case 6:
                  Console.WriteLine($"{dia} de junio de {año}");
                  break;
               case 7:
                  Console.WriteLine($"{dia} de julio de {año}");
                  break;
               case 8:
                  Console.WriteLine($"{dia} de agosto de {año}");
                  break;
               case 9:
                  Console.WriteLine($"{dia} de septiembre de {año}");
                  break;
               case 10:
                  Console.WriteLine($"{dia} de octubre de {año}");
                  break;
               case 11:
                  Console.WriteLine($"{dia} de noviembre de {año}");
                  break;
               case 12:
                  Console.WriteLine($"{dia} de diciembre de {año}");
                  break;
               default:
                  Console.WriteLine("error");
                  break;
            }
         }
         Console.ReadKey();
      }
   }
}

