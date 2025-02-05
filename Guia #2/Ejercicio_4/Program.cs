using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WindowHeight = 25;  // alto de la ventana             
            Console.WindowWidth = 70; //ancho de la ventana  
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.Title = "Fecha de 8 digitos, separadonla";
            Console.Write("\nGuia#2 Ejemplo4");
            Console.Write("\n\n");
            // Declaracion de variables  
            int fecha, anio, resto, mes, dia;
            // Entrada  
            Console.Write("\tSepararemos una fecha de 8 numeros enteros...");
            Console.Write("\n\n");
            Console.Write("\tDigitar la fecha en formato 8 digitos [aaaammdd]: ");
            fecha = int.Parse(Console.ReadLine());
            Console.Write("\n");
            //Procesos  
            anio = fecha / 10000;
            resto = fecha % 10000;
            mes = resto / 100;
            dia = resto % 100;
            Console.Write("\n");
            //Salida  
            Console.WriteLine("\t*********************************************");
            Console.WriteLine("\tEl año digitado es: [" + anio + "]");
            Console.WriteLine("\tEl mes digitado es: [" + mes + "]");
            Console.WriteLine("\tEl dia digitado es: [" + dia + "]");
            Console.WriteLine("\t*********************************************");
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
