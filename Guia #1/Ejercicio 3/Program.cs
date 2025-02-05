using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Programa realizado por  
            // Día:  
            // Console.WindowHeight = 20;  // alto de la ventana            
            // Console.WindowWidth = 65; //ancho de la ventana 
             Console.ForegroundColor = ConsoleColor.Black;
             Console.BackgroundColor = ConsoleColor.White;
             Console.Clear();
             Console.Title = "Programa de Calculo de descuentos de un salario base";
             Console.Write("\n\tGuia#1 Ejemplo3");
             Console.Write("\n\n");

             // Declaracion de variables 
             Double sal, d1, d2, d3, s, total;

            // Entrada 
             Console.Write("\tLibreria SanRey...");
             Console.Write("\n");
             Console.Write("\tDigitar el salario base.....:  $");
             sal = Double.Parse(Console.ReadLine());
             
            // Procesos 
             d1 = sal * 0.10;  // calculo de la renta 
             d2 = sal * 0.07;  // calculo del afp 
             d3 = sal * 0.05;  // calculo del seguro social 
             s = d1 + d2 + d3;
             total = sal - s;

            // Salida 
             Console.Write("\n");
             Console.WriteLine("\t---------------------------------------");
             Console.ForegroundColor = ConsoleColor.Red;
             Console.WriteLine("\tEl salario total es de......:  $" + Math.Round(total, 2));
             Console.ForegroundColor = ConsoleColor.Black;
             Console.WriteLine("\t---------------------------------------");
             Console.Write("\n");

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
