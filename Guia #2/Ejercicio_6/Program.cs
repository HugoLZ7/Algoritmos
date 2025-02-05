using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_6
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
            Console.Title = "Programa de conversiones de radianes y grados";
            Console.Write("\nGuia#2 Ejemplo6");
            Console.Write("\n\n");
            // Declaracion de variables  
            Double gra, rad, x, y;
            const Double Pi = 3.1415;
            //Entrada de datos  
            Console.Write("\tIngrese el valor de grados....: ");
            gra = Double.Parse(Console.ReadLine());
            Console.WriteLine("\n");
            // calculo de conversion de grados a radianes  
            x = (gra * Pi) / 180;
            // Salida  
            Console.WriteLine("\tLa cantidad de " + gra + "º son " + Math.Round(x, 2) +
           " radianes ");
            Console.Write("\n\n");
            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey(); Console.Clear();
            //Entrada de datos  
            Console.WriteLine("\n");
            Console.Write("\tIngrese el valor de radianes....: ");
            rad = Double.Parse(Console.ReadLine());
            Console.WriteLine("\n");
            // calculo de conversion de radianes a grados  
            y = (rad * 180) / Pi;
            // Salida  
            Console.WriteLine("\tLa cantidad de " + rad + " radianes son " +
           Math.Round(y, 2) + "º ");
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
