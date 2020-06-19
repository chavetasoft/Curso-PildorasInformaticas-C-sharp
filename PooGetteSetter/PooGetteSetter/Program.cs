using PooGetteSetter;
using System;

namespace PooGetterSetter
{

    class Program
    {
        //*******************************
        static void Main(string[] args)
        {
            
        }
        static void UsarCoche()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Coche1:");
            Console.ForegroundColor = ConsoleColor.White;
            Coche coche1 = new Coche();
            Console.WriteLine(coche1.GetInfoCoche());
            Console.WriteLine(coche1.getExtras());

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Coche1:");
            Console.ForegroundColor = ConsoleColor.White;
            Coche coche2 = new Coche(1800, 1000);
            Console.WriteLine(coche2.GetInfoCoche());
            coche2.setExtras(true, "cuero");
            Console.WriteLine(coche2.getExtras());
        }


      
    }
}