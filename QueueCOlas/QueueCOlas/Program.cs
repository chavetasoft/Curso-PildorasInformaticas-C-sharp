using System;
using System.Collections.Generic;


namespace QueueCOlas
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> numeros = new Queue<int>();

            //agregando elementos a la cola
            foreach (int numero in new int[5] {2,4,6,8,10 })
            {
                numeros.Enqueue(numero);
            }

            //recorriendo la cola
            Console.WriteLine("Recorriendo la cola");
            foreach (var item in numeros)
            {
                Console.WriteLine(item);
            }
            //eliminando elementos del queque
            Console.WriteLine("Eliminando elementos");
            numeros.Dequeue();
            Console.WriteLine("Recorriendo la cola");
            foreach (var item in numeros)
            {
                Console.WriteLine(item);
            }
        }
    }
}
