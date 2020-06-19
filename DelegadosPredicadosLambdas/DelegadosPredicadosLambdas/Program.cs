using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegadosPredicadosLambdas
{
    class Program
    {
        static void Main(string[] args)
        {

            Persona p1 = new Persona("Maria",12);
            Persona p2 = new Persona("Jose",21);
     

            ComparaEdad comparaedad = (edad1,edad2)=>edad1==edad2;
            Console.WriteLine(comparaedad(p1.Edad,p2.Edad));

            ComparaNombre comparaNombre = (nom1, nom2) => nom1 == nom2;
            Console.WriteLine(comparaNombre(p1.Nombre,p2.Nombre));






            /*
            OperacionesMatematicas op = new OperacionesMatematicas(num=>num*num);
            Console.WriteLine(op(5));
            Suma sum = new Suma((num1,num2)=>num1+num2);
            Console.WriteLine(sum(10,12));

            List<int> numeros = new List<int> { 1,2,3,4,5,6,7,8,9};
            List<int> pares = numeros.FindAll(i => i%2==0);
            */
            /*
            foreach (int i in pares)
            {
                Console.WriteLine(i);

            }*/
            /*
            pares.ForEach(n => Console.WriteLine(n));
            */


        }



        public delegate bool ComparaEdad(int edad1, int edad2);
        public delegate bool ComparaNombre(String nombre1, String nombre2);

        public delegate int OperacionesMatematicas(int num);
        public delegate int Suma(int a, int b);


 


    }
    class Persona 
    {
        private String nombre;
        private int edad;

        public Persona(string nombre, int edad)
        {
            this.nombre = nombre;
            this.edad = edad;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public int Edad { get => edad; set => edad = value; }
    }
}