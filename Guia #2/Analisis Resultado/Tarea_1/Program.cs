using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WindowHeight = 25;  // alto de la ventana             
            Console.WindowWidth = 65; //ancho de la ventana  
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.Title = "Conversor Kilometros";
            Console.Write("\nTarea 1");
            Console.Write("\n\n");

            double km, m, yar, varas;

            //Entrada de datos  
            Console.Write("\tIngrese la cantidad de kilometros:");

            km = double.Parse(Console.ReadLine());
            Console.WriteLine("\n");

            m = km * 1000; //   1km = 1000m
            Console.WriteLine("La cantidad en metros es de:" + m);

            yar = km * 1000 * 1.09361;
            Console.WriteLine("La catidad en yardas es de:" + yar);

            varas = km * 1000 * 1.1963; 
            Console.WriteLine("La cantidad en varas es de:" + varas);


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
