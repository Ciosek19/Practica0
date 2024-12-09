using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
   internal class Program
   {
      static void Main()
      {
         string alumno;
         do
         {
            Console.WriteLine("Introduce el nombre del alumno");
            alumno = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(alumno))
            {
               Console.WriteLine("Introduce la nota de practica");
               double notaPractica = Convert.ToDouble(Console.ReadLine());

               Console.WriteLine("Introduce la nota de problemas");
               double notaProblemas = Convert.ToDouble(Console.ReadLine());

               Console.WriteLine("Introduce la nota de teoria");
               double notaTeoria = Convert.ToDouble(Console.ReadLine());
               
               if (notaPractica >= 0 && notaPractica <= 10 &&
                   notaProblemas >= 0 && notaProblemas <= 10 &&
                   notaTeoria >= 0 && notaTeoria <= 10)
               {
                  Console.WriteLine("El alumno " + alumno);
                  Console.WriteLine("La nota practica es " + notaPractica);
                  Console.WriteLine("La nota de problemas es " + notaProblemas);
                  Console.WriteLine("La nota de teoria es " + notaTeoria);

                  notaPractica *= 0.8;
                  notaProblemas *= 0.5;
                  notaTeoria *= 0.4;

                  double notaFinal = notaPractica + notaProblemas + notaTeoria;
                  Console.WriteLine("La nota final es " + notaFinal);
               }
               else
               {
                  Console.WriteLine("Has escrito una nota incorrecta, vuelve a intentarlo");
               }
            }
         } while (!string.IsNullOrWhiteSpace(alumno));
         Console.ReadKey();
      }
   }
}
