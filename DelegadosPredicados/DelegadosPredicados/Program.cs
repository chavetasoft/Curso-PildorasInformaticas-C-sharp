using System;
using System.Collections.Generic;


namespace DelegadosPredicados
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaramos un list de int
            List<int> listanumeros = new List<int>();
            //rellenamos la list con un array de enteros 
            listanumeros.AddRange(new int[] {1,2,3,4,5,6,7,8,9,10});
            //Declaramos delegado predicado
            Predicate<int> delegadopredicado = new Predicate<int>(Pares);
            //creamos una lista a apartir de listanumeros que cuimplen con el metodo findALl que recive nuestro perdicado pares por param
            List<int> numpares = listanumeros.FindAll(delegadopredicado);
            //recorremos la lista numpares y la imprimimos por pantalla
            foreach (int  num in numpares) Console.WriteLine(num);
            //
            delegadopredicado = new Predicate<int>(Primos);
            List<int> numprimo = listanumeros.FindAll(delegadopredicado);
            foreach (int primo in numprimo) Console.WriteLine(primo);

        }

        static bool Pares(int numero) 
        {
            if (numero%2==0)return true;
            else return false;
        
        }
        static bool Primos(int numero)
        {
            for (int i = 2; i < numero; i++)
            {
                if (numero % i == 0 && i != numero)
                    return false;
            }
            return true;
        }
    }
}
