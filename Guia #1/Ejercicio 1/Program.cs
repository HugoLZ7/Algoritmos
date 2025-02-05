using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Ejercicio_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Programa realizado por  
            // Día:  
            // Console.WindowHeight = 25;  // alto de la ventana            
            // Console.WindowWidth = 70; //ancho de la ventana 

            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
             Console.Clear();
             Console.Title = "Programa con operadores matematicos - numeros enteros";
             Console.Write("\n\tGuia#1 Ejemplo1");
            //Declaracion variales
            int n1, n2, s, r, m, d, mo;

            //Entrada de datos (procesos van en escalera)
            Console.Write("\n\n");
             Console.Write("\tDigitar el primer número  : ");
             n1 = int.Parse(Console.ReadLine());
             Console.Write("\tDigitar el segundo número : ");
             n2 = int.Parse(Console.ReadLine());
             Console.Write("\n");

            // Proceso de los datos 
             s = n1 + n2;   // calculamos la suma 
             r = n1 - n2;   // calculamos la resta 
             m = n1 * n2;   // calculamos la multiplicacion 
             d = n1 / n2;   // calculamos la division entera 
             mo = n1 % n2;   // calculamos el modulo de la division

            // Salida de los datos 
             Console.WriteLine("\t************************************************");
             Console.WriteLine("\t  La suma de los numeros es.............: " + s);
             Console.WriteLine("\t  La resta de los numeros es............: " + r);
             Console.WriteLine("\t  La multiplicacion de los numeros es.. : " + m);
             Console.WriteLine("\t  La division de los numeros es.........: " + d);
             Console.WriteLine("\t  El modulo de los numeros es...........: " + mo);
             Console.WriteLine("\t*************************************************");
             Console.Write("\n\n");

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
