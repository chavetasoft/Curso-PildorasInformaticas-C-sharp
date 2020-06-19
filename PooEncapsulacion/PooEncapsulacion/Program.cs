using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooEncapsulacion
{
    class Program
    {


        static void Main(string[] args)
        {
            //Circulo cir = new Circulo();//instanciar clase Circulo
            //int radio = 5;
            //Double area = cir.CalculoArea(radio);
            //Console.WriteLine($"El area del circulo con radio {radio} es {area}");
            //Console.WriteLine(cir.getPi());


            ConversorEuroDolar obj = new ConversorEuroDolar();
            obj.setEuro(-2);
            Console.WriteLine(obj.Convierte(50));
        }
    }
    class ConversorEuroDolar
    {
       private double euro = 1.253;

        public double Convierte(double cantidad)
        {
            return cantidad * euro;
        }
        public void setEuro(double nuevoValor) 
        {
            if (nuevoValor < 0)
            {
                euro = 1.253;
            }else euro = nuevoValor;
        }

    }
    class Circulo
        {   
            //encapsular la variable solo es accsesible desde la clase Circuloo
            //cuando en umna clase se utilizan datos,variables o constante se recomienda encapsular
            // y crear metodos de accseso publicos

            //NombreDePublic nombreDeLosQueNoSonPublic
 
            private const double pi = 3.1416; // propiedad de la clase circulo

            //nivel_de_acceso tipo_a_devolver Nombre (tipo_de_dato_a_recivir Nombre){ return algo;}
            public double CalculoArea(int radio) //metodo de clase, (que puede hacer la clase)
            {
                return pi * (radio * radio);
            }

            public Double getPi() 
            {
            return pi;
            }

        }
    }



