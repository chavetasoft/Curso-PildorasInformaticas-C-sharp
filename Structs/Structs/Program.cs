using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structs
{
    class Program
    {
        static void Main(string[] args)
        {
            Empleado e1 = new Empleado(1200,500);
            e1.cambiaSalario(e1, 100);
            Console.WriteLine(e1);
        }
    }
    public struct Empleado 
    {
        private double salarioBase, comision;

        public Empleado(int salarioBase, int comision)
        {
            this.salarioBase = salarioBase;
            this.comision = comision;

        }
        public override string ToString()
        {
            return string.Format("Salario y comicion del empleado({0},{1})", this.salarioBase, this.comision);
        }
        public void cambiaSalario(Empleado em, double inc)
        {
            em.salarioBase += inc;
            em.comision += inc;
        
        }

    }
}
