using System;
using System.Security.Cryptography;

namespace PooUsoStatic
{
    class Program
    {
        static void Main(string[] args)
        {
            Punto origen = new Punto();
            Punto destino = new Punto(150, 90);
            double distancia = origen.DistanciaHasta(destino);
            Console.WriteLine($"La distancia entre los dos puntos es {distancia}");
            Console.WriteLine($"Numero de Objetos creados: {Punto.GetContador()}");

            int a = Punto.variabledeprueba;//accediedo a una constante se permite por que en este caso esta accediendo la clase
            // int b = origen.variabledeprueba; // las constantes se auto determinan static por eso esto daria error al ser una instancia   

        }
    }
   
}
