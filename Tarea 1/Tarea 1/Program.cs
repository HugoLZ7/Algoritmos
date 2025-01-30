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
            //Inicializar consola
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.Title = "Programa TRAEA 1";
            Console.Write("\n\tGuia#1 Tarea 1");

            //Decalarar variables de base, altura y area.
            float b, h, A;

            //Primer proceso ingreso de datos 
            Console.Write("\n\n");
            Console.Write("\tDigitar el valor de la base  : "); //Escribir en la consola
            b = float.Parse(Console.ReadLine());//Leer y almacenar en b
            Console.Write("\tDigitar el valor de la altura : ");
            h = float.Parse(Console.ReadLine());//float permite utilizar decimales

            //Operacion para encontrar el area
            A = (b * h) / 2;

            //Mostrar el resultado en la consola
            Console.Write("\tEl Area es = " + A);
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
