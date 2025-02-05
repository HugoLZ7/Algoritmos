using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_5
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
            Console.Title = "Denominaciones de billetes de una cantidad de dinero";
            Console.Write("\nGuia#2 Ejemplo5");
            Console.Write("\n\n");
            // Declaracion de variables  
            int v, denom, cant, residuo;
            //Entrada de datos  
            Console.Write("\tIngrese el valor a pagar $ ");

            v = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");
            // calculo de los billetes de a 100  
            denom = 100;
            cant = v / denom;
            residuo = v % denom;
            Console.WriteLine("\tBilletes de a $100 son  [ " + cant + " ]");
            // calculo de los billetes de a 50  
            v = residuo;
            denom = 50;
            cant = v / denom;
            residuo = v % denom;
            Console.WriteLine("\tBilletes de a $50  son  [ " + cant + " ]");
            // calculo de los billetes de a 20  
            v = residuo;
            denom = 20;
            cant = v / denom;
            residuo = v % denom;
            Console.WriteLine("\tBilletes de a $20  son  [ " + cant + " ]");
            // calculo de los billetes de a 10  
            v = residuo;
            denom = 10;
            cant = v / denom;
            residuo = v % denom;
            Console.WriteLine("\tBilletes de a $10  son  [ " + cant + " ]");
            // calculo de los billetes de a 5  
            v = residuo;
            denom = 5;
            cant = v / denom;
            residuo = v % denom;
            Console.WriteLine("\tBilletes de a $5   son  [ " + cant + " ] ");
            // calculo de los billetes de a 2  
            v = residuo;
            denom = 2;
            cant = v / denom;
            residuo = v % denom;
            Console.WriteLine("\tBilletes de a $2   son  [ " + cant + " ] ");
            // calculo de los billetes de a 1  
            v = residuo;
            denom = 1;
            cant = v / denom;
            residuo = v % denom;
            Console.WriteLine("\tBilletes de a $1   son  [ " + cant + " ] ");
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
