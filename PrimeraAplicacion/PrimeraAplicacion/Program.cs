using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeraAplicacion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Verde");
          
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Azul");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Rojo");

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Rojo Oscuro");

            Console.ReadKey();
        }
    }
}
