using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegados

{
    class Program
    {
        static void Main(string[] args)
        {   //crea objeto delegado apuntando a MensajeBIenVenida.SaludoBienvenid
            ObjetoDelegado objetoDelegado = new ObjetoDelegado(MensajeBIenVenida.SaludoBienvenida);
            //utilizar el objeto para utilizar el  metodo MensajeBIenVenida.SaludoBienvenida
            objetoDelegado();

            //apuntar a otra clase, en este caso  al metodo MensajeDespedida.SaludoDespedida
            objetoDelegado = new ObjetoDelegado(MensajeDespedida.SaludoDespedida);

            objetoDelegado();
        }
        //defdel objeto delegado
        delegate void ObjetoDelegado();




        class MensajeBIenVenida
        {
            public static void SaludoBienvenida()
            {

                Console.WriteLine("Hola acabo de llegar");

            }
        }

        class MensajeDespedida
        {
            public static void SaludoDespedida()
            {

                Console.WriteLine("Hola ya me marcho");

            }
        }

    }
}
