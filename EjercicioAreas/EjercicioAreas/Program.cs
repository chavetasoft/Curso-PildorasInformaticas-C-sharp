using System;


namespace EjercicioAreas
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] lista = { 10, 10, 10, 10, 10, 10, 10, 9,10,11 };

            Console.WriteLine($"el area del circulo es {CalculosAreas.AreaCirculo(3)}");
            Console.WriteLine($"el area del cuadrado es {CalculosAreas.AreaCuadrado(2)}");
            Console.WriteLine($"el area del rectangulo es {CalculosAreas.AreaRectangulo(2,3)}");
            Console.WriteLine($"el area del triangulo es {CalculosAreas.AreaTriangulo(2,2,2)}");
            Console.WriteLine($"El elemento menor de la lista es {Arreglos.Mayor(lista)}");
            Console.WriteLine($"El elemento menor de la lista es {Arreglos.Menor(lista)}");
            Console.WriteLine($"El promedio de los valores de la lista es {Arreglos.Promedio(lista)}");
            Arreglos.BubleSort(lista);
            for (int i = 0; i < lista.Length; i++)
            {
                Console.Write(lista[i]+ " ") ;
            }

        }
    }
}