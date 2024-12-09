using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ejercicio3
{
   internal class Program
   {
      static void Main()
      {
         int horas = 0;
         int minutos = 0;
         int segundos = 0;

         while (true)
         {
            if (horas < 10)
            {
               Console.Write("0");
            }
            Console.Write(horas + ":");

            if (minutos < 10)
            {
               Console.Write("0");
            }
            Console.Write(minutos + ":");

            if (segundos < 10)
            {
               Console.Write("0");
            }
            Console.WriteLine(segundos);

            segundos = segundos + 1;

            if (segundos == 60)
            {
               minutos = minutos + 1;
               segundos = 0;
            }

            if (minutos == 60)
            {
               horas = horas + 1;
               minutos = 0;
            }

            if (horas == 24)
            {
               horas = 0;
            }

            Thread.Sleep(1000);
         }
      }
   }
}
