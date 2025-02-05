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
            // Día: Enero 23,2023  
            Console.WindowHeight = 30;  // alto de la ventana             
            Console.WindowWidth = 70; //ancho de la ventana  
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;

            Console.Clear();
            Console.Title = "<< Calculo de operaciones aritméticas >>";
            Console.Write("\nGuia#2 Ejemplo3");
            Console.Write("\n\n");
            // Declaracion de variables  
            int n1, n2, n3, n4, n5;
            Double r1, r2, r3, r4, r5;
            // Entrada  
            Console.Write("\tCalculando varias operaciones aritméticas...");
            Console.Write("\n\n");
            Console.Write("\tDigitar el primer numero.....: ");
            n1 = int.Parse(Console.ReadLine());
            Console.Write("\tDigitar el segundo numero....: ");
            n2 = int.Parse(Console.ReadLine());
            Console.Write("\tDigitar el tercer numero.....: ");
            n3 = int.Parse(Console.ReadLine());
            Console.Write("\tDigitar el cuarto numero.....: ");
            n4 = int.Parse(Console.ReadLine());
            Console.Write("\tDigitar el quinto numero.....: ");
            n5 = int.Parse(Console.ReadLine());
            Console.Write("\n");
            //Procesos  
            r1 = Math.Pow(n1, 2);  // potencia al cuadrado  
            r2 = Math.Pow(n2, 6);  // potencia a la sexta  
            r3 = Math.Sqrt(n3);  // raiz cuadrada  
            r4 = Math.Pow(n4, 0.33);  // raiz cubica  
            r5 = Math.Pow(n5, 0.25);  // raiz cuarta  
            Console.Write("\n");
            //Salida  
            Console.WriteLine("\t*********************************************");
            Console.WriteLine("\tEl " + n1 + ", elevado al cuadrado es:..\t" + r1);
            Console.WriteLine("\tEl " + n2 + ", elevado a la sexta es:..\t" + r2);
            Console.WriteLine("\tEl " + n3 + ", su raiz cuadrada es:....\t" +
           Math.Round(r3, 2));
            Console.WriteLine("\tEl " + n4 + ", su raiz cubica es:......\t" +
           Math.Round(r4, 2));
            Console.WriteLine("\tEl " + n5 + ", su raiz cuarta es:.....\t" +
           Math.Round(r5, 2));
            Console.WriteLine("\t*********************************************");
            Console.Write("\n");

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
