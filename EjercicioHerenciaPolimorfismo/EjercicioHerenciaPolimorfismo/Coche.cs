using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioHerenciaPolimorfismo
{
    class Coche : Vehiculo
    {

        public void acelerar() { Console.WriteLine("Acelerndo"); }
        public void frenar() { Console.WriteLine("Frenando"); }
        public override void Conducir()
        {
            Console.WriteLine("Conduciendo desde coche");
        }
    }
}
