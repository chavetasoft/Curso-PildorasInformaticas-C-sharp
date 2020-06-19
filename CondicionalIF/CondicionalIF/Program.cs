using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CondicionalIF
{
    class Program
    {
        static void Main(string[] args)
        {
            Juguete();
        }
        static void Juguete() {


            Console.WriteLine("Ingresa tu edad :");
            int edad = Int32.Parse(Console.ReadLine());

            if (edad < 18) Console.WriteLine("Eres un niño ");
            else if ( edad < 30) Console.WriteLine("Eres joven");
            else if (edad < 60)Console.WriteLine("Eres adulto");
            else Console.WriteLine("Eres Anciano");

        }
        static void Conducir() 
        {

            Console.WriteLine("Vamos a evaluar si púedes conducir");
            Console.WriteLine("introduce tu edad");

            int edad = Int32.Parse(Console.ReadLine());
            string carnet = "";

            if (edad < 18)
            {
                Console.WriteLine("No puedes conducir");
            }
            else
            {
                Console.WriteLine("tienes carnet?");
                carnet = Console.ReadLine();
                if (carnet == "si") Console.WriteLine("Puedes conducir");
                else Console.WriteLine("No puedes conducir");
            }

        }
    }
}
