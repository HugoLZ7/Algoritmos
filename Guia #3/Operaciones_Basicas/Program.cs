using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operaciones_Basicas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Inicializar consola
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.Title = "Programa Ej2";
            Console.Write("\n\tGuia#1 Ej2");

            Double x, y, z, w;
            // Entrada 
            Console.Write("\tOperaciones matematicas con condicionales...");
            Console.Write("\n\n");
            Console.Write("\tDigitar primer numero  : ");
            x = Double.Parse(Console.ReadLine());
            Console.Write("\tDigitar segundo numero : ");
            y = Double.Parse(Console.ReadLine());
            Console.Write("\n");
            //Procesos 
            if (x > y)
            {
                z = x + y;
                w = x - y;
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\tMOSTRANDO RESULTADOS");
                Console.WriteLine("\tLa suma es  : " + Math.Round(z, 2));
                Console.WriteLine("\tLa resta es : " + Math.Round(w, 2));
                Console.ForegroundColor = ConsoleColor.Black;
            }
            else
            {
                z = x * y;
                if (y == 0)
                {
                    Console.WriteLine("\tNo se puede dividir entre CERO");
                }
                else
                {
                    w = x / y;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\tMOSTRANDO RESULTADOS");
                    Console.WriteLine("\tLa multiplicación es : " + z);
                    Console.WriteLine("\tLa división es       : " + Math.Round(w, 2));
                    Console.ForegroundColor = ConsoleColor.Black;
                }
            }
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
