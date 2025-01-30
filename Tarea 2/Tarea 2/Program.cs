using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_2
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

            //Decalarar variables .
            double x, r, ope;

            //Primer proceso ingreso de datos 
            Console.Write("\n\n");
            Console.Write("\tDigitar el valor de r  : "); //Escribir en la consola
            r = double.Parse(Console.ReadLine());//Leer y almacenar en r
            Console.Write("\n\n");

            //Para usar math.pow debemos definir las variables con double o definir con
            //(float, int, etc) antes de Math.pow. ej: (float)Math.pow(r,3)
            r = Math.Pow(r, 3);//Elevar a potencia
            Console.Write("\tEl valor de r exp. es: " + r);
            Console.Write("\n\n");

            //Operacion
            x = Math.PI * 4/3 * r;
            Console.Write("\tEl resultado es: " + x);
            Console.Write("\n\n");
            
            //Resultado Final
            Console.Write("\tEl resultado redondeando es: " + Math.Round(x,2));
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
