using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> numeros = new Stack<int>();
            //agregabdo 
            Console.WriteLine("Agregamos");
            foreach (int item in new int[5] {2,4,6,8,10 })
            {
                Console.WriteLine(item);
                numeros.Push(item);
            }
            Console.WriteLine("Leemos");
            //mostrando
            foreach (int item in numeros)
            {
                Console.WriteLine(item);
            }
            //quitando
            numeros.Pop();
            //mostrando de nuevo
            Console.WriteLine("MOstrando luego de POP()");
            foreach (int item in numeros)
            {
                Console.WriteLine(item);
            }


        }
    }
}
