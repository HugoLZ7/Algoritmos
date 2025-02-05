using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_7
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
            Console.Title = "Calcular el seno y coseno de un angulo en grados";
            Console.Write("\nGuia#2 Ejemplo7");
            Console.Write("\n\n");
            // Declaracion de variables  
            Double gra, x, y, z;
            const Double Pi = 3.1415;
            //Entrada de datos  
            Console.Write("\tIngrese el valor de grados....: ");

            gra = Double.Parse(Console.ReadLine());
            Console.WriteLine("\n");
            // Calculos  
            x = (gra * Pi) / 180; // convertimos grados a radianes  
            y = Math.Sin(x); // calculamos el seno del angulo  
            z = Math.Cos(x); // calculamos el coseno del angulo  
                             // Salida  
            Console.WriteLine("\tEl seno del angulo [" + gra + "º] es de....: " + Math.Round(y, 3));
            Console.WriteLine("\n");
            Console.WriteLine("\tEl coseno del angulo [" + gra + "º] es de..: " + Math.Round(z, 3));
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
