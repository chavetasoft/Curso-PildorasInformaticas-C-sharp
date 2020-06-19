using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioHerenciaPolimorfismo
{
    class Avion : Vehiculo
    {

        public void despegar() { Console.WriteLine("Despegando"); }
        public void aterrizar() { Console.WriteLine("Aterrizando"); }
        public override void Conducir()
        {
            Console.WriteLine("Conduciendo desde avion");

        }

    }
}
