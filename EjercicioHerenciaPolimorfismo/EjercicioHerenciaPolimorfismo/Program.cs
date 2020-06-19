using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioHerenciaPolimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("\tProvando el avion\n");
            Avion avion = new Avion();
            avion.Arrancar("avion");
            avion.despegar();
            avion.Conducir();
            avion.aterrizar();
            avion.PararMotor("avion");
            Console.WriteLine("\n\tProbando coche\n");
            Coche coche  = new Coche();
            coche.Arrancar("coche");
            coche.acelerar();
            coche.Conducir();
            coche.frenar();
            coche.PararMotor("coche");
            Console.WriteLine("\n\tPolimorfismo en accion\n");
            Vehiculo vehiculo = coche;
            vehiculo.Conducir();
            vehiculo = avion;
            vehiculo.Conducir();





        }
    }
}
