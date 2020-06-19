using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Propiertis
{
    class Program
    {
        static void Main(string[] args)
        {

            Empleado empleado = new Empleado();
            empleado.SALARIO=1200;
            empleado.SALARIO += 500;
            empleado.SALARIO = -1;
            Console.WriteLine($"el salario del empleado es {empleado.SALARIO}"); 
        }
    }


    class Empleado
    {

        private double evaluarSalario(double salario) 
        {
            if (salario < 0) return 0;
            else return salario;
        }

        public double SALARIO
        {
            //por convencion se utiliza lambda y las variables usan _nombreVariable
            get => _salario; 
            set => _salario = evaluarSalario(value); 
        }

        public void setNombre(String nombre)
        {
            _nombre = nombre;
        }
        private double _salario;
        private string _nombre;
    
    
    
    
    
    }
}
