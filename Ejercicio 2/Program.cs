using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Programa realizado por  
            // Día:  
            // Console.WindowHeight = 25;  // alto de la ventana            
            // Console.WindowWidth = 60; //ancho de la ventana 
             Console.ForegroundColor = ConsoleColor.Black;
             Console.BackgroundColor = ConsoleColor.White;
             Console.Clear();
             Console.Title = "Programa de Promedio de ventas de un vendedor";
             Console.Write("\n\tGuia#1 Ejemplo2");
             Console.Write("\n\n");

            // Declaracion de variables 
             String nomb, ape;
             Double v1, v2, v3, prom;

            // Entrada 
             Console.Write("\tEmpresa ADOC...");
             Console.Write("\n");
             Console.Write("\tDigitar el nombre del vendedor......: ");
             nomb = (Console.ReadLine());
             Console.Write("\tDigitar el apellido del vendedor....: ");
             ape = (Console.ReadLine());
             Console.Write("\tDigitar la primer venta.............: $ ");
             v1 = Double.Parse(Console.ReadLine());
             Console.Write("\tDigitar la segunda venta............: $ ");
             v2 = Double.Parse(Console.ReadLine());
             Console.Write("\tDigitar la tercer venta.............: $ ");
             v3 = Double.Parse(Console.ReadLine());

            // Procesos 
             prom = (v1 + v2 + v3) / 3;
             // Salida 
             Console.Write("\n");
             Console.WriteLine("\t------------------------------------------------");
             Console.WriteLine("\tEl promedio de " + nomb + " " + ape + " es $ " + Math.Round(prom, 2));
             Console.WriteLine("\t------------------------------------------------");
             Console.Write("\n\n");

            //Pantalla opcional 
            Console.Write("\t");
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Red;
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
            Console.BackgroundColor = ConsoleColor.Red;
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
