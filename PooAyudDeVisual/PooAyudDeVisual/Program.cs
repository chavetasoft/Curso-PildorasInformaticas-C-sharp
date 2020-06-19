using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooAyudDeVisual
{//todo: esto aparecera en la lista de tareas
    class Program
    {
        static void Main(string[] args)
        {
            realizarTarea();
        }
        static void realizarTarea()
        {

            //si no exist el metod constructorvacio en la 
            //clase punto lo podemos crear con la ayuda de VS
            Punto origen = new Punto();
            Punto destino = new Punto(128, 80);
        }
    }
}
