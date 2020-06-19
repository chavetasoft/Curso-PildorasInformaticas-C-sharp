using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructuraSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            Comisiones(); 
        }
        static void Comisiones() 
        {

            Console.WriteLine("Escriba el numero de mes que desea escoger.");
            int mes =Int32.Parse( Console.ReadLine());

            switch (mes)
            {

                case 1:
                    Console.WriteLine("Mes escogido enero");
                    break;
                case 2:
                    Console.WriteLine("Mes escogido febrero");
                    break;
                case 3:
                    Console.WriteLine("Mes escogido marzo");
                    break;

                case 4:
                    Console.WriteLine("Mes escogido abril");
                    break;
                case 5:
                    Console.WriteLine("Mes escogido mayo");
                    break;
                case 6:
                    Console.WriteLine("Mes escogido junio");
                    break;
                case 7:
                    Console.WriteLine("Mes escogido julio");
                    break;
                case 8:
                    Console.WriteLine("Mes escogido agosto");
                    break;
                case 9:
                    Console.WriteLine("Mes escogido setiembre");
                    break;
                case 10:
                    Console.WriteLine("Mes escogido octubre");
                    break;
                case 11:
                    Console.WriteLine("Mes escogido noviembre");
                    break;
                case 12:
                    Console.WriteLine("Mes escogido diciembre");
                    break;
                default:
                    Console.WriteLine("Mes escogido invalido");
                    break;

            }







        }
        static void SwCtrl() 
        {
            Console.WriteLine("Escriba , auto, tren o avion");
            string vehiculo = Console.ReadLine(); 

            switch (vehiculo) {

                case "auto":
                    Console.WriteLine( "el auto viaja a 120 km/h");
                    break;
                case "tren":
                    Console.WriteLine("el tren viaja a 250 km/h");
                    break;
                case "avion":
                    Console.WriteLine( "el avion viaja a 800 km/h");
                    break;
                default:
                    Console.WriteLine("No tengo informacion de esos vehiculos");
                    break;

            }
        
        
        }

    }
}
