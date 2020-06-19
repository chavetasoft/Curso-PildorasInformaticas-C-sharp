using System;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //arreglo declarado despues iniciado sus valore
            int[] arreglo1 = new int[5];
            arreglo1[0] = 1;
            arreglo1[1] = 2;
            arreglo1[2] = 3;
            arreglo1[3] = 4;
            arreglo1[4] = 5;
           
            //arreglo declarado e iniciado
            int[] arreglo2 = { 1, 2, 3, 4, 5 };

            //array implicitos 
            var datos = new[] { "Juan", "Diaz", "Uruguay" };
            //var datos2 = new[] { 1,2,""};//no es posible por que tiene que se el mismo tipo de dato 

            int[] arregloCreadoDinamicamente= CrearArrayDinamicamente();
            Console.WriteLine("Imprimiendo desde el main\n");

            foreach (var item in arregloCreadoDinamicamente)
            {
                Console.Write(item+"\t");
            }

        }
        static void recorreConFor()
        {//recprrer arreglo con for
         //array de clases anonimas
            var personas = new[]
            {
            new {Nombre = "Juan" ,edad = 35 },
            new {Nombre = "Mariana", edad = 37},
            new { Nombre = "Andrea", edad = 33 },
            new {Nombre = "Virginia", edad = 32},
            new {Nombre = "Daniela", edad = 32},


            };
            Console.WriteLine("\tRECORRIENDO CON FOR\n");
            for (int i = 0; i < personas.Length; i++)
            {
                Console.WriteLine($"Nombre :{personas[i].Nombre}\nEdad:{ personas[i].edad}");
            }
            Console.WriteLine("\n");
        }
        static void recorreConForEach()
        {           
                      //array de clases anonimas
            var personas = new[]
            {
            new {Nombre = "Juan" ,edad = 35 },
            new {Nombre = "Mariana", edad = 37},
            new { Nombre = "Andrea", edad = 33 },
            new {Nombre = "Virginia", edad = 32},
            new {Nombre = "Daniela", edad = 32},


            };
            //recorrer arreglo con foreach
            Console.WriteLine("\tRECORRIENDO CON FOREACH\n");
            foreach (var item in personas)
            {
                Console.WriteLine($"Nombre :{item.Nombre}\nEdad:{ item.edad}");
            }
            Console.WriteLine("\n");
        }
        static void arrayDeObjetos()
        {  //array de Objetos
            Empleados[] arregloEmpleados = new Empleados[2];
            Empleados ana = new Empleados("Ana", 35);
            arregloEmpleados[0] = new Empleados("Federico", 37);
            arregloEmpleados[1] = ana;
            Console.WriteLine("\tRECORRIENDO EL ARREGLOEMPLEADOS\n");
            foreach (var item in arregloEmpleados)
            {
                Console.WriteLine($"EL empleado {item.getNombre()} tiene {item.getEdad()} años");
            }
            Console.WriteLine("\n");
        }
        static void Procesadatos(int[] datos)
        {

     


            for (int i = 0; i < datos.Length; i++)
            {
                datos[i] += 10;
            }


        }
        static int[] CrearArrayDinamicamente() 
        {
            Console.WriteLine("Cuantos elementos quiere que tenga el array ?");
            String respuesta = Console.ReadLine();
            int numElementos = int.Parse(respuesta);
            int[] datos = new int[numElementos];

            for (int i = 0; i < datos.Length; i++)
            {
                Console.WriteLine($"Introduce el dato para la pocicion {i}");
                respuesta = Console.ReadLine();
                int dato = int.Parse(respuesta);
                datos[i] = dato;

            }
            return datos;

        }
    }
        class Empleados
    {
            public Empleados(String nombre, int edad) 
            {
                this.nombre = nombre;
                this.edad = edad;
            }
            public String getNombre() 
            {
                return nombre;
            }
            public int getEdad() 
            {
                return edad;
            }
            String nombre;
            int edad;
    }


}

