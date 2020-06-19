using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuclesWhile
{
    class Program
    {
        static void Main(string[] args)
        {
          
        }
        static void Dowhile()
        {
            int z = 10;
            do
            {
                Console.WriteLine($"impresion n' {z}");
            } while (z < 10);

      

        }
        static void JuegoDW()
        {

            Random random = new Random();
            int a = 0;
            int b = 10;
            int aleatorio = random.Next(a, b);
            int miNumero;
            int intentos = 0;
            Console.WriteLine($"Introduce un numero entre {a} y {b}");

            do
            {
                intentos++;
                miNumero = Int32.Parse(Console.ReadLine());
                if (miNumero > aleatorio) Console.WriteLine("El numero es menor, intenta con otro");
                if (miNumero < aleatorio) Console.WriteLine("El numero es mayor, intenta con otro");

            } while (aleatorio != miNumero);

            Console.WriteLine($"Correcto el numero aleatorio es el {aleatorio}, lo acerto en el intento numero {intentos}");

            Console.ReadKey();



        }
        static void Juego()
        {
            Random random = new Random();
            int a = 0;
            int b = 10;
            int aleatorio = random.Next(a, b);
            int miNumero = 101;
            int intentos = 0;
            Console.WriteLine($"Introduce un numero entre {a} y {b}");

            while (aleatorio != miNumero)
            {
                intentos++;
                miNumero = Int32.Parse(Console.ReadLine());
                if (miNumero > aleatorio) Console.WriteLine("El numero es menor, intenta con otro");
                if (miNumero < aleatorio) Console.WriteLine("El numero es mayor, intenta con otro"); 
                
            }
            Console.WriteLine($"Correcto el numero aleatorio es el {aleatorio}, lo acerto en el intento numero {intentos}");
            Console.ReadKey();
        }
        static void WlCtrl() 
        {
            bool sigue = true;
            int tope = 0;

            while (sigue)
            {
                Console.WriteLine($"el tope es {tope}");
                tope++;
                if (tope > 50)  sigue = false;
            }
        }

        static void Usowhile() {
            Console.WriteLine("deseas entrar el ciclo while");
            string respuesta = Console.ReadLine().ToLower();

            while (respuesta !="no")
            {
                Console.WriteLine("Estas dentro del while");
                Console.WriteLine("introduce un nombre");
                string nombre = Console.ReadLine();
                Console.WriteLine($"Saldras del bucle {nombre} cuando respondas no a la pregunta");
                Console.WriteLine("deseas repetir el bucle ?");
                respuesta = Console.ReadLine().ToLower();
            }

        }
    }
}
