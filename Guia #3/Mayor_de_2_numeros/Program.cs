using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mayor_de_2_numeros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Inicializar consola
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.Title = "Programa Ej1";
            Console.Write("\n\tGuia#3 Ej1");

            // Declaracion de variables 
            Double x, y;
            // Entrada 
            Console.Write("\tAveriguaremos cual es el mayor de 2 numeros...");
            Console.Write("\n\n");
            Console.Write("\tDigitar el primer número  : ");
            x = Double.Parse(Console.ReadLine());
            Console.Write("\tDigitar el segundo número : ");
            y = Double.Parse(Console.ReadLine());
            Console.Write("\n");
            //Procesos 
            if (x > y)
            {
                Console.WriteLine("\tEl numero " + x + " es mayor que " + y); // v 
            }
            else
            {
                Console.WriteLine("\tEl numero " + y + " es mayor que " + x); // f 
            }
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
            Console.WriteLine("\t*              Hugo Lopez                   * ");
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
