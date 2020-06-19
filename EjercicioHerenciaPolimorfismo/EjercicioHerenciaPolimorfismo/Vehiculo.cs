using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioHerenciaPolimorfismo
{
    class Vehiculo
    {
        public void Arrancar(String queArranca) 
        {
            Console.WriteLine($"Arrancando el {queArranca}");

        }
        public void PararMotor(String quePara) 
        {
            Console.WriteLine($"Parando motor del {quePara}");

        }
        public virtual void Conducir() 
        {
            Console.WriteLine("Conduciendo desde vehiculo");

        }


    }
}
