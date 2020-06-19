using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine(opcional(1,2,5)) ;
        }

        private static bool sinconstruir()
        {
            throw new NotImplementedException();
        }

        static void MensajeEnPantalla() 
        {
            Console.WriteLine("Mensaje desde un metodo");
        }
        static void Sumar(int a , int b)
        {
            Console.WriteLine($"La suma de los numeros es {a+b}");

        }

        static int SumaReturn(int a, int b) =>  a+b;//simplificacion de un metodo
        void PrimerMetodo() 
        {
   
            Console.WriteLine(numero1+numero2);
        }
        void SegundoMetodo()
        {
            Console.WriteLine(numero1);
        }
        //sobrecarga de metodos solo cuando recive diferentes tipos o cantidad de parametros
        static int sobrecarga(int a, int b) => a + b;
        static int sobrecarga(int a, int b, int c) => a + b + c;
        static int sobrecarga()=>2;

        //metodo valor por defecto en un parametro es como si estuviera sobrecargado
        static double opcional(double a, double b, double opcional = 0) => a + b + opcional;


        //campos de clase
        int numero1 = 5;
        int numero2 = 7;
    }
}
