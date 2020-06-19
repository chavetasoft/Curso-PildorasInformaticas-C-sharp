using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PooLLamadasYClaseMath
{
    class Program
    {
        static void Main(string[] args)
        {
            realizarTarea();
        }
        static void realizarTarea()
        {
            Punto origen = new Punto();
            Punto destino = new Punto(128, 80);
            //Punto.distanciaHasta();
            double distanciaXY = origen.distanciaHasta(destino);
            Console.WriteLine(distanciaXY);



        }



    }
}
