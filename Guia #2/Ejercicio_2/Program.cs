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
            // Programa realizado por Hugo Lopez
            // Día: Enero 23,2023  
            Console.WindowHeight = 30;  // alto de la ventana             
            Console.WindowWidth = 70; //ancho de la ventana  
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.Title = "Calculo de la cabuda de 3 amigos";
            Console.Write("\nGuia#2 Ejemplo2");
            Console.Write("\n\n");

             // Declaracion de variables  
             Double c1, c2, c3, c4, p1, p2, p3, total;
             // Entrada  
             Console.Write("\tCalculando la cabuda de dinero...");

             Console.Write("\n\n");
             Console.Write("\tIntroduzca la cantidad de Mbapee [dólares]....: $ ");
             c1 = Double.Parse(Console.ReadLine());
             Console.Write("\tIntroduzca la cantidad de Neymar [euros]......: e ");  
             c2= Double.Parse(Console.ReadLine());
             Console.Write("\tIntroduzca la cantidad de Melviño [dólares]...: $ ");
             c3 = Double.Parse(Console.ReadLine());
             Console.Write("\n");
             //Procesos  
             c4 = c2 * 0.92; // pasamos los euros a dolares  
             total = c1 + c4 + c3;
             p1 = (c1 * 100) / total;  // regla de tres  
             p2 = (c4 * 100) / total;  // regla de tres  
             p3 = (c3 * 100) / total;  // regla de tres  
             //Salida  
             Console.WriteLine("\t**************************************************");
             Console.WriteLine("\tEl total de dinero es de........: $" +
             Math.Round(total, 2));
             Console.Write("\n");
             Console.WriteLine("\tEl porcentaje de Mbapee es de...: " + Math.Round(p1, 2) + "%");
             Console.WriteLine("\tEl porcentaje de Neymar es de...: " + Math.Round(p2, 2) + "%");
             Console.WriteLine("\tEl porcentaje de Melviño es de..: " + Math.Round(p3, 2) + "%");

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
