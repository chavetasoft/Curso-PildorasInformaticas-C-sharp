using System;

namespace PooUno
{
    class Program
    {
        static void Main(string[] args)
        {
            Circulo cir = new Circulo();//instanciar clase Circulo
            int radio = 5;
            Double area = cir.calculoArea(radio);
            Console.WriteLine($"El area del circulo con radio {radio} es {area}");
        }
    }
    class Circulo
    {
        const double pi = 3.1416; // propiedad de la clase circulo

       //nivel_de_acceso tipo_a_devolver Nombre (tipo_de_dato_a_recivir Nombre){ return algo;}
        public double calculoArea(int radio) //metodo de clase, (que puede hacer la clase)
        {
            return pi*(radio*radio);
        }
    
    }
}
