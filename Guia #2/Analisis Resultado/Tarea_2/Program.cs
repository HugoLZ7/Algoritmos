using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Inicializar consola
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.Title = "Programa TRAEA 1";
            Console.Write("\n\tGuia#1 Tarea 1");

            //Decalarar variables .
            double x1, x2, y1, y2, P;

            //Primer proceso ingreso de datos 
            Console.Write("\n\n");
            Console.Write("\tDigitar el valor de x1  : "); //Escribir en la consola
            x1 = double.Parse(Console.ReadLine());
            Console.Write("\n\n");
            Console.Write("\tDigitar el valor de x2  : "); //Escribir en la consola
            x2 = double.Parse(Console.ReadLine());
            Console.Write("\n\n");
            Console.Write("\tDigitar el valor de y1  : "); //Escribir en la consola
            y1 = double.Parse(Console.ReadLine());
            Console.Write("\n\n");
            Console.Write("\tDigitar el valor de y2  : "); //Escribir en la consola
            y2 = double.Parse(Console.ReadLine());
            Console.Write("\n\n");

            P = Math.Pow(x2-x1,2) + Math.Pow(y2-y1,2); //Operacion P
            Console.Write("\n\n");
            Console.Write("\tEl Resultado de P es:" + P);
            Console.Write("\n\n");

            //Pantalla opcional 
            Console.Write("\t");
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine("*********************************************");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;

            Console.WriteLine("\t*                                           * ");
            Console.WriteLine("\t*         Este programa fue diseñado por:   * ");
            Console.WriteLine("\t*                                           * ");
            Console.WriteLine("\t*                  Hugo Lopez               * ");
            Console.WriteLine("\t*                                           * ");
            Console.Write("\t");

            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine("*********************************************");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Write("\t");
            Console.WriteLine("--> Fin del Programa");
            Console.Write("\t");
            Console.ReadKey();

        }
    }
}
