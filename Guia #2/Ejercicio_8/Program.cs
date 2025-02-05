using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_8
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
            Console.Title = "Uso de numeros aleatorios con calculos matematicos";
            Console.Write("\nGuia#2 Ejemplo8");
            Console.Write("\n\n");
            // Declaracion de variables  
            Double x, y, w, z;
            int a;
            // Calculos  
            Random generador = new Random();  // funcion de numero aleatorios  
            a = generador.Next(1, 10);
            // especificamos el rango de 1 a 10
            x = a * 2;
            y = Math.Pow(a, 3);
            w = Math.Sqrt(a);
            z = 15 + a;
            // Salida  
            Console.WriteLine("\tEl numero aleatorio es:..........: " + a);
            Console.WriteLine("\n");
            Console.WriteLine("\tSu calculo con la multiplicacion es de:...: " + x);
            Console.WriteLine("\tSu calculo con la exponenciacion es de:...: " + y);
            Console.WriteLine("\tSu calculo con la raiz cuadrada es de:....: " + Math.Round(w, 2));

            Console.WriteLine("\tSu calculo con la suma es de:.............: " + z);
            Console.Write("\n\n");
        }
    }
}
